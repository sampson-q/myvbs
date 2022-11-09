Public Class home ' this is the first class; the login page. here, we find all elements of the login page here including all events associated with the elements
    Public database As New Database() ' creating an instance of the database class. with this, we can have access to all fields and properties in the database class
    Dim errorText As String ' errorText variable as string
    Public username As String ' public string variable, username
    Private userIndex As Integer ' userindex as integer

    ' sub for to handle login button's click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If accountNumber.Text = "" And accountPassword.Text = "" Then ' first, we check if accountNumber provided is empty or not. we do same for password
            MsgBox("Fill out all forms", MsgBoxStyle.Exclamation, "Empty Feilds") ' if they both empty, use a message box to give out a warning
        Else ' else
            If login(accountNumber.Text, accountPassword.Text) Then ' if true in terms of login with accountnumber and password
                Me.Hide() ' hide this class
                dashboard.Show() ' show the dashboard form
                accountNumber.ResetText() ' reset the account number to empty
                accountPassword.ResetText() ' do smae for account password
            Else ' else; that means if false in terms of login with account number and password
                MsgBox("Invalid Username or Password", MsgBoxStyle.Exclamation, "Login Failed") ' tell the user that the provided credentials are invalid
                accountNumber.Focus() ' focus on the accountnumber textbox
            End If
        End If
    End Sub

    ' function to handle this class's form. when ever this this form is loaded, this sub runs
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' we call the setAccountDetails sub and we pass the necessary parameters to set an account
        ' don't forget that this is a method we've gotten from the database instance
        database.setAccountDetails(0, "1234567899", "Vera Adams", "summer12") ' here we set first account
        database.setAccountDetails(1, "1234567890", "Mark Dronney", "bluesky")
        ' don't forget the about the parameters we set for it. first is the position, second is the account number, third is username and fourth is the password
    End Sub

    ' writing a function to help us login. it returns a boolean value after checking if the account number with the password provided by the user is correct
    Private Function login(accNumb, accPass) As Boolean ' take account number and account password as parameters or arguments
        Try ' try
            For i = 0 To database.getAccountNumbers.Length ' for i equals 0 to the length of accountNumbers array (which is in the database class but we were able to have access to it through the database instance we've created in this class)
                ' if accountNumber index i equals the accountnumber array provided and accountpasswords array index i equals the account password provided by way of parameterization or argumentation
                If database.getAccountNumbers(i) = accNumb AndAlso database.getAccountPasswords(i) = accPass Then
                    username = database.getUsernames(i) ' set username to the username
                    userIndex = i ' set userindex as i
                    Return True ' return true or set the value of this function to true
                End If ' end if
            Next ' next
        Catch ex As Exception 'catch exception as ex
            errorText = ex.Message() ' errorText equal ex.message
        End Try ' stop the try

        Return False 'return false
    End Function

    ' public readonly property userid as integer. this block is actually creating a 'variable' (not a function) and setting it's value to the user index
    Public ReadOnly Property userID As Integer ' userID on this line is the variable name
        Get ' get
            Return userIndex 'return userIndex. this becomes the value of the userID variable
        End Get
    End Property
End Class