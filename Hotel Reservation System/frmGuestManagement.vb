Public Class frmGuestManagement
    Dim selectedId As String = ""

    Private Sub frmGuestManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGuests()
    End Sub

    Sub LoadGuests()
        dgvGuest.DataSource = GetData("SELECT * FROM guests")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or txtPhone.Text = "" Then
            MsgBox("Please fill in required fields.")
            Exit Sub
        End If
        Dim sql As String = "INSERT INTO guests(full_name, email, phone) VALUES('" & txtName.Text & "', '" & txtEmail.Text & "', '" & txtPhone.Text & "')"
        ExecuteQuery(sql)
        MsgBox("Guest Added!")
        LoadGuests()
        ClearFields()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedId = "" Then Return
        Dim sql As String = "UPDATE guests SET full_name='" & txtName.Text & "', email='" & txtEmail.Text & "', phone='" & txtPhone.Text & "' WHERE id=" & selectedId
        ExecuteQuery(sql)
        MsgBox("Guest Updated!")
        LoadGuests()
        ClearFields()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedId = "" Then Return
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExecuteQuery("DELETE FROM guests WHERE id=" & selectedId)
            LoadGuests()
            ClearFields()
        End If
    End Sub

    Private Sub dgvGuest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvGuest.Rows(e.RowIndex)
            selectedId = row.Cells("id").Value.ToString()
            txtName.Text = row.Cells("full_name").Value.ToString()
            txtEmail.Text = row.Cells("email").Value.ToString()
            txtPhone.Text = row.Cells("phone").Value.ToString()
        End If
    End Sub

    Sub ClearFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        selectedId = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        SlideInForm(dash)
        Me.Hide()
    End Sub
End Class