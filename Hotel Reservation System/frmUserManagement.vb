Public Class frmUserManagement


    Dim selectedId As String = ""

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Sub LoadUsers()
        dgvUsers.DataSource = GetData("SELECT * FROM users")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter a username and password.")
            Exit Sub
        End If

        Dim sql As String = "INSERT INTO users(username, password, role) VALUES('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & cmbRole.Text & "')"
        ExecuteQuery(sql)
        MsgBox("User Added!")
        LoadUsers()
        ClearFields()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedId = "" Then Return
        Dim sql As String = "UPDATE users SET username='" & txtUsername.Text & "', password='" & txtPassword.Text & "', role='" & cmbRole.Text & "' WHERE id=" & selectedId
        ExecuteQuery(sql)
        MsgBox("User Updated!")
        LoadUsers()
        ClearFields()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedId = "" Then Return
        If MsgBox("Are you sure you want to delete this user?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExecuteQuery("DELETE FROM users WHERE id=" & selectedId)
            LoadUsers()
            ClearFields()
        End If
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            selectedId = row.Cells("id").Value.ToString()
            txtUsername.Text = row.Cells("username").Value.ToString()
            txtPassword.Text = row.Cells("password").Value.ToString()
            cmbRole.Text = row.Cells("role").Value.ToString()
        End If
    End Sub

    Sub ClearFields()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbRole.SelectedIndex = -1
        selectedId = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        dash.Show()
        Me.Hide()
    End Sub
End Class