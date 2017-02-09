Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = txtNum.Text
        Dim nTo As Integer = txtTo.Text
        txtRez.Text = from10(n, nTo)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As String = txtRez.Text
        Dim nTo As Integer = txtTo2.Text
        txtRez2.Text = to10(n, nTo)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        рез.Text = FromTo(вход.Text, основание1.Text, основание2.Text)
    End Sub
End Class
