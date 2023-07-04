Imports System
Imports System.Globalization
Imports System.Linq
Imports System.Net.Sockets
Imports System.Runtime.Intrinsics

Module Program
    Sub Main(args As String())
        Dim arr() As Integer = {1, 2, 3, 4, 5}
        Dim rotationCount As Integer = 2

        Console.WriteLine("Your input Array:")
        For Each element As Integer In arr
            Console.Write(element & " ")
        Next
        Console.WriteLine()

        RotateArray(arr, rotationCount)

        Console.WriteLine("Array after cyclic rotation:")
        For Each element As Integer In arr
            Console.Write(element & " ")
        Next
        Console.WriteLine()

        Console.ReadLine()
    End Sub


    Function RotateArray(arr() As Integer, rotationCount As Integer)
        Dim length As Integer = arr.Length


        For count As Integer = 0 To rotationCount - 1
            Dim lastElement As Integer = arr(length - 1)


            For i As Integer = length - 1 To 1 Step -1
                arr(i) = arr(i - 1)
            Next

            arr(0) = lastElement
        Next
    End Function


End Module
