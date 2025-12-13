Public Class frmClientBooking

    ' 1. Form Load: Setup UI and Auto-Fill
    Private Sub frmClientBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me) ' Apply modern styling
        LoadRoomTypes()

        ' Set Date Limits (Cannot book in the past)
        dtCheckIn.MinDate = DateTime.Now
        dtCheckOut.MinDate = DateTime.Now.AddDays(1)

        ' --- AUTO-FILL LOGIC START ---
        ' If a user is logged in (CurrentGuestID is not 0), fill their info
        If CurrentGuestID > 0 Then
            PreFillGuestInfo()
        End If
        ' --- AUTO-FILL LOGIC END ---
    End Sub

    ' 2. Function to Fetch and Fill Guest Details
    Sub PreFillGuestInfo()
        Try
            Dim sql As String = "SELECT * FROM guests WHERE id=" & CurrentGuestID
            Dim dt As DataTable = GetData(sql)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                ' Populate the TextBoxes
                txtName.Text = dt.Rows(0)("full_name").ToString()
                txtPhone.Text = dt.Rows(0)("phone").ToString()
                txtEmail.Text = dt.Rows(0)("email").ToString()

                ' Optional: Lock these fields so they can't be changed
                txtName.Enabled = False
                txtPhone.Enabled = False
                txtEmail.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error loading guest info: " & ex.Message)
        End Try
    End Sub

    ' 3. Load Room Types into Dropdown
    Sub LoadRoomTypes()
        Dim dt As DataTable = GetData("SELECT DISTINCT room_type FROM rooms")
        If dt IsNot Nothing Then
            For Each row As DataRow In dt.Rows
                cmbRoomType.Items.Add(row("room_type"))
            Next
        End If
    End Sub

    ' 4. Book Button Logic
    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        ' Validation
        If txtName.Text = "" Or txtPhone.Text = "" Or cmbRoomType.SelectedIndex = -1 Then
            MsgBox("Please fill in Name, Phone, and Room Type.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim bookingGuestID As Integer = CurrentGuestID

        ' If Walk-in (No Login), create a new account for them
        If bookingGuestID = 0 Then
            bookingGuestID = GetOrCreateGuest(txtName.Text, txtPhone.Text, txtEmail.Text)
            If bookingGuestID = -1 Then Exit Sub
        End If

        ' Check Availability
        Dim roomType As String = cmbRoomType.Text
        Dim roomId As Integer = GetAvailableRoomId(roomType)

        If roomId = -1 Then
            MsgBox("Sorry, no '" & roomType & "' rooms are currently available.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Calculate Price
        Dim price As Decimal = GetRoomPrice(roomId)
        Dim days As Integer = DateDiff(DateInterval.Day, dtCheckIn.Value, dtCheckOut.Value)
        If days < 1 Then days = 1
        Dim total As Decimal = price * days

        ' Save Reservation
        Try
            Dim sql As String = "INSERT INTO reservations(guest_id, room_id, check_in, check_out, total_amount) " &
                                "VALUES(" & bookingGuestID & ", " & roomId & ", '" & dtCheckIn.Value.ToString("yyyy-MM-dd") & "', '" & dtCheckOut.Value.ToString("yyyy-MM-dd") & "', " & total & ")"
            ExecuteQuery(sql)

            ' Mark Room Occupied
            ExecuteQuery("UPDATE rooms SET status='Occupied' WHERE id=" & roomId)

            MsgBox("Booking Successful! Total: " & total.ToString("C"), MsgBoxStyle.Information)

            ' Return to Login (Logout)
            CurrentGuestID = 0
            Dim login As New LoginForm
            login.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox("Booking Failed: " & ex.Message)
        End Try
    End Sub

    ' --- Helper Functions ---

    Function GetOrCreateGuest(name As String, phone As String, email As String) As Integer
        Dim dt As DataTable = GetData("SELECT id FROM guests WHERE full_name='" & name & "'")
        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("id"))
        Else
            ' Auto-generate credentials for walk-ins
            Dim tempUser As String = name.Replace(" ", "").ToLower() & New Random().Next(100, 999).ToString()
            Dim defaultPass As String = "12345"
            Try
                Dim sql As String = "INSERT INTO guests(full_name, phone, email, username, password) " &
                                    "VALUES('" & name & "', '" & phone & "', '" & email & "', '" & tempUser & "', '" & defaultPass & "')"
                ExecuteQuery(sql)
                MsgBox("Account created! User: " & tempUser & " | Pass: " & defaultPass, MsgBoxStyle.Information)

                Dim dtNew As DataTable = GetData("SELECT id FROM guests WHERE username='" & tempUser & "'")
                If dtNew.Rows.Count > 0 Then Return Convert.ToInt32(dtNew.Rows(0)("id"))
            Catch ex As Exception
                MsgBox("Error creating guest: " & ex.Message)
            End Try
        End If
        Return -1
    End Function

    Function GetAvailableRoomId(type As String) As Integer
        Dim dt As DataTable = GetData("SELECT id FROM rooms WHERE room_type='" & type & "' AND status='Available' LIMIT 1")
        If dt.Rows.Count > 0 Then Return Convert.ToInt32(dt.Rows(0)("id"))
        Return -1
    End Function

    Function GetRoomPrice(roomId As Integer) As Decimal
        Dim dt As DataTable = GetData("SELECT price FROM rooms WHERE id=" & roomId)
        If dt.Rows.Count > 0 Then Return Convert.ToDecimal(dt.Rows(0)("price"))
        Return 0
    End Function

    ' Update Estimate Price Label
    Private Sub UpdateTotal(sender As Object, e As EventArgs) Handles cmbRoomType.SelectedIndexChanged, dtCheckIn.ValueChanged, dtCheckOut.ValueChanged
        If cmbRoomType.SelectedIndex = -1 Then Return
        Dim dt As DataTable = GetData("SELECT price FROM rooms WHERE room_type='" & cmbRoomType.Text & "' LIMIT 1")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Dim price As Decimal = Convert.ToDecimal(dt.Rows(0)("price"))
            Dim days As Integer = DateDiff(DateInterval.Day, dtCheckIn.Value, dtCheckOut.Value)
            If days < 1 Then days = 1
            lblTotal.Text = "Est. Total: " & (price * days).ToString("C")
        End If
    End Sub

    ' View History Button
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        If CurrentGuestID > 0 Then
            Dim history As New frmBookingHistory
            history.ShowDialog()
        Else
            MsgBox("Log in to see history.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CurrentGuestID = 0
        Dim login As New LoginForm
        login.Show()
        Me.Close()
    End Sub

End Class