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

        While True
            Console.WriteLine()
            Console.WriteLine("1. Print Account Details")
            Console.WriteLine("2. Print Transaction History")
            Console.WriteLine("3. Deposit Funds")
            Console.WriteLine("4. Withdraw Funds")
            Console.WriteLine("5. Exit")
            Console.WriteLine()
            Console.Write("Enter your choice: ")
            Dim choice As Integer = Integer.Parse(Console.ReadLine())

            Select Case choice
                Case 1
                    account.PrintAccountDetails()
                Case 2
                    account.PrintTransactionHistory()
                Case 3
                    Console.Write("Enter amount to deposit: $")
                    Dim depositAmount As Double = Double.Parse(Console.ReadLine())
                    account.Deposit(depositAmount)
                    Console.WriteLine("Funds deposited successfully!")
                Case 4
                    Console.Write("Enter amount to withdraw: $")
                    Dim withdrawalAmount As Double = Double.Parse(Console.ReadLine())
                    account.Withdraw(withdrawalAmount)
                Case 5
                    Exit While
                Case Else
                    Console.WriteLine("Invalid choice. Please try again.")
            End Select
        End While


    End Sub


    Class train
        Dim count As Integer = 0
        Dim passengerName(count) As String
        Dim passengerage(count) As Integer
        Dim fare As Double = 300
        Dim discount As Double
        Dim trainName As String
        Dim trainNumber As Integer

        Sub result()
            If (count = 0) Then
                Console.WriteLine("Enter Train Details:")
                Console.Write("Train Number: ")
                trainNumber = (Console.ReadLine())

                Console.Write("Train Name: ")
                trainName = Console.ReadLine()
            End If

            Console.WriteLine("Enter Passenger Details:")
            Console.Write("Passenger Name: ")
            passengerName(count) = Console.ReadLine()
            Console.Write("Passenger Age: ")
            passengerage(count) = Console.ReadLine()

            If passengerage(count) > 60 Then
                discount += fare - ((fare) * 0.25)
            ElseIf passengerage(count) <= 5 Then
                discount += fare \ 2
            Else
                discount += fare
            End If

            Dim add As String
            Console.Write("Add passenger:Add/No ")
            add = Console.ReadLine()
            add = add.ToLower()

            If add.Equals("no") Then
                Exit Sub
            Else
                count += 1
                Array.Resize(passengerage, count + 1)
                Array.Resize(passengerName, count + 1)
                result()
            End If


        End Sub

        Sub tickets()

            Console.WriteLine("Train Name:{0}", trainName)
            Console.WriteLine()
            Console.WriteLine("Train no: {0}", trainNumber)

            Console.WriteLine("Passenger Detrails")
            For i = 0 To count
                Console.WriteLine("{0}", passengerName(i))
                For j = 0 To (30 - passengerName(i).Length)

                Next
                Console.Write(passengerage(i))
                Console.WriteLine()
            Next

            Console.WriteLine("No of passenger: {0}", count + 1)


            Console.WriteLine("Total Fare: {0}", discount)



        End Sub
    End Class






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
            Dim delayDays As Integer = (submissionDate - purchaseDate).Days





            If fineAmount > 0 Then
                Console.WriteLine("Fine amount: " & fineAmount & " rupees.")
            Else
                Console.WriteLine("Submission done.")
            End If

            Console.ReadLine()
        End Sub
        ''' <summary>
        ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''' </summary>
        '''
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


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Class accountholder
        Public accno As Int64 = 0
        Public name As String
        Public balance As Double
        Public opendate As Date
        Public acctype As String

    End Class
    Class bank
        Dim memberscount As Integer = 0
        Dim name() As String = New String(memberscount) {}
        Dim balance() As Double = New Double(memberscount) {}
        Dim accno() As Integer = New Integer(memberscount) {}
        Dim acctype() As String = New String(memberscount) {}
        Dim opendate() As Date = New Date(memberscount) {}
        Shared accountno As Integer = 1234567




        Sub createaccount()
            accountno += 1
            Console.WriteLine("ENTER NAME: ")
            name(memberscount) = Console.ReadLine()
            Console.WriteLine("Enter the account type: savings/current")
            acctype(memberscount) = Console.ReadLine()
            balance(memberscount) = 0
            accno(memberscount) = accountno
            opendate(memberscount) = Date.Now
            Console.WriteLine("Account Created Successfully")
            Console.WriteLine()
            showuser(memberscount)
            memberscount += 1
            Array.Resize(name, memberscount + 1)
            Array.Resize(balance, memberscount + 1)
            Array.Resize(acctype, memberscount + 1)
            Array.Resize(opendate, memberscount + 1)
            Array.Resize(accno, memberscount + 1)
            Console.WriteLine()

        End Sub

        Sub deposit()
            Console.WriteLine("Enter the Name ")
            Dim depname = Console.ReadLine()
            Console.WriteLine("Enter the NO ")
            Dim No = Console.ReadLine()
            Console.WriteLine("enter amount ")
            Dim amount = Console.ReadLine()
            Dim depdate = Date.Now

            If finduser(No, depname) = -1 Then
                Console.WriteLine("account not found")
            Else
                balance(finduser(No, depname)) = amount
                Console.WriteLine("Amount deposited successfully")

            End If
            Console.WriteLine()
        End Sub
        Sub passbook()
            Console.WriteLine()
            Dim passno = Console.ReadLine()
            Dim passnumber = Console.ReadLine()
            If finduser(passno, passnumber) = -1 Then
                Console.WriteLine("No account number and name found")
            Else
                showuser(finduser(passno, passnumber))
            End If
        End Sub


        Sub showuser(roll As Integer)
            Console.WriteLine("Acount holder name :{0}", name(roll))
            Console.WriteLine("No :{0}", accno(roll))
            Console.WriteLine("Type :{0}", acctype(roll))
            Console.WriteLine("Balance :{0}", balance(roll))
            Console.WriteLine("Open date:{0}", opendate(roll))

        End Sub


        Function finduser(num As Integer, n As String)
            For i = 0 To accno.Length - 1
                If accno(i) = num Then
                    Return i
                End If
            Next

        End Function


    End Class















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
