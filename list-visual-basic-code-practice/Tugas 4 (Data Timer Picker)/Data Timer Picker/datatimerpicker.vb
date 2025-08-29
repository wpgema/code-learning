Public Class datatimerpicker

    Private Sub datatimerpicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MsgBox(" Anda memilih tanngal : " + Me.DateTimePicker1.Value.Day.ToString + " ,Bulan : " + Me.DateTimePicker1.Value.Month.ToString + " ,Tahun : " + Me.DateTimePicker1.Value.Year.ToString)
    End Sub

End Class
