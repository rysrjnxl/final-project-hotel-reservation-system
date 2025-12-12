<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(391, 36)
        Label1.TabIndex = 0
        Label1.Text = "Hotel Management System"
        ' 
        ' pnlAvailable
        ' 
        pnlAvailable.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        pnlAvailable.Controls.Add(Label3)
        pnlAvailable.Controls.Add(lblAvailableRooms)
        pnlAvailable.Location = New Point(435, 41)
        pnlAvailable.Name = "pnlAvailable"
        pnlAvailable.Size = New Size(261, 91)
        pnlAvailable.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(19, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 23)
        Label3.TabIndex = 1
        Label3.Text = "Available Rooms"
        ' 
        ' lblAvailableRooms
        ' 
        lblAvailableRooms.AutoSize = True
        lblAvailableRooms.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableRooms.ForeColor = SystemColors.Control
        lblAvailableRooms.Location = New Point(19, 37)
        lblAvailableRooms.Name = "lblAvailableRooms"
        lblAvailableRooms.Size = New Size(43, 50)
        lblAvailableRooms.TabIndex = 0
        lblAvailableRooms.Text = "0"
        ' 
        ' pnlStaff
        ' 
        pnlStaff.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        pnlStaff.Controls.Add(Label2)
        pnlStaff.Controls.Add(lblStaffOnDuty)
        pnlStaff.Location = New Point(435, 344)
        pnlStaff.Name = "pnlStaff"
        pnlStaff.Size = New Size(261, 88)
        pnlStaff.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(17, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 23)
        Label2.TabIndex = 1
        Label2.Text = "Staff On Duty"
        ' 
        ' lblStaffOnDuty
        ' 
        lblStaffOnDuty.AutoSize = True
        lblStaffOnDuty.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStaffOnDuty.ForeColor = SystemColors.Control
        lblStaffOnDuty.Location = New Point(17, 30)
        lblStaffOnDuty.Name = "lblStaffOnDuty"
        lblStaffOnDuty.Size = New Size(43, 50)
        lblStaffOnDuty.TabIndex = 0
        lblStaffOnDuty.Text = "0"
        ' 
        ' pnlTotalGuests
        ' 
        pnlTotalGuests.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        pnlTotalGuests.Controls.Add(Label5)
        pnlTotalGuests.Controls.Add(lblTotalGuests)
        pnlTotalGuests.Location = New Point(435, 240)
        pnlTotalGuests.Name = "pnlTotalGuests"
        pnlTotalGuests.Size = New Size(261, 88)
        pnlTotalGuests.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(18, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 23)
        Label5.TabIndex = 1
        Label5.Text = "Total Guests"
        ' 
        ' lblTotalGuests
        ' 
        lblTotalGuests.AutoSize = True
        lblTotalGuests.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalGuests.ForeColor = SystemColors.Control
        lblTotalGuests.Location = New Point(19, 36)
        lblTotalGuests.Name = "lblTotalGuests"
        lblTotalGuests.Size = New Size(43, 50)
        lblTotalGuests.TabIndex = 0
        lblTotalGuests.Text = "0"
        ' 
        ' pnlTodayRes
        ' 
        pnlTodayRes.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        pnlTodayRes.Controls.Add(label)
        pnlTodayRes.Controls.Add(lblTodayRes)
        pnlTodayRes.Location = New Point(435, 149)
        pnlTodayRes.Name = "pnlTodayRes"
        pnlTodayRes.Size = New Size(261, 75)
        pnlTodayRes.TabIndex = 9
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label.ForeColor = Color.White
        label.Location = New Point(18, 6)
        label.Name = "label"
        label.Size = New Size(165, 23)
        label.TabIndex = 1
        label.Text = "Today's Reservations"
        ' 
        ' lblTodayRes
        ' 
        lblTodayRes.AutoSize = True
        lblTodayRes.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTodayRes.ForeColor = SystemColors.Control
        lblTodayRes.Location = New Point(19, 25)
        lblTodayRes.Name = "lblTodayRes"
        lblTodayRes.Size = New Size(43, 50)
        lblTodayRes.TabIndex = 0
        lblTodayRes.Text = "0"
        ' 
        ' btnGuest
        ' 
        btnGuest.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btnGuest.Location = New Point(12, 124)
        btnGuest.Name = "btnGuest"
        btnGuest.Size = New Size(231, 35)
        btnGuest.TabIndex = 1
        btnGuest.Text = "Guest Management"
        btnGuest.UseVisualStyleBackColor = True
        ' 
        ' btnRoom
        ' 
        btnRoom.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btnRoom.Location = New Point(12, 83)
        btnRoom.Name = "btnRoom"
        btnRoom.Size = New Size(231, 35)
        btnRoom.TabIndex = 3
        btnRoom.Text = "Room Management"
        btnRoom.UseVisualStyleBackColor = True
        ' 
        ' btnReservation
        ' 
        btnReservation.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btnReservation.Location = New Point(12, 48)
        btnReservation.Name = "btnReservation"
        btnReservation.Size = New Size(231, 29)
        btnReservation.TabIndex = 2
        btnReservation.Text = "Reservation"
        btnReservation.UseVisualStyleBackColor = True
        ' 
        ' btnStaff
        ' 
        btnStaff.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btnStaff.Location = New Point(12, 165)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(231, 35)
        btnStaff.TabIndex = 4
        btnStaff.Text = "Staff Management"
        btnStaff.UseVisualStyleBackColor = True
        ' 
        ' btnCleaning
        ' 
        btnCleaning.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btnCleaning.Location = New Point(12, 206)
        btnCleaning.Name = "btnCleaning"
        btnCleaning.Size = New Size(231, 35)
        btnCleaning.TabIndex = 5
        btnCleaning.Text = "Cleaning Schedule"
        btnCleaning.UseVisualStyleBackColor = True
        ' 
        ' frmDashbaord
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
        MaximizeBox = False
        Name = "frmDashbaord"
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
