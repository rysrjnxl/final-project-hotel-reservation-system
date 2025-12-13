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
        Label4 = New Label()
        Label5 = New Label()
        linkSignUp = New LinkLabel()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(240, 509)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 32)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(240, 612)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 32)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' txtbxPassword
        ' 
        txtbxPassword.BackColor = Color.WhiteSmoke
        txtbxPassword.Font = New Font("Segoe UI", 12.0F)
        txtbxPassword.Location = New Point(366, 609)
        txtbxPassword.Margin = New Padding(4)
        txtbxPassword.Name = "txtbxPassword"
        txtbxPassword.Size = New Size(312, 39)
        txtbxPassword.TabIndex = 2
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.BackColor = Color.WhiteSmoke
        txtbxUsername.Font = New Font("Segoe UI", 12.0F)
        txtbxUsername.Location = New Point(366, 509)
        txtbxUsername.Margin = New Padding(4)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Size(312, 39)
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
        btnLogin.Location = New Point(366, 700)
        btnLogin.Margin = New Padding(4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(312, 56)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(366, 823)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 25)
        Label4.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(366, 779)
        Label5.Name = "Label5"
        Label5.Size = New Size(197, 25)
        Label5.TabIndex = 7
        Label5.Text = "Don't have an account?"
        ' 
        ' linkSignUp
        ' 
        linkSignUp.AutoSize = True
        linkSignUp.ForeColor = Color.WhiteSmoke
        linkSignUp.LinkColor = Color.WhiteSmoke
        linkSignUp.Location = New Point(559, 779)
        linkSignUp.Name = "linkSignUp"
        linkSignUp.Size = New Size(75, 25)
        linkSignUp.TabIndex = 8
        linkSignUp.TabStop = True
        linkSignUp.Text = "Sign Up"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Green_and_Beige_Minimalist_Luxury_Hotel_Logo_21
        PictureBox1.Location = New Point(151, -22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(700, 644)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        ClientSize = New Size(948, 1065)
        Controls.Add(linkSignUp)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnLogin)
        Controls.Add(txtbxUsername)
        Controls.Add(txtbxPassword)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(4)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxPassword As TextBox
    Friend WithEvents txtbxUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents linkSignUp As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class