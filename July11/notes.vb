Imports System
Imports System.Collections.Specialized
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")














        '''''
        'coll()
        'Dim stak As star = New star
        'stak.stark()
        'que()
        'gc()
        'namevaluecol90()


        '''''''''''''''''''''''''''''
        '''



        ' 2 st question Employee PROGRAM

        Dim numOfEmployees As Integer

        Console.WriteLine("Enter the number of employees:")
        numOfEmployees = Integer.Parse(Console.ReadLine())

        Dim employees(numOfEmployees - 1) As Employee

        For i As Integer = 0 To numOfEmployees - 1
            Console.WriteLine("Enter details for Employee #" & (i + 1) & ":")
            employees(i) = New Employee()
            employees(i).GetEmployeeInfo()
        Next

        Console.WriteLine("Employee details:")
        For Each emp As Employee In employees
            emp.ShowEmployeeInfo()
            Console.WriteLine("-----------------------------")
        Next

        '1st question
        Console.ReadLine()

        Dim empel As Employee = New Employee
        empel.ShowEmployeeInfo()



        '3rd question

        Dim ban As bankaccount = New bankaccount
        ban.getbankdetails()
        ban.ShowbankInfo()
        Console.Write("------------------------------------------------")
        Console.WriteLine()

        Dim A As String
        Dim B As String
        Dim C As Decimal
        Console.Write("Enter Account no: ")
        A = Console.ReadLine()
        Console.Write("Enter Type: ")
        B = Console.ReadLine()
        Console.Write("Enter Account balance: ")
        C = Convert.ToDecimal(Console.ReadLine())
        Console.Write("------------------------------------------------")


        '4th question
        Dim account As BankeAccount = New BankeAccount(A, B, C)
        account.GetBankDetails()
        account.Display()
        Console.Write("------------------------------------------------")
        Console.WriteLine()
        account.Deposit()

        Console.Write("------------------------------------------------")
        Console.WriteLine()
        account.Withdraw()
        account.Display()


        '5th question car

        fifththqncar()



        '6th question


        Dim phdStudent As New PhdStudent()
        Dim gradStudent As New GradStudent()

        phdStudent.TakeExam()
        gradStudent.TakeExam()

        Console.ReadLine()



    End Sub




    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''Imports System
    Private empId As Integer
    Private empName As String
    Private empDepartment As String
    Private empSalary As Double

    Class Employee

        Public Sub GetEmployeeInfo()
            Console.WriteLine("Enter Employee ID:")
            empId = Integer.Parse(Console.ReadLine())
            Console.WriteLine("Enter Employee Name:")
            empName = Console.ReadLine()
            Console.WriteLine("Enter Employee Department:")
            empDepartment = Console.ReadLine()
            Console.WriteLine("Enter Employee Salary:")
            empSalary = Double.Parse(Console.ReadLine())
        End Sub



        Public Sub ShowEmployeeInfo()
            Console.WriteLine("Employee ID: " & empId)
            Console.WriteLine("Employee Name: " & empName)
            Console.WriteLine("Employee Department: " & empDepartment)
            Console.WriteLine("Employee Salary: " & empSalary)
        End Sub





        Public Class employee

            Sub employeinfo()
                Console.Write("Enter id: ")
                empId = Convert.ToInt32(Console.ReadLine())
                Console.Write("Enter name: ")
                empName = Console.ReadLine()
                Console.Write("Enter designation: ")
                empDepartment = Console.ReadLine()
                Console.Write("Enter office: ")
                empSalary = Console.ReadLine()

            End Sub



            Public Sub showemployeinfo()
                Console.WriteLine("---------------------------Employee Details------------------------")
                Console.WriteLine(empId)
                Console.WriteLine(empName)
                Console.WriteLine(empDepartment)
                Console.WriteLine(empSalary)

            End Sub

        End Class



    End Class

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''    <summary>
    '''   
    ''' </summary>
    Public accountNumber As String
    Dim accountType As String
    Dim accountBalance As Decimal

    Private balance As Double
    Public Class bankaccount

        Sub getbankdetails()
            Console.WriteLine("Enter accno:")
            accountNumber = (Console.ReadLine())
            Console.WriteLine("Enter acctype:")
            accountType = Console.ReadLine()
            Console.WriteLine("Enter accbalance:")
            accountBalance = Convert.ToDecimal(Console.ReadLine())



        End Sub
        Sub ShowbankInfo()
            Console.WriteLine("Account no: " & accountNumber)
            Console.WriteLine("Account Type: " & accountType)
            Console.WriteLine("Account balance: " & accountBalance)

        End Sub

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''
    End Class






    Public Class BankeAccount


        Public Sub New(number As String, type As String, balance As Decimal)
            accountNumber = number
            accountType = type
            accountBalance = balance
        End Sub

        Public Function GetBankDetails() As String
            Return $"Account Number: {accountNumber}{Environment.NewLine}Account Type: {accountType}{Environment.NewLine}Account Balance: {accountBalance}"
        End Function

        Public Function CheckAccountBalance() As String
            If accountBalance > 800000 Then
                Return "Eligible for Platinum credit card"
            ElseIf accountBalance > 500000 Then
                Return "Eligible for Golden credit card"
            ElseIf accountBalance > 200000 Then
                Return "Eligible for Silver credit card"
            Else
                Return "Not eligible for any credit card"
            End If
        End Function

        Public Sub Display()
            Console.WriteLine("Bank Account Details:")
            Console.WriteLine(GetBankDetails())
            Console.WriteLine("Credit Card Eligibility:")
            Console.WriteLine(CheckAccountBalance())
        End Sub







        Public Sub Withdraw()
            Dim amount As Double
            Console.WriteLine("Enter the amount you want to withdraw: ")
            amount = Convert.ToInt64(Console.ReadLine())
            If amount > 0 AndAlso amount <= accountBalance Then
                accountBalance -= amount
                Console.WriteLine("Withdrawn: $" & amount)
            Else
                Console.WriteLine("Invalid withdrawal amount!")
            End If
        End Sub




        Public Sub Deposit()
            Dim amount As Double
            Console.WriteLine("Enter the amount you want to deposit: ")
            amount = Convert.ToInt64(Console.ReadLine())
            If amount > 0 Then
                accountBalance += amount
                Console.WriteLine("Deposited: $" & amount)
            Else
                Console.WriteLine("Invalid deposit amount!")
            End If
        End Sub



        Public Function GetAccountNumber() As String
            Return accountNumber
        End Function


        Public Function GetBalance() As Double
            Return balance
        End Function



    End Class



    Sub coll()
        Dim mycoll As ArrayList = New ArrayList
        mycoll.Add(4 + 1)
        mycoll.Add("ABC")
        mycoll.Add(3.3)
        mycoll.Add(True)
        mycoll.Remove(True)


        For Each i In mycoll
            Console.WriteLine(i)
        Next
        Console.WriteLine(mycoll.Count)
        Console.WriteLine()



    End Sub



    Class Vehicle
        Public mileage As Integer
        Public price As Double
    End Class

    Class Car
        Inherits Vehicle
        Public ownershipCost As Double
        Public warranty As Integer
        Public seatingCapacity As Integer
        Public fuelType As String
    End Class

    Class Bike
        Inherits Vehicle
        Public numberOfCylinders As Integer
        Public numberOfGears As Integer
        Public coolingType As String
        Public wheelType As String
        Public fuelTankSize As Double
    End Class

    Class Audi
        Inherits Car
        Public modelType As String
    End Class

    Class Ford
        Inherits Car
        Public modelType As String
    End Class

    Class Bajaj
        Inherits Bike
        Public makeType As String
    End Class

    Class TVS
        Inherits Bike
        Public makeType As String
    End Class


    Sub fifththqncar()

        Dim audiCar As New Audi()
        audiCar.modelType = "A3"
        audiCar.ownershipCost = 5000
        audiCar.warranty = 3
        audiCar.seatingCapacity = 5
        audiCar.fuelType = "Petrol"
        audiCar.mileage = 20
        audiCar.price = 50000


        Dim fordCar As New Ford()
        fordCar.modelType = "Mustang"
        fordCar.ownershipCost = 4000
        fordCar.warranty = 2
        fordCar.seatingCapacity = 4
        fordCar.fuelType = "Petrol"
        fordCar.mileage = 15
        fordCar.price = 60000


        Dim bajajBike As New Bajaj()
        bajajBike.makeType = "Pulsar"
        bajajBike.numberOfCylinders = 1
        bajajBike.numberOfGears = 5
        bajajBike.coolingType = "Air"
        bajajBike.wheelType = "Spokes"
        bajajBike.fuelTankSize = 10

        Dim tvsBike As New TVS()
        tvsBike.makeType = "Apache"
        tvsBike.numberOfCylinders = 2
        tvsBike.numberOfGears = 6
        tvsBike.coolingType = "Liquid"
        tvsBike.wheelType = "Alloys"
        tvsBike.fuelTankSize = 12

        'f Audi car
        Console.WriteLine("Audi Car:")
        Console.WriteLine("Model Type: " & audiCar.modelType)
        Console.WriteLine("Ownership Cost: $" & audiCar.ownershipCost)
        Console.WriteLine("Warranty: " & audiCar.warranty & " years")
        Console.WriteLine("Seating Capacity: " & audiCar.seatingCapacity)
        Console.WriteLine("Fuel Type: " & audiCar.fuelType)
        Console.WriteLine("Mileage: " & audiCar.mileage & " km/l")
        Console.WriteLine("Price: $" & audiCar.price)
        Console.WriteLine()

        ' Ford car
        Console.WriteLine("Ford Car:")
        Console.WriteLine("Model Type: " & fordCar.modelType)
        Console.WriteLine("Ownership Cost: $" & fordCar.ownershipCost)
        Console.WriteLine("Warranty: " & fordCar.warranty & " years")
        Console.WriteLine("Seating Capacity: " & fordCar.seatingCapacity)
        Console.WriteLine("Fuel Type: " & fordCar.fuelType)
        Console.WriteLine("Mileage: " & fordCar.mileage & " km/l")
        Console.WriteLine("Price: $" & fordCar.price)
        Console.WriteLine()

        '  Bajaj bike
        Console.WriteLine("Bajaj Bike:")
        Console.WriteLine("Make Type: " & bajajBike.makeType)
        Console.WriteLine("Number of Cylinders: " & bajajBike.numberOfCylinders)
        Console.WriteLine("Number of Gears: " & bajajBike.numberOfGears)
        Console.WriteLine("Cooling Type: " & bajajBike.coolingType)
        Console.WriteLine("Wheel Type: " & bajajBike.wheelType)
        Console.WriteLine("Fuel Tank Size: " & bajajBike.fuelTankSize & " inches")
        Console.WriteLine()

        'tvs
        Console.WriteLine("TVS Bike:")
        Console.WriteLine("Make Type: " & tvsBike.makeType)
        Console.WriteLine("Number of Cylinders: " & tvsBike.numberOfCylinders)
        Console.WriteLine("Number of Gears: " & tvsBike.numberOfGears)
        Console.WriteLine("Cooling Type: " & tvsBike.coolingType)
        Console.WriteLine("Wheel Type: " & tvsBike.wheelType)
        Console.WriteLine("Fuel Tank Size: " & tvsBike.fuelTankSize & " inches")
        Console.WriteLine()

        Console.ReadLine()
    End Sub





    ''' <summary>
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>


    'stack
    Class star
        Sub stark()
            Dim moblist As Stack = New Stack
            Console.WriteLine("enter number of elements to be added :")
            Dim n = Convert.ToInt32(Console.ReadLine)
            For i = 1 To n
                moblist.Push(Console.ReadLine)
            Next
            Console.WriteLine("The top Element: " & moblist.Peek())
            Console.WriteLine("The top element removed and returned :" & moblist.Pop)
            For Each i In moblist
                Console.WriteLine(i)
            Next
            moblist.Clear()
            Console.WriteLine("After stack is cleared the count is:" & moblist.Count)
            Console.ReadLine()
        End Sub

    End Class

    'queue
    Sub que()
        Dim mobList As Queue = New Queue
        Dim opt As Boolean = True
        While opt
            Console.Write("Enter Value to Store: ")
            mobList.Enqueue(Console.ReadLine())
            Console.Write("Do You want to add Another value: (Yes/No) ")
            Dim input = Console.ReadLine()
            input = input.ToLower()
            If input.Equals("yes") Then
                opt = True
            ElseIf input.Equals("No") Then
                opt = False
            Else
                Console.WriteLine("Enter Correct Option")
                opt = False
            End If

        End While
        Console.WriteLine("Top most value:{0}", mobList.Peek())
        Console.WriteLine("Top most val removed and returned: {0}", mobList.Dequeue())



        Console.WriteLine()

        Console.WriteLine("Elements in this are: ")
        For Each i In mobList
            Console.WriteLine(i)
        Next
        Console.ReadLine()


    End Sub



    'namevalue collection

    Sub namevaluecol90()


        Dim mycol As NameValueCollection = New NameValueCollection
        mycol.Add("mobile", "iphone")
        mycol.Add("mobile", "samsung")
        mycol.Add("mobile", "realme")
        mycol.Add("laptop", "asus")
        mycol.Add("laptop", "dell")
        mycol.Add("laptop", "hp")
        mycol.Add("laptop", "mac")

        For Each i In mycol
            Console.WriteLine(i)
            Console.WriteLine(mycol.Get(i))
        Next
        mycol.Remove("laptop")
        For Each i In mycol
            Console.WriteLine(i)
            Console.WriteLine(mycol.Get(i))
        Next


    End Sub



    'generic collection

    Sub gc()
        Dim mydata As List(Of Integer) = New List(Of Integer)
        mydata.Add(100)
        mydata.Add(200)
        mydata.Add(300)
        mydata.Add(4000)
        mydata.Add(1000)
        mydata.Remove(100)


        Dim objct As List(Of Object) = New List(Of Object)
        objct.Add(1000)
        objct.Add("STr")
        For Each i In mydata
            Console.WriteLine(i)
        Next
    End Sub





    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    MustInherit Class Student
        Public MustOverride Sub TakeExam()
    End Class

    Class PhdStudent
        Inherits Student

        Public Overrides Sub TakeExam()
            Console.WriteLine("PhdStudent giving final presentation.")

        End Sub
    End Class

    Class GradStudent
        Inherits Student

        Public Overrides Sub TakeExam()
            Console.WriteLine("GradStudent writing paper exam.")

        End Sub
    End Class


End Module













