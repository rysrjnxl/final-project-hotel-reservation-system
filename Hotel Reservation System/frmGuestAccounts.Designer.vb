<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGuestAccounts
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGuests = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guest Account Manager"
        '
        'dgvGuests
        '
        Me.dgvGuests.BackgroundColor = System.Drawing.Color.White
        Me.dgvGuests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuests.Location = New System.Drawing.Point(30, 220)
        Me.dgvGuests.Name = "dgvGuests"
        Me.dgvGuests.RowHeadersWidth = 51
        Me.dgvGuests.Size = New System.Drawing.Size(740, 300)
        Me.dgvGuests.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(30, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Guest:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtName.Location = New System.Drawing.Point(120, 77)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 30)
        Me.txtName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(350, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.Location = New System.Drawing.Point(450, 77)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(180, 30)
        Me.txtUsername.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(350, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(450, 127)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(180, 30)
        Me.txtPassword.TabIndex = 3
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(650, 75)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 35)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update Info"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(650, 125)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 35)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete Guest"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(680, 20)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 35)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmGuestAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvGuests)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGuestAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Accounts"
        CType(Me.dgvGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvGuests As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
End Class