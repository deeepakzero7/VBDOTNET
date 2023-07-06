
Imports System

Module Program


    Sub main(args As String)


        'pla1()
        'gmail()
        'functionpla2()
        'Ma()




        Dim x As Integer = 10
        Dim y As Integer = 5
        Console.WriteLine("x > y : " & (x > y))
        Console.WriteLine("x < y : " & (x < y))
        Console.WriteLine("x >= y : " & (x >= y))
        Console.WriteLine("x <= y : " & (x <= y))
        Console.WriteLine("x = y : " & (x = y))
        Console.WriteLine("x != y : " & (x <> y))
    End Sub

    Sub palindrome()
        Console.WriteLine("Enter the String")
        Dim str As String = Console.ReadLine()
        Dim str1 As String = ""
        For i As Integer = 0 To i < str.Length Step i + 1
            str1 = str.Chars(i) + str1

        Next
        If str.Equals(str1) Then
            Console.WriteLine("Its a palindrome")

        Else

            Console.WriteLine("Its a palindrome")

        End If


    End Sub





    Sub pla1()
        Console.Write("Enter a string: ")
        Dim input As String = Console.ReadLine()

        If IsPalindrome(input) Then
            Console.WriteLine("The string is a palindrome.")
        Else
            Console.WriteLine("The string is not a palindrome.")
        End If

        Console.ReadLine()
    End Sub

    Function IsPalindrome(str As String)
        Dim reversed As String = ""
        For i As Integer = str.Length - 1 To 0 Step -1
            reversed += str(i)
        Next

        Return str.ToLower() = reversed.ToLower()
    End Function



    Sub gmail()

        Console.Write("Enter an email address: ")
        Dim email As String = Console.ReadLine()
        email = email.ToUpper
        Dim letterCount As Integer = 0
        Dim numberCount As Integer = 0
        Dim specialCount As Integer = 0

        For i = 0 To email.Length - 1
            If Asc(email.Chars(i)) >= 65 And Asc(email.Chars(i)) <= 91 Then
                letterCount += 1
            ElseIf Asc(email.Chars(i)) >= 48 And Asc(email.Chars(i)) <= 57 Then
                numberCount += 1
            Else
                specialCount += 1
            End If
        Next

        Console.WriteLine("Letters = {0}", letterCount)
        Console.WriteLine("Numbers ={0}", numberCount)
        Console.WriteLine("Special characters = {0}", specialCount)
    End Sub





    'Get the mail id As the input And show total count Of the letters , numbers ands special characters In the mail id

    'input
    'dk23@gmail.com

    ' check whether it Is palindrome Or Not, it it Is palindrome print whether it Is String Or number plaindrome



    'Sub quespalf()

    '    Dim input As String
    '    Console.Write("Enter a string or number: ")
    '    input = Console.ReadLine()

    '    Dim isPalindrome As Boolean = True


    '    Dim length As Integer = input.Length
    '    For i As Integer = 0 To length \ 2
    '        If input(i) <> input(length - i - 1) Then
    '            isPalindrome = False
    '
    '        End If
    '    Next
    '
    '
    '    If isPalindrome Then
    '        If IsNumeric(input) Then
    '            Console.WriteLine("The given input is a number palindrome.")
    '        Else
    '            Console.WriteLine("The given input is a string palindrome.")
    '        End If
    '    Else
    '        Console.WriteLine("The given input is not a palindrome.")
    '    End If

    '    Console.ReadLine()
    'End Sub

    ''' <summary>
    ''' write the vb.net program to get username and password check if the user enter wrong username or password show the output as  invalid creadentials and display to get same username and passord again
    ''' </summary>


    Sub functionpla2()
        Console.Write("Enter a string: ")
        Dim input As String = Console.ReadLine()


        If IsvPalindrome(input) Then
            If IsNumeric(input) Then
                Console.WriteLine("The given input is a number palindrome.")
            Else
                Console.WriteLine("The given input is a string palindrome.")
            End If
        Else
            Console.WriteLine("The given input is not a palindrome.")
        End If

        Console.ReadLine()

        Console.ReadLine()
    End Sub

    Function IsvPalindrome(str As String)
        Dim reversed As String = ""
        For i As Integer = str.Length - 1 To 0 Step -1
            reversed += str(i)
        Next

        Return str = reversed
    End Function





    'Function isnum()

    'End Function



    Sub Ma()
        Dim validUsername As String = "admin"
        Dim validPassword As String = "password"
        Dim username As String
        Dim password As String

        While True
            Console.WriteLine("Enter username:")
            username = Console.ReadLine()
            Console.WriteLine("Enter password:")
            password = Console.ReadLine()

            If username = validUsername AndAlso password = validPassword Then
                Console.WriteLine("Login successful!")
                Exit While
            Else
                Console.WriteLine("Invalid credentials. Please try again.")
            End If
        End While

        Console.ReadLine()
    End Sub




    ''' 
    '''



    '''single inheritance
    '''multi level inheritance 
    '''hierachical inheritance
    '''


    'If the passanger Is senior citizen Then 25 % discount On =his fare 
    'If the passager Is under age that Is below 5 the ticket fare Is half Of the original price
    '\\passenger name and passenger


    '''if passenger are more than one ..print the price of the ticket
    '''


    '''2nd program

    '''Get detail Of books and print as output of details of that6 book\ if dop exceed 10 days the fine is 25 rupeees
    '''
    ''''''write the vbdotnet program to create a train class with number, name, fare, passenger name, passenger age and function getdetails and print details if the passenger is senior , for senior passenger the age is above 60,and the senior passeger get 25% discount. if the passenger is under age 5 the fare is 50% discount and print the output 
    '''
    '''



End Module
