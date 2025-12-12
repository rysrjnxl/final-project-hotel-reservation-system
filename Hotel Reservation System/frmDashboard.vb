Imports System.Drawing.Drawing2D

Public Class frmDashboard

    ' This runs automatically when the Dashboard opens
    Private Sub frmDashbaord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardStats()
    End Sub

    Private Sub LoadDashboardStats()
        Try
            ' 1. Get Count of Available Rooms
            ' We check the 'rooms' table where status is 'Available'
            Dim dtRooms As DataTable = GetData("SELECT COUNT(*) FROM rooms WHERE status='Available'")
            If dtRooms IsNot Nothing AndAlso dtRooms.Rows.Count > 0 Then
                lblAvailableRooms.Text = dtRooms.Rows(0)(0).ToString()
            Else
                lblAvailableRooms.Text = "0"
            End If

            ' 2. Get Total Count of Guests
            Dim dtGuests As DataTable = GetData("SELECT COUNT(*) FROM guests")
            If dtGuests IsNot Nothing AndAlso dtGuests.Rows.Count > 0 Then
                lblTotalGuests.Text = dtGuests.Rows(0)(0).ToString()
            Else
                lblTotalGuests.Text = "0"
            End If

            ' 3. Get Count of Staff
            Dim dtStaff As DataTable = GetData("SELECT COUNT(*) FROM staff")
            If dtStaff IsNot Nothing AndAlso dtStaff.Rows.Count > 0 Then
                lblStaffOnDuty.Text = dtStaff.Rows(0)(0).ToString()
            Else
                lblStaffOnDuty.Text = "0"
            End If

            ' 4. Get Today's Reservations
            ' We check reservations where the check_in date matches today's date (CURDATE)
            Dim dtRes As DataTable = GetData("SELECT COUNT(*) FROM reservations WHERE check_in = CURDATE()")
            If dtRes IsNot Nothing AndAlso dtRes.Rows.Count > 0 Then
                lblTodayRes.Text = dtRes.Rows(0)(0).ToString()
            Else
                lblTodayRes.Text = "0"
            End If

        Catch ex As Exception
            ' If the database connection fails, just show dashes
            lblAvailableRooms.Text = "-"
            lblTotalGuests.Text = "-"
            lblStaffOnDuty.Text = "-"
            lblTodayRes.Text = "-"
        End Try

        ' Apply the rounded corner styling to the panels
        RoundPanel(pnlAvailable)
        RoundPanel(pnlTodayRes)
        RoundPanel(pnlTotalGuests)
        RoundPanel(pnlStaff)
    End Sub

    ' --- Navigation Buttons ---

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Dim f As New frmGuestManagement
        SlideInForm(f)
        Me.Hide()
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        Dim f As New frmRoomManagement
        SlideInForm(f)
        Me.Hide()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Dim f As New frmReservation
        SlideInForm(f)
        Me.Hide()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim f As New frmStaffManagement
        SlideInForm(f)
        Me.Hide()
    End Sub

    Private Sub btnCleaning_Click(sender As Object, e As EventArgs) Handles btnCleaning.Click
        Dim f As New frmCleaningSchedule
        SlideInForm(f)
        Me.Hide()
    End Sub

    ' --- Visual Styling Function ---
    Public Sub RoundPanel(p As Panel)
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(p.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(p.Width - radius, p.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, p.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        p.Region = New Region(path)
    End Sub

End Class