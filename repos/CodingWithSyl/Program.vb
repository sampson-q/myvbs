Imports System
Module Program
    Sub Main(args As String())
        ' Dim variableName As dataType
        Dim integerVariable As Integer = 143
        Dim stringVariable As String = "Syl"

        Console.WriteLine("Concantenation with ampersand " & integerVariable & " " & stringVariable)
        Console.WriteLine("Concantenation with placeholders {0} {1} {2}", integerVariable, stringVariable, (143 * 143) / 143)

        ' loops: while-loops, for-loops, do-while-loops

        Dim counter As Integer = 0

        While counter < 100
            Console.WriteLine(counter)
            counter = counter + 1
        End While

        For i As Integer = 0 To 10 Step 3
            Console.WriteLine("For Loop: {0}", i)
        Next

        Do While counter < 200
            Console.WriteLine("Do While Loop: " & counter)
            counter = counter + 1
        Loop

        Dim array As String =

    End Sub
End Module
