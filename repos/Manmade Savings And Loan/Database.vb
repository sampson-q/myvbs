Public Class Database ' this class is to help set and get various account details
    Dim accountNumbers(40) As String ' declaring array of size 40 to hold account number
    Dim usernames(40) As String ' declaring array of size 40 to hold usernames
    Dim passwords(40) As String ' declaring array of size 40 to hold passwords
    Dim accountBalances(40) As Decimal ' declaring array of size 40 to hold account balances
    Dim loans(40) As Decimal ' declaring array of size 40 to hold loans

    ' writing up a functiton to get account numbers
    Function getAccountNumbers() As Array
        Return accountNumbers ' setting the value of the function to the accountNumbers array
    End Function

    ' writing a function to get account passwords
    Function getAccountPasswords() As Array
        Return passwords ' setting the value of the function to the passwords array
    End Function

    ' writing a function to get usernames
    Function getUsernames() As Array
        Return usernames ' setting the value of the function to the usernames array
    End Function

    ' function to return the loans array
    Function getLoans() As Array
        Return loans
    End Function

    'Note that functions have return values. And that, subs are functions without return values

    ' writing a sub to set some account details
    ' it picks positions as integer, accountNumber as String, username as String and password as String; as parameters
    Sub setAccountDetails(position As Integer, accountNumber As String, username As String, password As String)
        Me.accountNumbers(position) = accountNumber ' set accountNumber index positition to accountNumber parameter
        Me.usernames(position) = username ' set usernames index position to username parameter
        Me.passwords(position) = password ' set passwords index position to password paramter
    End Sub

    ' writing a sub to set account balance. picks position and amount as arguments/parameters
    Sub setAccountBalance(position As Integer, amount As Decimal)
        Me.accountBalances(position) = amount ' sets accountBalances index position to amount
    End Sub

    ' writing a function to get account balance
    Function getAccountBalance(position As Integer) As Decimal
        Return accountBalances(position) ' setting the value of the function to accountBalances index position
    End Function

    ' writing a sub to set loans
    Sub setLoans(position As Integer, amount As Decimal)
        Me.loans(position) = amount ' setting the loan
    End Sub

End Class
