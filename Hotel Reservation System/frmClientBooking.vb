Public Class frmClientBooking

    Private Sub frmClientBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me)

        ' 1. Load Room Types
        LoadRoomTypes()

        ' 2. Set Date Limits
        dtCheckIn.MinDate = DateTime.Now
        dtCheckOut.MinDate = DateTime.Now.AddDays(1)

        ' 3. Strict Check: User MUST be logged in
        If CurrentGuestID = 0 Then
            MsgBox("Session expired. Please log in again.", MsgBoxStyle.Critical)
            Dim login As New LoginForm
            login.Show()
            Me.Close()
            Return
        End If

        ' 4. Auto-fill info
        PreFillGuestInfo()
    End Sub

    ' --- LOAD ROOM TYPES FIX ---
    Sub LoadRoomTypes()
        cmbRoomType.Items.Clear() ' Clear previous items to avoid duplicates
        Try
            Dim dt As DataTable = GetData("SELECT DISTINCT room_type FROM rooms")
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    cmbRoomType.Items.Add(row("room_type").ToString())
                Next
            Else
                ' If this message appears, your database 'rooms' table is empty!
                ' MsgBox("Warning: No room types found in the database.", MsgBoxStyle.Exclamation) 
            End If
        Catch ex As Exception
            MsgBox("Error loading room types: " & ex.Message)
        End Try
    End Sub

    Sub PreFillGuestInfo()
        Try
            Dim dt As DataTable = GetData("SELECT * FROM guests WHERE id=" & CurrentGuestID)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                txtName.Text = dt.Rows(0)("full_name").ToString()
                txtPhone.Text = dt.Rows(0)("phone").ToString()
                txtEmail.Text = dt.Rows(0)("email").ToString()

                ' Lock fields
                txtName.Enabled = False
                txtPhone.Enabled = False
                txtEmail.Enabled = False
            End If
        Catch ex As Exception
            ' Silent fail or log
        End Try
    End Sub

    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        If cmbRoomType.SelectedIndex = -1 Then
            MsgBox("Please select a Room Type.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim roomType As String = cmbRoomType.Text
        Dim checkIn As String = dtCheckIn.Value.ToString("yyyy-MM-dd")
        Dim checkOut As String = dtCheckOut.Value.ToString("yyyy-MM-dd")

        ' --- DOUBLE BOOKING PREVENTION LOGIC ---
        ' Find a room of this type that DOES NOT have a reservation overlapping the requested dates
        Dim sqlAvailability As String = "SELECT id, price FROM rooms " &
                                        "WHERE room_type='" & roomType & "' " &
                                        "AND id NOT IN (" &
                                        "    SELECT room_id FROM reservations " &
                                        "    WHERE check_in < '" & checkOut & "' AND check_out > '" & checkIn & "'" &
                                        ") LIMIT 1"

        Dim dt As DataTable = GetData(sqlAvailability)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Dim roomId As Integer = Convert.ToInt32(dt.Rows(0)("id"))
            Dim price As Decimal = Convert.ToDecimal(dt.Rows(0)("price"))

            Dim days As Integer = DateDiff(DateInterval.Day, dtCheckIn.Value, dtCheckOut.Value)
            If days < 1 Then days = 1
            Dim total As Decimal = price * days

            Try
                Dim sqlBook As String = "INSERT INTO reservations(guest_id, room_id, check_in, check_out, total_amount) " &
                                        "VALUES(" & CurrentGuestID & ", " & roomId & ", '" & checkIn & "', '" & checkOut & "', " & total & ")"
                ExecuteQuery(sqlBook)

                If dtCheckIn.Value.Date = DateTime.Now.Date Then
                    ExecuteQuery("UPDATE rooms SET status='Occupied' WHERE id=" & roomId)
                End If

                MsgBox("Booking Successful! Total Cost: " & total.ToString("C"), MsgBoxStyle.Information)

                CurrentGuestID = 0
                Dim login As New LoginForm
                login.Show()
                Me.Close()

            Catch ex As Exception
                MsgBox("Booking Error: " & ex.Message)
            End Try
        Else
            MsgBox("Sorry, no '" & roomType & "' rooms are available for these specific dates.", MsgBoxStyle.Exclamation, "Fully Booked")
        End If
    End Sub

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

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim history As New frmBookingHistory
        history.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CurrentGuestID = 0
        Dim login As New LoginForm
        login.Show()
        Me.Close()
    End Sub

End Class