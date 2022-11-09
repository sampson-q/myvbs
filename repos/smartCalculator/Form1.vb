Public Class calculator
    Dim num1, num2 As Double
    Dim oprClickCount As Integer = 0
    Dim isOprClick As Boolean = False
    Dim isEqualClick As Boolean = False
    Dim opr As String

    Private Sub calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each c As Control In Controls
            If c.GetType() = GetType(Button) Then
                If Not c.Text.Equals("Reset") Then
                    AddHandler c.Click, AddressOf resetBtn_Click
                End If
            End If
        Next
    End Sub

    Private Sub equBtn_Click(sender As Object, e As EventArgs) Handles equalBtn.Click
        Dim button As Button = sender
        If Not isOperator(button) Then
            If isOprClick Then
                num1 = Double.Parse(screen.Text)
                screen.Text = ""
            End If

            If Not screen.Text.Contains(".") Then
                If screen.Text.Equals("0") AndAlso Not button.Text.Equals(".") Then
                    screen.Text = button.Text
                    isOprClick = False

                Else
                    screen.Text += button.Text
                    isOprClick = False
                End If

            ElseIf Not button.Text.Equals(".") Then
                screen.Text += button.Text
                isOprClick = False
            End If

        Else
            If oprClickCount = 0 Then
                oprClickCount += 0
                num1 = Double.Parse(screen.Text)
                opr = button.Text
                isOprClick = True

            Else
                If Not button.Text.Equals("=") Then
                    If Not isEqualClick Then
                        num2 = Double.Parse(screen.Text)
                        screen.Text = Convert.ToString(calc(opr, num1, num2))
                        num2 = Double.Parse(screen.Text)
                        opr = button.Text
                        isOprClick = True
                        isEqualClick = False

                    Else
                        isEqualClick = False
                        opr = button.Text
                    End If

                Else
                    num2 = Double.Parse(screen.Text)
                    screen.Text = Convert.ToString(calc(opr, num1, num2))
                    num1 = Double.Parse(screen.Text)
                    isOprClick = True
                    isEqualClick = True
                End If
            End If

        End If
    End Sub

    Private Function calc(opr As String, num1 As Double, num2 As Double) As Boolean
        Dim result As Double
        result = 0
        Select Case opr
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "X"
                result = num1 * num2
            Case "/"
                result = num1 / num2
        End Select
        Return result
    End Function

    Private Function isOperator(ByVal btn As Button) As Boolean
        Dim btnTxt As String
        btnTxt = btn.Text
        If (btnTxt.Equals("+") Or btnTxt.Equals("-") Or btnTxt.Equals("/") Or btnTxt.Equals("X") Or btnTxt.Equals("=")) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub oneBtn_Click(sender As Object, e As EventArgs) Handles oneBtn.Click
        screen.Text = "1"

    End Sub



    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        num1 = 0
        num2 = 0
        opr = ""
        oprClickCount = 0
        isOprClick = False
        isEqualClick = False
        screen.Text = ""
    End Sub



End Class
