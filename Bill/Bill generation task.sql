Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")


        Console.WriteLine("Hello World!")
            Console.WriteLine("Hello World!")
            Dim obj As M = New M()
            obj.Main2()
        End Sub

        Class MenuItem
            Public Property Name As String
            Public Property Cost As Decimal
            Public Property Quantity As Integer
        End Class

        Class M
        Const GstRate As Decimal = 0.15

        Sub Main2()
            Dim currentDate As Date = Date.Now
            Dim yearFolder As String = currentDate.Year.ToString()
            Dim monthFolder As String = currentDate.ToString("MM")
            Dim dayFolder As String = currentDate.ToString("dd")

            If Not Directory.Exists(yearFolder) Then
                Directory.CreateDirectory(yearFolder)
            End If

            If Not Directory.Exists(Path.Combine(yearFolder, monthFolder)) Then
                Directory.CreateDirectory(Path.Combine(yearFolder, monthFolder))
            End If

            If Not Directory.Exists(Path.Combine(yearFolder, monthFolder, dayFolder)) Then
                Directory.CreateDirectory(Path.Combine(yearFolder, monthFolder, dayFolder))
            End If

            Dim menuItemsCost As New Dictionary(Of String, Decimal)()
            menuItemsCost.Add("parotta", 5)
            menuItemsCost.Add("chicken briyani", 12)
            menuItemsCost.Add("mutton briyani", 15)
            menuItemsCost.Add("chilli chicken", 8)
            menuItemsCost.Add("dosa", 6)

            Dim menuItems As String() = {"parotta", "chicken briyani", "mutton briyani", "chilli chicken", "dosa"}
            Dim totalAmount As Decimal = 0

            Console.WriteLine("Welcome to the Hotel!")
            Console.WriteLine("Menu Card:")
            For i As Integer = 0 To menuItems.Length - 1
                Console.WriteLine($"{i + 1}. {menuItems(i)} - ${menuItemsCost(menuItems(i))}")
            Next

            Dim orderCount As Integer = ReadOrderCount()
            Dim continueOrdering As Boolean = True
            Dim orderedItems As New List(Of MenuItem)()

            While continueOrdering
                Console.WriteLine("Enter the item number to order (0 to quit ordering):")
                Dim input As String = Console.ReadLine()
                Dim itemNumber As Integer

                If Integer.TryParse(input, itemNumber) AndAlso itemNumber >= 1 AndAlso itemNumber <= menuItems.Length Then
                    Dim itemName As String = menuItems(itemNumber - 1)

                    If Not orderedItems.Any(Function(item) item.Name = itemName) Then
                        orderedItems.Add(New MenuItem() With {
                            .Name = itemName,
                            .Cost = menuItemsCost(itemName),
                            .Quantity = 0
                        })
                    End If

                    Console.WriteLine($"Enter the quantity of {itemName} to order (or 'add' to add more):")
                    input = Console.ReadLine()
                    Dim quantity As Integer

                    If Integer.TryParse(input, quantity) AndAlso quantity >= 1 Then
                        Dim menuItem As MenuItem = orderedItems.Find(Function(item) item.Name = itemName)
                        menuItem.Quantity += quantity
                        Console.WriteLine($"You ordered: {quantity} {itemName} - ${menuItem.Cost * quantity}")
                        totalAmount += menuItem.Cost * quantity
                    ElseIf input.ToLower() = "add" Then
                        Console.WriteLine("Enter the additional quantity to add:")
                        input = Console.ReadLine()

                        If Integer.TryParse(input, quantity) AndAlso quantity >= 1 Then
                            Dim menuItem As MenuItem = orderedItems.Find(Function(item) item.Name = itemName)
                            menuItem.Quantity += quantity
                            Console.WriteLine($"You added: {quantity} {itemName} - ${menuItem.Cost * quantity}")
                            totalAmount += menuItem.Cost * quantity
                        Else
                            Console.WriteLine("Invalid input. Quantity must be a positive integer.")
                        End If
                    Else
                        Console.WriteLine("Invalid input. Quantity must be a positive integer.")
                    End If
                ElseIf itemNumber = 0 Then
                    continueOrdering = False
                Else
                    Console.WriteLine("Invalid input. Please enter a valid item number.")
                End If
            End While

            If orderedItems.Count > 0 Then
                orderCount += 1
                WriteOrderCount(orderCount)
                Dim billFileName As String = Path.Combine(yearFolder, monthFolder, dayFolder, $"Bill{orderCount}.txt")

                Using writer As New StreamWriter(billFileName)
                    writer.WriteLine($"Hotel Bill - Order {orderCount} - {currentDate}")
                    writer.WriteLine("---------------------------------------")
                    writer.WriteLine("Items Ordered:")
                    For Each item In orderedItems
                        writer.WriteLine($"{item.Quantity} {item.Name} - ${item.Cost * item.Quantity}")
                    Next
                    writer.WriteLine("---------------------------------------")
                    writer.WriteLine($"Total Amount: ${totalAmount}")
                    writer.WriteLine($"GST ({GstRate * 100}%): ${totalAmount * GstRate}")
                    writer.WriteLine("---------------------------------------")
                    writer.WriteLine($"Total Price (including GST): ${totalAmount + (totalAmount * GstRate)}")
                    writer.WriteLine("---------------------------------------")
                End Using
            End If
        End Sub

        Function ReadOrderCount() As Integer
                Dim orderCount As Integer = 0
                Dim orderCountFile As String = "order_count.txt"

                If File.Exists(orderCountFile) Then
                    Using reader As New StreamReader(orderCountFile)
                        Dim line As String = reader.ReadLine()

                        If Integer.TryParse(line, orderCount) Then
                            Return orderCount
                        End If
                    End Using
                End If

                Return orderCount
            End Function

            Sub WriteOrderCount(orderCount As Integer)
                Dim orderCountFile As String = "order_count.txt"

                Using writer As New StreamWriter(orderCountFile)
                    writer.WriteLine(orderCount)
                End Using
            End Sub
        End Class
    End Module
