Module Module3
    Public Class [Class]
        Public age As Integer
    End Class
    Sub MySub1()
        Dim p1 As [Class] = New [Class]()
        p1.age = 10
        Console.WriteLine("Age: " & p1.age)
        Console.WriteLine("Press Enter Key to Exit...")
        Console.ReadLine()
    End Sub
End Module
