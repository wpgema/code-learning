Public Class EditDataMhs
    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
        Call Koneksi()
        Dim edit As String = "update mahasiswa set NIM='" & Me.txtNIM.Text & _
            "', Nama_Mahasiswa='" & Me.txtNama.Text & "', Th_Ajaran='" & Me.cboAngkatan.Text & _
            "',Jenis_Kelamin='" & Me.cboKelamin.Text & "', TTL='" & Me.txtTTL.Text & _
            "', Agama='" & Me.cboAgama.Text & "', SMU_Asal='" & Me.txtSMU.Text & _
            "', NEM='" & Me.txtNEM.Text & "', Alamat='" & Me.txtAlamat.Text & _
            "', Status_Lulus ='" & Me.txtLulus.Text & "', Nama_Ortu= '" & Me.txtNmOrtu.Text & _
            "', Pekerjaan = '" & Me.txtPekerjaan.Text & "', Alamat_Ortu= '" & Me.txtAlamatOrtu.Text & _
            "' where NIM = '" & Me.Tag & "'"
        CMD = New Odbc.OdbcCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil di Update", MsgBoxStyle.Information, "Information")
        DtMahasiswa.Tampil_Data()
    End Sub

    Private Sub EditDataMhs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtNIM.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(1).Text
        Me.txtNama.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(2).Text
        Me.cboAngkatan.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(3).Text
        Me.cboKelamin.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(4).Text
        Me.txtTTL.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(5).Text
        Me.cboAgama.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(6).Text
        Me.txtSMU.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(7).Text
        Me.txtNEM.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(8).Text
        Me.txtAlamat.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(9).Text
        Me.txtLulus.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(10).Text
        Me.txtNmOrtu.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(11).Text
        Me.txtPekerjaan.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(12).Text
        Me.txtAlamatOrtu.Text = DtMahasiswa.ListView1.SelectedItems(0).SubItems(13).Text
        Me.Tag = DtMahasiswa.ListView1.SelectedItems(0).SubItems(1).Text

    End Sub

    Private Sub btBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBatal.Click
        Me.Close()
    End Sub
End Class