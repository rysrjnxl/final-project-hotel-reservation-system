<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtbxPassword = New TextBox()
        txtbxUsername = New TextBox()
        btnLogin = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(192, 407)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(192, 490)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 28)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' txtbxPassword
        ' 
        txtbxPassword.Font = New Font("Segoe UI", 12.0F)
        txtbxPassword.Location = New Point(293, 487)
        txtbxPassword.Name = "txtbxPassword"
        txtbxPassword.Size = New Size(250, 34)
        txtbxPassword.TabIndex = 2
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.Font = New Font("Segoe UI", 12.0F)
        txtbxUsername.Location = New Point(293, 407)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Size(250, 34)
        txtbxUsername.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(293, 560)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(250, 45)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label3.Location = New Point(180, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(376, 62)
        Label3.TabIndex = 5
        Label3.Text = "HOTEL DANICA"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(758, 852)
        Controls.Add(Label3)
        Controls.Add(btnLogin)
        Controls.Add(txtbxUsername)
        Controls.Add(txtbxPassword)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxPassword As TextBox
    Friend WithEvents txtbxUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
End Class