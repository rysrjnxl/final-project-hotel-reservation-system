Public Class frmGuestManagement
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        SlideInForm(dash)
        Me.Hide()
    End Sub
End Class
