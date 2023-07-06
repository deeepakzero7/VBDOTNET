Imports System
Module Program
Sub Main(args As String())

        Console.Write("Enter a string: ")
        Dim input As String = Console.ReadLine()


        If IsvPalindrome(input) Then
            If IsNumeric(input) Then
                Console.WriteLine("The given input is a number palindrome.")
            Else
                Console.WriteLine("The given input is a string palindrome.")
            End If
        Else
            Console.WriteLine("The given input is not a palindrome.")
        End If

        Console.ReadLine()

        Console.ReadLine()
    End Sub

    Function IsvPalindrome(str As String)
        Dim reversed As String = ""
        For i As Integer = str.Length - 1 To 0 Step -1
            reversed += str(i)
        Next

        Return str = reversed
    End Function
End Module
