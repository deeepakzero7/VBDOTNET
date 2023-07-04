Imports System
Imports System.Globalization
Imports System.Linq
Imports System.Net.Sockets
Imports System.Runtime.Intrinsics

Module Program
    Sub Main(args As String())
        Dim numbers() As Integer = {5, 2, 9, 1, 3}
        Console.WriteLine("Before sorting:")
        For Each input As Integer In numbers
            Console.Write(input & " ")
        Next
        Console.WriteLine()


        For i As Integer = 0 To numbers.Length - 2
            For j As Integer = i + 1 To numbers.Length - 1
                If numbers(i) > numbers(j) Then

                    Dim temp As Integer = numbers(i)
                    numbers(i) = numbers(j)
                    numbers(j) = temp
                End If
            Next
        Next

        Console.WriteLine("After sorting:")
        For Each input As Integer In numbers
            Console.Write(input & " ")
        Next
        Console.WriteLine()

        Console.ReadLine()
    End Sub
End Module
