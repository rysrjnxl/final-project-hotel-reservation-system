Public Class frmCleaningSchedule
    Dim selectedId As String = ""

    Private Sub frmCleaningSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombos()
        LoadSchedule()
    End Sub

    ' 1. Load Dropdowns (Rooms and Staff)
    Sub LoadCombos()
        ' Fill Room ComboBox
        Dim dtRooms As DataTable = GetData("SELECT id, room_number FROM rooms")
        cmbCleanRoom.DataSource = dtRooms
        cmbCleanRoom.DisplayMember = "room_number"
        cmbCleanRoom.ValueMember = "id"

        ' Fill Staff ComboBox
        Dim dtStaff As DataTable = GetData("SELECT id, full_name FROM staff")
        cmbCleanStaff.DataSource = dtStaff
        cmbCleanStaff.DisplayMember = "full_name"
        cmbCleanStaff.ValueMember = "id"
    End Sub

    ' 2. Load the DataGridView
    Sub LoadSchedule()
        ' We join tables so we see Names/Numbers instead of just IDs
        Dim sql As String = "SELECT ct.id, r.room_number, s.full_name, ct.status, ct.room_id, ct.staff_id " &
                            "FROM cleaning_tasks ct " &
                            "JOIN rooms r ON ct.room_id = r.id " &
                            "JOIN staff s ON ct.staff_id = s.id"

        Dim dt As DataTable = GetData(sql)
        dgvCleaning.DataSource = dt

        ' Hide the ID columns so the grid looks cleaner
        If dgvCleaning.Columns.Count > 0 Then
            dgvCleaning.Columns("id").Visible = False
            dgvCleaning.Columns("room_id").Visible = False
            dgvCleaning.Columns("staff_id").Visible = False
            dgvCleaning.Columns("room_number").HeaderText = "Room"
            dgvCleaning.Columns("full_name").HeaderText = "Staff Assigned"
        End If
    End Sub

    ' 3. Assign (Add) Button
    Private Sub btnAssignClean_Click(sender As Object, e As EventArgs) Handles btnAssignClean.Click
        If cmbCleanRoom.SelectedIndex = -1 Or cmbCleanStaff.SelectedIndex = -1 Then
            MsgBox("Please select both a Room and a Staff member.")
            Exit Sub
        End If

        Dim roomId As String = cmbCleanRoom.SelectedValue.ToString()
        Dim staffId As String = cmbCleanStaff.SelectedValue.ToString()
        Dim status As String = cmbCleanStatus.Text

        Dim sql As String = "INSERT INTO cleaning_tasks(room_id, staff_id, status) VALUES(" & roomId & ", " & staffId & ", '" & status & "')"
        ExecuteQuery(sql)

        MsgBox("Task Assigned Successfully!")
        LoadSchedule()
    End Sub

    ' 4. Update Button
    Private Sub btnUpdateClean_Click(sender As Object, e As EventArgs) Handles btnUpdateClean.Click
        If selectedId = "" Then
            MsgBox("Please select a task from the list to update.")
            Return
        End If

        Dim roomId As String = cmbCleanRoom.SelectedValue.ToString()
        Dim staffId As String = cmbCleanStaff.SelectedValue.ToString()
        Dim status As String = cmbCleanStatus.Text

        Dim sql As String = "UPDATE cleaning_tasks SET room_id=" & roomId & ", staff_id=" & staffId & ", status='" & status & "' WHERE id=" & selectedId
        ExecuteQuery(sql)

        MsgBox("Task Updated!")
        LoadSchedule()
        selectedId = ""
    End Sub

    ' 5. Delete Button
    Private Sub btnDeleteClean_Click(sender As Object, e As EventArgs) Handles btnDeleteClean.Click
        If selectedId = "" Then
            MsgBox("Please select a task to delete.")
            Return
        End If

        If MsgBox("Are you sure you want to remove this task?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExecuteQuery("DELETE FROM cleaning_tasks WHERE id=" & selectedId)
            LoadSchedule()
            selectedId = ""
        End If
    End Sub

    ' 6. Click Grid to fill form (for editing)
    Private Sub dgvCleaning_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCleaning.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCleaning.Rows(e.RowIndex)

            ' Store the hidden ID for updates/deletes
            selectedId = row.Cells("id").Value.ToString()

            ' Set the ComboBoxes to match the selected row
            cmbCleanRoom.SelectedValue = row.Cells("room_id").Value
            cmbCleanStaff.SelectedValue = row.Cells("staff_id").Value
            cmbCleanStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        SlideInForm(dash)
        Me.Hide()
    End Sub
End Class