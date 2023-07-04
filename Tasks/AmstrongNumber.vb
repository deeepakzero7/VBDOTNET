Imports System
Imports System.Globalization

Module Program
    Sub Main(args As String())
        '<<<<amstrong number>>>>
        Console.WriteLine("Amstrong number from 1 to 1000")
        For number As Integer = 1 To 1000
            If amstrong(number) Then
                Console.WriteLine(number)

            End If
        Next


    End Sub



    Function amstrong(number As Integer)
        Dim sum As Integer = 0
        Dim digit As Integer
        Dim result As Integer = number

        While number <> 0

            digit = number Mod 10
            sum += digit * digit * digit
            number \= 10
        End While
        Return sum = result

    End Function





End Module


