Imports System
Imports System.Globalization

Module Program
    Sub Main(args As String())
        Dim input As Integer = 15
        Dim input2 As Integer = 10
        For num As Integer = 1 To input2
            Console.WriteLine(input & "x" & num & "=" & input * num)
        Next
    End Sub

End Module


