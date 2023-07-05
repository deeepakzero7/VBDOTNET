
Imports System
Imports System.Security.Cryptography
Imports System.Threading

Module Program
    Sub Main(args As String())
        'AmstrongNumber()
        'Tables()
        'Population()
        'Inputs()
        'phone()
        'multiDim()
        'UniqueEmployeeNames()
        'cyclicRotation()
        Ascsort()
    End Sub

    Sub AmstrongNumber()
        Dim num As Int64
        For num = 1 To 1000
            If isAmstrong(num) Then
                Console.WriteLine(num)
            End If
        Next
    End Sub

    Function isAmstrong(num As Int64)
        Dim total As Int64 = 0
        Dim temp = num
        While num > 0
            Dim digit As Int64
            digit = num Mod 10
            total += (digit ^ 3)
            num \= 10
        End While
        Return total = temp
    End Function


    Sub Tables()
        Dim n As Int64
        Dim i As Int64
        Console.WriteLine("Enter the value of n: ")
        n = Convert.ToInt64(Console.ReadLine())
        Console.WriteLine("Enter the value of i: ")
        i = Convert.ToInt64(Console.ReadLine())
        For num As Integer = 1 To i
            Console.WriteLine(n & " * " & num & " = " & (n * num))
        Next
    End Sub

    Sub Population()
        Dim totalPopulation As Int64 = 1049358
        Dim malePopulationPer = 57
        Dim maleLiteracyPer = 79
        Dim maleIilerate As Int64
        Dim malePop = (totalPopulation / 100) * malePopulationPer
        Dim maleLitPop = (malePop / 100) * maleLiteracyPer
        maleIilerate = malePop - maleLitPop
        Console.WriteLine("Male Illerate Population: " & maleIilerate)
    End Sub

    Sub Inputs()
        Dim ID As Int64
        Dim name As String
        Dim percentage As Double
        Dim mark As Decimal
        Dim grade As Char
        Dim result As Boolean
        Console.WriteLine("Enter your Id : ")
        ID = Convert.ToInt64(Console.ReadLine())
        Console.WriteLine("Enter your name : ")
        name = Console.ReadLine()
        Console.WriteLine("Enter your percentage : ")
        percentage = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Enter your mark : ")
        mark = Convert.ToDecimal(Console.ReadLine())
        Console.WriteLine("Enter your grade : ")
        grade = Convert.ToChar(Console.ReadLine())
        Console.WriteLine("Enter the result : ")
        result = Convert.ToBoolean(Console.ReadLine())
        Console.WriteLine("ID: {0},Name: {1},Percentage: {2},mark: {3},grade: {4},result{5}", ID, name, percentage, mark, grade, result)
    End Sub

    Sub phone()
        Dim number As Int64
        Console.WriteLine("Enter your phone number")
        number = Convert.ToInt64(Console.ReadLine())
        Dim odd As Int64
        Dim even As Int64
        Dim temp = number
        Dim switch As Boolean = True
        Dim evenreverse = 0
        Dim evenanswer = 0
        Dim oddreverse = 0
        Dim oddanswer = 0

        While temp > 0
            If switch Then
                even += temp Mod 10
                evenreverse = evenanswer * 10
                evenanswer = evenreverse + (temp Mod 10)
                switch = False
            Else
                odd += temp Mod 10
                oddreverse = oddanswer * 10
                oddanswer = oddreverse + (temp Mod 10)
                switch = True
            End If
            temp \= 10
        End While

        Console.WriteLine("{0},{1}", NumReverse(oddanswer), NumReverse(evenanswer))
        Console.WriteLine("{0},{1}", odd, even)

        If odd <> 0 Then
            While findLength(odd) <> 1
                Dim lc = odd
                Dim singleOdd = 0
                While lc > 0
                    singleOdd += lc Mod 10
                    lc \= 10
                End While
                odd = singleOdd
            End While

        End If
        If even <> 0 Then
            While findLength(even) <> 1
                Dim lc = even
                Dim singleEven = 0
                While lc > 0
                    singleEven += lc Mod 10
                    lc \= 10
                End While
                even = singleEven
            End While
        End If

        Console.WriteLine("{0},{1}", odd, even)
        Console.WriteLine("Addition: " & (odd + even))
        Console.WriteLine("subtraction: " & (odd - even))
    End Sub

    Function findLength(temp As Int64)
        Dim length As Int64 = 0
        While temp > 0
            temp = temp \ 10
            length += 1
        End While
        Return length
    End Function

    Function NumReverse(number As Int64)
        Dim reverse As Int64 = 0
        Dim answer As Int64 = 0
        While number > 0
            reverse = answer * 10
            answer = reverse + (number Mod 10)
            number \= 10
        End While
        Return answer
    End Function


    'Sub array()
    'Dim num() As Integer = {12, 23, 11, 23, 23}
    'For i = 0 To 4
    '    Console.WriteLine(num(i))
    'Next
    'Dim names() As String = {"sathish", "deepak", " parthipan"}
    'For i = 0 To names.Length - 1
    '    Console.WriteLine(names(i))
    'Next
    'Dim size As Int16
    'Console.WriteLine("enter the size: ")
    'size = Console.ReadLine()
    'Dim array() As Integer = New Integer(10) {}
    'For i As Integer = 0 To array.Length - 1
    '        array(i) = Console.ReadLine()
    '    Next

    'End Sub
    'strin array = name of the employee only show unique value 
    'sort an array
    'cyclic rotation of a array n

    Sub multiDim()
        Dim row As Integer
        Dim column As Integer
        Console.WriteLine("Enter Row value: ")
        row = Console.ReadLine()
        Console.WriteLine("Enter colum value : ")
        column = Console.ReadLine()
        Dim matrix(,) As Integer = New Integer(row, column) {}
        For i = 0 To row - 1
            For j = 0 To column - 1
                Console.WriteLine("Enter matrix value ({0},{1})", i, j)
                matrix(i, j) = Console.ReadLine()
            Next
        Next
        Console.WriteLine("The Elements of the matrix are: ")
        For i = 0 To row - 1
            For j = 0 To column - 1
                Console.Write(" " & matrix(i, j))

            Next
            Console.WriteLine()

        Next


    End Sub

    Sub UniqueEmployeeNames()
        Dim noOfEmployees As Integer
        Console.WriteLine("Enter no of Employees")
        noOfEmployees = Console.ReadLine()
        Dim nameArray() As String = New String(noOfEmployees) {}

        For i = 0 To noOfEmployees - 1
            nameArray(i) = Console.ReadLine()
        Next
        For i = 0 To noOfEmployees - 1
            For j = i + 1 To noOfEmployees - 1
                If nameArray(i) = nameArray(j) Then
                    nameArray(j) = ""
                End If
            Next
        Next
        Dim sum As Integer = 0

        For Each i In nameArray
            If i = "" Then
            Else
                sum += 1
            End If
        Next

        Console.WriteLine(sum)
        Dim val = 0
        Dim unique() As String = New String(sum) {}
        For Each i In nameArray
            If i <> "" Then
                unique(val) = i
                val += 1
            End If
        Next
        Console.WriteLine("The Unique values is: ")
        For i = 0 To unique.Length - 1
            Console.WriteLine(unique(i) & " ")
        Next

    End Sub

    Sub Ascsort()
        Dim size = Console.ReadLine()
        Dim array() As Integer = New Integer(size) {}
        For i As Int16 = 0 To size
            array(i) = Console.ReadLine()
        Next
        For i As Int16 = 0 To size
            For j As Int16 = 1 To size
                If array(j) < array(j - 1) Then
                    Dim temp = array(j)
                    array(j) = array(j - 1)
                    array(j - 1) = temp
                End If
            Next
        Next
        Console.WriteLine("The Sorted Array Is: ")
        For Each i In array
            Console.Write(i & " ")
        Next
    End Sub

    Sub Dscsort()
        Dim size = Console.ReadLine()
        Dim array() As Integer = New Integer(size) {}
        For i As Int16 = 0 To size
            array(i) = Console.ReadLine()
        Next
        For i As Int16 = 0 To size
            For j As Int16 = 1 To size
                If array(j) > array(j - 1) Then
                    Dim temp = array(j)
                    array(j) = array(j - 1)
                    array(j - 1) = temp
                End If
            Next
        Next
        Console.WriteLine("The Sorted Array Is: ")
        For Each i In array
            Console.Write(i & " ")
        Next
    End Sub


    Sub cyclicRotation()
        Dim n As Int16
        Console.Write("Enter n value: ")
        n = Console.ReadLine()
        Dim array() As Integer = {1, 2, 3, 4, 5, 6, 7}
        While (n > 0)
            Dim temp = array(0)
            For i = 0 To array.Length - 2
                array(i) = array(i + 1)
            Next
            array(array.Length - 1) = temp
            n -= 1
        End While
        Console.WriteLine("The Rotated Array is: ")
        For Each i In array
            Console.Write(i & " ")
        Next

    End Sub


End Module
