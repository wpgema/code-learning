Public Class OpAritmatika

    Private Sub btHASIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHASIL.Click
        Dim varA As Integer = Me.txtNILAIPERTAMA.Text
        Dim varB As Integer = Me.txtNILAIKEDUA.Text
        If Me.ibOperator.Text = "+" Then
            Me.txtHASIL.Text = varA + varB
        ElseIf Me.ibOperator.Text = "-" Then
            Me.txtHASIL.Text = varA - varB
        ElseIf Me.ibOperator.Text = "*" Then
            Me.txtHASIL.Text = varA * varB
        ElseIf Me.ibOperator.Text = "/" Then
            Me.txtHASIL.Text = varA / varB
        ElseIf Me.ibOperator.Text = "\" Then
            Me.txtHASIL.Text = varA \ varB
        ElseIf Me.ibOperator.Text = "Mod" Then
            Me.txtHASIL.Text = varA Mod varB
        ElseIf Me.ibOperator.Text = "&" Then
            Me.txtHASIL.Text = varA & varB
        ElseIf Me.ibOperator.Text = "^" Then
            Me.txtHASIL.Text = varA ^ varB
        End If
    End Sub
End Class
