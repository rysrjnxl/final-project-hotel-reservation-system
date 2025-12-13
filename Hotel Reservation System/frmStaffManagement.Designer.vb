<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaffManagement
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
        txtStaffName = New TextBox()
        txtStaffPhone = New TextBox()
        cmbPosition = New ComboBox()
        btnAddStaff = New Button()
        btnUpdateStaff = New Button()
        btnDeleteStaff = New Button()
        DataGridView1 = New DataGridView()
        btnBack = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        Label2.Size = New Size(78, 23)
        Label2.TabIndex = 1
        Label2.Text = "Position:"
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
        ' txtStaffName
        ' 
        txtStaffName.Font = New Font("Segoe UI", 10.0F)
        txtStaffName.Location = New Point(140, 67)
        txtStaffName.Name = "txtStaffName"
        txtStaffName.Size = New Size(240, 30)
        txtStaffName.TabIndex = 3
        ' 
        ' txtStaffPhone
        ' 
        txtStaffPhone.Font = New Font("Segoe UI", 10.0F)
        txtStaffPhone.Location = New Point(140, 157)
        txtStaffPhone.Name = "txtStaffPhone"
        txtStaffPhone.Size = New Size(240, 30)
        txtStaffPhone.TabIndex = 4
        ' 
        ' cmbPosition
        ' 
        cmbPosition.Font = New Font("Segoe UI", 10.0F)
        cmbPosition.FormattingEnabled = True
        cmbPosition.Location = New Point(140, 112)
        cmbPosition.Name = "cmbPosition"
        cmbPosition.Size = New Size(240, 31)
        cmbPosition.TabIndex = 5
        ' 
        ' btnAddStaff
        ' 
        btnAddStaff.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnAddStaff.FlatStyle = FlatStyle.Flat
        btnAddStaff.FlatAppearance.BorderSize = 0
        btnAddStaff.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnAddStaff.ForeColor = Color.White
        btnAddStaff.Location = New Point(50, 220)
        btnAddStaff.Name = "btnAddStaff"
        btnAddStaff.Size = New Size(100, 40)
        btnAddStaff.TabIndex = 6
        btnAddStaff.Text = "Add"
        btnAddStaff.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateStaff
        ' 
        btnUpdateStaff.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdateStaff.FlatStyle = FlatStyle.Flat
        btnUpdateStaff.FlatAppearance.BorderSize = 0
        btnUpdateStaff.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdateStaff.ForeColor = Color.White
        btnUpdateStaff.Location = New Point(160, 220)
        btnUpdateStaff.Name = "btnUpdateStaff"
        btnUpdateStaff.Size = New Size(100, 40)
        btnUpdateStaff.TabIndex = 7
        btnUpdateStaff.Text = "Update"
        btnUpdateStaff.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteStaff
        ' 
        btnDeleteStaff.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDeleteStaff.FlatStyle = FlatStyle.Flat
        btnDeleteStaff.FlatAppearance.BorderSize = 0
        btnDeleteStaff.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDeleteStaff.ForeColor = Color.White
        btnDeleteStaff.Location = New Point(270, 220)
        btnDeleteStaff.Name = "btnDeleteStaff"
        btnDeleteStaff.Size = New Size(100, 40)
        btnDeleteStaff.TabIndex = 8
        btnDeleteStaff.Text = "Delete"
        btnDeleteStaff.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(50, 280)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(700, 200)
        DataGridView1.TabIndex = 9
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
        ' frmStaffManagement
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(800, 500)
        Controls.Add(btnBack)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteStaff)
        Controls.Add(btnUpdateStaff)
        Controls.Add(btnAddStaff)
        Controls.Add(cmbPosition)
        Controls.Add(txtStaffPhone)
        Controls.Add(txtStaffName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmStaffManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Staff Management"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtStaffPhone As TextBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnUpdateStaff As Button
    Friend WithEvents btnDeleteStaff As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
End Class