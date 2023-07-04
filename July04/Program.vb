Imports System

Module Program
    Sub Main(args As String())


        Dim numvalue As Integer
        Dim charvalue As Char
        Dim stringvalue As String
        Dim doublevalue As Double
        Dim decivalue As Decimal
        Dim boolvalue As Boolean

        numvalue = Convert.ToInt16(Console.ReadLine())
        stringvalue = (Console.ReadLine())
        charvalue = (Console.ReadLine())
        doublevalue = Convert.ToDouble(Console.ReadLine())
        decivalue = Convert.ToDecimal(Console.ReadLine())
        boolvalue = Convert.ToBoolean(Console.ReadLine())



        Console.WriteLine(numvalue)
        Console.WriteLine(charvalue)
        Console.WriteLine(stringvalue)
        Console.WriteLine(doublevalue)
        Console.WriteLine(decivalue)
        Console.WriteLine(boolvalue)

        Dim totalpopulation As Integer = 1049353
        Dim malepercentage As Double = 0.57
        Dim literacypercentage As Double = 0.79
        Dim malepopulation As Integer = totalpopulation * malepercentage
        Dim literatepopulation As Integer = totalpopulation * literacypercentage
        Dim illetratepopulation As Integer = totalpopulation - literatepopulation
        Console.WriteLine(illetratepopulation)


    End Sub
End Module
