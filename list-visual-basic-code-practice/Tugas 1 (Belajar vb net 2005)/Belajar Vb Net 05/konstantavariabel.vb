Public Class konstantavariabel


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Const pi As Double = 3.14159265
        Dim Luas As Double
        Dim JariJari As Double
        JariJari = Me.txtJARI.Text
        Luas = pi * JariJari * JariJari
        Me.txtHASIL.Text = Luas.ToString
    End Sub


End Class