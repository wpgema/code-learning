<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransTerimaBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransTerimaBarang))
        Me.BtInsert = New System.Windows.Forms.Button
        Me.TbJumlah = New System.Windows.Forms.TextBox
        Me.TbKode = New System.Windows.Forms.TextBox
        Me.LbNama1 = New System.Windows.Forms.Label
        Me.LbHarga = New System.Windows.Forms.Label
        Me.LbJumlah = New System.Windows.Forms.Label
        Me.LbKodeBarang = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label10 = New System.Windows.Forms.Label
        Me.LbSubTotal = New System.Windows.Forms.Label
        Me.LBLAdmin = New System.Windows.Forms.Label
        Me.LbJam = New System.Windows.Forms.Label
        Me.LBLTanggal = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LBLNamaSupplier = New System.Windows.Forms.Label
        Me.LbAlamatSupplier = New System.Windows.Forms.Label
        Me.LbTelepon = New System.Windows.Forms.Label
        Me.LBLNoTerima = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TbNamaBarang = New System.Windows.Forms.TextBox
        Me.TbHargaBarang = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtInsert
        '
        Me.BtInsert.Location = New System.Drawing.Point(734, 192)
        Me.BtInsert.Name = "BtInsert"
        Me.BtInsert.Size = New System.Drawing.Size(65, 28)
        Me.BtInsert.TabIndex = 134
        Me.BtInsert.Text = "INSERT"
        Me.BtInsert.UseVisualStyleBackColor = True
        '
        'TbJumlah
        '
        Me.TbJumlah.Location = New System.Drawing.Point(667, 195)
        Me.TbJumlah.Name = "TbJumlah"
        Me.TbJumlah.Size = New System.Drawing.Size(61, 20)
        Me.TbJumlah.TabIndex = 133
        '
        'TbKode
        '
        Me.TbKode.Location = New System.Drawing.Point(64, 194)
        Me.TbKode.Name = "TbKode"
        Me.TbKode.Size = New System.Drawing.Size(87, 20)
        Me.TbKode.TabIndex = 132
        '
        'LbNama1
        '
        Me.LbNama1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNama1.Location = New System.Drawing.Point(157, 192)
        Me.LbNama1.Name = "LbNama1"
        Me.LbNama1.Size = New System.Drawing.Size(58, 28)
        Me.LbNama1.TabIndex = 131
        Me.LbNama1.Text = "Nama"
        '
        'LbHarga
        '
        Me.LbHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbHarga.Location = New System.Drawing.Point(390, 192)
        Me.LbHarga.Name = "LbHarga"
        Me.LbHarga.Size = New System.Drawing.Size(53, 28)
        Me.LbHarga.TabIndex = 129
        Me.LbHarga.Text = "Harga"
        '
        'LbJumlah
        '
        Me.LbJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbJumlah.Location = New System.Drawing.Point(583, 192)
        Me.LbJumlah.Name = "LbJumlah"
        Me.LbJumlah.Size = New System.Drawing.Size(76, 28)
        Me.LbJumlah.TabIndex = 127
        Me.LbJumlah.Text = "Jumlah"
        '
        'LbKodeBarang
        '
        Me.LbKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbKodeBarang.Location = New System.Drawing.Point(2, 192)
        Me.LbKodeBarang.Name = "LbKodeBarang"
        Me.LbKodeBarang.Size = New System.Drawing.Size(56, 28)
        Me.LbKodeBarang.TabIndex = 126
        Me.LbKodeBarang.Text = "Kode"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(797, 168)
        Me.DataGridView1.TabIndex = 122
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(330, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 32)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "TOTAL : Rp."
        '
        'LbSubTotal
        '
        Me.LbSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSubTotal.Location = New System.Drawing.Point(540, 29)
        Me.LbSubTotal.Name = "LbSubTotal"
        Me.LbSubTotal.Size = New System.Drawing.Size(259, 33)
        Me.LbSubTotal.TabIndex = 120
        '
        'LBLAdmin
        '
        Me.LBLAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAdmin.Location = New System.Drawing.Point(680, 130)
        Me.LBLAdmin.Name = "LBLAdmin"
        Me.LBLAdmin.Size = New System.Drawing.Size(119, 20)
        Me.LBLAdmin.TabIndex = 119
        '
        'LbJam
        '
        Me.LbJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbJam.Location = New System.Drawing.Point(680, 103)
        Me.LbJam.Name = "LbJam"
        Me.LbJam.Size = New System.Drawing.Size(119, 20)
        Me.LbJam.TabIndex = 118
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Location = New System.Drawing.Point(680, 73)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(119, 20)
        Me.LBLTanggal.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(540, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Jam"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(540, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 20)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Level Admin"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(540, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Tanggal"
        '
        'LBLNamaSupplier
        '
        Me.LBLNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaSupplier.Location = New System.Drawing.Point(140, 86)
        Me.LBLNamaSupplier.Name = "LBLNamaSupplier"
        Me.LBLNamaSupplier.Size = New System.Drawing.Size(380, 20)
        Me.LBLNamaSupplier.TabIndex = 113
        '
        'LbAlamatSupplier
        '
        Me.LbAlamatSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbAlamatSupplier.Location = New System.Drawing.Point(140, 117)
        Me.LbAlamatSupplier.Name = "LbAlamatSupplier"
        Me.LbAlamatSupplier.Size = New System.Drawing.Size(380, 20)
        Me.LbAlamatSupplier.TabIndex = 112
        '
        'LbTelepon
        '
        Me.LbTelepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbTelepon.Location = New System.Drawing.Point(140, 144)
        Me.LbTelepon.Name = "LbTelepon"
        Me.LbTelepon.Size = New System.Drawing.Size(380, 20)
        Me.LbTelepon.TabIndex = 111
        '
        'LBLNoTerima
        '
        Me.LBLNoTerima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoTerima.Location = New System.Drawing.Point(140, 29)
        Me.LBLNoTerima.Name = "LBLNoTerima"
        Me.LBLNoTerima.Size = New System.Drawing.Size(119, 20)
        Me.LBLNoTerima.TabIndex = 110
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(2, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Alamat Supplier"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(2, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Telepon"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(2, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Nama Supplier"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(2, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Kode Supplier"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(140, 59)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(2, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Nomor Terima"
        '
        'TbNamaBarang
        '
        Me.TbNamaBarang.Location = New System.Drawing.Point(236, 192)
        Me.TbNamaBarang.Name = "TbNamaBarang"
        Me.TbNamaBarang.Size = New System.Drawing.Size(100, 20)
        Me.TbNamaBarang.TabIndex = 137
        '
        'TbHargaBarang
        '
        Me.TbHargaBarang.Location = New System.Drawing.Point(463, 195)
        Me.TbHargaBarang.Name = "TbHargaBarang"
        Me.TbHargaBarang.Size = New System.Drawing.Size(100, 20)
        Me.TbHargaBarang.TabIndex = 138
        '
        'FormTransTerimaBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(807, 497)
        Me.Controls.Add(Me.TbHargaBarang)
        Me.Controls.Add(Me.TbNamaBarang)
        Me.Controls.Add(Me.BtInsert)
        Me.Controls.Add(Me.TbJumlah)
        Me.Controls.Add(Me.TbKode)
        Me.Controls.Add(Me.LbNama1)
        Me.Controls.Add(Me.LbHarga)
        Me.Controls.Add(Me.LbJumlah)
        Me.Controls.Add(Me.LbKodeBarang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LbSubTotal)
        Me.Controls.Add(Me.LBLAdmin)
        Me.Controls.Add(Me.LbJam)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LBLNamaSupplier)
        Me.Controls.Add(Me.LbAlamatSupplier)
        Me.Controls.Add(Me.LbTelepon)
        Me.Controls.Add(Me.LBLNoTerima)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransTerimaBarang"
        Me.Text = "Penjulalan Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtInsert As System.Windows.Forms.Button
    Friend WithEvents TbJumlah As System.Windows.Forms.TextBox
    Friend WithEvents TbKode As System.Windows.Forms.TextBox
    Friend WithEvents LbNama1 As System.Windows.Forms.Label
    Friend WithEvents LbHarga As System.Windows.Forms.Label
    Friend WithEvents LbJumlah As System.Windows.Forms.Label
    Friend WithEvents LbKodeBarang As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LbSubTotal As System.Windows.Forms.Label
    Friend WithEvents LBLAdmin As System.Windows.Forms.Label
    Friend WithEvents LbJam As System.Windows.Forms.Label
    Friend WithEvents LBLTanggal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LBLNamaSupplier As System.Windows.Forms.Label
    Friend WithEvents LbAlamatSupplier As System.Windows.Forms.Label
    Friend WithEvents LbTelepon As System.Windows.Forms.Label
    Friend WithEvents LBLNoTerima As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents TbHargaBarang As System.Windows.Forms.TextBox
End Class
