Imports System
Imports System.Net

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")



        'task zero
        'Dim all As Listemployee = New Listemployee
        'GetDetails()


        ' 1 st question


        'Dim em As Emp = New Emp
        'em.GetEmployeeInfo()
        'em.ShowEmployeeInfo()
        'Console.WriteLine("Program end ...press enter to execute next program")


        '2nd question

        'Dim numOfEmployees As Integer

        'Console.WriteLine("Enter the number of employees:")
        'numOfEmployees = Integer.Parse(Console.ReadLine())

        'Dim employees(numOfEmployees - 1) As Employee

        'For i As Integer = 0 To numOfEmployees - 1
        '    Console.WriteLine("Enter details for Employee #" & (i + 1) & ":")
        '    employees(i) = New Employee()
        '    employees(i).GetEmployeeInfo()
        'Next

        'Console.WriteLine("Employee details:")
        'For Each emp As Employee In employees
        '    emp.ShowEmployeeInfo()
        '    Console.WriteLine("-----------------------------")
        'Next

        'Console.WriteLine("Program end ...press enter to execute next program")

        '3rd question

        'Dim bankAccount As New BankAccount()

        'bankAccount.GetBankDetails()
        'Console.WriteLine()
        'bankAccount.Display()

        'Console.ReadLine()
        'Console.WriteLine("Program end ...press enter to execute next program")

        '4th question
        'Console.WriteLine("Enter Bank Account Details:")
        'Console.Write("Account Number: ")
        'Dim accountNumber As Integer = Integer.Parse(Console.ReadLine())

        'Console.Write("Account Type: ")
        'Dim accountType As String = Console.ReadLine()

        'Console.Write("Account Balance: ")
        'Dim accountBalance As Double = Double.Parse(Console.ReadLine())

        'Dim bankAccount As New BankAccount4(accountNumber, accountType, accountBalance)

        'Console.WriteLine()
        'bankAccount.Display()

        'Console.WriteLine()
        'Console.Write("Enter withdrawal amount: ")
        'Dim withdrawalAmount As Double = Double.Parse(Console.ReadLine())
        'bankAccount.Withdraw(withdrawalAmount)

        'Console.WriteLine()
        'Console.Write("Enter deposit amount: ")
        'Dim depositAmount As Double = Double.Parse(Console.ReadLine())
        'bankAccount.Deposit(depositAmount)

        'Console.ReadLine()
        'Console.WriteLine("Program end ...press enter to execute next program")

        '5th question
        'fifththqncar()


        'Console.WriteLine("Program end ...press enter to execute next program")

        ''6th question
        '''''''''''''''''''''''''''''''''''''''''''''''''

        'Dim phdStudentdot As New PhdStudentsixex()
        'phdStudentdot.TakeExamx()
        'Dim gradStudentsixexdot As New GradStudentsixex()
        'gradStudentsixexdot.TakeExamx()



        'Console.ReadLine()
        'Console.WriteLine("Program end ...press enter to execute next program")

        '7th question
        'Console.WriteLine("Enter Bank Account Details:")
        'Console.Write("Account Number: ")
        'Dim accountNumber As Integer = Integer.Parse(Console.ReadLine())

        'Console.Write("Account Type: ")
        'Dim accountType As String = Console.ReadLine()

        'Console.Write("Account Balance: ")
        'Dim accountBalance As Double = Double.Parse(Console.ReadLine())

        'Dim bankAccount As New BankAccountencap()
        'bankAccount.SetAccountNumber(accountNumber)
        'bankAccount.SetAccountType(accountType)
        'bankAccount.SetAccountBalance(accountBalance)

        'Console.WriteLine()
        'bankAccount.Display()

        'Console.WriteLine()
        'Console.Write("Enter withdrawal amount: ")
        'Dim withdrawalAmount As Double = Double.Parse(Console.ReadLine())
        'bankAccount.Withdraw(withdrawalAmount)

        'Console.WriteLine()
        'Console.Write("Enter deposit amount: ")
        'Dim depositAmount As Double = Double.Parse(Console.ReadLine())
        'bankAccount.Deposit(depositAmount)

        'Console.ReadLine()
        'Console.WriteLine("Program end ...press enter to execute next program")

        '8th question
        'Console.WriteLine("Enter Student name")

        'Dim x As String = Console.ReadLine()
        'Console.WriteLine("Enter Student name")
        'Dim y As String = Console.ReadLine()



        'Dim phdStudente As New PhdStudentn(x)
        'Dim gradStudente As New GradStudentn(y)

        'Dim students As Studente() = {phdStudente, gradStudente}

        'For Each student As Studente In students
        '    Console.WriteLine("Student: " & student.GetName())
        '    student.TakeExam()
        '    Console.WriteLine("--------------------")
        'Next
        'Console.WriteLine("Program end ...press enter to execute next program")

        '''''''''''''''''''''''''''''''''''
        ' #last one
        Dim hospital As New Hospital()

        ' In-Patient Example
        Dim inPatient As New InPatient("John Doe", 35, "123 Main St", "555-1234", "Fractured Arm", 200, 100, "separate room")
        hospital.addPatient(inPatient)

        ' Out-Patient Example
        Dim outPatient As New OutPatient("Jane Smith", 45, "456 Elm St", "555-5678", "Flu", 100, 50)
        hospital.addPatient(outPatient)

        '  Bill
        For Each patient As Patient In hospital.__patients
            Console.WriteLine(hospital.generateBill(patient))
            Console.WriteLine("-------------------------------")
        Next

        ''''''''''''''''''''''''''''''''''''''''''''
    End Sub




    Public Class Listemployee
        Public Property Id As Integer
        Public Property Name As String
        Public Property Salary As Double
        Public Property YearsOfExperience As Integer
    End Class

    Sub GetDetails()
        Dim employees As New List(Of Listemployee)()

        Console.Write("Enter the number of employees: ")
        Dim numberOfEmployees As Integer = Integer.Parse(Console.ReadLine())

        For i As Integer = 1 To numberOfEmployees
            Console.WriteLine("Enter details for employee #" & i)
            Dim emp As New Listemployee()


            Try
                Console.Write("Employee ID: ")
                emp.Id = GetValidIntegerInput()

                Console.Write("Name: ")
                emp.Name = GetValidStringInput()

                Console.Write("Salary: ")
                emp.Salary = GetValidDoubleInput()

                Console.Write("Years of Experience: ")
                emp.YearsOfExperience = GetValidIntegerInput()

                employees.Add(emp)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                i -= 1
            End Try
        Next

        For Each emp As Listemployee In employees
            PrintEmployeeDetails(emp)
        Next

        Console.ReadLine()
    End Sub

    Sub PrintEmployeeDetails(emp As Listemployee)
        If emp.YearsOfExperience > 8 AndAlso emp.Salary >= 100000 AndAlso emp.Salary < 200000 Then
            Console.WriteLine("-----------------------------------------------------------------------------")
            Console.WriteLine("Employee ID: " & emp.Id)
            Console.WriteLine("Name: " & emp.Name)
            Console.WriteLine("Salary: " & emp.Salary)
            Console.WriteLine("Years of Experience: " & emp.YearsOfExperience)
            Console.WriteLine("-----------------------------------------------------------------------------")
            Console.WriteLine()
        End If
    End Sub

    Function GetValidIntegerInput() As Integer
        Dim userInput As String
        Dim validInput As Integer

        While True
            userInput = Console.ReadLine()
            If Integer.TryParse(userInput, validInput) Then
                Return validInput
            Else
                Console.WriteLine("Invalid input. Please enter a valid integer.")
            End If
        End While
    End Function

    Function GetValidDoubleInput() As Double
        Dim userInput As String
        Dim validInput As Double

        While True
            userInput = Console.ReadLine()
            If Double.TryParse(userInput, validInput) Then
                Return validInput
            Else
                Console.WriteLine("Invalid input. Please enter a valid number.")
            End If
        End While
    End Function

    Function GetValidStringInput() As String
        Dim userInput As String

        While True
            userInput = Console.ReadLine()
            If Not String.IsNullOrWhiteSpace(userInput) Then
                Return userInput
            Else
                Console.WriteLine("Invalid input. Please enter a non-empty name.")
            End If
        End While
    End Function

    Private emId As Integer
    Private emName As String
    Private emDepartment As String
    Private emSalary As Double

    Class Emp
        Private emId As Integer
        Private emName As String
        Private emDepartment As String
        Private emSalary As Double

        Public Sub GetEmployeeInfo()
            Console.WriteLine("Enter Employee ID:")
            emId = Integer.Parse(Console.ReadLine())
            Console.WriteLine("Enter Employee Name:")
            emName = Console.ReadLine()
            Console.WriteLine("Enter Employee Department:")
            emDepartment = Console.ReadLine()
            Console.WriteLine("Enter Employee Salary:")
            emSalary = Double.Parse(Console.ReadLine())
        End Sub



        Public Sub ShowEmployeeInfo()
            Console.WriteLine("---------------------------Employee Details------------------------")
            Console.WriteLine("Employee ID: " & emId)
            Console.WriteLine("Employee Name: " & emName)
            Console.WriteLine("Employee Department: " & emDepartment)
            Console.WriteLine("Employee Salary: " & emSalary)
        End Sub

    End Class



    Public Class Employee


        Private empId As Integer
        Private empName As String
        Private empDepartment As String
        Private empSalary As Double

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
    End Class
    '#3
    Public Class BankAccount
        Private accountNumber As Integer
        Private accountType As String
        Private accountBalance As Double

        Public Sub GetBankDetails()
            Console.WriteLine("Enter Bank Account Details:")
            Console.Write("Account Number: ")
            accountNumber = Integer.Parse(Console.ReadLine())

            Console.Write("Account Type: ")
            accountType = Console.ReadLine()

            Console.Write("Account Balance: ")
            accountBalance = Double.Parse(Console.ReadLine())
        End Sub



        Public Sub Display()
            Console.WriteLine("Bank Account Details:")
            Console.WriteLine("Account Number: " & accountNumber)
            Console.WriteLine("Account Type: " & accountType)
            Console.WriteLine("Account Balance: " & accountBalance)
            Console.WriteLine("Credit Card Eligibility:")
            If accountBalance > 200000 And accountBalance <= 500000 Then
                Console.WriteLine("Eligible for Silver Credit Card")
            ElseIf accountBalance > 500000 And accountBalance <= 800000 Then
                Console.WriteLine("Eligible for Golden Credit Card")
            ElseIf accountBalance > 800000 Then
                Console.WriteLine("Eligible for Platinum Credit Card")
            Else
                Console.WriteLine("Not Eligible")
            End If
        End Sub
    End Class


    '#4
    Public Class BankAccount4
        Private accountNumber As Integer
        Private accountType As String
        Private accountBalance As Double

        ' Constructors
        Public Sub New(ByVal number As Integer, ByVal type As String, ByVal balance As Double)
            accountNumber = number
            accountType = type
            accountBalance = balance
        End Sub

        Public Sub New()
        End Sub

        Public Sub GetBankDetails()
            Console.Write("Enter Account Number: ")
            accountNumber = Integer.Parse(Console.ReadLine())

            Console.Write("Enter Account Type: ")
            accountType = Console.ReadLine()

            Console.Write("Enter Account Balance: ")
            accountBalance = Double.Parse(Console.ReadLine())
        End Sub

        Public Function CheckAccountBalance() As String
            If accountBalance > 800000 Then
                Return "Eligible for Platinum Credit Card"
            ElseIf accountBalance > 500000 Then
                Return "Eligible for Golden Credit Card"
            ElseIf accountBalance > 200000 Then
                Return "Eligible for Silver Credit Card"
            Else
                Return "Not Eligible"
            End If
        End Function

        Public Sub Display()
            Console.WriteLine("Bank Account Details:")
            Console.WriteLine("Account Number: " & accountNumber)
            Console.WriteLine("Account Type: " & accountType)
            Console.WriteLine("Account Balance: " & accountBalance)
            Console.WriteLine("Credit Card Eligibility: " & CheckAccountBalance())
        End Sub

        Public Sub Withdraw(ByVal amount As Double)
            If amount > 0 AndAlso amount <= accountBalance Then
                accountBalance -= amount
                Console.WriteLine("Withdrawal successful. New balance: " & accountBalance)
            Else
                Console.WriteLine("Invalid withdrawal amount.")
            End If
        End Sub

        Public Sub Deposit(ByVal amount As Double)
            If amount > 0 Then
                accountBalance += amount
                Console.WriteLine("Deposit successful. New balance: " & accountBalance)
            Else
                Console.WriteLine("Invalid deposit amount.")
            End If
        End Sub
    End Class



    '#5
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


    '#6
    MustInherit Class Studentsixth
        Public MustOverride Sub TakeExamx()
    End Class

    Class PhdStudentsixex
        Inherits Studentsixth

        Public Overrides Sub TakeExamx()
            Console.WriteLine("PhdStudent giving final presentation.")

        End Sub
    End Class

    Class GradStudentsixex
        Inherits Studentsixth

        Public Overrides Sub TakeExamx()
            Console.WriteLine("GradStudent writing paper exam.")

        End Sub
    End Class

    '#7
    Public Class BankAccountencap
        Private accountNumber As Integer
        Private accountType As String
        Private accountBalance As Double

        ' Constructors
        Public Sub New(ByVal number As Integer, ByVal type As String, ByVal balance As Double)
            SetAccountNumber(number)
            SetAccountType(type)
            SetAccountBalance(balance)
        End Sub

        Public Sub New()
            ' Default constructor
        End Sub

        ' Encapsulated setters
        Public Sub SetAccountNumber(ByVal number As Integer)
            accountNumber = number
        End Sub

        Public Sub SetAccountType(ByVal type As String)
            accountType = type
        End Sub

        Public Sub SetAccountBalance(ByVal balance As Double)
            accountBalance = balance
        End Sub

        ' Encapsulated getters
        Public Function GetAccountNumber() As Integer
            Return accountNumber
        End Function

        Public Function GetAccountType() As String
            Return accountType
        End Function

        Public Function GetAccountBalance() As Double
            Return accountBalance
        End Function

        Public Function CheckAccountBalance() As String
            If accountBalance > 800000 Then
                Return "Eligible for Platinum Credit Card"
            ElseIf accountBalance > 500000 Then
                Return "Eligible for Golden Credit Card"
            ElseIf accountBalance > 200000 Then
                Return "Eligible for Silver Credit Card"
            Else
                Return "Not Eligible"
            End If
        End Function

        Public Sub Display()
            Console.WriteLine("Bank Account Details:")
            Console.WriteLine("Account Number: " & GetAccountNumber())
            Console.WriteLine("Account Type: " & GetAccountType())
            Console.WriteLine("Account Balance: " & GetAccountBalance())
            Console.WriteLine("Credit Card Eligibility: " & CheckAccountBalance())
        End Sub

        Public Sub Withdraw(ByVal amount As Double)
            If amount > 0 AndAlso amount <= accountBalance Then
                accountBalance -= amount
                Console.WriteLine("Withdrawal successful. New balance: " & accountBalance)
            Else
                Console.WriteLine("Invalid withdrawal amount.")
            End If
        End Sub

        Public Sub Deposit(ByVal amount As Double)
            If amount > 0 Then
                accountBalance += amount
                Console.WriteLine("Deposit successful. New balance: " & accountBalance)
            Else
                Console.WriteLine("Invalid deposit amount.")
            End If
        End Sub
    End Class





    Public MustInherit Class Studente
        Private _name As String

        Public Sub New(name As String)
            _name = name
        End Sub

        Public Function GetName() As String
            Return _name
        End Function

        Public MustOverride Sub TakeExam()
    End Class

    Public Class PhdStudentn
        Inherits Studente

        Public Sub New(name As String)
            MyBase.New(name)
        End Sub

        Public Overrides Sub TakeExam()
            Console.WriteLine($"{GetName()} is giving the final presentation.")
        End Sub
    End Class

    Public Class GradStudentn
        Inherits Studente

        Public Sub New(name As String)
            MyBase.New(name)
        End Sub

        Public Overrides Sub TakeExam()
            Console.WriteLine($"{GetName()} is writing a research paper.")
        End Sub
    End Class









    ''' <summary>
    ''' ''''''''''''''''''''''''''''''''''''''
    ''' </summary>






    Class Patient
        Protected __name As String
        Protected __age As Integer
        Protected __address As String
        Protected __mobile_number As String
        Protected __illness As String

        Public Sub New(name As String, age As Integer, address As String, mobileNumber As String, illness As String)
            __name = name
            __age = age
            __address = address
            __mobile_number = mobileNumber
            __illness = illness
        End Sub

        Public Function getPatientBasicDetails() As String
            Return $"Name: {_name}{Environment.NewLine}Age: {age}{Environment.NewLine}Address: {address}{Environment.NewLine}Mobile Number: {mobile_number}{Environment.NewLine}Illness: {_illness}"
        End Function
    End Class

    Class InPatient
        Inherits Patient
        Private __doctor_fees As Decimal
        Private __nurse_fees As Decimal
        Private __room_type As String

        Public Sub New(name As String, age As Integer, address As String, mobileNumber As String, illness As String, doctorFees As Decimal, nurseFees As Decimal, roomType As String)
            MyBase.New(name, age, address, mobileNumber, illness)
            __doctor_fees = doctorFees
            __nurse_fees = nurseFees
            __room_type = roomType
        End Sub

        Private Function calculateRoomCharges() As Decimal
            Select Case __room_type
                Case "general ward"
                    Return 1000 ' Example charge for general ward
                Case "separate room"
                    Return 2000 ' Example charge for separate room
                Case "icu"
                    Return 5000 ' Example charge for ICU
                Case Else
                    Return 0
            End Select
        End Function

        Public Function getInPatientDetails() As String
            Return $"Doctor Fees: {_doctor_fees}{Environment.NewLine}Nurse Fees: {nurse_fees}{Environment.NewLine}Room Type: {_room_type}{Environment.NewLine}Room Charges: {calculateRoomCharges()}"
        End Function
    End Class

    Class OutPatient
        Inherits Patient
        Private __doctor_fees As Decimal
        Private __medicine_cost As Decimal

        Public Sub New(name As String, age As Integer, address As String, mobileNumber As String, illness As String, doctorFees As Decimal, medicineCost As Decimal)
            MyBase.New(name, age, address, mobileNumber, illness)
            __doctor_fees = doctorFees
            __medicine_cost = medicineCost
        End Sub

        Public Function getOutPatientDetails() As String
            Return $"Doctor Fees: {_doctor_fees}{Environment.NewLine}Medicine Cost: {_medicine_cost}"
        End Function
    End Class

    Class Hospital
        Private __patients As List(Of Patient)

        Public Sub New()
            __patients = New List(Of Patient)
        End Sub

        Public Sub addPatient(patient As Patient)
            __patients.Add(patient)
        End Sub

        Public Function generateBill(patient As Patient) As String
            Dim bill As String = ""
            If TypeOf patient Is InPatient Then
                bill += "In-Patient Details:" + Environment.NewLine
                bill += DirectCast(patient, InPatient).getInPatientDetails() + Environment.NewLine
            ElseIf TypeOf patient Is OutPatient Then
                bill += "Out-Patient Details:" + Environment.NewLine
                bill += DirectCast(patient, OutPatient).getOutPatientDetails() + Environment.NewLine
            End If
            bill += "Patient Basic Details:" + Environment.NewLine
            bill += patient.getPatientBasicDetails()
            Return bill
        End Function
    End Class


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''

End Module
