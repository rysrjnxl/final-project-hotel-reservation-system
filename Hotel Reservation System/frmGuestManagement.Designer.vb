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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()

        txtName = New TextBox()
        txtPhone = New TextBox()
        cmbRoom = New ComboBox()
        dtCheckIn = New DateTimePicker()
        dtCheckOut = New DateTimePicker()

        btnUpdate = New Button()
        btnCheckOut = New Button()
        btnBack = New Button()

        dgvGuestStays = New DataGridView()

        CType(dgvGuestStays, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1 - Title
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 37)
        Label1.TabIndex = 0
        Label1.Text = "Guest Stay Manager"
        ' 
        ' Label2 - Name
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label2.Location = New Point(30, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 23)
        Label2.Text = "Guest:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.0F)
        txtName.Location = New Point(100, 77)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 30)
        txtName.TabIndex = 1
        ' 
        ' Label3 - Phone
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label3.Location = New Point(320, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 23)
        Label3.Text = "Phone:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 10.0F)
        txtPhone.Location = New Point(390, 77)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(180, 30)
        txtPhone.TabIndex = 2
        ' 
        ' Label4 - Room
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label4.Location = New Point(600, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 23)
        Label4.Text = "Room:"
        ' 
        ' cmbRoom
        ' 
        cmbRoom.Font = New Font("Segoe UI", 10.0F)
        cmbRoom.FormattingEnabled = True
        cmbRoom.Location = New Point(670, 77)
        cmbRoom.Name = "cmbRoom"
        cmbRoom.Size = New Size(120, 31)
        cmbRoom.TabIndex = 3
        ' 
        ' Label5 - Check In
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label5.Location = New Point(30, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 23)
        Label5.Text = "Check In:"
        ' 
        ' dtCheckIn
        ' 
        dtCheckIn.Font = New Font("Segoe UI", 10.0F)
        dtCheckIn.Format = DateTimePickerFormat.Short
        dtCheckIn.Location = New Point(120, 127)
        dtCheckIn.Name = "dtCheckIn"
        dtCheckIn.Size = New Size(150, 30)
        dtCheckIn.TabIndex = 4
        ' 
        ' Label6 - Check Out
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label6.Location = New Point(300, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 23)
        Label6.Text = "Check Out:"
        ' 
        ' dtCheckOut
        ' 
        dtCheckOut.Font = New Font("Segoe UI", 10.0F)
        dtCheckOut.Format = DateTimePickerFormat.Short
        dtCheckOut.Location = New Point(400, 127)
        dtCheckOut.Name = "dtCheckOut"
        dtCheckOut.Size = New Size(150, 30)
        dtCheckOut.TabIndex = 5
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(580, 125)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(100, 35)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnCheckOut
        ' 
        btnCheckOut.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnCheckOut.FlatStyle = FlatStyle.Flat
        btnCheckOut.FlatAppearance.BorderSize = 0
        btnCheckOut.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCheckOut.ForeColor = Color.White
        btnCheckOut.Location = New Point(690, 125)
        btnCheckOut.Name = "btnCheckOut"
        btnCheckOut.Size = New Size(100, 35)
        btnCheckOut.TabIndex = 7
        btnCheckOut.Text = "Check Out"
        btnCheckOut.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(700, 20)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(90, 35)
        btnBack.TabIndex = 8
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' dgvGuestStays
        ' 
        dgvGuestStays.BackgroundColor = Color.White
        dgvGuestStays.BorderStyle = BorderStyle.None
        dgvGuestStays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuestStays.Location = New Point(30, 180)
        dgvGuestStays.Name = "dgvGuestStays"
        dgvGuestStays.RowHeadersWidth = 51
        dgvGuestStays.Size = New Size(760, 300)
        dgvGuestStays.TabIndex = 9
        ' 
        ' frmGuestManagement
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(820, 500)
        Controls.Add(dgvGuestStays)
        Controls.Add(btnBack)
        Controls.Add(btnCheckOut)
        Controls.Add(btnUpdate)
        Controls.Add(dtCheckOut)
        Controls.Add(Label6)
        Controls.Add(dtCheckIn)
        Controls.Add(Label5)
        Controls.Add(cmbRoom)
        Controls.Add(Label4)
        Controls.Add(txtPhone)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmGuestManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Guest Management"
        CType(dgvGuestStays, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cmbRoom As ComboBox
    Friend WithEvents dtCheckIn As DateTimePicker
    Friend WithEvents dtCheckOut As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvGuestStays As DataGridView
End Class