Public Class frmGuestRegistration

    Private Sub frmGuestRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me)
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Validate Input
        If txtName.Text = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please fill in all fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            ' 2. Check if user already exists
            Dim checkSql As String = "SELECT * FROM guests WHERE full_name='" & txtName.Text & "'"
            Dim dt As DataTable = GetData(checkSql)

            If dt.Rows.Count > 0 Then
                MsgBox("An account with this name already exists.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' 3. Create Account
            Dim sql As String = "INSERT INTO guests(full_name, email, phone, password) VALUES('" & txtName.Text & "', '" & txtEmail.Text & "', '" & txtPhone.Text & "', '" & txtPassword.Text & "')"
            ExecuteQuery(sql)

            MsgBox("Account Created Successfully! Please Login.", MsgBoxStyle.Information)

            ' 4. Return to Login Screen
            Dim login As New LoginForm
            login.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox("Registration Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim login As New LoginForm
        login.Show()
        Me.Close()
    End Sub
End Class