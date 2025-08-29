Imports System.Data.Odbc
Module ModMain
    Public CONN As OdbcConnection
    Public CMD As OdbcCommand
    Public DR As OdbcDataReader
    Public QUERY As String
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public DT As DataTable

    Sub Koneksi()
        Dim Str As String = "Dsn=siakadd3"
        CONN = New OdbcConnection(Str)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
            MsgBox("Koneksi Berhasil")
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub
End Module

