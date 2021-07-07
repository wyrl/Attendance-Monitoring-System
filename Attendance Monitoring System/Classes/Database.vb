Imports System.IO

Public Class Database
    Protected connection As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Directory.GetCurrentDirectory() & "\\sams.mdb;Persist Security Info=False")
End Class
