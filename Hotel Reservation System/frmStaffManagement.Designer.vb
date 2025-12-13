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
        dgvStaff = New DataGridView()
        btnBack = New Button()
        CType(dgvStaff, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(62, 88)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 30)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(62, 144)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 30)
        Label2.TabIndex = 1
        Label2.Text = "Position:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(62, 200)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 30)
        Label3.TabIndex = 2
        Label3.Text = "Phone:"
        ' 
        ' txtStaffName
        ' 
        txtStaffName.Font = New Font("Segoe UI", 10.0F)
        txtStaffName.Location = New Point(175, 84)
        txtStaffName.Margin = New Padding(4, 4, 4, 4)
        txtStaffName.Name = "txtStaffName"
        txtStaffName.Size = New Size(299, 34)
        txtStaffName.TabIndex = 3
        ' 
        ' txtStaffPhone
        ' 
        txtStaffPhone.Font = New Font("Segoe UI", 10.0F)
        txtStaffPhone.Location = New Point(175, 196)
        txtStaffPhone.Margin = New Padding(4, 4, 4, 4)
        txtStaffPhone.Name = "txtStaffPhone"
        txtStaffPhone.Size = New Size(299, 34)
        txtStaffPhone.TabIndex = 4
        ' 
        ' cmbPosition
        ' 
        cmbPosition.Font = New Font("Segoe UI", 10.0F)
        cmbPosition.FormattingEnabled = True
        cmbPosition.Location = New Point(175, 140)
        cmbPosition.Margin = New Padding(4, 4, 4, 4)
        cmbPosition.Name = "cmbPosition"
        cmbPosition.Size = New Size(299, 36)
        cmbPosition.TabIndex = 5
        ' 
        ' btnAddStaff
        ' 
        btnAddStaff.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnAddStaff.FlatAppearance.BorderSize = 0
        btnAddStaff.FlatStyle = FlatStyle.Flat
        btnAddStaff.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnAddStaff.ForeColor = Color.White
        btnAddStaff.Location = New Point(62, 275)
        btnAddStaff.Margin = New Padding(4, 4, 4, 4)
        btnAddStaff.Name = "btnAddStaff"
        btnAddStaff.Size = New Size(125, 50)
        btnAddStaff.TabIndex = 6
        btnAddStaff.Text = "Add"
        btnAddStaff.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateStaff
        ' 
        btnUpdateStaff.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdateStaff.FlatAppearance.BorderSize = 0
        btnUpdateStaff.FlatStyle = FlatStyle.Flat
        btnUpdateStaff.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdateStaff.ForeColor = Color.White
        btnUpdateStaff.Location = New Point(200, 275)
        btnUpdateStaff.Margin = New Padding(4, 4, 4, 4)
        btnUpdateStaff.Name = "btnUpdateStaff"
        btnUpdateStaff.Size = New Size(125, 50)
        btnUpdateStaff.TabIndex = 7
        btnUpdateStaff.Text = "Update"
        btnUpdateStaff.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteStaff
        ' 
        btnDeleteStaff.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDeleteStaff.FlatAppearance.BorderSize = 0
        btnDeleteStaff.FlatStyle = FlatStyle.Flat
        btnDeleteStaff.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDeleteStaff.ForeColor = Color.White
        btnDeleteStaff.Location = New Point(338, 275)
        btnDeleteStaff.Margin = New Padding(4, 4, 4, 4)
        btnDeleteStaff.Name = "btnDeleteStaff"
        btnDeleteStaff.Size = New Size(125, 50)
        btnDeleteStaff.TabIndex = 8
        btnDeleteStaff.Text = "Delete"
        btnDeleteStaff.UseVisualStyleBackColor = False
        ' 
        ' dgvStaff
        ' 
        dgvStaff.BackgroundColor = Color.White
        dgvStaff.BorderStyle = BorderStyle.None
        dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStaff.Location = New Point(62, 350)
        dgvStaff.Margin = New Padding(4, 4, 4, 4)
        dgvStaff.Name = "dgvStaff"
        dgvStaff.RowHeadersWidth = 51
        dgvStaff.Size = New Size(875, 250)
        dgvStaff.TabIndex = 9
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(15, 15)
        btnBack.Margin = New Padding(4, 4, 4, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(125, 44)
        btnBack.TabIndex = 11
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmStaffManagement
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(1000, 625)
        Controls.Add(btnBack)
        Controls.Add(dgvStaff)
        Controls.Add(btnDeleteStaff)
        Controls.Add(btnUpdateStaff)
        Controls.Add(btnAddStaff)
        Controls.Add(cmbPosition)
        Controls.Add(txtStaffPhone)
        Controls.Add(txtStaffName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4, 4, 4, 4)
        Name = "frmStaffManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Staff Management"
        CType(dgvStaff, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents btnBack As Button
End Class