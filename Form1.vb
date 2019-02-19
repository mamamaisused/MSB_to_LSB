''' <summary>
''' 单个字节二进制MSB开头转换为LSB开头
''' </summary>
''' <remarks></remarks>
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtInput.Text = "" Then
            txtInput.Text = 1
        End If
        '二进制显示
        txtInputBinary.Text = Convert.ToString(Convert.ToByte(txtInput.Text), 2)
        '前段补零
        FormatBin(txtInputBinary.Text)
        '十六进制显示2位
        txtInputHex.Text = Convert.ToByte(txtInput.Text).ToString("X2")

        Dim res As Byte
        '二进制数据颠倒
        txtOutpuBinary.Text = InvertBin(txtInputBinary.Text)
        '二进制字符串转换为Byte型
        res = Convert.ToByte(txtOutpuBinary.Text, 2)
        '十六进制显示
        txtOutputHex.Text = res.ToString("X2")

    End Sub

    Public Sub FormatBin(ByRef str As String)
        Dim len As Integer
        len = str.Length
        If len < 8 Then
            For i As Integer = 1 To 8 - len
                str = "0" + str
            Next
        End If
    End Sub

    Public Function InvertBin(_byte As String) As String
        Debug.Print("Start:")
        Dim bit(8) As String
        Dim tmp As String
        tmp = _byte
        For i As Integer = 0 To 7
            bit(i) = Mid(tmp, i + 1, 1)
            Debug.Print(bit(i))
        Next
        tmp = ""
        For j As Integer = 7 To 0 Step -1
            tmp = tmp + bit(j)
        Next
        Return tmp
    End Function
End Class
