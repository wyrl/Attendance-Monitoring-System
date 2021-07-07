Public Class StudentList
    Private Sub StudentRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgvStudents.DataSource = StudentBindingSource.DataSource
        'RefreshData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studentRegister As New frmStudentRegister
        studentRegister.Action = frmStudentRegister.ADD

        'studentRegister.studentRow = SamsDataSet.Student1.NewStudent1Row
        Dim result = studentRegister.ShowDialog()

        If result = DialogResult.OK Then
            If studentRegister.Action = frmStudentRegister.ADD Then

                studentRegister.student.Add()

                'SamsDataSet.Student1.AddStudent1Row(studentRegister.studentRow)
                'TableAdapterManager2.UpdateAll(SamsDataSet)
            End If

            RefreshData()
        End If

    End Sub

    Public Sub RefreshData()


        Search("")

        ''Student1TableAdapter1.Fill(SamsDataSet.Student1)
    End Sub

    Public Sub Search(search As String)
        'Dim command As OleDb.OleDbCommand


        'command = StudentTableAdapter.CommandCollection(0)
        'command.Parameters.AddWithValue("@ID", search)

        'SamsDataSet.Student.Clear()
        'StudentTableAdapter.Fill(SamsDataSet.Student)

        SamsDataSet.Student1.Clear()
        SamsDataSet.Student.Clear()

        Student.Search(search, SamsDataSet.Student)
        Student.Search1(search, SamsDataSet.Student1)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvStudents.SelectedRows.Count > 0 Then

            Dim dataRowView As DataRowView = StudentBindingSource.Current
            Dim studentRow As samsDataSet.StudentRow = dataRowView.Row

            Dim result = MessageBox.Show("Are your sure do you want to Delete?", "Deleting", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Dim student As New Student()
                student.Delete(studentRow.ID)

                RefreshData()

            End If


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvStudents.SelectedRows.Count > 0 Then
            Dim dataRowView As DataRowView = StudentBindingSource.Current
            Dim studentRow = SamsDataSet.Student1.Item(StudentBindingSource.Position)

            Dim studentRegister As New frmStudentRegister
            studentRegister.Action = frmStudentRegister.EDIT

            'studentRegister.studentRow = SamsDataSet.Student1.NewStudent1Row

            Dim student As New Student
            student.ID = studentRow.ID
            student.Firstname = studentRow.firstname
            student.Middlename = studentRow.middlename
            student.Lastname = studentRow.lastname
            student.Course = studentRow.course
            student.YearLevel = studentRow.year_level
            student.EmergencyContact = studentRow.emergency_contact
            student.ContactNumber = studentRow.contact_number
            student.Active = studentRow.is_active

            studentRegister.setStudent(student)

            Dim result = studentRegister.ShowDialog()

            If result = DialogResult.OK Then
                student.Update(studentRow.ID)


                RefreshData()
            End If




        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Search(txtSearch.Text)
    End Sub
End Class
