<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpAritmatika
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpAritmatika))
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNILAIPERTAMA = New System.Windows.Forms.TextBox
        Me.txtHASIL = New System.Windows.Forms.TextBox
        Me.txtNILAIKEDUA = New System.Windows.Forms.TextBox
        Me.ibOperator = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btHASIL = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "KALKULATOR"
        '
        'txtNILAIPERTAMA
        '
        Me.txtNILAIPERTAMA.Location = New System.Drawing.Point(117, 75)
        Me.txtNILAIPERTAMA.Name = "txtNILAIPERTAMA"
        Me.txtNILAIPERTAMA.Size = New System.Drawing.Size(120, 20)
        Me.txtNILAIPERTAMA.TabIndex = 19
        '
        'txtHASIL
        '
        Me.txtHASIL.Location = New System.Drawing.Point(117, 252)
        Me.txtHASIL.Name = "txtHASIL"
        Me.txtHASIL.Size = New System.Drawing.Size(120, 20)
        Me.txtHASIL.TabIndex = 18
        '
        'txtNILAIKEDUA
        '
        Me.txtNILAIKEDUA.Location = New System.Drawing.Point(117, 207)
        Me.txtNILAIKEDUA.Name = "txtNILAIKEDUA"
        Me.txtNILAIKEDUA.Size = New System.Drawing.Size(120, 20)
        Me.txtNILAIKEDUA.TabIndex = 17
        '
        'ibOperator
        '
        Me.ibOperator.FormattingEnabled = True
        Me.ibOperator.Items.AddRange(New Object() {"+", "-", "*", "/", "\", "^", "Mod", "&"})
        Me.ibOperator.Location = New System.Drawing.Point(117, 101)
        Me.ibOperator.Name = "ibOperator"
        Me.ibOperator.Size = New System.Drawing.Size(120, 95)
        Me.ibOperator.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(22, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "NILAI KEDUA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(22, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "NILAI PERTAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(22, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "HASIL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(22, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "OPERATOR"
        '
        'btHASIL
        '
        Me.btHASIL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btHASIL.Location = New System.Drawing.Point(323, 252)
        Me.btHASIL.Name = "btHASIL"
        Me.btHASIL.Size = New System.Drawing.Size(75, 35)
        Me.btHASIL.TabIndex = 11
        Me.btHASIL.Text = "HASIL"
        Me.btHASIL.UseVisualStyleBackColor = True
        '
        'OpAritmatika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(421, 321)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNILAIPERTAMA)
        Me.Controls.Add(Me.txtHASIL)
        Me.Controls.Add(Me.txtNILAIKEDUA)
        Me.Controls.Add(Me.ibOperator)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btHASIL)
        Me.Name = "OpAritmatika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Space En"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNILAIPERTAMA As System.Windows.Forms.TextBox
    Friend WithEvents txtHASIL As System.Windows.Forms.TextBox
    Friend WithEvents txtNILAIKEDUA As System.Windows.Forms.TextBox
    Friend WithEvents ibOperator As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btHASIL As System.Windows.Forms.Button

End Class
