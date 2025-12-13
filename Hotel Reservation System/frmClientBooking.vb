Public Class frmClientBooking

    Private Sub frmClientBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me) ' Apply global styling
        LoadRoomTypes()
        dtCheckIn.MinDate = DateTime.Now
        dtCheckOut.MinDate = DateTime.Now.AddDays(1)
    End Sub

    Sub LoadRoomTypes()
        ' Get distinct room types from database
        Dim dt As DataTable = GetData("SELECT DISTINCT room_type FROM rooms")
        If dt IsNot Nothing Then
            For Each row As DataRow In dt.Rows
                cmbRoomType.Items.Add(row("room_type"))
            Next
        End If
    End Sub

    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        ' 1. Validate Inputs
        If txtName.Text = "" Or txtPhone.Text = "" Or cmbRoomType.SelectedIndex = -1 Then
            MsgBox("Please fill in Name, Phone, and Room Type.")
            Exit Sub
        End If

        ' 2. Handle Guest (Check if exists, otherwise create)
        Dim guestId As Integer = GetOrCreateGuest(txtName.Text, txtPhone.Text, txtEmail.Text)
        If guestId = -1 Then Exit Sub ' Error happened

        ' 3. Find Available Room
        Dim roomType As String = cmbRoomType.Text
        Dim roomId As Integer = GetAvailableRoomId(roomType)

        If roomId = -1 Then
            MsgBox("Sorry, no '" & roomType & "' rooms are currently available.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' 4. Calculate Price
        Dim price As Decimal = GetRoomPrice(roomId)
        Dim days As Integer = DateDiff(DateInterval.Day, dtCheckIn.Value, dtCheckOut.Value)
        If days < 1 Then days = 1
        Dim total As Decimal = price * days

        ' 5. Create Reservation
        Try
            Dim sql As String = "INSERT INTO reservations(guest_id, room_id, check_in, check_out, total_amount) " &
                                "VALUES(" & guestId & ", " & roomId & ", '" & dtCheckIn.Value.ToString("yyyy-MM-dd") & "', '" & dtCheckOut.Value.ToString("yyyy-MM-dd") & "', " & total & ")"
            ExecuteQuery(sql)

            ' Mark room as occupied
            ExecuteQuery("UPDATE rooms SET status='Occupied' WHERE id=" & roomId)

            MsgBox("Booking Successful!" & vbCrLf & "Total Cost: " & total.ToString("C"), MsgBoxStyle.Information)

            ' Return to dashboard or clear form
            Dim dash As New frmDashboard
            SlideInForm(dash)
            Me.Hide()

        Catch ex As Exception
            MsgBox("Booking failed: " & ex.Message)
        End Try
    End Sub

    ' --- Helper Functions ---

    Function GetOrCreateGuest(name As String, phone As String, email As String) As Integer
        ' Check if guest exists by Name
        Dim dt As DataTable = GetData("SELECT id FROM guests WHERE full_name='" & name & "'")
        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("id"))
        Else
            ' Create new guest
            ExecuteQuery("INSERT INTO guests(full_name, phone, email) VALUES('" & name & "', '" & phone & "', '" & email & "')")
            ' Fetch the new ID
            Dim dtNew As DataTable = GetData("SELECT id FROM guests WHERE full_name='" & name & "' ORDER BY id DESC LIMIT 1")
            If dtNew.Rows.Count > 0 Then
                Return Convert.ToInt32(dtNew.Rows(0)("id"))
            End If
        End If
        Return -1
    End Function

    Function GetAvailableRoomId(type As String) As Integer
        Dim dt As DataTable = GetData("SELECT id FROM rooms WHERE room_type='" & type & "' AND status='Available' LIMIT 1")
        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("id"))
        End If
        Return -1
    End Function

    Function GetRoomPrice(roomId As Integer) As Decimal
        Dim dt As DataTable = GetData("SELECT price FROM rooms WHERE id=" & roomId)
        If dt.Rows.Count > 0 Then
            Return Convert.ToDecimal(dt.Rows(0)("price"))
        End If
        Return 0
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dash As New frmDashboard
        dash.Show()
        Me.Hide()
    End Sub
End Class