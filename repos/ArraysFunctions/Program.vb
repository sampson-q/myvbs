Imports System

Module Program
    Sub Main(args As String())
        Dim n(10) As Integer
        ' initialize elements of array n '

        For i = 0 To 10
            n(i) = i + 100 ' set element at location i to i + 100
        Next i
        ' output each array element's value

        For j = 0 To 10
            Console.WriteLine("Element({0}) = {1}", j, n(j))
        Next j

        Console.WriteLine()

        For k = 0 To 10
            Console.WriteLine("Element({0}) ^ 2 = {1}", k, n(k) ^ 2)
        Next

        Console.ReadKey()
    End Sub
End Module