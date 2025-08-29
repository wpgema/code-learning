Public Class DtMahasiswa
    Public Sub Tampil_Data()
        If Me.ListView1.Columns.Count <= 0 Then
            Me.ListView1.Columns.Add("NO", 50, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("NIM", 200, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("NAMA MAHASISWA", 200, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("Tahun AJARAN", 100, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("JENIS KELAMIN", 100, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("TEMPAT,TANGGAL LAHIR", 250, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("AGAMA", 100, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("SMU ASAL", 250, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("NEM", 50, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("ALAMAT", 250, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("STATUS LULUS", 100, HorizontalAlignment.Center)
            Me.ListView1.Columns.Add("NAMA ORANG TUA", 250, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("PEKERJAAN ORANG TUA", 250, HorizontalAlignment.Left)
            Me.ListView1.Columns.Add("ALAMAT ORANG TUA", 300, HorizontalAlignment.Left)
        End If
        On Error GoTo gagal
        Me.ListView1.Items.Clear()
        Call Koneksi()
        CMD = New Odbc.OdbcCommand("Select * From Mahasiswa order by NIM ASC", CONN)
        DA = New Odbc.OdbcDataAdapter(CMD)
        Dim dt As New DataTable
        DA.Fill(dt)
        Dim no As Integer = 1
        For i As Integer = 0 To dt.Rows.Count - 1
            With Me.ListView1
                .Items.Add(no)
                With .Items(.Items.Count - 1).SubItems
                    .Add(dt.Rows(i)("NIM"))
                    .Add(IIf(IsDBNull(dt.Rows(i)("Nama_Mahasiswa")), "", dt.Rows(i)("Nama_Mahasiswa")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("Th_Ajaran")), "", dt.Rows(i)("Th_Ajaran")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("Jenis_Kelamin")), "", dt.Rows(i)("Jenis_Kelamin")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("TTL")), "", dt.Rows(i)("TTL")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("Agama")), "", dt.Rows(i)("Agama")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("SMU_Asal")), "", dt.Rows(i)("SMU_Asal")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("NEM")), "", dt.Rows(i)("NEM")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("Alamat")), "", dt.Rows(i)("Alamat")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("Status_Lulus")), "", dt.Rows(i)("Status_Lulus")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("Nama_Ortu")), "", dt.Rows(i)("Nama_Ortu")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("Pekerjaan")), "", dt.Rows(i)("pekerjaan")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("Alamat_Ortu")), "", dt.Rows(i)("Alamat_Ortu")))

                End With
            End With
            no = no + 1
        Next
        CONN.Dispose()
        CONN.Close()
        Exit Sub
gagal:
        MsgBox("Terjadi Keselahan" & Err.Number & " " & Err.Description, vbInformation, "Info")

    End Sub
    Private Sub DtMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampil_Data()

    End Sub

    Private Sub btTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTambah.Click
        TambahDataMhs.Show()
    End Sub
End Class
