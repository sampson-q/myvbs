Imports System

Module Program
    Sub Main(args As String())
        ' Write a VB.Net program that outputs the following element {78, 83, 75, 90} in an Array in the reverse order
        Dim arr() As Integer = {78, 83, 75, 90}
        System.Array.Sort(arr)
        System.Array.Reverse(arr)

        For Each i As Integer In arr
            Console.WriteLine(i)
        Next

        Console.WriteLine(addNum(3, 4))
    End Sub

    Function addNum(num1 As Integer, num2 As Integer) As Integer
        addNum = num1 + num2
    End Function

End Module
