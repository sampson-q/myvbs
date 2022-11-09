Imports System

Module Program
    Sub Main(args As String())
        Dim array(4) As Integer

        For i As Integer = 0 To (array.Length - 1)
            Console.Write("Enter number " & (i + 1) & " of " & array.Length & ": ")
            array(i) = Console.ReadLine()

            For j As Integer = 0 To (array.Length - 2)
                If (array(i) < array(j)) Then
                    Dim temp As Integer = array(i)
                    array(i) = array(j)
                    array(j) = temp
                End If
            Next j
        Next i

        Console.Write("Sorted Array: ")

        For i As Integer = 0 To (array.Length - 1)
            Console.Write(array(i) & ", ")
        Next
    End Sub
End Module
