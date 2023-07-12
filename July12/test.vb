Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        two()


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
        '    writer.Write(student.Id & " " & student.Name & " " & student.Department & " " & student.Percentage & " " & student.Year)
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


End Module
