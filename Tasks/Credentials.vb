Imports System

Module Program

    Sub Main(args As String())
        Dim validUsername As String = "admin"
        Dim validPassword As String = "password"
        Dim username As String
        Dim password As String

        While True
            Console.WriteLine("Enter username:")
            username = Console.ReadLine()
            Console.WriteLine("Enter password:")
            password = Console.ReadLine()

            If username = validUsername AndAlso password = validPassword Then
                Console.WriteLine("Login successful!")
                Exit While
            Else
                Console.WriteLine("Invalid credentials. Please try again.")
            End If
        End While

        Console.ReadLine()
    End Sub
End Module
