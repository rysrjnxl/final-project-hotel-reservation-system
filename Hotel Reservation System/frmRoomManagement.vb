Imports System.Drawing.Drawing2D

Public Class frmRoomManagement
    Dim selectedId As String = ""

    Private Sub frmRoomManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRoomManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRoomManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRoomManagement.ReadOnly = True
        dgvRoomManagement.AllowUserToAddRows = False
        dgvRoomManagement.RowHeadersVisible = False
        dgvRoomManagement.AllowUserToResizeColumns = False
        dgvRoomManagement.AllowUserToResizeRows = False
        LoadRooms()
        ' Populate Room Types
        cmbRoomType.Items.Add("Single")
        cmbRoomType.Items.Add("Double")
        cmbRoomType.Items.Add("Suite")
    End Sub

    Sub LoadRooms()
        dgvRoomManagement.DataSource = GetData("SELECT * FROM rooms")
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        Dim sql As String = "INSERT INTO rooms(room_number, room_type, price, status) VALUES('" & txtRoomNumber.Text & "', '" & cmbRoomType.Text & "', '" & txtRate.Text & "', 'Available')"
        ExecuteQuery(sql)
        LoadRooms()
    End Sub

    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click
        If selectedId = "" Then Return
        Dim sql As String = "UPDATE rooms SET room_number='" & txtRoomNumber.Text & "', room_type='" & cmbRoomType.Text & "', price='" & txtRate.Text & "' WHERE id=" & selectedId
        ExecuteQuery(sql)
        LoadRooms()
    End Sub

    Private Sub btnDeleteRoom_Click(sender As Object, e As EventArgs) Handles btnDeleteRoom.Click
        If selectedId = "" Then Return
        ExecuteQuery("DELETE FROM rooms WHERE id=" & selectedId)
        LoadRooms()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoomManagement.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRoomManagement.Rows(e.RowIndex)
            selectedId = row.Cells("id").Value.ToString()
            txtRoomNumber.Text = row.Cells("room_number").Value.ToString()
            cmbRoomType.Text = row.Cells("room_type").Value.ToString()
            txtRate.Text = row.Cells("price").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        dash.Show()
        Me.Hide()
    End Sub
End Class