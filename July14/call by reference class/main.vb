Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports System.Runtime.InteropServices
Imports ClassLibrary1
Imports ClassLibrary1.Class1

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        'two()
        'Console.ReadLine()
        'third()
        'Console.ReadLine()
        'fourth()
        'Console.ReadLine()
        'fifth()
        'demo()



        Dim obj As Class1 = New Class1
        Console.Write("Enter 1st number: ")
        Dim a As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Enter 2nd number: ")
        Dim b As Integer = Integer.Parse(Console.ReadLine())
        Dim c = obj.multiply(a, b)
        Console.Write(c)

    End sub
