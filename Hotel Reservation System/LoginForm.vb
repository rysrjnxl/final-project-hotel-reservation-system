Public Class LoginForm

    ' 1. Form Load: Setup UI
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbxPassword.PasswordChar = "*"
    End Sub

    ' 2. Login Logic
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtbxUsername.Text
        Dim pass As String = txtbxPassword.Text

        ' Basic Validation
        If user = "" Or pass = "" Then
            MsgBox("Please enter both username and password.", MsgBoxStyle.Exclamation, "Login Error")
            Return
        End If

        Try
            ' --- PHASE 1: CHECK ADMIN/STAFF TABLE ---
            Dim sqlUser As String = "SELECT * FROM users WHERE username='" & user & "' AND password='" & pass & "'"
            Dim dtUser As DataTable = GetData(sqlUser)

            If dtUser IsNot Nothing AndAlso dtUser.Rows.Count > 0 Then
                ' Found in USERS table -> Go to ADMIN Dashboard
                Dim role As String = dtUser.Rows(0)("role").ToString()
                MsgBox("Welcome, " & role & "!", MsgBoxStyle.Information, "Login Successful")

                Dim dash As New frmDashboard
                dash.Show()
                Me.Hide()
                Exit Sub ' Stop here!
            End If

            ' --- PHASE 2: CHECK GUEST TABLE ---
            ' Note: Guests now use 'username' column, NOT 'full_name'
            Dim sqlGuest As String = "SELECT * FROM guests WHERE username='" & user & "' AND password='" & pass & "'"
            Dim dtGuest As DataTable = GetData(sqlGuest)

            If dtGuest IsNot Nothing AndAlso dtGuest.Rows.Count > 0 Then
                ' Found in GUESTS table -> Go to CLIENT Dashboard

                ' Store Guest ID for this session (Important for history!)
                Dim CurrentGuestID = Convert.ToInt32(dtGuest.Rows(0)("id"))

                MsgBox("Welcome back, " & user & "!", MsgBoxStyle.Information, "Login Successful")

                Dim clientDash As New frmClientBooking
                clientDash.Show()
                Me.Hide()
                Exit Sub ' Stop here!
            End If

            ' --- IF NOT FOUND IN EITHER ---
            MsgBox("Invalid Username or Password.", MsgBoxStyle.Critical, "Login Failed")

        Catch ex As Exception
            MsgBox("Error connecting to database: " & ex.Message)
        End Try
    End Sub

    ' 3. Allow pressing "Enter" key to login
    Private Sub txtbxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    ' 4. Sign Up Button (Opens Registration)
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles linkSignUp.Click
        Dim reg As New frmGuestRegistration
        reg.Show()
        Me.Hide()
    End Sub
End Class