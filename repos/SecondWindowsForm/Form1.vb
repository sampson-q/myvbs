Public Class Form1
    Private Sub resltBtn_Click(sender As Object, e As EventArgs) Handles resltBtn.Click
        Try
            Dim result As Integer
            Dim firstNum, secondNum As Integer
            firstNum = firstNumber.Text
            secondNum = secondNumber.Text

            If addChk.Checked Then
                result = firstNum + secondNum
                MessageBox.Show(result)

            ElseIf subChk.Checked Then
                result = firstNum - secondNum
                MessageBox.Show(result)

            ElseIf mulChk.Checked Then
                result = firstNum * secondNum
                MessageBox.Show(result)

            ElseIf divChk.Checked Then
                result = firstNum / secondNum
                MessageBox.Show(result)
            End If
        Catch ex As Exception
            MessageBox.Show("No Blank Feild & Non-Int Values Allowed!")
        End Try

    End Sub

    Private Sub addChk_CheckedChanged(sender As Object, e As EventArgs) Handles addChk.CheckStateChanged
        If addChk.CheckState = 1 Then
            subChk.CheckState = 0
            mulChk.CheckState = 0
            divChk.CheckState = 0
        End If
    End Sub

    Private Sub subChk_CheckedChanged(sender As Object, e As EventArgs) Handles subChk.CheckedChanged
        If subChk.CheckState = 1 Then
            addChk.CheckState = 0
            mulChk.CheckState = 0
            divChk.CheckState = 0
        End If
    End Sub

    Private Sub mulChk_CheckedChanged(sender As Object, e As EventArgs) Handles mulChk.CheckedChanged
        If mulChk.CheckState = 1 Then
            addChk.CheckState = 0
            subChk.CheckState = 0
            divChk.CheckState = 0
        End If
    End Sub

    Private Sub divChk_checkedChaged(sender As Object, e As EventArgs) Handles divChk.CheckedChanged
        If divChk.CheckState = 1 Then
            addChk.CheckState = 0
            subChk.CheckState = 0
            mulChk.CheckState = 0
        End If
    End Sub
End Class
