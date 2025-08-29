Public Class mengenalobjek

    Private Sub mengenalobjek_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProses.Click
        MsgBox(" Nama Anda : " + Me.txtNama.Text + " Alamat Anda : " + Me.txtAlamat.Text + "Pekerjaan Anda : " + Me.txtPekerjaan.Text, MsgBoxStyle.Information, "Informasi Data Pribadi")

    End Sub

    Private Sub btPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPilih.Click
        Dim Status As String = Nothing
        If Me.cbSateAyam.Checked = True Then
            Status = Me.cbSateAyam.Text
        End If
        If Me.cbSateKambing.Checked = True Then
            Status += ", " + Me.cbSateKambing.Text
        End If
        If Me.cbBaksoBakar.Checked = True Then
            Status += "' " + Me.cbBaksoBakar.Text
        End If
        MsgBox(" Anda Suka " + Status)



    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        If Me.rbPria.Checked = True Then
            MsgBox("jenis kelamin laki laki yang dipilih")
        Else
            MsgBox("jenis kelamin wanita yang dipilih")
        End If
    End Sub
End Class
