Imports System.ComponentModel.DataAnnotations
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions

Module Program
    Sub Main(args As String())
        'usingmatch()
        'withoutusingmatch()
        'replace()
        'split()
        'useridpass()
        ''small letter, length = 8, vbUpperCase Case, Random alphbets
        'phonenumber()
        'email()
        '''exceptionhandling()
        ''tryhandlemulti()
        'finalblock()
        'case2()
        Dim emp As employee = New employee
        emp.employeinfo()
        emp.showemployeinfo()





        Console.WriteLine("Hello World!")
    End Sub




    'match for regular expression 

    Sub usingmatch()
        Dim regex As Regex = New Regex("\d+")
        Dim input As String = Console.ReadLine()
        Dim match As Match = regex.Match(input)
        If match.Success Then
            Console.WriteLine(match.Value)
        End If
        Console.ReadKey()
    End Sub


    Sub email()
        Dim input As String = Console.ReadLine()
        Dim regex As Regex = New Regex("^[a-zA-Z][a-zA-Z0-9+_-]+@[a-z]+\.(com|in)$")
        Dim match As Match = regex.Match(input)
        If match.Success Then
            Console.WriteLine("valid")
        End If
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




    Sub withoutusingmatch()


        ' Without using Match
        Dim input As String = Console.ReadLine()
        Dim pattern As String = "\d+"
        Dim matches As MatchCollection = Regex.Matches(input, pattern)

        For Each m As Match In matches
            Console.WriteLine(m.Value)
        Next
    End Sub





    Sub replace()

        Dim input As String = "Dot 77 Perls"
        Dim pattern As String = "\d+"
        Dim replacement As String = "word"
        Dim rgx As New Regex(pattern)
        Dim result As String = rgx.Replace(input, replacement)
        Console.WriteLine("Original String: {0}", input)
        Console.WriteLine("Replacement String: {0}", result)
    End Sub
    Sub split()

        Dim words As String = "This is a sentence."
        Dim separators() As Char = {" "c, "."c}
        Dim resultWords() As String = Regex.Split(words, separators)
        For Each word In resultWords
            Console.WriteLine(word)
        Next
    End Sub


    Sub useridpass()
        Dim username As String = Console.ReadLine()
        Dim password As String = Console.ReadLine()
        Dim regex As Regex = New Regex("[A-Z]{1}[a-zA-Z0-9+@]+\w+{8, }")
        '("[A-Z]{1}[a-zA-Z0-9+@]+\w+{8, }")
        Dim match As Match = regex.Match(username)

        If (match.Success) Then
            Console.WriteLine("username is valid")
        Else
            Console.WriteLine("username is invalid")
        End If




    End Sub
    Sub tryhandlemulti()
        Dim num1, num2, res1 As Integer
        Dim arr() As Integer = New Int32(10) {}
        Dim val As String = "1234"
        num1 = 2
        num2 = 0
        Dim result As Integer = 0
        Try
            result = num1 / num2
            arr(8) = 38
            res1 = Convert.ToInt16(Val)
        Catch ex As Exception
            Console.WriteLine("€SOME ERROE OCCUR DUE TO:{0}", ex)

        End Try
        Console.WriteLine(result)
        Console.WriteLine("arrayu val:{0}", arr(3))
        Console.WriteLine("after conversion")


    End Sub
    Sub phonenumber()
        Dim username As String = Console.ReadLine()
        Dim password As String = Console.ReadLine()
        Dim regex As Regex = New Regex("[0-9]{10}")
        Dim match As Match = regex.Match(username)

        If (match.Success) Then
            Console.WriteLine("username is valid")
        Else
            Console.WriteLine("username is invalid")
        End If


    End Sub


    Sub exceptionhandling(num1 As Integer, ByVal num2 As Integer)

        Dim result As Integer
        Try
            result = num1 \ num2
        Catch e As DivideByZeroException
            Console.WriteLine("Exception caught: {0}", e)
        Finally
            Console.WriteLine("Result: {0}", result)
        End Try
    End Sub
    Sub cub()
        exceptionhandling(25, 0)
        Console.ReadKey()
    End Sub






    'final block make the code execute at any case
    'its a ciompulsory block




    Sub finalblock()
        Dim num1, num2, res1, value As Integer
        Dim arr() As Integer = New Int32(10) {}
        Dim val As String = "deepak"
        num1 = Convert.ToInt64(Console.ReadLine())
        num2 = Convert.ToInt64(Console.ReadLine())
        Dim array() As Integer = New Integer(5) {}
        Dim result As Integer = 0
        Try
            result = num1 \ num2
            value = Convert.ToInt16(val)
            arr(7) = 343
        Catch ex As DivideByZeroException
            Console.WriteLine("some error occured:{0}", ex)
        Catch ex As IndexOutOfRangeException
            Console.WriteLine("Index out of range:{0}", ex)
        Catch ex As FormatException
            Console.WriteLine("wrong format {0}", ex)

        Finally
            Console.WriteLine("finalblock block executed")
        End Try

        Console.WriteLine("Diviosin result:", result)

    End Sub

    Sub case2()

    End Sub



    Public Class employee
        Dim id As Integer
        Dim name As String
        Dim designation As String
        Dim office As String
        Dim city As String
        Sub employeinfo()
            Console.Write("Enter id: ")
            id = Convert.ToInt32(Console.ReadLine())
            Console.Write("Enter name: ")
            name = Console.ReadLine()
            Console.Write("Enter designation: ")
            designation = Console.ReadLine()
            Console.Write("Enter office: ")
            office = Console.ReadLine()
            Console.Write("city: ")
            city = Console.ReadLine()
        End Sub



        Public Sub showemployeinfo()
            Console.WriteLine("---------------------------Employee Details------------------------")
            Console.WriteLine(id)
            Console.WriteLine(name)
            Console.WriteLine(designation)
            Console.WriteLine(office)
            Console.WriteLine(city)
        End Sub

    End Class


    Class




End Module



