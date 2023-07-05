Imports System
Imports System.Globalization
Imports System.Linq
Imports System.Net.Sockets
Imports System.Runtime.Intrinsics

Module Program
    Sub Main(args As String())
        Dim length As Integer

        Console.WriteLine("Enter multiple:")
        Dim table As Integer = Convert.ToInt64(Console.ReadLine())
        Console.WriteLine("Enter length:")
        length = Convert.ToInt16(Console.ReadLine())

        Dim multi = 1

        Dim first = 0
        Dim second = 1
        Dim nextTerm As Int16
        For i = 1 To length


            If i Mod 2 <> 0 Then
                Console.Write((multi * table))
                multi += 1

            Else
                If i < 3 Then
                    Console.Write(first)
                ElseIf i < 5 Then
                    Console.Write(second)

                Else

                    nextTerm = first + second
                    Console.Write(nextTerm)
                    first = second
                    second = nextTerm
                End If
            End If

            If i < length Then

                Console.Write(" ")
            End If
        Next

        Console.ReadLine()
    End Sub



End Module
