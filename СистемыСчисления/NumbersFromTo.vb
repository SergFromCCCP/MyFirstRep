Module NumbersFromTo
    Dim validChars As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"

    Private Function isValidNumber(num As String, n As Integer) As Boolean
        For Each v As Char In num.ToUpper
            If Not validChars.Contains(v) OrElse validChars.IndexOf(v) >= n Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function FromTo(ByVal num As String, ByVal nFrom As Integer, ByVal nTo As Integer) As String
        If Math.Min(nFrom, nTo) < 2 OrElse Math.Max(nFrom, nTo) > validChars.Length Then
            MessageBox.Show("Ошибка системы счисления")
            Return ""
        End If
        If isValidNumber(num, nFrom) Then
            Return from10(to10(num.ToUpper, nFrom), nTo)
        Else
            MessageBox.Show("Ошибка входного числа")
            Return ""
        End If
    End Function

    Public Function from10(ByVal num As Integer, ByVal nTo As Integer) As String
        If nTo <= validChars.Length Then
            Dim s As String = ""
            Dim i As Integer
            Do
                i = num Mod nTo
                s = validChars(i) & s
                num = Int(num / nTo)
            Loop While num > 0
            Return s
        Else
            Return ""
        End If
    End Function

    Public Function to10(ByVal num As String, ByVal nFrom As Integer) As Integer
        Dim n As Integer = 1
        Dim rez As Integer = 0
        For Each v As Char In num.Reverse
            rez += n * validChars.IndexOf(v)
            n *= nFrom
        Next
        Return rez
    End Function
End Module
