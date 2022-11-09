Imports System

Module Program

    Function getMessageDetails() As List(Of Object)
        Dim getMessageList As New List(Of Object)

        Console.Write("Enter Key: ")
        Dim encKey As Integer = Console.ReadLine()

        Console.Write("Enter Message: ")
        Dim encMessage = Console.ReadLine()

        getMessageList.Add(encKey)
        getMessageList.Add(encMessage)

        Return getMessageList
    End Function
    Sub Main(args As String())
        Dim eleArray() As String = {"a", "b", "c", "d", "e", "f", "g", "h"}
        Dim message As String = ""

        Console.WriteLine("[1] Encode")
        Console.WriteLine("[2] Decode")
        Console.Write("Enter Choice: ")

        Dim userChoice As Integer = Console.ReadLine()

        Console.WriteLine()

        If (userChoice = 1) Then

            Dim messageDetails = getMessageDetails()
            Console.WriteLine()

            For Each element As String In messageDetails(1)
                Dim eleIndex As Integer = Array.IndexOf(eleArray, element)

                If ((eleIndex + messageDetails(0) >= eleArray.Length)) Then
                    message += eleArray((eleIndex + messageDetails(0)) Mod eleArray.Length)
                Else
                    message += eleArray(eleIndex + messageDetails(0))
                End If
            Next

            Console.Write("Encoded Message: " + message)

        ElseIf (userChoice = 2) Then
            Dim reversedArray(eleArray.Length) As Integer
            For i As Integer = (eleArray.Length - 1) To 0 Step -1
                For j As Integer = 0 To (eleArray.Length - 1)
                    reversedArray(j) = eleArray(i)
                Next
            Next

            Dim messageDetails = getMessageDetails()
            Console.WriteLine()

            For Each element As String In messageDetails(1)
                Dim eleIndex As Integer = Array.IndexOf(reversedArray, element)

                If ((eleIndex + messageDetails(0) >= reversedArray.Length)) Then
                    message += reversedArray((eleIndex + messageDetails(0)) Mod reversedArray.Length)
                Else
                    message += reversedArray(eleIndex + messageDetails(0))
                End If
            Next

            Console.Write("Encoded Message: " + message)
        Else
            Console.Write("You made a wrong choice!")

        End If


    End Sub
End Module
