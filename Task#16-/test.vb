Imports System
Imports System.Net
Imports System.Reflection.Metadata
Imports System.Text.RegularExpressions
Imports System.Exception

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")



        'task zero
        Dim all As Listemployee = New Listemployee

        GetDetails()
        'Console.WriteLine("Program end ...press enter to execute next program")


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

        ''8th question
        'Dim phdStudent As IExam = New PhdStudent()
        'phdStudent.TakeExam()

        'Dim gradStudent As IExam = New GradStudent()
        'gradStudent.TakeExam()

        'Console.ReadLine()


        'Console.ReadLine()
        'Console.WriteLine("Program end ...press enter to execute next program")

        '''''''''''''''''''''''''''''''''''
        ' #last one
        'indexi()



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


        For i As Integer = 1 To getnoemp()
            Console.WriteLine("Enter details for employee #" & i)
            Dim emp As New Listemployee()


            Try
                Console.Write("Employee ID: ")
                emp.Id = GetValidIntegerInput()

                Console.Write("Enter the Name of employee: ")
                emp.Name = getName()

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
    Function getnoemp()
        Dim user As Integer
        Try
            user = Convert.ToInt64(Console.ReadLine())

        Catch ex As FormatException
            Console.WriteLine("Enter valid Integer value")
            user = getnoemp()

        End Try

        Return user
    End Function

    Function getName()
        Dim namee As String

        Try
            namee = Console.ReadLine()
            Dim pattern As String = "^[a-zA-Z ]+$"
            If Not Regex.Match(namee, pattern).Success Then
                Console.WriteLine("Name Should Only contains Alphabets")
                getName()
            End If
        Catch ex As FormatException

            getName()
        End Try
        Return namee
    End Function


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
        Dim validInput As String

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


        ' Encaps set
        Public Sub SetAccountNumber(ByVal number As Integer)
                accountNumber = number
            End Sub

            Public Sub SetAccountType(ByVal type As String)
                accountType = type
            End Sub

            Public Sub SetAccountBalance(ByVal balance As Double)
                accountBalance = balance
            End Sub

        ' Encaps get
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



    '#8



    Public Interface IExam
            Sub TakeExam()
        End Interface

        Public Class PhdStudent
            Implements IExam

            Public Sub TakeExam() Implements IExam.TakeExam
                Console.WriteLine("PhD student is giving his final presentation.")
            End Sub
        End Class

        Public Class GradStudent
            Implements IExam

            Public Sub TakeExam() Implements IExam.TakeExam
                Console.WriteLine("Graduate student is giving a written paper.")
            End Sub
        End Class





    '''' 
    ''' #9
    ''' 
    Class Patient
        Private patientName As String
        Private age As Integer
        Private address As String
        Private mobileNumber As String
        Private injuryOrSickness As String

        Public Sub New(name As String, age As Integer, address As String, mobileNumber As String, injuryOrSickness As String)
            Me.patientName = name
            Me.age = age
            Me.address = address
            Me.mobileNumber = mobileNumber
            Me.injuryOrSickness = injuryOrSickness
        End Sub

        Public Sub getPatientBasicDetails()
            Console.WriteLine("Patient Name: " & patientName)
            Console.WriteLine("Age: " & age)
            Console.WriteLine("Address: " & address)
            Console.WriteLine("Mobile Number: " & mobileNumber)
            Console.WriteLine("Injury or Sickness: " & injuryOrSickness)
        End Sub
    End Class

    Class InPatient
        Inherits Patient
        Private doctorFeesPerDay As Decimal
        Private nurseFeesPerDay As Decimal
        Private roomType As String
        Private roomCharges As Decimal
        Private extraScansCharges As Decimal

        Public Sub New(name As String, age As Integer, address As String, mobileNumber As String, injuryOrSickness As String, doctorFeesPerDay As Decimal, nurseFeesPerDay As Decimal, roomType As String, roomCharges As Decimal, extraScansCharges As Decimal)
            MyBase.New(name, age, address, mobileNumber, injuryOrSickness)
            Me.doctorFeesPerDay = doctorFeesPerDay
            Me.nurseFeesPerDay = nurseFeesPerDay
            Me.roomType = roomType
            Me.roomCharges = roomCharges
            Me.extraScansCharges = extraScansCharges
        End Sub

        Public Sub getInPatientDetails()
            getPatientBasicDetails()
            Console.WriteLine("Doctor Fees per day: " & doctorFeesPerDay)
            Console.WriteLine("Nurse Fees per day: " & nurseFeesPerDay)
            Console.WriteLine("Room Type: " & roomType)
            Console.WriteLine("Room Charges: " & roomCharges)
            Console.WriteLine("Extra Scans Charges: " & extraScansCharges)
        End Sub

        Public Function calculateTotalBill() As Decimal
            Return doctorFeesPerDay + nurseFeesPerDay + roomCharges + extraScansCharges
        End Function
    End Class

    Class OutPatient
        Inherits Patient
        Private doctorConsultantFees As Decimal
        Private medicineCost As Decimal

        Public Sub New(name As String, age As Integer, address As String, mobileNumber As String, injuryOrSickness As String, doctorConsultantFees As Decimal, medicineCost As Decimal)
            MyBase.New(name, age, address, mobileNumber, injuryOrSickness)
            Me.doctorConsultantFees = doctorConsultantFees
            Me.medicineCost = medicineCost
        End Sub

        Public Sub getOutPatientDetails()
            getPatientBasicDetails()

            Console.WriteLine("Doctor Consultant Fees: " & doctorConsultantFees)
            Console.WriteLine("Medicine Cost: " & medicineCost)
        End Sub

        Public Function calculateTotalBill() As Decimal
            Return doctorConsultantFees + medicineCost
        End Function
    End Class


    Public Sub indexi()
        Console.WriteLine("Enter Patient Details:")
        Console.Write("Patient Name: ")
        Dim name As String = Console.ReadLine()

        Console.Write("Age: ")
        Dim age As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Address: ")
        Dim address As String = Console.ReadLine()

        Console.Write("Mobile Number: ")
        Dim mobileNumber As String = Console.ReadLine()

        Console.Write("Injury or Sickness: ")
        Dim injuryOrSickness As String = Console.ReadLine()

        Console.WriteLine("Select Patient Type:")
        Console.WriteLine("1. InPatient")
        Console.WriteLine("2. OutPatient")
        Console.Write("Choice: ")
        Dim patientTypeChoice As Integer = Integer.Parse(Console.ReadLine())

        Select Case patientTypeChoice
            Case 1 ' InPatient
                Console.WriteLine("Enter InPatient Details:")
                Console.Write("Doctor Fees per day: ")
                Dim doctorFeesPerDay As Decimal = Decimal.Parse(Console.ReadLine())

                Console.Write("Nurse Fees per day: ")
                Dim nurseFeesPerDay As Decimal = Decimal.Parse(Console.ReadLine())

                Console.Write("Room Type: ")
                Dim roomType As String = Console.ReadLine()

                Console.Write("Room Charges: ")
                Dim roomCharges As Decimal = Decimal.Parse(Console.ReadLine())

                Console.Write("Extra Scans Charges: ")
                Dim extraScansCharges As Decimal = Decimal.Parse(Console.ReadLine())

                Dim inPatient As New InPatient(name, age, address, mobileNumber, injuryOrSickness, doctorFeesPerDay, nurseFeesPerDay, roomType, roomCharges, extraScansCharges)
                Console.WriteLine("------------------------------Patient recipt-----------------------")
                Console.WriteLine("InPatient Details:")
                inPatient.getInPatientDetails()
                Console.WriteLine("Total Bill: " & inPatient.calculateTotalBill())

            Case 2 ' OutPatient
                Console.WriteLine("Enter OutPatient Details:")
                Console.Write("Doctor Consultant Fees: ")
                Dim doctorConsultantFees As Decimal = Decimal.Parse(Console.ReadLine())

                Console.Write("Medicine Cost: ")
                Dim medicineCost As Decimal = Decimal.Parse(Console.ReadLine())

                Dim outPatient As New OutPatient(name, age, address, mobileNumber, injuryOrSickness, doctorConsultantFees, medicineCost)
                Console.WriteLine("------------------------------Patient recipt-----------------------")
                Console.WriteLine("OutPatient Details:")
                outPatient.getOutPatientDetails()
                Console.WriteLine("Total Bill: " & outPatient.calculateTotalBill())

            Case Else
                Console.WriteLine("Invalid choice!")

        End Select

        Console.ReadLine()
    End Sub

End Module


'''' <summary>
'''
''' 
''' 
''' Imports System


'
'
'
'
