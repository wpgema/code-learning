Public Class menumanustrip

    Private Sub menumanustrip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BukaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BukaToolStripMenuItem.Click
        MsgBox("pesan ini dikaitkan ke event klik dari menu Itemnya manuStrip, yaitu menu Buka")
    End Sub

    Private Sub TutupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupToolStripMenuItem.Click
        End
    End Sub
End Class