Public Class frmReservation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashbaord
        SlideInForm(dash)
        Me.Hide()
    End Sub

    Private Sub frmReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class