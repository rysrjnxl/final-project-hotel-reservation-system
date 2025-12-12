<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffManagement
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
        Label1.Location = New Point(72, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 0
        Label1.Text = "Staff Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(95, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 1
        Label2.Text = "Position"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(106, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 2
        Label3.Text = "Phone"
        ' 
        ' txtStaffName
        ' 
        txtStaffName.Location = New Point(162, 83)
        txtStaffName.Name = "txtStaffName"
        txtStaffName.Size = New Size(151, 27)
        txtStaffName.TabIndex = 3
        ' 
        ' txtStaffPhone
        ' 
        txtStaffPhone.Location = New Point(162, 159)
        txtStaffPhone.Name = "txtStaffPhone"
        txtStaffPhone.Size = New Size(151, 27)
        txtStaffPhone.TabIndex = 4
        ' 
        ' cmbPosition
        ' 
        cmbPosition.FormattingEnabled = True
        cmbPosition.Location = New Point(162, 122)
        cmbPosition.Name = "cmbPosition"
        cmbPosition.Size = New Size(151, 28)
        cmbPosition.TabIndex = 5
        ' 
        ' btnAddStaff
        ' 
        btnAddStaff.Location = New Point(106, 209)
        btnAddStaff.Name = "btnAddStaff"
        btnAddStaff.Size = New Size(94, 29)
        btnAddStaff.TabIndex = 6
        btnAddStaff.Text = "Add"
        btnAddStaff.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateStaff
        ' 
        btnUpdateStaff.Location = New Point(206, 209)
        btnUpdateStaff.Name = "btnUpdateStaff"
        btnUpdateStaff.Size = New Size(94, 29)
        btnUpdateStaff.TabIndex = 7
        btnUpdateStaff.Text = "Update"
        btnUpdateStaff.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteStaff
        ' 
        btnDeleteStaff.Location = New Point(306, 209)
        btnDeleteStaff.Name = "btnDeleteStaff"
        btnDeleteStaff.Size = New Size(94, 29)
        btnDeleteStaff.TabIndex = 8
        btnDeleteStaff.Text = "Delete"
        btnDeleteStaff.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 271)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(776, 167)
        DataGridView1.TabIndex = 9
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(146, 29)
        btnBack.TabIndex = 11
        btnBack.Text = "Back to Dashboard"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmStaffManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
