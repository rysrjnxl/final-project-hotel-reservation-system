<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Label1.Location = New Point(192, 407)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(192, 490)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' txtbxPassword
        ' 
        txtbxPassword.Location = New Point(293, 487)
        txtbxPassword.Name = "txtbxPassword"
        txtbxPassword.Size = New Size(215, 31)
        txtbxPassword.TabIndex = 2
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.Location = New Point(293, 407)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Size(215, 31)
        txtbxUsername.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(328, 582)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(192, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(376, 65)
        Label3.TabIndex = 5
        Label3.Text = "HOTEL DANICA"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(758, 852)
        Controls.Add(Label3)
        Controls.Add(btnLogin)
        Controls.Add(txtbxUsername)
        Controls.Add(txtbxPassword)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
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
