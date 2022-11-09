Public Class AccountTest
    ' create and manipulate and Account object
    ' display the initial account balance when program executes

    Private account As New Account() ' create an Account object

    Private Sub AccountTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim accountBalanceValueLabel As Object = Nothing
        accountBalanceValueLabel.Text = String.Format("{0:C}", account.Balance)
    End Sub

    Private Sub depositButton_Click(sender As Object, e As EventArgs) Handles depositButton.Click
        Try
            'get deposit amount
            Dim depositAmount As Decimal = Convert.ToDecimal(inputTextBox.Text)
            account.Deposit(depositAmount)
            accountBalanceValueLabel.Text = String.Format("{0:C}", account.Balance)
        Catch ex As Exception
            If ex.GetType().ToString().Equals("System.FormatException") Then
                MessageBox.Show("Provide integer values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.GetType.ToString.Equals("System.ArgumentOutOfRangeException") Then
                MessageBox.Show("Deposit amount must be positive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try

        inputTextBox.Clear() 'clear the inputTextBox
        inputTextBox.Focus() 'allow user to type in the inputTextBox
    End Sub

    Private Sub withdrawButton_Click(sender As Object, e As EventArgs) Handles withdrawButton.Click
        Try
            'get withdrawal amount
            Dim withdrawalAmount As Decimal = Convert.ToDecimal(inputTextBox.Text)
            account.Withdrawal(withdrawalAmount)
            accountBalanceValueLabel.Text = String.Format("{0:C}", account.Balance)
        Catch ex As Exception
            If ex.GetType().ToString().Equals("System.FormatException") Then
                MessageBox.Show("Provide integer values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.GetType.ToString.Equals("System.ArgumentOutOfRangeException") Then
                MessageBox.Show("Withdraw amount must be greater than 0 " & "and less than or equal to the account balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try

        inputTextBox.Clear() 'clear the inputTextBox
        inputTextBox.Focus() 'allow user to type in the inputTextBox
    End Sub
End Class
