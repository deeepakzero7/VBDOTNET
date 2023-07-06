Imports System
Module Program
    Sub Main(args As String())
Sub palindrome()
        Console.Write("Enter a string: ")
        Dim input As String = Console.ReadLine()

        If IsPalindrome(input) Then
            Console.WriteLine("The string is a palindrome.")
        Else
            Console.WriteLine("The string is not a palindrome.")
        End If

        Console.ReadLine()
    End Sub

    Function IsPalindrome(str As String)
        Dim reversed As String = ""
        For i As Integer = str.Length - 1 To 0 Step -1
            reversed += str(i)
        Next

        Return str.ToLower() = reversed.ToLower()
    End Function
End Module
