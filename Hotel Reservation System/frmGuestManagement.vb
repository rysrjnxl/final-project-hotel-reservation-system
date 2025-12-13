Public Class frmGuestManagement
    Dim selectedResId As String = ""
    Dim selectedRoomId As String = ""

    Private Sub frmGuestManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me)
        LoadRooms()
        LoadGuestStays()
    End Sub

    Sub LoadGuestStays()
        Dim sql As String = "SELECT r.id AS 'Res ID', g.full_name AS 'Guest Name', g.phone AS 'Phone', " &
                            "rm.room_number AS 'Room', r.check_in AS 'Check In', r.check_out AS 'Check Out', rm.status AS 'Room Status', " &
                            "r.room_id " &
                            "FROM reservations r " &
                            "JOIN guests g ON r.guest_id = g.id " &
                            "JOIN rooms rm ON r.room_id = rm.id " &
                            "WHERE r.check_in <= CURDATE() AND r.check_out >= CURDATE() " &
                            "ORDER BY r.check_out ASC"

        Dim dt As DataTable = GetData(sql)
        dgvGuestStays.DataSource = dt

        If dgvGuestStays.Columns.Count > 0 Then
            dgvGuestStays.Columns("Res ID").Visible = False
            dgvGuestStays.Columns("room_id").Visible = False
        End If
    End Sub

    Sub LoadRooms()
        Dim dt As DataTable = GetData("SELECT id, room_number FROM rooms")
        cmbRoom.DataSource = dt
        cmbRoom.DisplayMember = "room_number"
        cmbRoom.ValueMember = "id"
    End Sub

    Private Sub dgvGuestStays_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuestStays.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvGuestStays.Rows(e.RowIndex)

            If Not IsDBNull(row.Cells("Res ID").Value) Then
                selectedResId = row.Cells("Res ID").Value.ToString()
            Else
                selectedResId = ""
            End If

            If Not IsDBNull(row.Cells("room_id").Value) AndAlso row.Cells("room_id").Value.ToString() <> "" Then
                selectedRoomId = row.Cells("room_id").Value.ToString()

                Try
                    cmbRoom.SelectedValue = Convert.ToInt32(selectedRoomId)
                Catch
                    cmbRoom.SelectedIndex = -1
                End Try
            Else
                selectedRoomId = ""
                cmbRoom.SelectedIndex = -1
            End If

            txtName.Text = row.Cells("Guest Name").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()

            Try
                If Not IsDBNull(row.Cells("Check In").Value) Then
                    dtCheckIn.Value = Convert.ToDateTime(row.Cells("Check In").Value)
                End If

                If Not IsDBNull(row.Cells("Check Out").Value) Then
                    dtCheckOut.Value = Convert.ToDateTime(row.Cells("Check Out").Value)
                End If
            Catch ex As Exception
                dtCheckIn.Value = DateTime.Now
                dtCheckOut.Value = DateTime.Now.AddDays(1)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedResId = "" Then
            MsgBox("Please select a guest booking from the list.")
            Return
        End If

        Dim newRoomId As String = cmbRoom.SelectedValue.ToString()
        Dim inDate As String = dtCheckIn.Value.ToString("yyyy-MM-dd")
        Dim outDate As String = dtCheckOut.Value.ToString("yyyy-MM-dd")

        Dim sql As String = "UPDATE reservations SET room_id=" & newRoomId & ", check_in='" & inDate & "', check_out='" & outDate & "' WHERE id=" & selectedResId
        ExecuteQuery(sql)

        If newRoomId <> selectedRoomId Then
            ExecuteQuery("UPDATE rooms SET status='Available' WHERE id=" & selectedRoomId)
            ExecuteQuery("UPDATE rooms SET status='Occupied' WHERE id=" & newRoomId)
        End If

        MsgBox("Booking Updated!")
        LoadGuestStays()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If selectedRoomId = "" Then
            MsgBox("Please select a guest to check out.")
            Return
        End If

        If MsgBox("Confirm Check Out for " & txtName.Text & "? Room will be marked Available.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            ExecuteQuery("UPDATE rooms SET status='Available' WHERE id=" & selectedRoomId)

            MsgBox("Guest Checked Out Successfully.")
            LoadGuestStays()

            txtName.Clear()
            txtPhone.Clear()
            selectedResId = ""
            selectedRoomId = ""
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        dash.Show()
        Me.Hide()
    End Sub
End Class