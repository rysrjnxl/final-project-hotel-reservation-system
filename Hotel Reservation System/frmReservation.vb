Public Class frmReservation
    Private Sub frmReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReservations()
        LoadCombos()
    End Sub

    Sub LoadCombos()
        ' Load Guests into ComboBox
        Dim dtGuests As DataTable = GetData("SELECT id, full_name FROM guests")
        cmbGuest.DataSource = dtGuests
        cmbGuest.DisplayMember = "full_name"
        cmbGuest.ValueMember = "id"

        ' Load Available Rooms into ComboBox
        Dim dtRooms As DataTable = GetData("SELECT id, room_number FROM rooms WHERE status='Available'")
        cmbRoom.DataSource = dtRooms
        cmbRoom.DisplayMember = "room_number"
        cmbRoom.ValueMember = "id"
    End Sub

    Sub LoadReservations()
        ' Join tables to show readable names instead of just IDs
        Dim sql As String = "SELECT r.id, g.full_name, rm.room_number, r.check_in, r.check_out, r.total_amount FROM reservations r JOIN guests g ON r.guest_id = g.id JOIN rooms rm ON r.room_id = rm.id"
        DataGridView1.DataSource = GetData(sql)
    End Sub

    Private Sub btnAddRes_Click(sender As Object, e As EventArgs) Handles btnAddRes.Click
        Dim guestId As Integer = cmbGuest.SelectedValue
        Dim roomId As Integer = cmbRoom.SelectedValue

        ' Calculate total price (Simplified logic)
        Dim days As Integer = DateDiff(DateInterval.Day, dtCheckIn.Value, dtCheckOut.Value)
        If days < 1 Then days = 1 ' Minimum 1 day

        ' Get Room Price
        Dim dtPrice As DataTable = GetData("SELECT price FROM rooms WHERE id=" & roomId)
        Dim price As Decimal = dtPrice.Rows(0)("price")
        Dim total As Decimal = price * days

        ' Insert Reservation
        Dim sql As String = "INSERT INTO reservations(guest_id, room_id, check_in, check_out, total_amount) VALUES(" & guestId & ", " & roomId & ", '" & dtCheckIn.Value.ToString("yyyy-MM-dd") & "', '" & dtCheckOut.Value.ToString("yyyy-MM-dd") & "', " & total & ")"
        ExecuteQuery(sql)

        ' Mark Room as Occupied
        ExecuteQuery("UPDATE rooms SET status='Occupied' WHERE id=" & roomId)

        MsgBox("Reservation Added! Total: $" & total)
        LoadReservations()
        LoadCombos() ' Refresh room list
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        SlideInForm(dash)
        Me.Hide()
    End Sub
End Class