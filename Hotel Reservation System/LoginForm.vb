Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbxPassword.PasswordChar = "*"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtbxUsername.Text
        Dim pass As String = txtbxPassword.Text

        If user = "" Or pass = "" Then
            MsgBox("Please enter both username and password.", MsgBoxStyle.Exclamation, "Login Error")
            Return
        End If

        Try
            ' 1. Check Admin
            Dim sqlUser As String = "SELECT * FROM users WHERE username='" & user & "' AND password='" & pass & "'"
            Dim dtUser As DataTable = GetData(sqlUser)

            If dtUser IsNot Nothing AndAlso dtUser.Rows.Count > 0 Then
                Dim role As String = dtUser.Rows(0)("role").ToString()
                MsgBox("Welcome, " & role & "!", MsgBoxStyle.Information, "Login Successful")
                Dim dash As New frmDashboard
                dash.Show()
                Me.Hide()
                Exit Sub
            End If

            ' 2. Check Guest
            Dim sqlGuest As String = "SELECT * FROM guests WHERE username='" & user & "' AND password='" & pass & "'"
            Dim dtGuest As DataTable = GetData(sqlGuest)

            If dtGuest IsNot Nothing AndAlso dtGuest.Rows.Count > 0 Then
                ' Set Global Session ID
                CurrentGuestID = Convert.ToInt32(dtGuest.Rows(0)("id"))

                MsgBox("Welcome back, " & user & "!", MsgBoxStyle.Information, "Login Successful")

                ' Go to Booking
                Dim clientBooking As New frmClientBooking
                clientBooking.Show()
                Me.Hide()
                Exit Sub
            End If

            MsgBox("Invalid Username or Password.", MsgBoxStyle.Critical, "Login Failed")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtbxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin.PerformClick()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles linkSignUp.Click
        Dim reg As New frmGuestRegistration
        reg.Show()
        Me.Hide()
    End Sub

End Class