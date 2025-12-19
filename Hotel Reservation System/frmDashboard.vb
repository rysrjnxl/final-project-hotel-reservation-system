Imports System.Drawing.Drawing2D

Public Class frmDashboard
    Private Sub frmDashbaord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardStats()
    End Sub

    Private Sub LoadDashboardStats()
        Try
            Dim dtRooms As DataTable = GetData("SELECT COUNT(*) FROM rooms WHERE status='Available'")
            If dtRooms IsNot Nothing AndAlso dtRooms.Rows.Count > 0 Then
                lblAvailableRooms.Text = dtRooms.Rows(0)(0).ToString()
            Else
                lblAvailableRooms.Text = "0"
            End If

            Dim dtGuests As DataTable = GetData("SELECT COUNT(*) FROM guests")
            If dtGuests IsNot Nothing AndAlso dtGuests.Rows.Count > 0 Then
                lblTotalGuests.Text = dtGuests.Rows(0)(0).ToString()
            Else
                lblTotalGuests.Text = "0"
            End If

            Dim dtStaff As DataTable = GetData("SELECT COUNT(*) FROM staff")
            If dtStaff IsNot Nothing AndAlso dtStaff.Rows.Count > 0 Then
                lblStaffOnDuty.Text = dtStaff.Rows(0)(0).ToString()
            Else
                lblStaffOnDuty.Text = "0"
            End If

            Dim dtRes As DataTable = GetData("SELECT COUNT(*) FROM reservations WHERE check_in = CURDATE()")
            If dtRes IsNot Nothing AndAlso dtRes.Rows.Count > 0 Then
                lblTodayRes.Text = dtRes.Rows(0)(0).ToString()
            Else
                lblTodayRes.Text = "0"
            End If

        Catch ex As Exception

            lblAvailableRooms.Text = "-"
            lblTotalGuests.Text = "-"
            lblStaffOnDuty.Text = "-"
            lblTodayRes.Text = "-"
        End Try


        RoundPanel(pnlAvailable)
        RoundPanel(pnlTodayRes)
        RoundPanel(pnlTotalGuests)
        RoundPanel(pnlStaff)
    End Sub


    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Dim f As New frmGuestManagement
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        Dim f As New frmRoomManagement
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Dim f As New frmReservation
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim f As New frmStaffManagement
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnCleaning_Click(sender As Object, e As EventArgs) Handles btnCleaning.Click
        Dim f As New frmCleaningSchedule
        f.Show()
        Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim f As New frmUserManagement
        f.Show()
        Hide()
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GuestsAccounts.Click
        Dim accounts As New frmGuestAccounts
        accounts.Show()
        Me.Hide()
    End Sub
End Class