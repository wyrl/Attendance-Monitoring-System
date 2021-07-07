Imports System.IO

Public Class Student
    Inherits Database

    Public ID As String
    Public Firstname As String
    Public Middlename As String
    Public Lastname As String
    Public Course As String
    Public YearLevel As String
    Public EmergencyContact As String
    Public ContactNumber As String
    Public Active As Boolean

    Public Sub Add()
        Dim sql = "INSERT INTO Student(ID, firstname, middlename, lastname, [course], year_level, emergency_contact, contact_number, is_active)" &
                                " VALUES(@ID, @firstname, @middlename, @lastname, @course, @year_level, @emergency_contact, @contact_number, @is_active)"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@ID", ID)
            com.Parameters.AddWithValue("@firstname", Firstname)
            com.Parameters.AddWithValue("@middlename", Middlename)
            com.Parameters.AddWithValue("@lastname", Lastname)
            com.Parameters.AddWithValue("@course", Course)
            com.Parameters.AddWithValue("@year_level", YearLevel)
            com.Parameters.AddWithValue("@emergency_contact", EmergencyContact)
            com.Parameters.AddWithValue("@contact_number", ContactNumber)
            com.Parameters.AddWithValue("@is_active", Active)

            com.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub

    Public Sub Update(ID As String)
        Dim sql = "Update Student 
                   SET ID = @newID, firstname = @firstname, middlename = @middlename, lastname = @lastname, 
                            [course] = @course, year_level = @year_level, emergency_contact = @emergency_contact,
                            contact_number = @contact_number, is_active = @is_active
                   WHERE ID = @ID"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@newID", ID)
            com.Parameters.AddWithValue("@firstname", Firstname)
            com.Parameters.AddWithValue("@middlename", Middlename)
            com.Parameters.AddWithValue("@lastname", Lastname)
            com.Parameters.AddWithValue("@course", Course)
            com.Parameters.AddWithValue("@year_level", YearLevel)
            com.Parameters.AddWithValue("@emergency_contact", EmergencyContact)
            com.Parameters.AddWithValue("@contact_number", ContactNumber)
            com.Parameters.AddWithValue("@is_active", Active)
            com.Parameters.AddWithValue("@ID", ID)

            com.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub

    Public Sub Delete(ID As String)
        Dim sql = "DELETE FROM Student WHERE ID = @ID"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@ID", ID)

            com.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub

    Public Shared Sub Search(searchStudent As String, dt As samsDataSet.StudentDataTable)
        Dim student As New Student
        Dim connection As OleDb.OleDbConnection = student.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = "SELECT ID, firstname & ' ' & middlename & ' ' & lastname AS Fullname, course AS Course, year_level AS [Year Level], emergency_contact AS [Emergency Contact], contact_number AS Contact, is_active AS Active FROM Student 
                                WHERE (ID LIKE @search) OR (firstname LIKE @search) OR (middlename LIKE @search) OR (lastname LIKE @search) ORDER BY ID"
            }

            com.Parameters.AddWithValue("@search", "%" & searchStudent & "%")

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            show.Fill(dt)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Shared Sub Search1(searchStudent As String, dt As samsDataSet.Student1DataTable)
        Dim student As New Student
        Dim connection As OleDb.OleDbConnection = student.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = "SELECT ID, firstname, middlename, lastname, [course], year_level, emergency_contact, contact_number, is_active FROM Student 
                                WHERE (ID LIKE @search) OR (firstname LIKE @search) OR (middlename LIKE @search) OR (lastname LIKE @search) ORDER BY ID"
            }

            com.Parameters.AddWithValue("@search", "%" & searchStudent & "%")

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            show.Fill(dt)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub



End Class
