Module ModuleTransitions
    Public Sub SlideInForm(ByVal frm As Form)
        frm.StartPosition = FormStartPosition.Manual
        frm.Left = Screen.PrimaryScreen.WorkingArea.Width ' Start off-screen
        frm.Top = (Screen.PrimaryScreen.WorkingArea.Height - frm.Height) \ 2
        frm.Show()

        ' Animate sliding
        For i As Integer = frm.Left To (Screen.PrimaryScreen.WorkingArea.Width - frm.Width) Step -20
            frm.Left = i
            Application.DoEvents()
            System.Threading.Thread.Sleep(5)
        Next
    End Sub
End Module