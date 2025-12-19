Public Class frmGuestAccounts
    Dim selectedGuestId As String = ""

    Private Sub frmGuestAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me)
        LoadGuests()
    End Sub

    Sub LoadGuests()
        Dim sql As String = "SELECT id, full_name, username, password, email, phone FROM guests"
        Dim dt As DataTable = GetData(sql)
        dgvGuests.DataSource = dt

        If dgvGuests.Columns.Contains("id") Then
            dgvGuests.Columns("id").Visible = False
        End If
    End Sub

    Private Sub dgvGuests_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuests.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvGuests.Rows(e.RowIndex)

            selectedGuestId = row.Cells("id").Value.ToString()
            txtName.Text = row.Cells("full_name").Value.ToString()
            txtUsername.Text = row.Cells("username").Value.ToString()
            txtPassword.Text = row.Cells("password").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedGuestId = "" Then
            MsgBox("Please select a guest first.", MsgBoxStyle.Exclamation)
            Return
        End If

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username and Password cannot be empty.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim checkSql As String = "SELECT id FROM guests WHERE username='" & txtUsername.Text & "' AND id <> " & selectedGuestId
            Dim dtCheck As DataTable = GetData(checkSql)
            If dtCheck.Rows.Count > 0 Then
                MsgBox("This username is already taken by another guest.", MsgBoxStyle.Exclamation)
                Return
            End If

            Dim sql As String = "UPDATE guests SET username='" & txtUsername.Text & "', password='" & txtPassword.Text & "' WHERE id=" & selectedGuestId
            ExecuteQuery(sql)

            MsgBox("Guest Account Updated Successfully!", MsgBoxStyle.Information)
            LoadGuests()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error updating account: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedGuestId = "" Then
            MsgBox("Please select a guest to delete.")
            Return
        End If

        If MsgBox("Are you sure you want to delete " & txtName.Text & "? This will remove their history.", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
            Try
                ExecuteQuery("DELETE FROM reservations WHERE guest_id=" & selectedGuestId)

                ExecuteQuery("DELETE FROM guests WHERE id=" & selectedGuestId)

                MsgBox("Guest Deleted Successfully.")
                LoadGuests()
                ClearFields()
            Catch ex As Exception
                MsgBox("Error deleting guest: " & ex.Message)
            End Try
        End If
    End Sub

    Sub ClearFields()
        selectedGuestId = ""
        txtName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        dash.Show()
        Me.Hide()
    End Sub
End Class