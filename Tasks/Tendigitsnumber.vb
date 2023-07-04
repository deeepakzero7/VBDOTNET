Imports System

Module Program
    'get the 10 digit integer and split the integers into two groups based on odd and even position print the sum
    'of odd and even digits separately
    Sub Main(args As String())
        Console.WriteLine("Enter a 10-digit integer:")
        Dim input As Long = Console.ReadLine()

        Dim oddSum As Long = 0
        Dim evenSum As Long = 0

        Dim reme As Integer = 0
        Dim switch As Boolean = True

        While input > 0
            reme = input Mod 10
            If switch = True Then
                evenSum += reme
                switch = False
            Else
                oddSum += reme
                switch = True


            End If
            input = input \ 10
        End While

        Console.WriteLine(oddSum)
        Console.WriteLine(evenSum)














        'System.out.println("Hello deepak")
        Console.WriteLine("Hello deepak")

    End Sub
End Module
