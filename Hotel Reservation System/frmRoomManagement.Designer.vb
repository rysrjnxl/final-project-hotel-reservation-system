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
        Label1.Size = New Size(90, 23)
        Label1.TabIndex = 0
        Label1.Text = "Room No:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(50, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 23)
        Label2.TabIndex = 1
        Label2.Text = "Type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(50, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 23)
        Label3.TabIndex = 2
        Label3.Text = "Rate:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Font = New Font("Segoe UI", 10.0F)
        txtRoomNumber.Location = New Point(150, 67)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(230, 30)
        txtRoomNumber.TabIndex = 3
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.Font = New Font("Segoe UI", 10.0F)
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Location = New Point(150, 112)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(230, 31)
        cmbRoomType.TabIndex = 4
        ' 
        ' txtRate
        ' 
        txtRate.Font = New Font("Segoe UI", 10.0F)
        txtRate.Location = New Point(150, 157)
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(230, 30)
        txtRate.TabIndex = 5
        ' 
        ' btnAddRoom
        ' 
        btnAddRoom.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnAddRoom.FlatStyle = FlatStyle.Flat
        btnAddRoom.FlatAppearance.BorderSize = 0
        btnAddRoom.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnAddRoom.ForeColor = Color.White
        btnAddRoom.Location = New Point(50, 220)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.Size = New Size(100, 40)
        btnAddRoom.TabIndex = 6
        btnAddRoom.Text = "Add"
        btnAddRoom.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateRoom
        ' 
        btnUpdateRoom.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdateRoom.FlatStyle = FlatStyle.Flat
        btnUpdateRoom.FlatAppearance.BorderSize = 0
        btnUpdateRoom.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdateRoom.ForeColor = Color.White
        btnUpdateRoom.Location = New Point(160, 220)
        btnUpdateRoom.Name = "btnUpdateRoom"
        btnUpdateRoom.Size = New Size(100, 40)
        btnUpdateRoom.TabIndex = 7
        btnUpdateRoom.Text = "Update"
        btnUpdateRoom.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRoom
        ' 
        btnDeleteRoom.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDeleteRoom.FlatStyle = FlatStyle.Flat
        btnDeleteRoom.FlatAppearance.BorderSize = 0
        btnDeleteRoom.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDeleteRoom.ForeColor = Color.White
        btnDeleteRoom.Location = New Point(270, 220)
        btnDeleteRoom.Name = "btnDeleteRoom"
        btnDeleteRoom.Size = New Size(100, 40)
        btnDeleteRoom.TabIndex = 8
        btnDeleteRoom.Text = "Delete"
        btnDeleteRoom.UseVisualStyleBackColor = False
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
        ' frmRoomManagement
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(800, 500)
        Controls.Add(btnBack)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteRoom)
        Controls.Add(btnUpdateRoom)
        Controls.Add(btnAddRoom)
        Controls.Add(txtRate)
        Controls.Add(cmbRoomType)
        Controls.Add(txtRoomNumber)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmRoomManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Room Management"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
End Class