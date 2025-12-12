<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCleaningSchedule
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
        cmbCleanRoom = New ComboBox()
        cmbCleanStaff = New ComboBox()
        cmbCleanStatus = New ComboBox()
        btnAssignClean = New Button()
        btnUpdateClean = New Button()
        btnDeleteClean = New Button()
        dgvCleaning = New DataGridView()
        btnBack = New Button()
        CType(dgvCleaning, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(119, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Room"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(64, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 1
        Label2.Text = "Staff Assigned"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(119, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 2
        Label3.Text = "Status"
        ' 
        ' cmbCleanRoom
        ' 
        cmbCleanRoom.FormattingEnabled = True
        cmbCleanRoom.Location = New Point(174, 91)
        cmbCleanRoom.Name = "cmbCleanRoom"
        cmbCleanRoom.Size = New Size(151, 28)
        cmbCleanRoom.TabIndex = 3
        ' 
        ' cmbCleanStaff
        ' 
        cmbCleanStaff.FormattingEnabled = True
        cmbCleanStaff.Location = New Point(174, 132)
        cmbCleanStaff.Name = "cmbCleanStaff"
        cmbCleanStaff.Size = New Size(151, 28)
        cmbCleanStaff.TabIndex = 4
        ' 
        ' cmbCleanStatus
        ' 
        cmbCleanStatus.FormattingEnabled = True
        cmbCleanStatus.Items.AddRange(New Object() {"Pending", "In Progress", "Completed"})
        cmbCleanStatus.Location = New Point(174, 173)
        cmbCleanStatus.Name = "cmbCleanStatus"
        cmbCleanStatus.Size = New Size(151, 28)
        cmbCleanStatus.TabIndex = 5
        ' 
        ' btnAssignClean
        ' 
        btnAssignClean.Location = New Point(64, 238)
        btnAssignClean.Name = "btnAssignClean"
        btnAssignClean.Size = New Size(94, 29)
        btnAssignClean.TabIndex = 6
        btnAssignClean.Text = "Assign"
        btnAssignClean.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateClean
        ' 
        btnUpdateClean.Location = New Point(164, 238)
        btnUpdateClean.Name = "btnUpdateClean"
        btnUpdateClean.Size = New Size(94, 29)
        btnUpdateClean.TabIndex = 7
        btnUpdateClean.Text = "Update"
        btnUpdateClean.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteClean
        ' 
        btnDeleteClean.Location = New Point(264, 238)
        btnDeleteClean.Name = "btnDeleteClean"
        btnDeleteClean.Size = New Size(94, 29)
        btnDeleteClean.TabIndex = 8
        btnDeleteClean.Text = "Delete"
        btnDeleteClean.UseVisualStyleBackColor = True
        ' 
        ' dgvCleaning
        ' 
        dgvCleaning.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCleaning.Location = New Point(12, 273)
        dgvCleaning.Name = "dgvCleaning"
        dgvCleaning.RowHeadersWidth = 51
        dgvCleaning.Size = New Size(776, 165)
        dgvCleaning.TabIndex = 9
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(146, 29)
        btnBack.TabIndex = 10
        btnBack.Text = "Back to Dashboard"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmCleaningSchedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(dgvCleaning)
        Controls.Add(btnDeleteClean)
        Controls.Add(btnUpdateClean)
        Controls.Add(btnAssignClean)
        Controls.Add(cmbCleanStatus)
        Controls.Add(cmbCleanStaff)
        Controls.Add(cmbCleanRoom)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmCleaningSchedule"
        Text = "Cleaning Schedule"
        CType(dgvCleaning, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCleanRoom As ComboBox
    Friend WithEvents cmbCleanStaff As ComboBox
    Friend WithEvents cmbCleanStatus As ComboBox
    Friend WithEvents btnAssignClean As Button
    Friend WithEvents btnUpdateClean As Button
    Friend WithEvents btnDeleteClean As Button
    Friend WithEvents dgvCleaning As DataGridView
    Friend WithEvents btnBack As Button
End Class
