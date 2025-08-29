Public Class ImageList

    Private Sub ImageList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStripButton1.Image = Me.ilGambar.Images.Item(1)
        Me.ToolStripButton1.Image = Me.ilGambar.Images.Item(2)
        Me.ToolStripButton1.Image = Me.ilGambar.Images.Item(3)
    End Sub

    Private Sub btProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProses.Click
        MsgBox(" Makanan anda adalah : " + Me.walan.SelectedItem.ToString + "Hobi anda adalah: " + Me.cbPekerjaan.SelectedItem.ToString, "Demo ListBox dan Combobox")

    End Sub
End Class