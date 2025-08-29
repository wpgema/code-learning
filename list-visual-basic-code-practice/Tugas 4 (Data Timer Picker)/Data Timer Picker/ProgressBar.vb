Public Class ProgressBar

    Private Sub ProgressBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.pbLoading.Value += 2
        If Me.pbLoading.Value <= 30 Then
            Me.Text = "Aplikasi sedang Inisiasi"
        ElseIf Me.pbLoading.Value <= 50 Then
            Me.Text = "Aplikasi hampir setengah jalan"
        ElseIf Me.pbLoading.Value <= 75 Then
            Me.Text = "Aplikasi sudah mau sempurna"
        ElseIf Me.pbLoading.Value <= 100 Then
            Me.Text = "Silahkan tunngu, Aplikasi hampir selesai"
            If Me.pbLoading.Value = 100 Then
                Me.Timer1.Dispose()

            End If

        End If
    End Sub
End Class