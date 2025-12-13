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
        dgvReservation = New DataGridView()
        btnBack = New Button()
        CType(dgvReservation, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(62, 88)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 30)
        Label1.TabIndex = 0
        Label1.Text = "Guest:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(62, 144)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 30)
        Label2.TabIndex = 1
        Label2.Text = "Room:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(62, 200)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 30)
        Label3.TabIndex = 2
        Label3.Text = "Check In:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(475, 200)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 30)
        Label4.TabIndex = 3
        Label4.Text = "Check Out:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label5.Location = New Point(62, 325)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(195, 32)
        Label5.TabIndex = 4
        Label5.Text = "Reservation List"
        ' 
        ' cmbGuest
        ' 
        cmbGuest.Font = New Font("Segoe UI", 10.0F)
        cmbGuest.FormattingEnabled = True
        cmbGuest.Location = New Point(175, 84)
        cmbGuest.Margin = New Padding(4)
        cmbGuest.Name = "cmbGuest"
        cmbGuest.Size = New Size(249, 36)
        cmbGuest.TabIndex = 5
        ' 
        ' cmbRoom
        ' 
        cmbRoom.Font = New Font("Segoe UI", 10.0F)
        cmbRoom.FormattingEnabled = True
        cmbRoom.Location = New Point(175, 140)
        cmbRoom.Margin = New Padding(4)
        cmbRoom.Name = "cmbRoom"
        cmbRoom.Size = New Size(249, 36)
        cmbRoom.TabIndex = 6
        ' 
        ' dtCheckIn
        ' 
        dtCheckIn.Font = New Font("Segoe UI", 10.0F)
        dtCheckIn.Location = New Point(175, 196)
        dtCheckIn.Margin = New Padding(4)
        dtCheckIn.Name = "dtCheckIn"
        dtCheckIn.Size = New Size(249, 34)
        dtCheckIn.TabIndex = 7
        ' 
        ' dtCheckOut
        ' 
        dtCheckOut.Font = New Font("Segoe UI", 10.0F)
        dtCheckOut.Location = New Point(600, 196)
        dtCheckOut.Margin = New Padding(4)
        dtCheckOut.Name = "dtCheckOut"
        dtCheckOut.Size = New Size(249, 34)
        dtCheckOut.TabIndex = 8
        ' 
        ' btnAddRes
        ' 
        btnAddRes.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnAddRes.FlatAppearance.BorderSize = 0
        btnAddRes.FlatStyle = FlatStyle.Flat
        btnAddRes.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnAddRes.ForeColor = Color.White
        btnAddRes.Location = New Point(62, 262)
        btnAddRes.Margin = New Padding(4)
        btnAddRes.Name = "btnAddRes"
        btnAddRes.Size = New Size(125, 50)
        btnAddRes.TabIndex = 9
        btnAddRes.Text = "Add"
        btnAddRes.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateRes
        ' 
        btnUpdateRes.BackColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        btnUpdateRes.FlatAppearance.BorderSize = 0
        btnUpdateRes.FlatStyle = FlatStyle.Flat
        btnUpdateRes.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdateRes.ForeColor = Color.White
        btnUpdateRes.Location = New Point(200, 262)
        btnUpdateRes.Margin = New Padding(4)
        btnUpdateRes.Name = "btnUpdateRes"
        btnUpdateRes.Size = New Size(125, 50)
        btnUpdateRes.TabIndex = 10
        btnUpdateRes.Text = "Update"
        btnUpdateRes.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRes
        ' 
        btnDeleteRes.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDeleteRes.FlatAppearance.BorderSize = 0
        btnDeleteRes.FlatStyle = FlatStyle.Flat
        btnDeleteRes.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDeleteRes.ForeColor = Color.White
        btnDeleteRes.Location = New Point(338, 262)
        btnDeleteRes.Margin = New Padding(4)
        btnDeleteRes.Name = "btnDeleteRes"
        btnDeleteRes.Size = New Size(125, 50)
        btnDeleteRes.TabIndex = 11
        btnDeleteRes.Text = "Delete"
        btnDeleteRes.UseVisualStyleBackColor = False
        ' 
        ' dgvReservation
        ' 
        dgvReservation.BackgroundColor = Color.White
        dgvReservation.BorderStyle = BorderStyle.None
        dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReservation.Location = New Point(62, 375)
        dgvReservation.Margin = New Padding(4)
        dgvReservation.Name = "dgvReservation"
        dgvReservation.RowHeadersWidth = 51
        dgvReservation.Size = New Size(875, 225)
        dgvReservation.TabIndex = 12
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(15, 15)
        btnBack.Margin = New Padding(4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(125, 44)
        btnBack.TabIndex = 13
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmReservation
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(1000, 625)
        Controls.Add(btnBack)
        Controls.Add(dgvReservation)
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
        Margin = New Padding(4)
        Name = "frmReservation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation"
        CType(dgvReservation, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvReservation As DataGridView
    Friend WithEvents btnBack As Button
End Class