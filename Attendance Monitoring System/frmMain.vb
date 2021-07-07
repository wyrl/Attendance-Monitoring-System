Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Draggable1.Start()
        Draggable2.Start()
        StudentList1.RefreshData()
        Attendance1.RefreshData()



    End Sub


    Private Sub Logout()
        Dim result = MessageBox.Show("Are your sure do you want to logout?", "Logging out", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Close()
        End If
    End Sub



#Region "Shadow"
    Private aeroEnabled As Boolean
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not aeroEnabled Then
                cp.ClassStyle = cp.ClassStyle Or NativeConstants.CS_DROPSHADOW
                Return cp
            Else
                Return cp
            End If
        End Get
    End Property
    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case NativeConstants.WM_NCPAINT
                Dim val = 2
                If aeroEnabled Then
                    NativeMethods.DwmSetWindowAttribute(Handle, 2, val, 4)
                    Dim bla As New NativeStructs.MARGINS()
                    With bla
                        .bottomHeight = 1
                        .leftWidth = 1
                        .rightWidth = 1
                        .topHeight = 1
                    End With
                    NativeMethods.DwmExtendFrameIntoClientArea(Handle, bla)
                End If
                Exit Select
        End Select
        MyBase.WndProc(m)
    End Sub
    Private Sub CheckAeroEnabled()
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            Dim response As Integer = NativeMethods.DwmIsCompositionEnabled(enabled)
            aeroEnabled = (enabled = 1)
        Else
            aeroEnabled = False
        End If
    End Sub
#End Region



    Private Sub ChangeContent(userControl As UserControl)
        StudentList1.Hide()
        Attendance1.Hide()

        userControl.Show()
    End Sub

    Private Sub ChangeButtonColor(btn As Button)
        btnStudents.BackColor = Theme.PrimaryColor
        btnAttendance.BackColor = Theme.PrimaryColor

        btn.BackColor = Theme.SecondaryColor
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Logout()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        ChangeButtonColor(btnStudents)
        ChangeContent(StudentList1)
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        ChangeButtonColor(btnAttendance)
        ChangeContent(Attendance1)
    End Sub
End Class