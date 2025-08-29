Imports System.Data.OleDB
Public Class FormMasterAdmin
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        MunculGrid()
        MunculCombo()
        
    End Sub

    Private Sub FormMasterAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call KondisiAwal()
        TextBox3.PasswordChar = "X"

    End Sub
    Sub MunculGrid()
        Call Koneksi()
        DA = New OleDbDataAdapter("Select KodeAdmin,NamaAdmin,LevelAdmin From TBL_ADMIN", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TBL_ADMIN")
        DataGridView1.DataSource = (DS.Tables("TBL_ADMIN"))
    End Sub
    Sub MunculCombo()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan Data diisi lengkap")
            Else
                Call Koneksi()
                Dim SimpanData As String = "Insert into TBL_ADMIN values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
                CMD = New OleDbCommand(SimpanData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Tambahkan")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Batal" Then
            Call KondisiAwal()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            CMD = New OleDbCommand("Select * from TBL_ADMIN where KodeAdmin ='" & TextBox1.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                TextBox2.Text = RD.Item("NamaAdmin")
                TextBox3.Text = RD.Item("PasswordAdmin")
                ComboBox1.Text = RD.Item("LevelAdmin")
            Else
                MsgBox("Data Tidak Ada")
            End If
        End If
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan Data diisi lengkap")
            Else
                Call Koneksi()
                Dim EditData As String = "Update TBL_ADMIN set NamaAdmin='" & TextBox2.Text & "',PasswordAdmin='" & TextBox3.Text & "',LevelAdmin='" & ComboBox1.Text & "' where KodeAdmin='" & TextBox1.Text & "'"
                CMD = New OleDbCommand(EditData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Update")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Hapus Data"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan Data diisi lengkap")
            Else
                Call Koneksi()
                Dim EditData As String = "Delete from TBL_ADMIN where KodeAdmin='" & TextBox1.Text & "'"
                CMD = New OleDbCommand(EditData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Hapus")
                Call KondisiAwal()
            End If
        End If

    End Sub
End Class