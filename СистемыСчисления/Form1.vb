Public Class Form1

    Private Sub numFrom_ValueChanged(sender As Object, e As EventArgs) Handles numTo.ValueChanged, numFrom.ValueChanged, вход.TextChanged
        рез.Text = FromTo(вход.Text, numFrom.Value, numTo.Value)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
