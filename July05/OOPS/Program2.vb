Public Class Employee
    Dim empId As Int16 = 12
    Dim empName As String = "sathish"

    Public Sub New()
        Console.WriteLine("Non Parameterised consutructor")
    End Sub

    Public Sub New(empId As Int16, empName As String)
        Console.WriteLine("Parameterised consutructor")
        Me.empId = empId
        Me.empName = empName
        Console.WriteLine()
    End Sub

    Public Sub New(emp As Employee)
        Console.WriteLine("copy consutructor")
        Me.empId = emp.empId
        Me.empName = emp.empName
    End Sub

    Protected Overrides Sub finalize()
        Console.WriteLine("Object is destroyed")
    End Sub
    Public Sub display()
        Console.WriteLine("ID: {0}, Name: {1} ", empId, empName)
    End Sub

End Class
