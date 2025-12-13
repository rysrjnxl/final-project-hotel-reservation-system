<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGuestManagement
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
        Label2 = New Label()
        Label3 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        dgvGuest = New DataGridView()
        btnBack = New Button()
        CType(dgvGuest, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(50, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 23)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(50, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 23)
        Label2.TabIndex = 1
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(50, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 23)
        Label3.TabIndex = 2
        Label3.Text = "Phone:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.0F)
        txtName.Location = New Point(130, 67)
        txtName.Name = "txtName"
        txtName.Size = New Size(250, 30)
        txtName.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.Location = New Point(130, 112)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 30)
        txtEmail.TabIndex = 4
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 10.0F)
        txtPhone.Location = New Point(130, 157)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(250, 30)
        txtPhone.TabIndex = 5
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(50, 220)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(100, 40)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(160, 220)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(100, 40)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(270, 220)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 40)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' dgvGuest
        ' 
        dgvGuest.BackgroundColor = Color.White
        dgvGuest.BorderStyle = BorderStyle.None
        dgvGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuest.Location = New Point(50, 280)
        dgvGuest.Name = "dgvGuest"
        dgvGuest.RowHeadersWidth = 51
        dgvGuest.Size = New Size(700, 200)
        dgvGuest.TabIndex = 9
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
        btnBack.Size = New Size(100, 35)
        btnBack.TabIndex = 11
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmGuestManagement
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(800, 500)
        Controls.Add(btnBack)
        Controls.Add(dgvGuest)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmGuestManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Guest Management"
        CType(dgvGuest, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvGuest As DataGridView
    Friend WithEvents btnBack As Button
End Class