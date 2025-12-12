Public Class LoginForm
    ' Event that runs when the form opens
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mask the password characters so they appear as dots
        txtbxPassword.PasswordChar = "*"
    End Sub

    ' Event that runs when the Login button is clicked
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtbxUsername.Text
        Dim pass As String = txtbxPassword.Text

        ' 1. Basic Validation
        If user = "" Or pass = "" Then
            MsgBox("Please enter both username and password.", MsgBoxStyle.Exclamation, "Login Error")
            Return
        End If

        ' 2. Check Database Logic
        Try
            ' We use the GetData function from your DatabaseModule
            Dim sql As String = "SELECT * FROM users WHERE username='" & user & "' AND password='" & pass & "'"
            Dim dt As DataTable = GetData(sql)

            If dt.Rows.Count > 0 Then
                ' Login Success
                MsgBox("Welcome, " & user & "!", MsgBoxStyle.Information, "Login Successful")

                ' Open the Dashboard
                Dim dash As New frmDashboard
                dash.Show()

                ' Hide this Login form
                Me.Hide()
            Else
                ' Login Failed
                MsgBox("Invalid Username or Password.", MsgBoxStyle.Critical, "Login Failed")
            End If

        Catch ex As Exception
            MsgBox("Error connecting to database: " & ex.Message)
        End Try
    End Sub
End Class