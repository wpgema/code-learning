Public Class belajarvbnet

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pertanyaan, NamaAnda As String
        pertanyaan = "siapa nama anda?"
        NamaAnda = InputBox(pertanyaan)
        MsgBox("Nama Anda " + NamaAnda)
    End Sub

End Class
