Imports System.Drawing.Drawing2D

Module ThemeModule
    ' --- COLOR PALETTE (Modern Flat UI) ---
    Public PrimaryDark As Color = Color.FromArgb(44, 62, 80)      ' Dark Blue/Grey (Sidebar)
    Public PrimaryBlue As Color = Color.FromArgb(52, 152, 219)    ' Bright Blue (Buttons)
    Public SuccessGreen As Color = Color.FromArgb(39, 174, 96)    ' Green (Add/Save)
    Public WarningOrange As Color = Color.FromArgb(243, 156, 18)  ' Orange (Update)
    Public DangerRed As Color = Color.FromArgb(231, 76, 60)       ' Red (Delete)
    Public LightGrayBG As Color = Color.FromArgb(236, 240, 241)   ' Background
    Public TextDark As Color = Color.FromArgb(44, 62, 80)         ' Text Color

    ' --- MAIN FUNCTION TO APPLY THEME ---
    Public Sub ApplyTheme(f As Form)
        f.BackColor = LightGrayBG
        f.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        f.FormBorderStyle = FormBorderStyle.FixedSingle
        f.StartPosition = FormStartPosition.CenterScreen

        ' Loop through every control on the form and style it
        For Each c As Control In f.Controls
            StyleControl(c)
        Next
    End Sub

    ' --- RECURSIVE STYLING LOGIC ---
    Private Sub StyleControl(c As Control)
        ' 1. Style BUTTONS
        If TypeOf c Is Button Then
            Dim btn As Button = CType(c, Button)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.Cursor = Cursors.Hand
            btn.ForeColor = Color.White
            btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            btn.Height = 40 ' Make buttons taller and easier to click

            ' Color coding based on button text
            Dim text As String = btn.Text.ToLower()
            If text.Contains("delete") Or text.Contains("cancel") Then
                btn.BackColor = DangerRed
            ElseIf text.Contains("update") Or text.Contains("edit") Then
                btn.BackColor = WarningOrange
            ElseIf text.Contains("add") Or text.Contains("save") Or text.Contains("assign") Then
                btn.BackColor = SuccessGreen
            Else
                btn.BackColor = PrimaryBlue
            End If

            ' 2. Style LABELS
        ElseIf TypeOf c Is Label Then
            c.ForeColor = TextDark
            ' If it's a big header label (detected by font size in designer), keep it big
            If c.Font.Size > 12 Then
                c.Font = New Font("Segoe UI", 18, FontStyle.Bold)
                c.ForeColor = PrimaryDark
            End If

            ' 3. Style TEXTBOXES & COMBOBOXES
        ElseIf TypeOf c Is TextBox Or TypeOf c Is ComboBox Or TypeOf c Is DateTimePicker Then
            c.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            c.BackColor = Color.White

            ' 4. Style DATAGRIDVIEWS (The Tables)
        ElseIf TypeOf c Is DataGridView Then
            Dim dgv As DataGridView = CType(c, DataGridView)
            dgv.BackgroundColor = Color.White
            dgv.BorderStyle = BorderStyle.None
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            dgv.EnableHeadersVisualStyles = False

            ' Header Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryDark
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            dgv.ColumnHeadersHeight = 40

            ' Row Style
            dgv.DefaultCellStyle.SelectionBackColor = PrimaryBlue
            dgv.DefaultCellStyle.SelectionForeColor = Color.White
            dgv.DefaultCellStyle.Font = New Font("Segoe UI", 10)
            dgv.RowHeadersVisible = False ' Hide the ugly left sidebar in grid
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If

        ' Recursive call for panels/groupboxes (to find controls inside them)
        If c.HasChildren Then
            For Each child As Control In c.Controls
                StyleControl(child)
            Next
        End If
    End Sub
End Module