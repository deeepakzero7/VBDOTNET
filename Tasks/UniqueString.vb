Imports System
Module Program
Sub Main(args As String())
        Dim words() As String = {"cat", "dog", "dog", "rat", "bird"}

        For i As Integer = 0 To words.Length - 1
            Dim isDuplicate As Boolean = False

            For j As Integer = 0 To i - 1
                If words(i) = words(j) Then
                    isDuplicate = True
                End If
            Next

            If Not isDuplicate Then
                Console.Write(words(i) & " ")
                Console.WriteLine()
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
