<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRoomManagement
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
        txtRoomNumber = New TextBox()
        cmbRoomType = New ComboBox()
        txtRate = New TextBox()
        btnAddRoom = New Button()
        btnUpdateRoom = New Button()
        btnDeleteRoom = New Button()
        dgvRoomManagement = New DataGridView()
        btnBack = New Button()
        CType(dgvRoomManagement, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(62, 88)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 30)
        Label1.TabIndex = 0
        Label1.Text = "Room No:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(62, 144)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 30)
        Label2.TabIndex = 1
        Label2.Text = "Type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(62, 200)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 30)
        Label3.TabIndex = 2
        Label3.Text = "Rate:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Font = New Font("Segoe UI", 10.0F)
        txtRoomNumber.Location = New Point(188, 84)
        txtRoomNumber.Margin = New Padding(4)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(286, 34)
        txtRoomNumber.TabIndex = 3
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.Font = New Font("Segoe UI", 10.0F)
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Location = New Point(188, 140)
        cmbRoomType.Margin = New Padding(4)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(286, 36)
        cmbRoomType.TabIndex = 4
        ' 
        ' txtRate
        ' 
        txtRate.Font = New Font("Segoe UI", 10.0F)
        txtRate.Location = New Point(188, 196)
        txtRate.Margin = New Padding(4)
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(286, 34)
        txtRate.TabIndex = 5
        ' 
        ' btnAddRoom
        ' 
        btnAddRoom.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnAddRoom.FlatAppearance.BorderSize = 0
        btnAddRoom.FlatStyle = FlatStyle.Flat
        btnAddRoom.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnAddRoom.ForeColor = Color.White
        btnAddRoom.Location = New Point(62, 275)
        btnAddRoom.Margin = New Padding(4)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.Size = New Size(125, 50)
        btnAddRoom.TabIndex = 6
        btnAddRoom.Text = "Add"
        btnAddRoom.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateRoom
        ' 
        btnUpdateRoom.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdateRoom.FlatAppearance.BorderSize = 0
        btnUpdateRoom.FlatStyle = FlatStyle.Flat
        btnUpdateRoom.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdateRoom.ForeColor = Color.White
        btnUpdateRoom.Location = New Point(200, 275)
        btnUpdateRoom.Margin = New Padding(4)
        btnUpdateRoom.Name = "btnUpdateRoom"
        btnUpdateRoom.Size = New Size(125, 50)
        btnUpdateRoom.TabIndex = 7
        btnUpdateRoom.Text = "Update"
        btnUpdateRoom.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRoom
        ' 
        btnDeleteRoom.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDeleteRoom.FlatAppearance.BorderSize = 0
        btnDeleteRoom.FlatStyle = FlatStyle.Flat
        btnDeleteRoom.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDeleteRoom.ForeColor = Color.White
        btnDeleteRoom.Location = New Point(338, 275)
        btnDeleteRoom.Margin = New Padding(4)
        btnDeleteRoom.Name = "btnDeleteRoom"
        btnDeleteRoom.Size = New Size(125, 50)
        btnDeleteRoom.TabIndex = 8
        btnDeleteRoom.Text = "Delete"
        btnDeleteRoom.UseVisualStyleBackColor = False
        ' 
        ' dgvRoomManagement
        ' 
        dgvRoomManagement.BackgroundColor = Color.White
        dgvRoomManagement.BorderStyle = BorderStyle.None
        dgvRoomManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRoomManagement.Location = New Point(62, 350)
        dgvRoomManagement.Margin = New Padding(4)
        dgvRoomManagement.Name = "dgvRoomManagement"
        dgvRoomManagement.RowHeadersWidth = 51
        dgvRoomManagement.Size = New Size(875, 250)
        dgvRoomManagement.TabIndex = 9
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(15, 15)
        btnBack.Margin = New Padding(4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(125, 44)
        btnBack.TabIndex = 11
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmRoomManagement
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(1000, 625)
        Controls.Add(btnBack)
        Controls.Add(dgvRoomManagement)
        Controls.Add(btnDeleteRoom)
        Controls.Add(btnUpdateRoom)
        Controls.Add(btnAddRoom)
        Controls.Add(txtRate)
        Controls.Add(cmbRoomType)
        Controls.Add(txtRoomNumber)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4)
        Name = "frmRoomManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Room Management"
        CType(dgvRoomManagement, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents btnUpdateRoom As Button
    Friend WithEvents btnDeleteRoom As Button
    Friend WithEvents dgvRoomManagement As DataGridView
    Friend WithEvents btnBack As Button
End Class