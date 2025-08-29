Imports System.Data.OleDb
Public Class FormMasterBarang
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        Label7.Text = ""
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        MunculGrid()
        Call MunculKodeKategori()
        Call MunculSatuan()
    End Sub
    Sub MunculGrid()
        Call Koneksi()
        DA = New OleDbDataAdapter("Select *From TBL_BARANG", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TBL_BARANG")
        DataGridView1.DataSource = (DS.Tables("TBL_BARANG"))
    End Sub
    Private Sub FormMasterBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()

    End Sub
    Sub MunculKodeKategori()
        Call Koneksi()
        'DA = New OleDbDataAdapter("Select * From TBL_Kategori", CONN)
        'DS = New DataSet
        'DS.Clear()
        'DA.Fill(DS, "TBL_KATEGORI")
        CMD = New OleDbCommand("Select * From TBL_KATEGORI", CONN)
        RD = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(0))
        Loop
    End Sub
    Sub MunculSatuan()
        Call Koneksi()
        CMD = New OleDbCommand("Select Distinct SatuanBarang From TBL_Barang", CONN)
        RD = CMD.ExecuteReader
        ComboBox2.Items.Clear()
        Do While RD.Read
            ComboBox2.Items.Add(RD.Item("SatuanBarang"))
        Loop
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Pastikan Data diisi lengkap")
            Else
                Call Koneksi()
                Dim SimpanData As String = "Insert into TBL_BARANG values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "')"
                CMD = New OleDbCommand(SimpanData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Tambahkan")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        CMD = New OleDbCommand("Select * from TBL_KATEGORI where KodeKategori ='" & ComboBox1.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Label7.Text = RD.Item("NamaKategori")

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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Pastikan Data diisi lengkap")
            Else
                Call Koneksi()
                Dim EditData As String = "Update TBL_BARANG set NamaBarang='" & TextBox2.Text & "',KodeKategori='" & ComboBox1.Text & "',HargaBarang='" & TextBox3.Text & "',JumlahBarang = '" & TextBox4.Text & "',SatuanBarang='" & ComboBox2.Text & "' where KodeBarang='" & TextBox1.Text & "'"
                CMD = New OleDbCommand(EditData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Update")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            CMD = New OleDbCommand("Select * from TBL_BARANG where KodeBarang ='" & TextBox1.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                TextBox2.Text = RD.Item("NamaBarang")
                TextBox3.Text = RD.Item("HargaBarang")
                TextBox4.Text = RD.Item("JumlahBarang")
                ComboBox1.Text = RD.Item("KodeBarang")
                ComboBox2.Text = RD.Item("SatuanBarang")
            Else
                MsgBox("Data Tidak Ada")
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Pastikan Data diisi lengkap")
            Else
                Call Koneksi()
                Dim EditData As String = "Delete from TBL_BARANG where KodeBarang='" & TextBox1.Text & "'"
                CMD = New OleDbCommand(EditData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Hapus")
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
End Class