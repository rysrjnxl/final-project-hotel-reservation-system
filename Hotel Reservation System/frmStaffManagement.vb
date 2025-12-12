Public Class frmStaffManagement
    Dim selectedId As String = ""

    Private Sub frmStaffManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaff()
        cmbPosition.Items.AddRange(New Object() {"Manager", "Receptionist", "Cleaner", "Security"})
    End Sub

    Sub LoadStaff()
        DataGridView1.DataSource = GetData("SELECT * FROM staff")
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            selectedId = row.Cells("id").Value.ToString()
            txtStaffName.Text = row.Cells("full_name").Value.ToString()
            cmbPosition.Text = row.Cells("position").Value.ToString()
            txtStaffPhone.Text = row.Cells("phone").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        dash.Show() ' Dashboard doesn't use SlideIn in your original code, adjusted here
        Me.Hide()
    End Sub
End Class