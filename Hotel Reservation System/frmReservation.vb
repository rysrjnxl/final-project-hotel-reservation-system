Public Class frmReservation
    Private Sub frmReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReservation.ReadOnly = True
        dgvReservation.AllowUserToAddRows = False
        dgvReservation.RowHeadersVisible = False
        dgvReservation.AllowUserToResizeColumns = False
        dgvReservation.AllowUserToResizeRows = False
        LoadCombos()
        LoadReservations()
    End Sub

    Sub LoadCombos()
        Dim dtGuests As DataTable = GetData("SELECT id, full_name FROM guests")
        If dtGuests IsNot Nothing Then
            cmbGuest.DataSource = dtGuests
            cmbGuest.DisplayMember = "full_name"
            cmbGuest.ValueMember = "id"
            cmbGuest.SelectedIndex = -1
        End If

        Dim dtRooms As DataTable = GetData("SELECT id, room_number FROM rooms WHERE status='Available'")
        If dtRooms IsNot Nothing Then
            cmbRoom.DataSource = dtRooms
            cmbRoom.DisplayMember = "room_number"
            cmbRoom.ValueMember = "id"
            cmbRoom.SelectedIndex = -1
        End If
    End Sub

    Sub LoadReservations()
        Dim sql As String = "SELECT r.id, g.full_name, rm.room_number, r.check_in, r.check_out, r.total_amount " &
                            "FROM reservations r " &
                            "JOIN guests g ON r.guest_id = g.id " &
                            "JOIN rooms rm ON r.room_id = rm.id"
        dgvReservation.DataSource = GetData(sql)
    End Sub

    Private Sub btnAddRes_Click(sender As Object, e As EventArgs) Handles btnAddRes.Click
        If cmbGuest.SelectedValue Is Nothing OrElse cmbRoom.SelectedValue Is Nothing Then
            MsgBox("Please select a Guest and a Room first.", MsgBoxStyle.Exclamation, "Missing Info")
            Exit Sub
        End If

        Dim guestId As Integer = Convert.ToInt32(cmbGuest.SelectedValue)
        Dim roomId As Integer = Convert.ToInt32(cmbRoom.SelectedValue)

        Dim days As Integer = DateDiff(DateInterval.Day, dtCheckIn.Value, dtCheckOut.Value)
        If days < 1 Then days = 1

        Dim dtPrice As DataTable = GetData("SELECT price FROM rooms WHERE id=" & roomId)
        Dim price As Decimal = 0
        If dtPrice.Rows.Count > 0 Then
            price = Convert.ToDecimal(dtPrice.Rows(0)("price"))
        End If

        Dim total As Decimal = price * days

        Try
            Dim sql As String = "INSERT INTO reservations(guest_id, room_id, check_in, check_out, total_amount) VALUES(" & guestId & ", " & roomId & ", '" & dtCheckIn.Value.ToString("yyyy-MM-dd") & "', '" & dtCheckOut.Value.ToString("yyyy-MM-dd") & "', " & total & ")"
            ExecuteQuery(sql)

            ExecuteQuery("UPDATE rooms SET status='Occupied' WHERE id=" & roomId)

            MsgBox("Reservation Successful! Total: " & total.ToString("C"))
            LoadReservations()
            LoadCombos()
        Catch ex As Exception
            MsgBox("Error saving reservation: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        dash.Show()
        Me.Hide()
    End Sub
End Class