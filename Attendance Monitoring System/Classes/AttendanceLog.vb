Public Class AttendanceLog
    Inherits Database

    Public Property StudentID As String
    Private Status As String

    Private Sub Add()
        Dim sql = "INSERT INTO AttendanceLog(student_id, _datetime, status)" &
                    " VALUES(@student_id, @_datetime, @status)"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@student_id", StudentID)
            com.Parameters.AddWithValue("@_datetime", Now.ToString("yyyy-MM-dd h:mm:ss tt"))
            com.Parameters.AddWithValue("@status", Status)

            com.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub


    Public Sub TimeIN()
        Status = "IN"
        Add()
    End Sub

    Public Sub TimeOUT()
        Status = "OUT"
        Add()
    End Sub

    Public Shared Sub List(student_id As String, dt As samsDataSet.AttendanceLogDataTable)
        Dim log As New AttendanceLog
        Dim connection As OleDb.OleDbConnection = log.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = "SELECT ID, student_id, [_datetime], status FROM AttendanceLog WHERE student_id = @student_id"
            }

            com.Parameters.AddWithValue("@student_id", student_id)

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            show.Fill(dt)

            Debug.WriteLine("COUNT: " & dt.Rows.Count)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class
