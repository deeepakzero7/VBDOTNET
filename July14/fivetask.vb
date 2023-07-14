Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        'two()
        'Console.ReadLine()
        'third()
        'Console.ReadLine()
        'fourth()
        'Console.ReadLine()
        fifth()
        'demo()




        'Console.WriteLine("No of employess :")
        'Dim noofstudents As Integer = Integer.Parse(Console.ReadLine())


        'Dim studentDetails As New List(Of Student)()
        'Dim stu As Student() = New Student(noofstudents) {}


        'For i = 1 To noofstudents

        '    stu(i) = New Student



        '    Console.Write("Student ID: ")
        '    stu(i).Id = Console.ReadLine()

        '    Console.Write("Name: ")
        '    stu(i).Name = Console.ReadLine()

        '    Console.Write("Department: ")
        '    stu(i).Department = Console.ReadLine()

        '    Console.Write("Percentage: ")
        '    stu(i).Percentage = Integer.Parse(Console.ReadLine())

        '    Console.Write("Year: ")
        '    stu(i).Year = Console.ReadLine()

        '    Console.Write("College Name: ")
        '    stu(i).CollegeName = Console.ReadLine()

        '    studentDetails.Add(stu(i))
        'Next

        'Dim steam As FileStream = New FileStream("C:\Users\User\Desktop\New Text Document.txt", FileMode.OpenOrCreate, FileAccess.Write)





        'Dim writer As New StreamWriter(steam)
        'For Each student As Student In studentDetails
        '    writer.Write(student.Id & " " & student.Name & " " & student.Department & " " & student.Percentage & " " & student.Year & vbCrLf)
        '    Console.WriteLine()
        'Next
        'writer.Close()
        'steam.Close()



        'Console.ReadLine()
    End Sub

    Class Student
        Public Property Id As String
        Public Property Name As String
        Public Property Department As String
        Public Property Percentage As Single
        Public Property Year As String
        Public Property CollegeName As String
    End Class







































    Class Student2
        Public Property Id As String
        Public Property Name As String
        Public Property Department As String
        Public Property Percentage As Single
        Public Property Year As String
        Public Property CollegeName As String
    End Class
    Sub two()
        'Console.WriteLine("Hello World!")


        'Console.WriteLine("No of employess :")
        'Dim noofstudents As Integer = Integer.Parse(Console.ReadLine())


        'Dim studentDetails As New List(Of Student)()
        'Dim stu As Student() = New Student(noofstudents) {}


        'For i = 1 To noofstudents

        '    stu(i) = New Student



        '    Console.Write("Student ID: ")
        '    stu(i).Id = Console.ReadLine()

        '    Console.Write("Name: ")
        '    stu(i).Name = Console.ReadLine()

        '    Console.Write("Department: ")
        '    stu(i).Department = Console.ReadLine()

        '    Console.Write("Percentage: ")
        '    stu(i).Percentage = Integer.Parse(Console.ReadLine())

        '    Console.Write("Year: ")
        '    stu(i).Year = Console.ReadLine()

        '    Console.Write("College Name: ")
        '    stu(i).CollegeName = Console.ReadLine()

        '    studentDetails.Add(stu(i))
        'Next

        Dim steam As FileStream = New FileStream("C:\Users\User\Desktop\New Text Document (2).txt", FileMode.OpenOrCreate, FileAccess.Read)





        Dim reader As New StreamReader(steam)


        Console.WriteLine(reader.ReadLine())

        reader.Close()
        steam.Close()



        Console.ReadLine()
    End Sub


























    Sub third()

        Dim file1Path As String = "file1.txt"
        Dim file2Path As String = "file2.txt"
        Dim outputPath As String = "comparedata.txt"
        Dim file1Data As List(Of String) = ReadFileData(file1Path)
        Dim file2Data As List(Of String) = ReadFileData(file2Path)
        Dim commonData As List(Of String) = FindCommonData(file1Data, file2Data)
        WriteToFile(outputPath, commonData)
        Console.WriteLine("Common data has been written to the output file.")
        Console.ReadLine()
    End Sub
    Function ReadFileData(filePath As String)
        Dim data As New List(Of String)()

        Dim reader As New StreamReader(filePath)
        Dim line As String = reader.ReadLine()

        While line IsNot Nothing
            data.Add(line)
            line = reader.ReadLine()
        End While

        Return data
    End Function
    Function FindCommonData(list1 As List(Of String), list2 As List(Of String))
        Dim commonData As New List(Of String)()

        For Each item In list1
            If list2.Contains(item) Then
                commonData.Add(item)
            End If
        Next

        Return commonData
    End Function
    Sub WriteToFile(filePath As String, data As List(Of String))

        Dim steam As FileStream = New FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write)



        Dim writer As New StreamWriter(steam)
        For Each item In data
            writer.Write(item & vbCrLf & "")
        Next
        writer.Close()
        steam.Close()


    End Sub




    Sub fourth()


        Dim filePath As String = "student_details.txt"
        Dim studentDetails As List(Of String) = ReadStudentDetails(filePath)
        studentDetails = SortByGraduationYear(studentDetails)


        ReplaceStudentDetails(filePath, studentDetails)

        Console.WriteLine("Student details sorted and replaced in the file.")
        Console.ReadLine()
    End Sub

    Function ReadStudentDetails(filePath As String) As List(Of String)
        Dim studentDetails As New List(Of String)()

        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    studentDetails.Add(reader.ReadLine())
                End While
            End Using
        Else
            Console.WriteLine("File not found.")
        End If

        Return studentDetails
    End Function




    '''''''''''''''''''''''009


    ''' ''''''''''''''''''''009

    Function SortByGraduationYear(studentDetails As List(Of String)) As List(Of String)
        studentDetails.Sort(AddressOf CompareGraduationYears)
        Return studentDetails
    End Function

    Function CompareGraduationYears(detail1 As String, detail2 As String) As Integer
        Dim graduationYear1 As Integer = GetGraduationYear(detail1)
        Dim graduationYear2 As Integer = GetGraduationYear(detail2)

        Return graduationYear1.CompareTo(graduationYear2)
    End Function


    ''' <summary>


    Function GetGraduationYear(detail As String) As Integer
        Dim parts As String() = detail.Split(" ")
        Dim graduationYear As Integer

        If parts.Length > 1 AndAlso Integer.TryParse(parts(1), graduationYear) Then
            Return graduationYear
        Else
            Return 0
        End If
    End Function
    ''' <summary>
    ''' ''''''''''''''''''''''''''''''''''''''''''

    Sub ReplaceStudentDetails(filePath As String, studentDetails As List(Of String))




        Dim steam As FileStream = New FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write)



        Dim writer As New StreamWriter(steam)
        For Each item In studentDetails
            writer.Write(item & vbCrLf & "")
        Next
        writer.Close()
        steam.Close()



    End Sub




    '001 2023 deepak
    '002 2020 sathish
    '003 2022 parthiban
    '004 2018 prasanth





    Sub fifth()

        Dim filePath As String = "fifth.txt"
        Dim data As List(Of String) = File.ReadAllLines(filePath).ToList()


        Dim a As Integer = -1
        For i As Integer = 0 To data.Count - 1
            If data(i).Contains("deepak") Then
                a = i
                Exit For
            End If
        Next


        If a >= 0 Then
            data.RemoveAt(a)
        End If

        File.WriteAllLines(filePath, data)



    End Sub



End Module














