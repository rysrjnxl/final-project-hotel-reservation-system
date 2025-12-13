Public Class frmStaffManagement
    Dim selectedId As String = ""

    Private Sub frmStaffManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStaff.ReadOnly = True
        dgvStaff.AllowUserToAddRows = False
        dgvStaff.RowHeadersVisible = False
        dgvStaff.AllowUserToResizeColumns = False
        dgvStaff.AllowUserToResizeRows = False
        LoadStaff()
        cmbPosition.Items.AddRange(New Object() {"Manager", "Receptionist", "Cleaner", "Security"})
    End Sub

    Sub LoadStaff()
        dgvStaff.DataSource = GetData("SELECT * FROM staff")
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        Dim sql As String = "INSERT INTO staff(full_name, position, phone) VALUES('" & txtStaffName.Text & "', '" & cmbPosition.Text & "', '" & txtStaffPhone.Text & "')"
        ExecuteQuery(sql)
        LoadStaff()
    End Sub

    Private Sub btnDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        If selectedId = "" Then Return
        ExecuteQuery("DELETE FROM staff WHERE id=" & selectedId)
        LoadStaff()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStaff.Rows(e.RowIndex)
            selectedId = row.Cells("id").Value.ToString()
            txtStaffName.Text = row.Cells("full_name").Value.ToString()
            cmbPosition.Text = row.Cells("position").Value.ToString()
            txtStaffPhone.Text = row.Cells("phone").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        dash.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdateStaff_Click(sender As Object, e As EventArgs) Handles btnUpdateStaff.Click
        If selectedId = "" Then
            MsgBox("Please select a staff member to update.")
            Return
        End If

        If txtStaffName.Text = "" Or cmbPosition.Text = "" Then
            MsgBox("Please fill in Name and Position.")
            Return
        End If

        Try
            Dim sql As String = "UPDATE staff SET full_name='" & txtStaffName.Text &
                                "', position='" & cmbPosition.Text &
                                "', phone='" & txtStaffPhone.Text &
                                "' WHERE id=" & selectedId
            ExecuteQuery(sql)

            MsgBox("Staff Member Updated Successfully!")
            LoadStaff()

            txtStaffName.Clear()
            txtStaffPhone.Clear()
            cmbPosition.SelectedIndex = -1
            selectedId = ""
        Catch ex As Exception
            MsgBox("Error updating staff: " & ex.Message)
        End Try
    End Sub
End Class