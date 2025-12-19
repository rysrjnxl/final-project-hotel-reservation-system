Public Class frmGuestRegistration

    Private Sub frmGuestRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me)
        txtPassword.PasswordChar = "*"
    End Sub
    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUsername.Text = "" Or txtName.Text = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please fill in all fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim checkSql As String = "SELECT * FROM guests WHERE username='" & txtUsername.Text & "'"
            Dim dt As DataTable = GetData(checkSql)

            If dt.Rows.Count > 0 Then
                MsgBox("This username is already taken. Please choose another.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim sql As String = "INSERT INTO guests(username, full_name, email, phone, password) VALUES('" & txtUsername.Text & "', '" & txtName.Text & "', '" & txtEmail.Text & "', '" & txtPhone.Text & "', '" & txtPassword.Text & "')"
            ExecuteQuery(sql)

            MsgBox("Account Created Successfully! Please Login with your Username.", MsgBoxStyle.Information)

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