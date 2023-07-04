
 Module Program
    Sub Main()
        Dim totalPopulation = 149353
        Dim malePercentage = 0.57
        Dim literacyPercentage = 0.79

        Dim malePopulation As Integer = totalPopulation * malePercentage
        Dim literatePopulation As Integer = totalPopulation * literacyPercentage
        Dim illiteratePopulation = totalPopulation - literatePopulation

        Console.WriteLine(illiteratePopulation)

        
    End Sub
End Module



