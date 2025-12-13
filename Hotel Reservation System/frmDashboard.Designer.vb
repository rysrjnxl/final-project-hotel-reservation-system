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
        btnLogout = New Button()
        btnUsers = New Button()
        btnCleaning = New Button()
        btnStaff = New Button()
        btnRoom = New Button()
        btnGuest = New Button()
        btnReservation = New Button()
        pnlSidebar = New Panel()
        pnlAvailable.SuspendLayout()
        pnlStaff.SuspendLayout()
        pnlTotalGuests.SuspendLayout()
        pnlTodayRes.SuspendLayout()
        pnlSidebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        Label1.Location = New Point(400, 25)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(642, 65)
        Label1.TabIndex = 0
        Label1.Text = "Hotel Management System"
        ' 
        ' pnlAvailable
        ' 
        pnlAvailable.BackColor = Color.FromArgb(CByte(193), CByte(154), CByte(107))
        pnlAvailable.Controls.Add(Label3)
        pnlAvailable.Controls.Add(lblAvailableRooms)
        pnlAvailable.Location = New Point(412, 125)
        pnlAvailable.Margin = New Padding(4)
        pnlAvailable.Name = "pnlAvailable"
        pnlAvailable.Size = New Size(300, 150)
        pnlAvailable.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F)
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
        lblAvailableRooms.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
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
        pnlStaff.BackColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        pnlStaff.Controls.Add(Label2)
        pnlStaff.Controls.Add(lblStaffOnDuty)
        pnlStaff.Location = New Point(738, 300)
        pnlStaff.Margin = New Padding(4)
        pnlStaff.Name = "pnlStaff"
        pnlStaff.Size = New Size(300, 150)
        pnlStaff.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F)
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
        lblStaffOnDuty.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
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
        pnlTotalGuests.BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        pnlTotalGuests.Controls.Add(Label5)
        pnlTotalGuests.Controls.Add(lblTotalGuests)
        pnlTotalGuests.Location = New Point(412, 300)
        pnlTotalGuests.Margin = New Padding(4)
        pnlTotalGuests.Name = "pnlTotalGuests"
        pnlTotalGuests.Size = New Size(300, 150)
        pnlTotalGuests.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F)
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
        lblTotalGuests.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
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
        pnlTodayRes.BackColor = Color.FromArgb(CByte(80), CByte(120), CByte(110))
        pnlTodayRes.Controls.Add(label)
        pnlTodayRes.Controls.Add(lblTodayRes)
        pnlTodayRes.Location = New Point(738, 125)
        pnlTodayRes.Margin = New Padding(4)
        pnlTodayRes.Name = "pnlTodayRes"
        pnlTodayRes.Size = New Size(300, 150)
        pnlTodayRes.TabIndex = 9
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Segoe UI", 12.0F)
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
        lblTodayRes.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
        lblTodayRes.ForeColor = Color.White
        lblTodayRes.Location = New Point(12, 50)
        lblTodayRes.Margin = New Padding(4, 0, 4, 0)
        lblTodayRes.Name = "lblTodayRes"
        lblTodayRes.Size = New Size(81, 96)
        lblTodayRes.TabIndex = 0
        lblTodayRes.Text = "0"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 11.0F)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(0, 613)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(25, 0, 0, 0)
        btnLogout.Size = New Size(350, 75)
        btnLogout.TabIndex = 11
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnUsers
        ' 
        btnUsers.BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Segoe UI", 11.0F)
        btnUsers.ForeColor = Color.White
        btnUsers.Location = New Point(0, 530)
        btnUsers.Margin = New Padding(4)
        btnUsers.Name = "btnUsers"
        btnUsers.Padding = New Padding(25, 0, 0, 0)
        btnUsers.Size = New Size(350, 75)
        btnUsers.TabIndex = 10
        btnUsers.Text = "User Management"
        btnUsers.TextAlign = ContentAlignment.MiddleLeft
        btnUsers.UseVisualStyleBackColor = False
        ' 
        ' btnCleaning
        ' 
        btnCleaning.BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        btnCleaning.FlatAppearance.BorderSize = 0
        btnCleaning.FlatStyle = FlatStyle.Flat
        btnCleaning.Font = New Font("Segoe UI", 11.0F)
        btnCleaning.ForeColor = Color.White
        btnCleaning.Location = New Point(-4, 101)
        btnCleaning.Margin = New Padding(4)
        btnCleaning.Name = "btnCleaning"
        btnCleaning.Padding = New Padding(25, 0, 0, 0)
        btnCleaning.Size = New Size(350, 75)
        btnCleaning.TabIndex = 5
        btnCleaning.Text = "Cleaning Schedule"
        btnCleaning.TextAlign = ContentAlignment.MiddleLeft
        btnCleaning.UseVisualStyleBackColor = False
        ' 
        ' btnStaff
        ' 
        btnStaff.BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        btnStaff.FlatAppearance.BorderSize = 0
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.Font = New Font("Segoe UI", 11.0F)
        btnStaff.ForeColor = Color.White
        btnStaff.Location = New Point(0, 319)
        btnStaff.Margin = New Padding(4)
        btnStaff.Name = "btnStaff"
        btnStaff.Padding = New Padding(25, 0, 0, 0)
        btnStaff.Size = New Size(350, 75)
        btnStaff.TabIndex = 4
        btnStaff.Text = "Staff Management"
        btnStaff.TextAlign = ContentAlignment.MiddleLeft
        btnStaff.UseVisualStyleBackColor = False
        ' 
        ' btnRoom
        ' 
        btnRoom.BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        btnRoom.FlatAppearance.BorderSize = 0
        btnRoom.FlatStyle = FlatStyle.Flat
        btnRoom.Font = New Font("Segoe UI", 11.0F)
        btnRoom.ForeColor = Color.White
        btnRoom.Location = New Point(-4, 245)
        btnRoom.Margin = New Padding(4)
        btnRoom.Name = "btnRoom"
        btnRoom.Padding = New Padding(25, 0, 0, 0)
        btnRoom.Size = New Size(350, 75)
        btnRoom.TabIndex = 3
        btnRoom.Text = "Room Management"
        btnRoom.TextAlign = ContentAlignment.MiddleLeft
        btnRoom.UseVisualStyleBackColor = False
        ' 
        ' btnGuest
        ' 
        btnGuest.BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        btnGuest.FlatAppearance.BorderSize = 0
        btnGuest.FlatStyle = FlatStyle.Flat
        btnGuest.Font = New Font("Segoe UI", 11.0F)
        btnGuest.ForeColor = Color.White
        btnGuest.Location = New Point(-4, 171)
        btnGuest.Margin = New Padding(4)
        btnGuest.Name = "btnGuest"
        btnGuest.Padding = New Padding(25, 0, 0, 0)
        btnGuest.Size = New Size(350, 75)
        btnGuest.TabIndex = 1
        btnGuest.Text = "Guest Management"
        btnGuest.TextAlign = ContentAlignment.MiddleLeft
        btnGuest.UseVisualStyleBackColor = False
        ' 
        ' btnReservation
        ' 
        btnReservation.BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        btnReservation.FlatAppearance.BorderSize = 0
        btnReservation.FlatStyle = FlatStyle.Flat
        btnReservation.Font = New Font("Segoe UI", 11.0F)
        btnReservation.ForeColor = Color.White
        btnReservation.Location = New Point(-4, 31)
        btnReservation.Margin = New Padding(4)
        btnReservation.Name = "btnReservation"
        btnReservation.Padding = New Padding(25, 0, 0, 0)
        btnReservation.Size = New Size(350, 75)
        btnReservation.TabIndex = 2
        btnReservation.Text = "Reservation"
        btnReservation.TextAlign = ContentAlignment.MiddleLeft
        btnReservation.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(12), CByte(52), CByte(51))
        pnlSidebar.Controls.Add(btnReservation)
        pnlSidebar.Controls.Add(btnGuest)
        pnlSidebar.Controls.Add(btnRoom)
        pnlSidebar.Controls.Add(btnStaff)
        pnlSidebar.Controls.Add(btnCleaning)
        pnlSidebar.Controls.Add(btnUsers)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(350, 688)
        pnlSidebar.TabIndex = 10
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1125, 688)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlTodayRes)
        Controls.Add(pnlTotalGuests)
        Controls.Add(pnlStaff)
        Controls.Add(pnlAvailable)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4)
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
        pnlSidebar.ResumeLayout(False)
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
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnCleaning As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnRoom As Button
    Friend WithEvents btnGuest As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents pnlSidebar As Panel
End Class