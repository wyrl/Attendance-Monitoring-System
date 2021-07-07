Public Class frmStudentRegister
    Public student As New Student
    Public Shared ReadOnly ADD As String = "Add"
    Public Shared ReadOnly EDIT As String = "Edit"
    'Public studentRow As samsDataSet.Student1Row
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        student.ID = txtId.Text
        student.Firstname = txtFirstname.Text
        student.Middlename = txtMiddlename.Text
        student.Lastname = txtLastname.Text
        student.Course = txtSection.Text
        student.YearLevel = txtYearLevel.Text
        student.Active = rbYes.Checked
        student.EmergencyContact = txtEmergencyContact.Text
        student.ContactNumber = txtContactNumber.Text

        DialogResult = DialogResult.OK
    End Sub

    Public Property Action As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmStudentRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Draggable1.Start()
        Draggable2.Start()

    End Sub

    Public Sub setStudent(student As Student)
        Me.student = student

        txtId.Text = student.ID
        txtFirstname.Text = student.Firstname
        txtMiddlename.Text = student.Middlename
        txtLastname.Text = student.Lastname
        txtSection.Text = student.Course
        txtYearLevel.Text = student.YearLevel
        txtEmergencyContact.Text = student.EmergencyContact
        txtContactNumber.Text = student.ContactNumber

        If student.Active Then
            rbYes.Checked = True
            rbNo.Checked = False
        Else
            rbYes.Checked = False
            rbNo.Checked = True
        End If

    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
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
End Class