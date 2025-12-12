<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Label1.Location = New Point(98, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 0
        Label1.Text = "Guest"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(95, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Room"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 2
        Label3.Text = "Check In"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 3
        Label4.Text = "Check Out"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 20)
        Label5.TabIndex = 4
        Label5.Text = "Reservation List"
        ' 
        ' cmbGuest
        ' 
        cmbGuest.FormattingEnabled = True
        cmbGuest.Location = New Point(161, 55)
        cmbGuest.Name = "cmbGuest"
        cmbGuest.Size = New Size(151, 28)
        cmbGuest.TabIndex = 5
        ' 
        ' cmbRoom
        ' 
        cmbRoom.FormattingEnabled = True
        cmbRoom.Location = New Point(161, 94)
        cmbRoom.Name = "cmbRoom"
        cmbRoom.Size = New Size(151, 28)
        cmbRoom.TabIndex = 6
        ' 
        ' dtCheckIn
        ' 
        dtCheckIn.Location = New Point(161, 134)
        dtCheckIn.Name = "dtCheckIn"
        dtCheckIn.Size = New Size(250, 27)
        dtCheckIn.TabIndex = 7
        ' 
        ' dtCheckOut
        ' 
        dtCheckOut.Location = New Point(161, 178)
        dtCheckOut.Name = "dtCheckOut"
        dtCheckOut.Size = New Size(250, 27)
        dtCheckOut.TabIndex = 8
        ' 
        ' btnAddRes
        ' 
        btnAddRes.Location = New Point(161, 219)
        btnAddRes.Name = "btnAddRes"
        btnAddRes.Size = New Size(94, 29)
        btnAddRes.TabIndex = 9
        btnAddRes.Text = "Add Reservation"
        btnAddRes.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateRes
        ' 
        btnUpdateRes.Location = New Point(261, 219)
        btnUpdateRes.Name = "btnUpdateRes"
        btnUpdateRes.Size = New Size(94, 29)
        btnUpdateRes.TabIndex = 10
        btnUpdateRes.Text = "Update"
        btnUpdateRes.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteRes
        ' 
        btnDeleteRes.Location = New Point(361, 219)
        btnDeleteRes.Name = "btnDeleteRes"
        btnDeleteRes.Size = New Size(94, 29)
        btnDeleteRes.TabIndex = 11
        btnDeleteRes.Text = "Delete"
        btnDeleteRes.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(32, 277)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(734, 165)
        DataGridView1.TabIndex = 12
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(146, 29)
        btnBack.TabIndex = 13
        btnBack.Text = "Back to Dashboard"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmReservation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
