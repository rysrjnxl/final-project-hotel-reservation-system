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
        btnHistory = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label1.Location = New Point(325, 25)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(354, 48)
        Label1.TabIndex = 0
        Label1.Text = "New Guest Booking"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label2.Location = New Point(100, 145)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 28)
        Label2.TabIndex = 1
        Label2.Text = "Full Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label3.Location = New Point(100, 208)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 28)
        Label3.TabIndex = 3
        Label3.Text = "Phone:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label4.Location = New Point(100, 270)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 28)
        Label4.TabIndex = 5
        Label4.Text = "Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label5.Location = New Point(100, 332)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 28)
        Label5.TabIndex = 7
        Label5.Text = "Room Type:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label6.Location = New Point(625, 145)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 28)
        Label6.TabIndex = 9
        Label6.Text = "Check In:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label7.Location = New Point(625, 208)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 28)
        Label7.TabIndex = 11
        Label7.Text = "Check Out:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.0F)
        txtName.Location = New Point(250, 141)
        txtName.Margin = New Padding(4)
        txtName.Name = "txtName"
        txtName.Size = New Size(312, 34)
        txtName.TabIndex = 2
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 10.0F)
        txtPhone.Location = New Point(250, 204)
        txtPhone.Margin = New Padding(4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(312, 34)
        txtPhone.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.Location = New Point(250, 266)
        txtEmail.Margin = New Padding(4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(312, 34)
        txtEmail.TabIndex = 6
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.Font = New Font("Segoe UI", 10.0F)
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Location = New Point(250, 329)
        cmbRoomType.Margin = New Padding(4)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(312, 36)
        cmbRoomType.TabIndex = 8
        ' 
        ' dtCheckIn
        ' 
        dtCheckIn.Font = New Font("Segoe UI", 10.0F)
        dtCheckIn.Location = New Point(750, 141)
        dtCheckIn.Margin = New Padding(4)
        dtCheckIn.Name = "dtCheckIn"
        dtCheckIn.Size = New Size(249, 34)
        dtCheckIn.TabIndex = 10
        ' 
        ' dtCheckOut
        ' 
        dtCheckOut.Font = New Font("Segoe UI", 10.0F)
        dtCheckOut.Location = New Point(750, 204)
        dtCheckOut.Margin = New Padding(4)
        dtCheckOut.Name = "dtCheckOut"
        dtCheckOut.Size = New Size(249, 34)
        dtCheckOut.TabIndex = 12
        ' 
        ' btnBookNow
        ' 
        btnBookNow.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnBookNow.FlatAppearance.BorderSize = 0
        btnBookNow.FlatStyle = FlatStyle.Flat
        btnBookNow.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnBookNow.ForeColor = Color.White
        btnBookNow.Location = New Point(250, 458)
        btnBookNow.Margin = New Padding(4)
        btnBookNow.Name = "btnBookNow"
        btnBookNow.Size = New Size(500, 62)
        btnBookNow.TabIndex = 13
        btnBookNow.Text = "BOOK NOW"
        btnBookNow.UseVisualStyleBackColor = False
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
        btnBack.TabIndex = 14
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        lblTotal.Location = New Point(625, 329)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(223, 38)
        lblTotal.TabIndex = 15
        lblTotal.Text = "Est. Total: ₱0.00"
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnHistory.FlatAppearance.BorderSize = 0
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHistory.ForeColor = Color.White
        btnHistory.Location = New Point(924, 15)
        btnHistory.Margin = New Padding(4)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(125, 44)
        btnHistory.TabIndex = 16
        btnHistory.Text = "History"
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' frmClientBooking
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(1062, 562)
        Controls.Add(btnHistory)
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
        Margin = New Padding(4)
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
    Friend WithEvents btnHistory As Button
End Class