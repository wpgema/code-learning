Public Class Form1

    Private Sub Daftar_namaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Daftar_namaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Daftar_namaBindingSource.EndEdit()
        Me.Daftar_namaTableAdapter.Update(Me.DbDesktopMaulanaDataSet.daftar_nama)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDesktopMaulanaDataSet.daftar_nama' table. You can move, or remove it, as needed.
        Me.Daftar_namaTableAdapter.Fill(Me.DbDesktopMaulanaDataSet.daftar_nama)

    End Sub

    Private Sub Daftar_namaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Daftar_namaDataGridView.CellContentClick

    End Sub
End Class
