
Imports System
Module Program
Sub datatypes(args As String)
        Dim numvalue As Integer
        Dim strvalue As String
        Dim charvalue As Char
        Dim dcimalvalue As Decimal
        Dim doublevalue As Double
        Dim boolvalue As Boolean

        numvalue = Convert.ToInt32(Console.ReadLine())
        dcimalvalue = Convert.ToDecimal(Console.ReadLine())
        doublevalue = Convert.ToDouble(Console.ReadLine())
        boolvalue = Convert.ToBoolean(Console.ReadLine())
        strvalue = Console.ReadLine()
        charvalue = Console.ReadLine()

        Console.WriteLine(numvalue)
        Console.WriteLine(dcimalvalue)
        Console.WriteLine(doublevalue)
        Console.WriteLine(boolvalue)
        Console.WriteLine(strvalue)
        Console.WriteLine(charvalue)
  
    End Sub
  End Module
