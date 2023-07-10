Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        'Dim bookobj As Library = New Library
        'bookobj.getlib()

        'Dim trainobj As train = New train
        'trainobj.result()
        'trainobj.tickets()


        'Dim bankobj As bank = New bank
        'bankobj.createaccount()

        Dim account As BankAccount = CreateAccount()
        Console.WriteLine("Bank Account Created Successfully!")
      End Sub
Class BankAccount
        Private accountNumber As Integer
        Private ownerName As String
        Private balance As Double
        Private transactionHistory As String()
        Private transactionCount As Integer

        Public Sub New(accNum As Integer, name As String, initialBalance As Double)
            accountNumber = accNum
            ownerName = name
            balance = initialBalance
            transactionHistory = New String(3) {}
            transactionCount = 0
        End Sub

        Public Sub PrintAccountDetails()
            Console.WriteLine("Account Number: " & accountNumber)
            Console.WriteLine("Owner Name: " & ownerName)
            Console.WriteLine("Balance: $" & balance)
        End Sub

        Public Sub AddTransaction(transaction As String)
            If transactionCount < 4 Then
                transactionHistory(transactionCount) = transaction
            Else
                ' Shift transactions to the left to make space for the new transaction
                For i As Integer = 0 To transactionHistory.Length - 2
                    transactionHistory(i) = transactionHistory(i + 1)
                Next
                transactionHistory(transactionHistory.Length - 1) = transaction
            End If

            transactionCount += 1
        End Sub

        Public Sub PrintTransactionHistory()
            Console.WriteLine("----- Transaction History -----")
            For Each transaction As String In transactionHistory
                If transaction IsNot Nothing Then
                    Console.WriteLine(transaction)
                End If
            Next
        End Sub

        Public Sub Deposit(amount As Double)
            balance += amount
            Dim transaction As String = "Deposit: $" & amount
            AddTransaction(transaction)
        End Sub

        Public Sub Withdraw(amount As Double)
            If amount <= balance Then
                balance -= amount
                Dim transaction As String = "Withdrawal: $" & amount
                AddTransaction(transaction)
            Else
                Console.WriteLine("Insufficient funds!")
            End If
        End Sub
    End Class


Function CreateAccount() As BankAccount
        Console.WriteLine("----- Bank Account Creation -----")
        Console.Write("Enter Account Number: ")
        Dim accNum As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Enter Owner Name: ")
        Dim name As String = Console.ReadLine()

        Console.Write("Enter Initial Balance: $")
        Dim initialBalance As Double = Double.Parse(Console.ReadLine())

        Return New BankAccount(accNum, name, initialBalance)
    End Function
End Module
