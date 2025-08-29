<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageList))
        Me.btProses = New System.Windows.Forms.Button
        Me.ilGambar = New System.Windows.Forms.ImageList(Me.components)
        Me.cbPekerjaan = New System.Windows.Forms.ComboBox
        Me.walan = New System.Windows.Forms.ListBox
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.HakCiptaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VersiProgramIniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.TentangKamiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.tsToolbar = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.cmFormIni = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttFormIni = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.tsToolbar.SuspendLayout()
        Me.cmFormIni.SuspendLayout()
        Me.SuspendLayout()
        '
        'btProses
        '
        Me.btProses.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btProses.Location = New System.Drawing.Point(332, 226)
        Me.btProses.Name = "btProses"
        Me.btProses.Size = New System.Drawing.Size(75, 35)
        Me.btProses.TabIndex = 9
        Me.btProses.Text = "Proses"
        Me.btProses.UseVisualStyleBackColor = False
        '
        'ilGambar
        '
        Me.ilGambar.ImageStream = CType(resources.GetObject("ilGambar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilGambar.TransparentColor = System.Drawing.Color.Transparent
        Me.ilGambar.Images.SetKeyName(0, "UCL.jpg")
        Me.ilGambar.Images.SetKeyName(1, "trofi laliga.jpg")
        Me.ilGambar.Images.SetKeyName(2, "treble winner barca.jpg")
        Me.ilGambar.Images.SetKeyName(3, "sixtuple_barca.jpg.jpg")
        Me.ilGambar.Images.SetKeyName(4, "laptop.jpg")
        '
        'cbPekerjaan
        '
        Me.cbPekerjaan.FormattingEnabled = True
        Me.cbPekerjaan.Items.AddRange(New Object() {"Penulis", "Sales", "Sopir", "Marketing"})
        Me.cbPekerjaan.Location = New System.Drawing.Point(12, 199)
        Me.cbPekerjaan.Name = "cbPekerjaan"
        Me.cbPekerjaan.Size = New System.Drawing.Size(395, 21)
        Me.cbPekerjaan.TabIndex = 8
        Me.cbPekerjaan.Text = "Apa Pekerjaan Anda?"
        '
        'walan
        '
        Me.walan.FormattingEnabled = True
        Me.walan.Items.AddRange(New Object() {"Sate Ayam", "Sate Kambing", "Bakso Ayam", "Bakso Sapi", "Soto Padang", "Petai Krispi"})
        Me.walan.Location = New System.Drawing.Point(12, 40)
        Me.walan.Name = "walan"
        Me.walan.Size = New System.Drawing.Size(395, 147)
        Me.walan.TabIndex = 7
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1, Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 356)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(465, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(94, 17)
        Me.ToolStripStatusLabel1.Text = "Freewere Edition"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'HakCiptaToolStripMenuItem
        '
        Me.HakCiptaToolStripMenuItem.Name = "HakCiptaToolStripMenuItem"
        Me.HakCiptaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.HakCiptaToolStripMenuItem.Text = "Hak Cipta"
        '
        'VersiProgramIniToolStripMenuItem
        '
        Me.VersiProgramIniToolStripMenuItem.Name = "VersiProgramIniToolStripMenuItem"
        Me.VersiProgramIniToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.VersiProgramIniToolStripMenuItem.Text = "Versi Program ini"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'TentangKamiToolStripMenuItem
        '
        Me.TentangKamiToolStripMenuItem.Name = "TentangKamiToolStripMenuItem"
        Me.TentangKamiToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TentangKamiToolStripMenuItem.Text = "Tentang Kami"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'tsToolbar
        '
        Me.tsToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.tsToolbar.Location = New System.Drawing.Point(0, 0)
        Me.tsToolbar.Name = "tsToolbar"
        Me.tsToolbar.Size = New System.Drawing.Size(465, 25)
        Me.tsToolbar.TabIndex = 6
        Me.tsToolbar.Text = "ToolStrip1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'cmFormIni
        '
        Me.cmFormIni.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TentangKamiToolStripMenuItem, Me.VersiProgramIniToolStripMenuItem, Me.HakCiptaToolStripMenuItem})
        Me.cmFormIni.Name = "cmFormIni"
        Me.cmFormIni.Size = New System.Drawing.Size(165, 70)
        '
        'ttFormIni
        '
        Me.ttFormIni.ToolTipTitle = "Inforrmasi Penting"
        '
        'ImageList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(465, 378)
        Me.Controls.Add(Me.cbPekerjaan)
        Me.Controls.Add(Me.walan)
        Me.Controls.Add(Me.btProses)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tsToolbar)
        Me.Name = "ImageList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Space En"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tsToolbar.ResumeLayout(False)
        Me.tsToolbar.PerformLayout()
        Me.cmFormIni.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btProses As System.Windows.Forms.Button
    Friend WithEvents ilGambar As System.Windows.Forms.ImageList
    Friend WithEvents cbPekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents walan As System.Windows.Forms.ListBox
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents HakCiptaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersiProgramIniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TentangKamiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmFormIni As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttFormIni As System.Windows.Forms.ToolTip
End Class
