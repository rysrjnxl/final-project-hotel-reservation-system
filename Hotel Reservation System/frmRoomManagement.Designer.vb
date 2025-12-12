<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomManagement
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
        Label1.Location = New Point(61, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 20)
        Label1.TabIndex = 0
        Label1.Text = "Room Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 1
        Label2.Text = "Room Type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 2
        Label3.Text = "Rate per Night:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Location = New Point(177, 86)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(151, 27)
        txtRoomNumber.TabIndex = 3
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Location = New Point(177, 122)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(151, 28)
        cmbRoomType.TabIndex = 4
        ' 
        ' txtRate
        ' 
        txtRate.Location = New Point(177, 162)
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(151, 27)
        txtRate.TabIndex = 5
        ' 
        ' btnAddRoom
        ' 
        btnAddRoom.Location = New Point(61, 244)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.Size = New Size(94, 29)
        btnAddRoom.TabIndex = 6
        btnAddRoom.Text = "Add"
        btnAddRoom.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateRoom
        ' 
        btnUpdateRoom.Location = New Point(161, 244)
        btnUpdateRoom.Name = "btnUpdateRoom"
        btnUpdateRoom.Size = New Size(94, 29)
        btnUpdateRoom.TabIndex = 7
        btnUpdateRoom.Text = "Update"
        btnUpdateRoom.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteRoom
        ' 
        btnDeleteRoom.Location = New Point(261, 244)
        btnDeleteRoom.Name = "btnDeleteRoom"
        btnDeleteRoom.Size = New Size(94, 29)
        btnDeleteRoom.TabIndex = 8
        btnDeleteRoom.Text = "Delete"
        btnDeleteRoom.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 291)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(776, 147)
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
        ' frmRoomManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
