Imports System

Module Program
    Sub Main(args As String())
        Dim unsortedArray(4) As Integer

        For i = 0 To (unsortedArray.Length - 1)
            Console.Write("Enter number {0} of {1}: ", i + 1, unsortedArray.Length)
            unsortedArray(i) = Console.ReadLine()

            For j = 0 To (unsortedArray.Length - 1)
                Dim temp As Integer

                If (unsortedArray(j) < unsortedArray(i)) Then
                    temp = unsortedArray(j)
                    unsortedArray(j) = unsortedArray(i)
                    unsortedArray(i) = temp
                End If
            Next
        Next

        Console.Write(String.Join(", ", unsortedArray))
    End Sub
End Module
