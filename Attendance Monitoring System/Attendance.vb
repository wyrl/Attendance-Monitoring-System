Public Class Attendance
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblCurrentDate.Text = Now.ToString("MMMM dd, yyyy h:mm:ss tt")

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim choose As New frmChoose

        Dim result = choose.ShowDialog()

        If result = DialogResult.OK Then
            txtID.Text = choose.ID
            txtFullname.Text = choose.Fullname

            RefreshData()
        End If

    End Sub

    Public Sub RefreshData()
        'AttendanceLogTableAdapter.Fill(SamsDataSet.AttendanceLog)
        SamsDataSet.AttendanceLog.Clear()
        AttendanceLog.List(txtID.Text, SamsDataSet.AttendanceLog)
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnIN_Click(sender As Object, e As EventArgs) Handles btnAMIN.Click
        InOut("IN")
    End Sub

    Private Sub btnOUT_Click(sender As Object, e As EventArgs) Handles btnAMOUT.Click
        InOut("OUT")
    End Sub


    Private Sub InOut(status As String)

        If txtID.Text.Trim() <> "" Then
            Dim attendanceLog As New AttendanceLog
            attendanceLog.StudentID = txtID.Text

            If status = "IN" Then
                attendanceLog.TimeIN()
            Else
                attendanceLog.TimeOUT()
            End If

            RefreshData()
        Else

            MessageBox.Show("Please choose student first")

        End If
    End Sub


End Class
