Imports System.Data.OleDB
Public Class FormTransTerimaBarang
    Sub KondisiAwal()
        LBLTanggal.Text = Today
        LBLAdmin.Text = FormMenuUtama.STLabel4.Text
        Call NomorFakturOtomatis()
        LbAlamatSupplier.Text = ""
        LBLNamaSupplier.Text = ""
        LbTelepon.Text = ""
        Call BuatKolom()
        ComboBox1.Text = ""
        LbSubTotal.Text = "0"

    End Sub




    Sub MunculKodeSupplier()
        Call Koneksi()
        DA = New OleDbDataAdapter("Select * From TBL_SUPPLIER", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "TBL_SUPPLIER")
        CMD = New OleDbCommand("Select * From TBL_SUPPLIER", CONN)
        RD = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(0))
        Loop
    End Sub
    Private Sub FormTransTerimaBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MunculKodeSupplier()
        Call KondisiAwal()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        CMD = New OleDbCommand("Select * From TBL_SUPPLIER where KodeSupplier ='" & ComboBox1.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LBLNamaSupplier.Text = RD!NamaSupplier
            LbAlamatSupplier.Text = RD!AlamatSupplier
            LbTelepon.Text = RD!TelpSupplier

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LbJam.Text = TimeOfDay
    End Sub
    Sub NomorFakturOtomatis()
        Call Koneksi()
        CMD = New OleDbCommand("Select * From TBL_TERIMA where NoTerima in (select max(NoTerima) From TBL_TERIMA)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            UrutanKode = "T" + Format(Now, "ddMMyy") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 9) + 1
            UrutanKode = "T" + Format(Now, "ddMMyy") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoTerima.Text = UrutanKode
    End Sub
    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("SubTotal", "SubTotal")
    End Sub
    Private Sub TbKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            CMD = New OleDbCommand("Select * From TBL_BARANG where KodeBarang ='" & TbKode.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("Data Tidak Ada")
            Else
                TbKode.Text = RD.Item("KodeBarang")
                TbNamaBarang.Text = RD.Item("NamaBarang")
                TbHargaBarang.Text = RD.Item("HargaBarang")

            End If
        End If
    End Sub

    Private Sub BtInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtInsert.Click
        If TbNamaBarang.Text = "" Or TbJumlah.Text = "" Then
            MsgBox("Silahkan masukkan kode barang dan tekan ENTER")
        Else
            DataGridView1.Rows.Add(New String() {TbKode.Text, TbNamaBarang.Text, TbHargaBarang.Text, TbJumlah.Text, Val(TbHargaBarang.Text) * Val(TbJumlah.Text)})
            Call RumusSubTotal()
            TbKode.Text = ""
            TbNamaBarang.Text = ""
            TbHargaBarang.Text = ""
            TbJumlah.Text = ""
            TbJumlah.Enabled = True
            Call RumusCariItem()
        End If
    End Sub
    Sub RumusSubTotal()
        Dim Hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Hitung = Hitung + DataGridView1.Rows(i).Cells(4).Value
            LbSubTotal.Text = Hitung
        Next
    End Sub
    Sub RumusCariItem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(3).Value

        Next
    End Sub
    Private Sub BtSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LBLNamaSupplier.Text = "" Or LbSubTotal.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silahkan Lakukan Transaksi Terlebih Dahulu")
        Else
            Dim SimpanTerima As String = "Insert into TBL_TERIMA values ('" & LBLNoTerima.Text & "', '" & LBLTanggal.Text & "', '" & LbJam.Text & "', '" & LbSubTotal.Text & "', '" & ComboBox1.Text & "', '" & FormMenuUtama.STLabel2.Text & "')"
            CMD = New OleDbCommand(SimpanTerima, CONN)
            CMD.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SimpanDetailTerima As String = "Insert into TBL_DETAILTERIMA values ('" & LBLNoTerima.Text & "', '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "', '" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                CMD = New OleDbCommand(SimpanDetailTerima, CONN)
                CMD.ExecuteNonQuery()

                CMD = New OleDbCommand("Select * From TBL_BARANG where KodeBarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                Dim TambahStok As String = "Update TBL_BARANG set JumlahBarang= '" & RD.Item("JumlahBarang") + DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeBarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                CMD = New OleDbCommand(TambahStok, CONN)
                CMD.ExecuteNonQuery()
            Next
            Call KondisiAwal()
            MsgBox("Transaksi Telah Berhasil Disimpan")
        End If
    End Sub

    Private Sub BtTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LbNama2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class