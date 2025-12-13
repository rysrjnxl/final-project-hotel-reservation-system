<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGuestRegistration
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        LabelUsername = New Label()
        txtUsername = New TextBox()
        Label2 = New Label()
        txtName = New TextBox()
        Label3 = New Label()
        txtEmail = New TextBox()
        Label4 = New Label()
        txtPhone = New TextBox()
        Label5 = New Label()
        txtPassword = New TextBox()
        btnRegister = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label1.Location = New Point(120, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 41)
        Label1.TabIndex = 0
        Label1.Text = "Create Guest Account"
        ' 
        ' LabelUsername
        ' 
        LabelUsername.AutoSize = True
        LabelUsername.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LabelUsername.Location = New Point(50, 90)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(94, 23)
        LabelUsername.TabIndex = 11
        LabelUsername.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.Location = New Point(160, 87)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(250, 30)
        txtUsername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label2.Location = New Point(50, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 23)
        Label2.TabIndex = 1
        Label2.Text = "Full Name:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.0F)
        txtName.Location = New Point(160, 137)
        txtName.Name = "txtName"
        txtName.Size = New Size(250, 30)
        txtName.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label3.Location = New Point(50, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 23)
        Label3.TabIndex = 3
        Label3.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.Location = New Point(160, 187)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 30)
        txtEmail.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label4.Location = New Point(50, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 23)
        Label4.TabIndex = 5
        Label4.Text = "Phone:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 10.0F)
        txtPhone.Location = New Point(160, 237)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(250, 30)
        txtPhone.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label5.Location = New Point(50, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 23)
        Label5.TabIndex = 7
        Label5.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.Location = New Point(160, 287)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(250, 30)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(50, 350)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(360, 45)
        btnRegister.TabIndex = 6
        btnRegister.Text = "SIGN UP"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(80, 35)
        btnBack.TabIndex = 7
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmClientRegistration
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(480, 450)
        Controls.Add(btnBack)
        Controls.Add(btnRegister)
        Controls.Add(txtPassword)
        Controls.Add(Label5)
        Controls.Add(txtPhone)
        Controls.Add(Label4)
        Controls.Add(txtEmail)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(LabelUsername)
        Controls.Add(Label1)
        Name = "frmClientRegistration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign Up"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBack As Button
End Class