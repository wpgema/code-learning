Public Class TambahDataMhs
    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        If Me.txtAlamat.Text = "" Or Me.txtAlamatOrtu.Text = "" _
                Or Me.txtLulus.Text = "" Or Me.txtNama.Text = "" _
                Or Me.txtNEM.Text = "" Or Me.txtNIM.Text = "" _
                Or Me.txtNmOrtu.Text = "" Or Me.txtPekerjaan.Text = "" _
                Or Me.txtPekerjaan.Text = "" Or Me.txtSMU.Text = "" _
                Or Me.txtTTL.Text = "" Or Me.cboAgama.Text = "" _
                Or Me.cboAngkatan.Text = "" Or Me.cboKelamin.Text = "" Then
            MsgBox("Data is not complate")
            Exit Sub
        Else
            Call Koneksi()
            CMD = New Odbc.OdbcCommand("select * from mahasiswa where NIM ='" & Me.txtNIM.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan As String = "Insert into mahasiswa values ('" & Me.txtNIM.Text _
                                       & "','" & Me.txtNama.Text & "','" & Me.cboAngkatan.Text _
                                       & "','" & Me.cboKelamin.Text & "','" & Me.txtTTL.Text _
                                       & "','" & Me.cboAgama.Text & "','" & Me.txtSMU.Text _
                                       & "','" & Me.txtNEM.Text & "','" & Me.txtAlamat.Text _
                                       & "','" & Me.txtLulus.Text & "','" & Me.txtNmOrtu.Text _
                                       & "','" & Me.txtPekerjaan.Text & "','" & Me.txtAlamatOrtu.Text & "')"
                CMD = New Odbc.OdbcCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Updated Succesfully", MsgBoxStyle.Information, "Information")
                dtMahasiswa.Tampil_Data()
            Else
                MsgBox("NIM """ & Me.txtNIM.Text & """ Sudah Ada...")
            End If
        End If
    End Sub

    Private Sub TambahDataMhs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanToolStripMenuItem.Click
        If Me.txtAlamat.Text = "" Or Me.txtAlamatOrtu.Text = "" _
                        Or Me.txtLulus.Text = "" Or Me.txtNama.Text = "" _
                        Or Me.txtNEM.Text = "" Or Me.txtNIM.Text = "" _
                        Or Me.txtNmOrtu.Text = "" Or Me.txtPekerjaan.Text = "" _
                        Or Me.txtPekerjaan.Text = "" Or Me.txtSMU.Text = "" _
                        Or Me.txtTTL.Text = "" Or Me.cboAgama.Text = "" _
                        Or Me.cboAngkatan.Text = "" Or Me.cboKelamin.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            CMD = New Odbc.OdbcCommand("select * from mahasiswa where NIM ='" & Me.txtNIM.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan As String = "Insert into mahasiswa values ('" & Me.txtNIM.Text _
                                       & "','" & Me.txtNama.Text & "','" & Me.cboAngkatan.Text _
                                       & "','" & Me.cboKelamin.Text & "','" & Me.txtTTL.Text _
                                       & "','" & Me.cboAgama.Text & "','" & Me.txtSMU.Text _
                                       & "','" & Me.txtNEM.Text & "','" & Me.txtAlamat.Text _
                                       & "','" & Me.txtLulus.Text & "','" & Me.txtNmOrtu.Text _
                                       & "','" & Me.txtPekerjaan.Text & "','" & Me.txtAlamatOrtu.Text & "')"
                CMD = New Odbc.OdbcCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Updated Succesfully", MsgBoxStyle.Information, "Information")
                DtMahasiswa.Tampil_Data()
            Else
                MsgBox("NIM """ & Me.txtNIM.Text & """ Sudah Ada...")
            End If
        End If
    End Sub

    Private Sub btBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBatal.Click
        Me.Close()
    End Sub
End Class


