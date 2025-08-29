Imports System.Data.OleDb
Public Class FormLogin
    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Masukkan Data Login dan Password !")
        Else
            Call Koneksi()
            CMD = New OleDbCommand("select * from TBL_ADMIN where KodeAdmin ='" & TextBox1.Text & "' and PasswordAdmin ='" & TextBox2.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Me.Close()
                Call Terbuka()
                FormMenuUtama.STLabel2.Text = RD!KodeAdmin
                FormMenuUtama.STLabel4.Text = RD!NamaAdmin
                FormMenuUtama.STLabel6.Text = RD!LevelAdmin
                
            Else
                MsgBox("Kode Admin atau Password Salah!")
            End If

        End If
    End Sub

    
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class