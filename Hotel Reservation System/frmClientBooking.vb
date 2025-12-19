Public Class frmClientBooking

    Private Sub frmClientBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyTheme(Me)

        ' 1. Load Custom Room Names
        LoadRoomTypes()

        dtCheckIn.MinDate = DateTime.Now
        dtCheckOut.MinDate = DateTime.Now.AddDays(1)

        If CurrentGuestID = 0 Then
            MsgBox("Session expired. Please log in again.", MsgBoxStyle.Critical)
            Dim login As New LoginForm
            login.Show()
            Me.Close()
            Return
        End If

        PreFillGuestInfo()
    End Sub
    Sub LoadRoomTypes()
        Try
            Dim dtDB As DataTable = GetData("SELECT DISTINCT room_type FROM rooms")

            ' Create a temporary table for the Dropdown
            Dim dtCombo As New DataTable()
            dtCombo.Columns.Add("Display")
            dtCombo.Columns.Add("Value")

            If dtDB IsNot Nothing AndAlso dtDB.Rows.Count > 0 Then
                For Each row As DataRow In dtDB.Rows
                    Dim realType As String = row("room_type").ToString()
                    Dim customName As String = realType

                    Select Case realType
                        Case "Single"
                            customName = "Single (Good for 1)"
                        Case "Double"
                            customName = "Double (Good for 2)"
                        Case "Suite"
                            customName = "Suite (Max 4 Persons)"
                        Case Else
                            customName = realType
                    End Select

                    dtCombo.Rows.Add(customName, realType)
                Next
            End If

            cmbRoomType.DataSource = dtCombo
            cmbRoomType.DisplayMember = "Display"
            cmbRoomType.ValueMember = "Value"
            cmbRoomType.SelectedIndex = -1

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

                txtName.Enabled = False
                txtPhone.Enabled = False
                txtEmail.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        If cmbRoomType.SelectedIndex = -1 Then
            MsgBox("Please select a Room Type.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim roomType As String = cmbRoomType.SelectedValue.ToString()
        Dim checkIn As String = dtCheckIn.Value.ToString("yyyy-MM-dd")
        Dim checkOut As String = dtCheckOut.Value.ToString("yyyy-MM-dd")

        ' 1. DUPLICATE CHECK: Prevent same guest from booking same dates twice
        Dim sqlMyBookings As String = "SELECT id FROM reservations " &
                                      "WHERE guest_id=" & CurrentGuestID & " " &
                                      "AND check_in < '" & checkOut & "' AND check_out > '" & checkIn & "'"
        Dim dtMyBookings As DataTable = GetData(sqlMyBookings)
        If dtMyBookings IsNot Nothing AndAlso dtMyBookings.Rows.Count > 0 Then
            MsgBox("You already have a reservation during these dates!", MsgBoxStyle.Exclamation, "Duplicate Booking")
            Exit Sub
        End If

        ' 2. FIND AVAILABLE ROOM
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
                ' 3. INSERT RESERVATION
                Dim sqlBook As String = "INSERT INTO reservations(guest_id, room_id, check_in, check_out, total_amount) " &
                                        "VALUES(" & CurrentGuestID & ", " & roomId & ", '" & checkIn & "', '" & checkOut & "', " & total & ")"
                ExecuteQuery(sqlBook)

                If dtCheckIn.Value.Date = DateTime.Now.Date Then
                    ExecuteQuery("UPDATE rooms SET status='Occupied' WHERE id=" & roomId)
                End If

                MsgBox("Booking Successful! Total Cost: ₱" & total.ToString("N2"), MsgBoxStyle.Information)

                ' 4. RESET FORM (Stay Logged In)
                cmbRoomType.SelectedIndex = -1
                lblTotal.Text = "Est. Total: ₱0.00"

            Catch ex As Exception
                MsgBox("Booking Error: " & ex.Message)
            End Try
        Else
            MsgBox("Sorry, no '" & roomType & "' rooms are available for these specific dates.", MsgBoxStyle.Exclamation, "Fully Booked")
        End If
    End Sub

    Private Sub UpdateTotal(sender As Object, e As EventArgs) Handles cmbRoomType.SelectedIndexChanged, dtCheckIn.ValueChanged, dtCheckOut.ValueChanged
        If cmbRoomType.SelectedIndex = -1 Then Return

        Dim roomType As String = cmbRoomType.SelectedValue.ToString()

        Dim dt As DataTable = GetData("SELECT price FROM rooms WHERE room_type='" & roomType & "' LIMIT 1")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Dim price As Decimal = Convert.ToDecimal(dt.Rows(0)("price"))
            Dim days As Integer = DateDiff(DateInterval.Day, dtCheckIn.Value, dtCheckOut.Value)
            If days < 1 Then days = 1
            lblTotal.Text = "Est. Total: ₱" & (price * days).ToString("N2")
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