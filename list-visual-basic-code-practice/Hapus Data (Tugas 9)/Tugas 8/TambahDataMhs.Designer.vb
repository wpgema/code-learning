<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahDataMhs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahDataMhs))
        Me.txtTTL = New System.Windows.Forms.TextBox
        Me.btBatal = New System.Windows.Forms.Button
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.txtAlamatOrtu = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPekerjaan = New System.Windows.Forms.TextBox
        Me.txtNmOrtu = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNEM = New System.Windows.Forms.TextBox
        Me.txtNIM = New System.Windows.Forms.TextBox
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtSMU = New System.Windows.Forms.TextBox
        Me.txtLulus = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboAngkatan = New System.Windows.Forms.ComboBox
        Me.cboAgama = New System.Windows.Forms.ComboBox
        Me.cboKelamin = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btSimpan = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTTL
        '
        Me.txtTTL.Location = New System.Drawing.Point(108, 118)
        Me.txtTTL.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTTL.Name = "txtTTL"
        Me.txtTTL.Size = New System.Drawing.Size(207, 23)
        Me.txtTTL.TabIndex = 36
        '
        'btBatal
        '
        Me.btBatal.BackgroundImage = CType(resources.GetObject("btBatal.BackgroundImage"), System.Drawing.Image)
        Me.btBatal.Location = New System.Drawing.Point(302, 550)
        Me.btBatal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(62, 40)
        Me.btBatal.TabIndex = 32
        Me.btBatal.Text = "Batal"
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(108, 210)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(207, 23)
        Me.txtAlamat.TabIndex = 37
        '
        'txtAlamatOrtu
        '
        Me.txtAlamatOrtu.Location = New System.Drawing.Point(111, 75)
        Me.txtAlamatOrtu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAlamatOrtu.Name = "txtAlamatOrtu"
        Me.txtAlamatOrtu.Size = New System.Drawing.Size(204, 23)
        Me.txtAlamatOrtu.TabIndex = 34
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAlamatOrtu)
        Me.GroupBox3.Controls.Add(Me.txtPekerjaan)
        Me.GroupBox3.Controls.Add(Me.txtNmOrtu)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(44, 434)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(319, 110)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Identitas Orang Tua/Wali"
        '
        'txtPekerjaan
        '
        Me.txtPekerjaan.Location = New System.Drawing.Point(111, 45)
        Me.txtPekerjaan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPekerjaan.Name = "txtPekerjaan"
        Me.txtPekerjaan.Size = New System.Drawing.Size(204, 23)
        Me.txtPekerjaan.TabIndex = 33
        '
        'txtNmOrtu
        '
        Me.txtNmOrtu.Location = New System.Drawing.Point(111, 15)
        Me.txtNmOrtu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNmOrtu.Name = "txtNmOrtu"
        Me.txtNmOrtu.Size = New System.Drawing.Size(204, 23)
        Me.txtNmOrtu.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(4, 78)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Alamat Orang Tua"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(4, 19)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 17)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Nama Orang Tua"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(4, 45)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Pekerjaan"
        '
        'txtNEM
        '
        Me.txtNEM.Location = New System.Drawing.Point(105, 59)
        Me.txtNEM.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNEM.Name = "txtNEM"
        Me.txtNEM.Size = New System.Drawing.Size(71, 23)
        Me.txtNEM.TabIndex = 32
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(108, 57)
        Me.txtNIM.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(207, 23)
        Me.txtNIM.TabIndex = 35
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(108, 27)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(207, 23)
        Me.txtNama.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNEM)
        Me.GroupBox2.Controls.Add(Me.txtSMU)
        Me.GroupBox2.Controls.Add(Me.txtLulus)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(42, 335)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(322, 92)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asal Sekolah"
        '
        'txtSMU
        '
        Me.txtSMU.Location = New System.Drawing.Point(105, 25)
        Me.txtSMU.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSMU.Name = "txtSMU"
        Me.txtSMU.Size = New System.Drawing.Size(212, 23)
        Me.txtSMU.TabIndex = 31
        '
        'txtLulus
        '
        Me.txtLulus.Location = New System.Drawing.Point(259, 59)
        Me.txtLulus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtLulus.Name = "txtLulus"
        Me.txtLulus.Size = New System.Drawing.Size(58, 23)
        Me.txtLulus.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(180, 62)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Status Lulus"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(14, 59)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "NEM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(14, 29)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "SMU Asal"
        '
        'cboAngkatan
        '
        Me.cboAngkatan.FormattingEnabled = True
        Me.cboAngkatan.Location = New System.Drawing.Point(108, 148)
        Me.cboAngkatan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboAngkatan.Name = "cboAngkatan"
        Me.cboAngkatan.Size = New System.Drawing.Size(101, 23)
        Me.cboAngkatan.TabIndex = 33
        '
        'cboAgama
        '
        Me.cboAgama.FormattingEnabled = True
        Me.cboAgama.Items.AddRange(New Object() {"Islam", "Non Islam"})
        Me.cboAgama.Location = New System.Drawing.Point(108, 179)
        Me.cboAgama.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboAgama.Name = "cboAgama"
        Me.cboAgama.Size = New System.Drawing.Size(101, 23)
        Me.cboAgama.TabIndex = 32
        '
        'cboKelamin
        '
        Me.cboKelamin.FormattingEnabled = True
        Me.cboKelamin.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboKelamin.Location = New System.Drawing.Point(108, 87)
        Me.cboKelamin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboKelamin.Name = "cboKelamin"
        Me.cboKelamin.Size = New System.Drawing.Size(101, 23)
        Me.cboKelamin.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(15, 182)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Agama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(16, 151)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Tahun Ajaran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(16, 121)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "TTL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(16, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Jenis Kelamin"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtTTL)
        Me.GroupBox1.Controls.Add(Me.txtNIM)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.cboAngkatan)
        Me.GroupBox1.Controls.Add(Me.cboAgama)
        Me.GroupBox1.Controls.Add(Me.cboKelamin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(42, 90)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(320, 238)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identitas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(15, 213)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(16, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(15, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Tambah Data Mahasiswa"
        '
        'btSimpan
        '
        Me.btSimpan.BackgroundImage = CType(resources.GetObject("btSimpan.BackgroundImage"), System.Drawing.Image)
        Me.btSimpan.Location = New System.Drawing.Point(236, 550)
        Me.btSimpan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(62, 40)
        Me.btSimpan.TabIndex = 33
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpanToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 26)
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'TambahDataMhs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(405, 600)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "TambahDataMhs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INPUT DATA"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTTL As System.Windows.Forms.TextBox
    Friend WithEvents btBatal As System.Windows.Forms.Button
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamatOrtu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents txtNmOrtu As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNEM As System.Windows.Forms.TextBox
    Friend WithEvents txtNIM As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSMU As System.Windows.Forms.TextBox
    Friend WithEvents txtLulus As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboAngkatan As System.Windows.Forms.ComboBox
    Friend WithEvents cboAgama As System.Windows.Forms.ComboBox
    Friend WithEvents cboKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SimpanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
