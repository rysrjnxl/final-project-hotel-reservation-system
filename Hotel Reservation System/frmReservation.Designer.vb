<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReservation
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        cmbGuest = New ComboBox()
        cmbRoom = New ComboBox()
        dtCheckIn = New DateTimePicker()
        dtCheckOut = New DateTimePicker()
        btnAddRes = New Button()
        btnUpdateRes = New Button()
        btnDeleteRes = New Button()
        DataGridView1 = New DataGridView()
        btnBack = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(50, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 23)
        Label1.TabIndex = 0
        Label1.Text = "Guest:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(50, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 23)
        Label2.TabIndex = 1
        Label2.Text = "Room:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(50, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 23)
        Label3.TabIndex = 2
        Label3.Text = "Check In:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(380, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 23)
        Label4.TabIndex = 3
        Label4.Text = "Check Out:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label5.Location = New Point(50, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(164, 28)
        Label5.TabIndex = 4
        Label5.Text = "Reservation List"
        ' 
        ' cmbGuest
        ' 
        cmbGuest.Font = New Font("Segoe UI", 10.0F)
        cmbGuest.FormattingEnabled = True
        cmbGuest.Location = New Point(140, 67)
        cmbGuest.Name = "cmbGuest"
        cmbGuest.Size = New Size(200, 31)
        cmbGuest.TabIndex = 5
        ' 
        ' cmbRoom
        ' 
        cmbRoom.Font = New Font("Segoe UI", 10.0F)
        cmbRoom.FormattingEnabled = True
        cmbRoom.Location = New Point(140, 112)
        cmbRoom.Name = "cmbRoom"
        cmbRoom.Size = New Size(200, 31)
        cmbRoom.TabIndex = 6
        ' 
        ' dtCheckIn
        ' 
        dtCheckIn.Font = New Font("Segoe UI", 10.0F)
        dtCheckIn.Location = New Point(140, 157)
        dtCheckIn.Name = "dtCheckIn"
        dtCheckIn.Size = New Size(200, 30)
        dtCheckIn.TabIndex = 7
        ' 
        ' dtCheckOut
        ' 
        dtCheckOut.Font = New Font("Segoe UI", 10.0F)
        dtCheckOut.Location = New Point(480, 157)
        dtCheckOut.Name = "dtCheckOut"
        dtCheckOut.Size = New Size(200, 30)
        dtCheckOut.TabIndex = 8
        ' 
        ' btnAddRes
        ' 
        btnAddRes.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnAddRes.FlatStyle = FlatStyle.Flat
        btnAddRes.FlatAppearance.BorderSize = 0
        btnAddRes.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnAddRes.ForeColor = Color.White
        btnAddRes.Location = New Point(50, 210)
        btnAddRes.Name = "btnAddRes"
        btnAddRes.Size = New Size(100, 40)
        btnAddRes.TabIndex = 9
        btnAddRes.Text = "Add"
        btnAddRes.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateRes
        ' 
        btnUpdateRes.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdateRes.FlatStyle = FlatStyle.Flat
        btnUpdateRes.FlatAppearance.BorderSize = 0
        btnUpdateRes.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdateRes.ForeColor = Color.White
        btnUpdateRes.Location = New Point(160, 210)
        btnUpdateRes.Name = "btnUpdateRes"
        btnUpdateRes.Size = New Size(100, 40)
        btnUpdateRes.TabIndex = 10
        btnUpdateRes.Text = "Update"
        btnUpdateRes.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRes
        ' 
        btnDeleteRes.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDeleteRes.FlatStyle = FlatStyle.Flat
        btnDeleteRes.FlatAppearance.BorderSize = 0
        btnDeleteRes.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDeleteRes.ForeColor = Color.White
        btnDeleteRes.Location = New Point(270, 210)
        btnDeleteRes.Name = "btnDeleteRes"
        btnDeleteRes.Size = New Size(100, 40)
        btnDeleteRes.TabIndex = 11
        btnDeleteRes.Text = "Delete"
        btnDeleteRes.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(50, 300)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(700, 180)
        DataGridView1.TabIndex = 12
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 35)
        btnBack.TabIndex = 13
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmReservation
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(800, 500)
        Controls.Add(btnBack)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteRes)
        Controls.Add(btnUpdateRes)
        Controls.Add(btnAddRes)
        Controls.Add(dtCheckOut)
        Controls.Add(dtCheckIn)
        Controls.Add(cmbRoom)
        Controls.Add(cmbGuest)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmReservation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbGuest As ComboBox
    Friend WithEvents cmbRoom As ComboBox
    Friend WithEvents dtCheckIn As DateTimePicker
    Friend WithEvents dtCheckOut As DateTimePicker
    Friend WithEvents btnAddRes As Button
    Friend WithEvents btnUpdateRes As Button
    Friend WithEvents btnDeleteRes As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
End Class