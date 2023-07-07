Imports System
Imports System.Threading

Module Program
    Sub Main(args As String())


        Dim trainobj As train = New train
        trainobj.result()
        trainobj.tickets()
    End Sub

    Class train
        Dim count As Integer = 0
        Dim passengerName(count) As String
        Dim passengerage(count) As Integer
        Dim fare As Double = 300
        Dim discount As Double
        Dim trainName As String
        Dim trainNumber As Integer

        Sub result()
            If (count = 0) Then
                Console.WriteLine("Enter Train Details:")
                Console.Write("Train Number: ")
                trainNumber = (Console.ReadLine())

                Console.Write("Train Name: ")
                trainName = Console.ReadLine()
            End If

            Console.WriteLine("Enter Passenger Details:")
            Console.Write("Passenger Name: ")
            passengerName(count) = Console.ReadLine()
            Console.Write("Passenger Age: ")
            passengerage(count) = Console.ReadLine()

            If passengerage(count) > 60 Then
                discount += fare - ((fare) * 0.25)
            ElseIf passengerage(count) <= 5 Then
                discount += fare \ 2
            Else
                discount += fare
            End If

            Dim add As String
            Console.Write("Add passenger:Add/No ")
            add = Console.ReadLine()
            add = add.ToLower()

            If add.Equals("no") Then
                Exit Sub
            Else
                count += 1
                Array.Resize(passengerage, count + 1)
                Array.Resize(passengerName, count + 1)
                result()
            End If


        End Sub

        Sub tickets()

            Console.WriteLine("Train Name:{0}", trainName)
            Console.WriteLine()
            Console.WriteLine("Train no: {0}", trainNumber)

            Console.WriteLine("Passenger Detrails")
            For i = 0 To count
                Console.WriteLine("{0}", passengerName(i))
                For j = 0 To (30 - passengerName(i).Length)

                Next
                Console.Write(passengerage(i))
                Console.WriteLine()
            Next

            Console.WriteLine("No of passenger: {0}", count + 1)


            Console.WriteLine("Total Fare: {0}", discount)



        End Sub
    End Class

End Module
