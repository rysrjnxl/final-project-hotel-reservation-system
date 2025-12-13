Public Class frmBookingHistory
    Private Sub frmBookingHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me)
        LoadHistory()
    End Sub

    Sub LoadHistory()
        Dim sql As String = "SELECT r.id AS 'Ref #', rm.room_number AS 'Room', r.check_in AS 'Check In', r.check_out AS 'Check Out', r.total_amount AS 'Total Paid' " &
                            "FROM reservations r " &
                            "JOIN rooms rm ON r.room_id = rm.id " &
                            "WHERE r.guest_id = " & CurrentGuestID & " ORDER BY r.check_in DESC"

        dgvHistory.DataSource = GetData(sql)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class