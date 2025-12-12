Imports System.Drawing.Drawing2D


Public Class frmDashbaord


    Private Sub frmDashbaord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardStats()
    End Sub

    Private Sub LoadDashboardStats()
        'Temporary values until database is connected
        lblAvailableRooms.Text = "15"
        lblTotalGuests.Text = "42"
        lblStaffOnDuty.Text = "6"
        lblTodayRes.Text = "3"

        RoundPanel(pnlAvailable)
        RoundPanel(pnlTodayRes)
        RoundPanel(pnlTotalGuests)
        RoundPanel(pnlStaff)
    End Sub

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