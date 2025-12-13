<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        pnlAvailable = New Panel()
        Label3 = New Label()
        lblAvailableRooms = New Label()
        pnlStaff = New Panel()
        Label2 = New Label()
        lblStaffOnDuty = New Label()
        pnlTotalGuests = New Panel()
        Label5 = New Label()
        lblTotalGuests = New Label()
        pnlTodayRes = New Panel()
        label = New Label()
        lblTodayRes = New Label()
        btnGuest = New Button()
        btnRoom = New Button()
        btnReservation = New Button()
        btnStaff = New Button()
        btnCleaning = New Button()
        pnlAvailable.SuspendLayout()
        pnlStaff.SuspendLayout()
        pnlTotalGuests.SuspendLayout()
        pnlTodayRes.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label1.Location = New Point(338, 25)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(642, 65)
        Label1.TabIndex = 0
        Label1.Text = "Hotel Management System"
        ' 
        ' pnlAvailable
        ' 
        pnlAvailable.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        pnlAvailable.Controls.Add(Label3)
        pnlAvailable.Controls.Add(lblAvailableRooms)
        pnlAvailable.Location = New Point(350, 125)
        pnlAvailable.Margin = New Padding(4, 4, 4, 4)
        pnlAvailable.Name = "pnlAvailable"
        pnlAvailable.Size = New Size(300, 150)
        pnlAvailable.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(19, 19)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(189, 32)
        Label3.TabIndex = 1
        Label3.Text = "Available Rooms"
        ' 
        ' lblAvailableRooms
        ' 
        lblAvailableRooms.AutoSize = True
        lblAvailableRooms.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableRooms.ForeColor = Color.White
        lblAvailableRooms.Location = New Point(12, 50)
        lblAvailableRooms.Margin = New Padding(4, 0, 4, 0)
        lblAvailableRooms.Name = "lblAvailableRooms"
        lblAvailableRooms.Size = New Size(81, 96)
        lblAvailableRooms.TabIndex = 0
        lblAvailableRooms.Text = "0"
        ' 
        ' pnlStaff
        ' 
        pnlStaff.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        pnlStaff.Controls.Add(Label2)
        pnlStaff.Controls.Add(lblStaffOnDuty)
        pnlStaff.Location = New Point(675, 300)
        pnlStaff.Margin = New Padding(4, 4, 4, 4)
        pnlStaff.Name = "pnlStaff"
        pnlStaff.Size = New Size(300, 150)
        pnlStaff.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(19, 19)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 32)
        Label2.TabIndex = 1
        Label2.Text = "Staff On Duty"
        ' 
        ' lblStaffOnDuty
        ' 
        lblStaffOnDuty.AutoSize = True
        lblStaffOnDuty.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStaffOnDuty.ForeColor = Color.White
        lblStaffOnDuty.Location = New Point(12, 50)
        lblStaffOnDuty.Margin = New Padding(4, 0, 4, 0)
        lblStaffOnDuty.Name = "lblStaffOnDuty"
        lblStaffOnDuty.Size = New Size(81, 96)
        lblStaffOnDuty.TabIndex = 0
        lblStaffOnDuty.Text = "0"
        ' 
        ' pnlTotalGuests
        ' 
        pnlTotalGuests.BackColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        pnlTotalGuests.Controls.Add(Label5)
        pnlTotalGuests.Controls.Add(lblTotalGuests)
        pnlTotalGuests.Location = New Point(350, 300)
        pnlTotalGuests.Margin = New Padding(4, 4, 4, 4)
        pnlTotalGuests.Name = "pnlTotalGuests"
        pnlTotalGuests.Size = New Size(300, 150)
        pnlTotalGuests.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(19, 19)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 32)
        Label5.TabIndex = 1
        Label5.Text = "Total Guests"
        ' 
        ' lblTotalGuests
        ' 
        lblTotalGuests.AutoSize = True
        lblTotalGuests.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalGuests.ForeColor = Color.White
        lblTotalGuests.Location = New Point(12, 50)
        lblTotalGuests.Margin = New Padding(4, 0, 4, 0)
        lblTotalGuests.Name = "lblTotalGuests"
        lblTotalGuests.Size = New Size(81, 96)
        lblTotalGuests.TabIndex = 0
        lblTotalGuests.Text = "0"
        ' 
        ' pnlTodayRes
        ' 
        pnlTodayRes.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        pnlTodayRes.Controls.Add(label)
        pnlTodayRes.Controls.Add(lblTodayRes)
        pnlTodayRes.Location = New Point(675, 125)
        pnlTodayRes.Margin = New Padding(4, 4, 4, 4)
        pnlTodayRes.Name = "pnlTodayRes"
        pnlTodayRes.Size = New Size(300, 150)
        pnlTodayRes.TabIndex = 9
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label.ForeColor = Color.White
        label.Location = New Point(19, 19)
        label.Margin = New Padding(4, 0, 4, 0)
        label.Name = "label"
        label.Size = New Size(233, 32)
        label.TabIndex = 1
        label.Text = "Today's Reservations"
        ' 
        ' lblTodayRes
        ' 
        lblTodayRes.AutoSize = True
        lblTodayRes.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTodayRes.ForeColor = Color.White
        lblTodayRes.Location = New Point(12, 50)
        lblTodayRes.Margin = New Padding(4, 0, 4, 0)
        lblTodayRes.Name = "lblTodayRes"
        lblTodayRes.Size = New Size(81, 96)
        lblTodayRes.TabIndex = 0
        lblTodayRes.Text = "0"
        ' 
        ' btnGuest
        ' 
        btnGuest.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnGuest.FlatAppearance.BorderSize = 0
        btnGuest.FlatStyle = FlatStyle.Flat
        btnGuest.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGuest.ForeColor = Color.White
        btnGuest.Location = New Point(0, 171)
        btnGuest.Margin = New Padding(4, 4, 4, 4)
        btnGuest.Name = "btnGuest"
        btnGuest.Padding = New Padding(25, 0, 0, 0)
        btnGuest.Size = New Size(312, 75)
        btnGuest.TabIndex = 1
        btnGuest.Text = "Guest Management"
        btnGuest.TextAlign = ContentAlignment.MiddleLeft
        btnGuest.UseVisualStyleBackColor = False
        ' 
        ' btnRoom
        ' 
        btnRoom.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnRoom.FlatAppearance.BorderSize = 0
        btnRoom.FlatStyle = FlatStyle.Flat
        btnRoom.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRoom.ForeColor = Color.White
        btnRoom.Location = New Point(0, 239)
        btnRoom.Margin = New Padding(4, 4, 4, 4)
        btnRoom.Name = "btnRoom"
        btnRoom.Padding = New Padding(25, 0, 0, 0)
        btnRoom.Size = New Size(312, 75)
        btnRoom.TabIndex = 3
        btnRoom.Text = "Room Management"
        btnRoom.TextAlign = ContentAlignment.MiddleLeft
        btnRoom.UseVisualStyleBackColor = False
        ' 
        ' btnReservation
        ' 
        btnReservation.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnReservation.FlatAppearance.BorderSize = 0
        btnReservation.FlatStyle = FlatStyle.Flat
        btnReservation.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReservation.ForeColor = Color.White
        btnReservation.Location = New Point(0, 101)
        btnReservation.Margin = New Padding(4, 4, 4, 4)
        btnReservation.Name = "btnReservation"
        btnReservation.Padding = New Padding(25, 0, 0, 0)
        btnReservation.Size = New Size(312, 75)
        btnReservation.TabIndex = 2
        btnReservation.Text = "Reservation"
        btnReservation.TextAlign = ContentAlignment.MiddleLeft
        btnReservation.UseVisualStyleBackColor = False
        ' 
        ' btnStaff
        ' 
        btnStaff.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnStaff.FlatAppearance.BorderSize = 0
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStaff.ForeColor = Color.White
        btnStaff.Location = New Point(0, 312)
        btnStaff.Margin = New Padding(4, 4, 4, 4)
        btnStaff.Name = "btnStaff"
        btnStaff.Padding = New Padding(25, 0, 0, 0)
        btnStaff.Size = New Size(312, 75)
        btnStaff.TabIndex = 4
        btnStaff.Text = "Staff Management"
        btnStaff.TextAlign = ContentAlignment.MiddleLeft
        btnStaff.UseVisualStyleBackColor = False
        ' 
        ' btnCleaning
        ' 
        btnCleaning.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnCleaning.FlatAppearance.BorderSize = 0
        btnCleaning.FlatStyle = FlatStyle.Flat
        btnCleaning.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCleaning.ForeColor = Color.White
        btnCleaning.Location = New Point(0, 380)
        btnCleaning.Margin = New Padding(4, 4, 4, 4)
        btnCleaning.Name = "btnCleaning"
        btnCleaning.Padding = New Padding(25, 0, 0, 0)
        btnCleaning.Size = New Size(312, 75)
        btnCleaning.TabIndex = 5
        btnCleaning.Text = "Cleaning Schedule"
        btnCleaning.TextAlign = ContentAlignment.MiddleLeft
        btnCleaning.UseVisualStyleBackColor = False
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(1000, 562)
        Controls.Add(btnCleaning)
        Controls.Add(pnlTodayRes)
        Controls.Add(btnStaff)
        Controls.Add(pnlTotalGuests)
        Controls.Add(btnReservation)
        Controls.Add(btnRoom)
        Controls.Add(pnlStaff)
        Controls.Add(btnGuest)
        Controls.Add(pnlAvailable)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 4, 4, 4)
        MaximizeBox = False
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hotel Dashboard"
        pnlAvailable.ResumeLayout(False)
        pnlAvailable.PerformLayout()
        pnlStaff.ResumeLayout(False)
        pnlStaff.PerformLayout()
        pnlTotalGuests.ResumeLayout(False)
        pnlTotalGuests.PerformLayout()
        pnlTodayRes.ResumeLayout(False)
        pnlTodayRes.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlAvailable As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAvailableRooms As Label
    Friend WithEvents pnlStaff As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStaffOnDuty As Label
    Friend WithEvents pnlTotalGuests As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalGuests As Label
    Friend WithEvents pnlTodayRes As Panel
    Friend WithEvents label As Label
    Friend WithEvents lblTodayRes As Label
    Friend WithEvents btnGuest As Button
    Friend WithEvents btnRoom As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnCleaning As Button
End Class