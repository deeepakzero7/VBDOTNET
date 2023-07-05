Imports System

Module Program


    Partial Class student
        Private id As Integer = 10
        Sub showID()
            Console.WriteLine("Student Id: {0}", id)
        End Sub
    End Class

    Class student
        Public name As String = "sathish"
        Sub showName()
            Console.WriteLine("student Name:{0} ", name)
        End Sub
    End Class
    Sub Main(args As String())
        'Dim emp1 As Employee = New Employee()
        'emp1.display()
        'Dim emp2 As Employee = New Employee(1222, "kumar")
        'emp2.display()
        'Dim emp3 As Employee = New Employee(emp1)
        'emp3.display()
        'first()
        'GC.Collect()
        Dim st As student = New student()
        st.showID()
        st.showName()

    End Sub

    Sub first()
        Dim emp1 As Employee = New Employee()
        emp1.display()
    End Sub
End Module
