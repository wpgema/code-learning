
Imports System.Data.OleDb
Module Module1
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public RD As OleDbDataReader
    Public CMD As OleDbCommand
    Public LOKASIDATA As String
    Public Sub Koneksi()
        LOKASIDATA = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBAPLIKASI.mdb"
        CONN = New OleDbConnection(LOKASIDATA)
        If CONN.State = ConnectionState.Closed Then CONN.Open()
    End Sub

End Module
