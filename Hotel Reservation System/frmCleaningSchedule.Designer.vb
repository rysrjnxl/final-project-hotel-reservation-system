<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCleaningSchedule
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
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(50, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 23)
        Label1.TabIndex = 0
        Label1.Text = "Room:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(50, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 23)
        Label2.TabIndex = 1
        Label2.Text = "Staff Assigned:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(50, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 23)
        Label3.TabIndex = 2
        Label3.Text = "Status:"
        ' 
        ' cmbCleanRoom
        ' 
        cmbCleanRoom.Font = New Font("Segoe UI", 10.0F)
        cmbCleanRoom.FormattingEnabled = True
        cmbCleanRoom.Location = New Point(180, 67)
        cmbCleanRoom.Name = "cmbCleanRoom"
        cmbCleanRoom.Size = New Size(200, 31)
        cmbCleanRoom.TabIndex = 3
        ' 
        ' cmbCleanStaff
        ' 
        cmbCleanStaff.Font = New Font("Segoe UI", 10.0F)
        cmbCleanStaff.FormattingEnabled = True
        cmbCleanStaff.Location = New Point(180, 112)
        cmbCleanStaff.Name = "cmbCleanStaff"
        cmbCleanStaff.Size = New Size(200, 31)
        cmbCleanStaff.TabIndex = 4
        ' 
        ' cmbCleanStatus
        ' 
        cmbCleanStatus.Font = New Font("Segoe UI", 10.0F)
        cmbCleanStatus.FormattingEnabled = True
        cmbCleanStatus.Items.AddRange(New Object() {"Pending", "In Progress", "Completed"})
        cmbCleanStatus.Location = New Point(180, 157)
        cmbCleanStatus.Name = "cmbCleanStatus"
        cmbCleanStatus.Size = New Size(200, 31)
        cmbCleanStatus.TabIndex = 5
        ' 
        ' btnAssignClean
        ' 
        btnAssignClean.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnAssignClean.FlatStyle = FlatStyle.Flat
        btnAssignClean.FlatAppearance.BorderSize = 0
        btnAssignClean.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnAssignClean.ForeColor = Color.White
        btnAssignClean.Location = New Point(50, 220)
        btnAssignClean.Name = "btnAssignClean"
        btnAssignClean.Size = New Size(100, 40)
        btnAssignClean.TabIndex = 6
        btnAssignClean.Text = "Assign"
        btnAssignClean.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateClean
        ' 
        btnUpdateClean.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdateClean.FlatStyle = FlatStyle.Flat
        btnUpdateClean.FlatAppearance.BorderSize = 0
        btnUpdateClean.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdateClean.ForeColor = Color.White
        btnUpdateClean.Location = New Point(160, 220)
        btnUpdateClean.Name = "btnUpdateClean"
        btnUpdateClean.Size = New Size(100, 40)
        btnUpdateClean.TabIndex = 7
        btnUpdateClean.Text = "Update"
        btnUpdateClean.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteClean
        ' 
        btnDeleteClean.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDeleteClean.FlatStyle = FlatStyle.Flat
        btnDeleteClean.FlatAppearance.BorderSize = 0
        btnDeleteClean.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDeleteClean.ForeColor = Color.White
        btnDeleteClean.Location = New Point(270, 220)
        btnDeleteClean.Name = "btnDeleteClean"
        btnDeleteClean.Size = New Size(100, 40)
        btnDeleteClean.TabIndex = 8
        btnDeleteClean.Text = "Delete"
        btnDeleteClean.UseVisualStyleBackColor = False
        ' 
        ' dgvCleaning
        ' 
        dgvCleaning.BackgroundColor = Color.White
        dgvCleaning.BorderStyle = BorderStyle.None
        dgvCleaning.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCleaning.Location = New Point(50, 280)
        dgvCleaning.Name = "dgvCleaning"
        dgvCleaning.RowHeadersWidth = 51
        dgvCleaning.Size = New Size(700, 200)
        dgvCleaning.TabIndex = 9
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
        btnBack.TabIndex = 10
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmCleaningSchedule
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(800, 500)
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
        StartPosition = FormStartPosition.CenterScreen
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