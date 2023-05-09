Module Module2
    Sub MySub()
        Dim x As Integer = 20, y As Integer = 20
        Dim result As String
        ' Nested Ternary Operator'
        result = If((x > y), "x lon hon y", If((x < y), "x be hon y", "x bang y"))
        Console.WriteLine(result)
        Console.WriteLine("Press Enter Key to Exit...")
        Console.ReadLine()
    End Sub
End Module
