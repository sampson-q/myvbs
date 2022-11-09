Public Class dashboard ' this is the part of the project which shows after a succesfull login
    Dim rate As Double ' declaring a rate variable as double
    Dim amount As Decimal ' declaring amount variable as decimal
    Dim period As Integer
    Dim interestLoan As Decimal

    ' sub to handle the click event of the logout button
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close() ' close this class. don't forget it's the dashboard class
        home.Show() ' show the home class
    End Sub

    ' sub to handle the loading of this class
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set withdrawal label to show the account number. note the code format for the concatenated part. it's home.accountNumber.Text
        ' which means that 'accountNumber.Text' is an attribute or a field from the 'home' class
        withdrawalLabel.Text = "Withdrawal From Acc. No: " & home.accountNumber.Text
        depositLabel.Text = "Deposit To Acc. No: " & home.accountNumber.Text ' same applies here for the deposit label
        usernameLabel.Text = "Welcome, " & home.username & "!" ' here, we set usernameLabel's text to the home's username property

        ' set the currentLoan text. what happens here is we get the userID from the home class.
        ' then we pass it as an index to the getLoans array from the database instance in the home class
        currentLoan.Text = String.Format("{0:C}", home.database.getLoans(home.userID))
        ' do same for the account balance
        accountBalanceTxt.Text = String.Format("{0:C}", home.database.getAccountBalance(home.userID))
    End Sub

    ' sub to handle the click even of the withdraw button
    Private Sub withdrawBtn_Click(sender As Object, e As EventArgs) Handles withdrawBtn.Click
        Try ' try
            Dim amount As Decimal = Convert.ToDecimal(withdrawalAmount.Text) ' convert the text from the withdrawal text feild to decimal

            ' check if the amount is greater than the amount balance
            If amount > home.database.getAccountBalance(home.userID) Then
                MsgBox("Insufficient Funds!", MsgBoxStyle.Exclamation, "Withdrawal Error") ' then tell the user they have insufficient funds
            ElseIf amount <= 0D Then ' also check if the amount is less than or equal to zero
                MsgBox("Insufficient Funds!", MsgBoxStyle.Exclamation, "Withdrawal Error") ' then tell the user they can provide values equal or less than zero
            Else ' otherwise, get the amount from home class, subtract the amount from it and set the account balance (from home class) with the userID (from home class)
                home.database.setAccountBalance(home.userID, (home.database.getAccountBalance(home.userID) - amount))
                accountBalanceTxt.Text = String.Format("{0:C}", home.database.getAccountBalance(home.userID)) ' update the account balance text
            End If

            withdrawalAmount.Text = "" ' clear with withdraw amount textbox
            withdrawalAmount.Focus() ' focus on the withdraw amount textbox
        Catch ex As Exception
            MsgBox("Provide Integers!", MsgBoxStyle.Exclamation, "Invalid Amount") ' tell the user to provide integer
        End Try
    End Sub

    ' sub to handle the click event of the deposit button
    Private Sub depositBtn_Click(sender As Object, e As EventArgs) Handles depositBtn.Click
        Try
            ' declare the amount as usual. this time, converting the text from the deposit amount textbox to decimal
            Dim amount As Decimal = Convert.ToDecimal(depositAmount.Text)

            ' if the deposit amount is less than zero
            If amount <= 0D Then
                MsgBox("Invalid Deposit Amount!", MsgBoxStyle.Exclamation, "Deposit Error") ' tell the user the amount is invalid
            Else ' otherwise,
                ' get the existing balance, add the amount to it and set it back to the balance again
                home.database.setAccountBalance(home.userID, (home.database.getAccountBalance(home.userID) + amount))
                accountBalanceTxt.Text = String.Format("{0:C}", home.database.getAccountBalance(home.userID)) ' rewrite it in the accountBalance textbox
            End If
        Catch ex As Exception
            MsgBox("Enter Deposit Amount!", MsgBoxStyle.Exclamation, "Deposit Error") ' tell the user to enter a deposit amount
        End Try

        depositAmount.Text = "" ' clear the deposit amount text box
        depositAmount.Focus() ' and focus on it
    End Sub

    ' a function to calculate the interest for loans. this goes with a customized loan ranges.
    ' this function takes amount and period as decimal and integers respectively.
    Private Function calculateInterest(amount As Decimal, period As Integer) As Decimal
        If amount <= 650 Then ' and checks if the amount is less than or euqal to 650
            rate = 0.05 ' then sets the rate to 5% if true

            ' return the interest by multiplying the amount by the rate and the period and dividing it my 100
            Return ((amount * rate * period) / 100)
        ElseIf amount > 650 Then ' same checks here too. only that it checks if the amount is greater than 650
            rate = 0.08 ' then sets the rate to 8% if true
            Return ((amount * rate * period) / 100)
        ElseIf amount > 880 Then ' same here
            rate = 0.21 ' rate for 21%
            Return ((amount * rate * period) / 100)
        ElseIf amount > 1200 Then
            rate = 0.26
            Return ((amount * rate * period) / 100)
        ElseIf amount <= 1300 Then
            rate = 0.3
            Return ((amount * rate * period) / 100)
        ElseIf amount > 1300 Then
            rate = 0.8
            Return ((amount * rate * period) / 100)
        End If

        Return 0.00
    End Function

    ' this sub handles the text-changed event of the loan amount textbox
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles loanAmount.TextChanged
        Try
            If loanAmount.Text <> "" And loanPeriod.Text <> "" Then ' if the text in loan amount and loan period is not empty
                amount = Convert.ToDecimal(loanAmount.Text) ' convert the text in loan amount text feild to decimal
                period = Convert.ToInt16(loanPeriod.Text) ' do same for the text in period text feild
                interest.Text = String.Format("Interest: {0:C}", calculateInterest(amount, period)) ' set the text of the interest text box to the calculated interest
                applyLoan.Enabled() = 1 ' enable the apply loan button
            Else
                interest.ResetText() ' reset the text in the interest text-box
                applyLoan.Enabled() = 0 ' disable the apply loan button
            End If
        Catch ex As Exception
            loanAmount.ResetText() 'reset the text in loan amount
            applyLoan.Enabled() = 0 ' disable the apply loan button
            MsgBox("Provide Valid Amount!", MsgBoxStyle.Exclamation, "Loan Error") ' tell the user to provide a valid loan amount
        End Try
    End Sub

    ' sub that handles the click event to the apply loan button
    Private Sub applyLoan_Click(sender As Object, e As EventArgs) Handles applyLoan.Click
        ' declare userChoice as a message box showing all the information they need to know about the loan they are applying for
        ' this includes the loan amount, the interest rate, the interest, etc. this allows the user to confirm his loan
        If amount > 5000 Then
            MsgBox("Your loan amount exceeded Manmade's Loan Limit!", MsgBoxStyle.Exclamation, "Loan Error") ' tell the user his amount has exceeded the loan limit
            loanAmount.ResetText() ' reset the loan amount text box
            loanPeriod.ResetText() ' reset the period textbox
        Else
            Dim userChoice = MsgBox("Your Loan Application Details: " & vbCrLf & vbCrLf &
                                String.Format("Loan Amount: {0:C}", amount) &
                                vbCrLf & "Period / Time: " & period & " years" &
                                vbCrLf & "Rate: " & (rate * 100) & "%" & vbCrLf &
                                String.Format("Interest: {0:C}", calculateInterest(amount, period)) & vbCrLf &
                                String.Format("Amount Payable: {0:C}", calculateInterest(amount, period) + amount) & vbCrLf &
                                vbCrLf & "Do you wish to continue loan application?", MsgBoxStyle.YesNo, "Confirm Loan Application")
            ' if the user choice is 6; means that if the user confirms by clicking yes,
            If userChoice = 6 Then
                ' set the loan
                home.database.setLoans(home.userID, home.database.getLoans(home.userID) + (calculateInterest(amount, period) + amount))
                ' refresh the currentLoan textbox to the current loan
                currentLoan.Text = String.Format("{0:C}", home.database.getLoans(home.userID))
                loanAmount.ResetText() ' reset the loan amount text box
                loanPeriod.ResetText() ' reset the period textbox
            Else ' otherwise
                loanPeriod.ResetText() ' reset the period text box
                loanAmount.ResetText() ' do same for the loan amount text box
            End If
        End If
    End Sub

    ' sub that handles the textchanged event of the loan period text box
    Private Sub loanPeriod_TextChanged(sender As Object, e As EventArgs) Handles loanPeriod.TextChanged
        loanAmount.ResetText() ' it resets the loan amount text box
    End Sub
End Class