Imports System

Module Program

    Sub Main(args As String())
        Console.Write("Enter an email address: ")
        Dim email As String = Console.ReadLine()
        email = email.ToUpper
        Dim letterCount As Integer = 0
        Dim numberCount As Integer = 0
        Dim specialCount As Integer = 0

        For i = 0 To email.Length - 1
            If Asc(email.Chars(i)) >= 65 And Asc(email.Chars(i)) <= 91 Then
                letterCount += 1
            ElseIf Asc(email.Chars(i)) >= 48 And Asc(email.Chars(i)) <= 57 Then
                numberCount += 1
            Else
                specialCount += 1
            End If
        Next

        Console.WriteLine("Letters = {0}", letterCount)
        Console.WriteLine("Numbers ={0}", numberCount)
        Console.WriteLine("Special characters = {0}", specialCount)
    End Sub

End Module
