Imports System
Imports System.Threading

Module Program
    Sub Main(args As String())


        Dim bookobj As Library = New Library
        bookobj.getlib()

     Class Book
        Dim Code As Integer
        Dim Name As String
        Dim Author As String
        Dim PurchaseDate As DateTime

        Sub New(code As Integer, name As String, author As String, purchaseDate As DateTime)
            Me.Code = code
            Me.Name = name
            Me.Author = author
            Me.PurchaseDate = purchaseDate
        End Sub

        Function CalculateFine(submissionDate As DateTime)
            Dim delayDays As Integer = (submissionDate - PurchaseDate).Days
            If delayDays > 0 Then
                Return (delayDays \ 10) * 25
            Else
                Return 0
            End If
        End Function
    End Class

    Class Library
        Sub getlib()
            Dim code As Integer = GetInputInteger("Enter Book Code:")
            Dim name As String = GetInputString("Enter Book Name:")
            Dim author As String = GetInputString("Enter Author:")
            Dim purchaseDate As DateTime = GetInputDate("Enter Date of Purchase (yyyy-mm-dd):")
            Dim submissionDate As DateTime = GetInputDate("Enter Submission Date (yyyy-mm-dd):")


            Dim book As New Book(code, name, author, purchaseDate)
            Dim fineAmount As Integer = book.CalculateFine(submissionDate)

            If fineAmount > 0 Then
                Console.WriteLine("Fine amount: " & fineAmount & " rupees.")
            Else
                Console.WriteLine("Submission done.")
            End If

            Console.ReadLine()
        End Sub
     
        Function GetInputInteger(pt As String)
            Console.WriteLine(pt)
            Return Convert.ToInt32(Console.ReadLine())
        End Function

        Function GetInputString(pt As String)
            Console.WriteLine(pt)
            Return Console.ReadLine()
        End Function

        Function GetInputDate(pt As String)
            Console.WriteLine(pt)
            Return DateTime.Parse(Console.ReadLine())
        End Function
    End Class


End Module
