Public Class frmReservation
    Dim selectedResId As String = ""
    Dim selectedRoomId As String = ""

    Private Sub frmReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me)
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

        Dim dtRooms As DataTable = GetData("SELECT id, room_number FROM rooms")
        If dtRooms IsNot Nothing Then
            cmbRoom.DataSource = dtRooms
            cmbRoom.DisplayMember = "room_number"
            cmbRoom.ValueMember = "id"
            cmbRoom.SelectedIndex = -1
        End If
    End Sub

    Sub LoadReservations()
        Dim sql As String = "SELECT r.id, g.full_name, rm.room_number, r.check_in, r.check_out, r.total_amount, r.guest_id, r.room_id " &
                            "FROM reservations r " &
                            "JOIN guests g ON r.guest_id = g.id " &
                            "JOIN rooms rm ON r.room_id = rm.id"

        Dim dt As DataTable = GetData(sql)
        dgvReservation.DataSource = dt

        If dgvReservation.Columns.Count > 0 Then
            dgvReservation.Columns("id").Visible = False
            dgvReservation.Columns("guest_id").Visible = False
            dgvReservation.Columns("room_id").Visible = False
        End If
    End Sub

    ' --- 1. FILL FORM WHEN CLICKING A ROW ---
    Private Sub dgvReservation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservation.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvReservation.Rows(e.RowIndex)

            ' Store IDs for the update logic
            selectedResId = row.Cells("id").Value.ToString()
            selectedRoomId = row.Cells("room_id").Value.ToString()

            ' Set Dropdowns
            cmbGuest.SelectedValue = row.Cells("guest_id").Value
            cmbRoom.SelectedValue = row.Cells("room_id").Value

            ' Set Dates (Safely)
            Try
                dtCheckIn.Value = Convert.ToDateTime(row.Cells("check_in").Value)
                dtCheckOut.Value = Convert.ToDateTime(row.Cells("check_out").Value)
            Catch
            End Try
        End If
    End Sub

    Private Sub btnUpdateRes_Click(sender As Object, e As EventArgs) Handles btnUpdateRes.Click
        If selectedResId = "" Then
            MsgBox("Please select a reservation to update.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim guestId As Integer = Convert.ToInt32(cmbGuest.SelectedValue)
        Dim newRoomId As String = cmbRoom.SelectedValue.ToString()

        Dim days As Integer = DateDiff(DateInterval.Day, dtCheckIn.Value, dtCheckOut.Value)
        If days < 1 Then days = 1
        Dim dtPrice As DataTable = GetData("SELECT price FROM rooms WHERE id=" & newRoomId)
        Dim price As Decimal = 0
        If dtPrice.Rows.Count > 0 Then price = Convert.ToDecimal(dtPrice.Rows(0)("price"))
        Dim total As Decimal = price * days

        Try
            Dim sql As String = "UPDATE reservations SET guest_id=" & guestId & ", room_id=" & newRoomId &
                                ", check_in='" & dtCheckIn.Value.ToString("yyyy-MM-dd") &
                                "', check_out='" & dtCheckOut.Value.ToString("yyyy-MM-dd") &
                                "', total_amount=" & total & " WHERE id=" & selectedResId
            ExecuteQuery(sql)

            If newRoomId <> selectedRoomId Then
                ExecuteQuery("UPDATE rooms SET status='Available' WHERE id=" & selectedRoomId)

                If dtCheckIn.Value.Date = DateTime.Now.Date Then
                    ExecuteQuery("UPDATE rooms SET status='Occupied' WHERE id=" & newRoomId)
                End If
            End If

            MsgBox("Reservation Updated! New Total: ₱" & total.ToString("N2"))
            LoadReservations()
            selectedResId = ""
        Catch ex As Exception
            MsgBox("Update Failed: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddRes_Click(sender As Object, e As EventArgs) Handles btnAddRes.Click
        If cmbGuest.SelectedValue Is Nothing OrElse cmbRoom.SelectedValue Is Nothing Then
            MsgBox("Please select a Guest and a Room.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim guestId As Integer = Convert.ToInt32(cmbGuest.SelectedValue)
        Dim roomId As Integer = Convert.ToInt32(cmbRoom.SelectedValue)
        Dim total As Decimal = CalculateTotal(roomId)

        Try
            Dim sql As String = "INSERT INTO reservations(guest_id, room_id, check_in, check_out, total_amount) VALUES(" & guestId & ", " & roomId & ", '" & dtCheckIn.Value.ToString("yyyy-MM-dd") & "', '" & dtCheckOut.Value.ToString("yyyy-MM-dd") & "', " & total & ")"
            ExecuteQuery(sql)

            If dtCheckIn.Value.Date = DateTime.Now.Date Then
                ExecuteQuery("UPDATE rooms SET status='Occupied' WHERE id=" & roomId)
            End If

            MsgBox("Reservation Added! Total: ₱" & total.ToString("N2"))
            LoadReservations()
            LoadCombos()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub btnDeleteRes_Click(sender As Object, e As EventArgs) Handles btnDeleteRes.Click
        If selectedResId = "" Then
            MsgBox("Please select a reservation to delete.")
            Return
        End If

        If MsgBox("Delete this reservation?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExecuteQuery("DELETE FROM reservations WHERE id=" & selectedResId)

            If selectedRoomId <> "" Then
                ExecuteQuery("UPDATE rooms SET status='Available' WHERE id=" & selectedRoomId)
            End If

            LoadReservations()
            selectedResId = ""
        End If
    End Sub

    Function CalculateTotal(roomId As Integer) As Decimal
        Dim days As Integer = DateDiff(DateInterval.Day, dtCheckIn.Value, dtCheckOut.Value)
        If days < 1 Then days = 1

        Dim dtPrice As DataTable = GetData("SELECT price FROM rooms WHERE id=" & roomId)
        If dtPrice.Rows.Count > 0 Then
            Return Convert.ToDecimal(dtPrice.Rows(0)("price")) * days
        End If
        Return 0
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        dash.Show()
        Me.Hide()
    End Sub
End Class