Public Class Admin
    Inherits Database


    Public Shared Function Login(username As String, password As String)
        Dim admin As New Admin()
        Dim connection As OleDb.OleDbConnection = admin.connection
        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = "SELECT * FROM Admin WHERE username = @username AND password = @password"
            }

            com.Parameters.AddWithValue("@username", username)
            com.Parameters.AddWithValue("@password", password)

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            show.Fill(d)
            connection.Close()

            Return d.Rows.Count > 0
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return False
    End Function

End Class
