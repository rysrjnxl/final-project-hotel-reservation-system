<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientBooking
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
        Label7 = New Label()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        cmbRoomType = New ComboBox()
        dtCheckIn = New DateTimePicker()
        dtCheckOut = New DateTimePicker()
        btnBookNow = New Button()
        btnBack = New Button()
        lblTotal = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label1.Location = New Point(260, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 41)
        Label1.TabIndex = 0
        Label1.Text = "New Guest Booking"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label2.Location = New Point(80, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 23)
        Label2.TabIndex = 1
        Label2.Text = "Full Name:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.0F)
        txtName.Location = New Point(200, 97)
        txtName.Name = "txtName"
        txtName.Size = New Size(250, 30)
        txtName.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label3.Location = New Point(80, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 23)
        Label3.TabIndex = 3
        Label3.Text = "Phone:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 10.0F)
        txtPhone.Location = New Point(200, 147)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(250, 30)
        txtPhone.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label4.Location = New Point(80, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 23)
        Label4.TabIndex = 5
        Label4.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.Location = New Point(200, 197)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 30)
        txtEmail.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label5.Location = New Point(80, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 23)
        Label5.TabIndex = 7
        Label5.Text = "Room Type:"
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.Font = New Font("Segoe UI", 10.0F)
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Location = New Point(200, 247)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(250, 31)
        cmbRoomType.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label6.Location = New Point(500, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 23)
        Label6.TabIndex = 9
        Label6.Text = "Check In:"
        ' 
        ' dtCheckIn
        ' 
        dtCheckIn.Font = New Font("Segoe UI", 10.0F)
        dtCheckIn.Location = New Point(600, 97)
        dtCheckIn.Name = "dtCheckIn"
        dtCheckIn.Size = New Size(200, 30)
        dtCheckIn.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label7.Location = New Point(500, 150)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 23)
        Label7.TabIndex = 11
        Label7.Text = "Check Out:"
        ' 
        ' dtCheckOut
        ' 
        dtCheckOut.Font = New Font("Segoe UI", 10.0F)
        dtCheckOut.Location = New Point(600, 147)
        dtCheckOut.Name = "dtCheckOut"
        dtCheckOut.Size = New Size(200, 30)
        dtCheckOut.TabIndex = 12
        ' 
        ' btnBookNow
        ' 
        btnBookNow.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnBookNow.FlatStyle = FlatStyle.Flat
        btnBookNow.FlatAppearance.BorderSize = 0
        btnBookNow.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnBookNow.ForeColor = Color.White
        btnBookNow.Location = New Point(200, 350)
        btnBookNow.Name = "btnBookNow"
        btnBookNow.Size = New Size(400, 50)
        btnBookNow.TabIndex = 13
        btnBookNow.Text = "BOOK NOW"
        btnBookNow.UseVisualStyleBackColor = False
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
        btnBack.TabIndex = 14
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        lblTotal.Location = New Point(500, 247)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(183, 32)
        lblTotal.TabIndex = 15
        lblTotal.Text = "Est. Total: $0.00"
        ' 
        ' frmClientBooking
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(850, 450)
        Controls.Add(lblTotal)
        Controls.Add(btnBack)
        Controls.Add(btnBookNow)
        Controls.Add(dtCheckOut)
        Controls.Add(dtCheckIn)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(cmbRoomType)
        Controls.Add(Label5)
        Controls.Add(txtEmail)
        Controls.Add(Label4)
        Controls.Add(txtPhone)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmClientBooking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Client Booking"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents dtCheckIn As DateTimePicker
    Friend WithEvents dtCheckOut As DateTimePicker
    Friend WithEvents btnBookNow As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTotal As Label
End Class