Module Module1

    Sub Main()
        Dim x As Integer, y As Integer
        Console.Write("Nhap x: ")
        x = Console.ReadLine()
        Console.Write("Nhap y: ")
        y = Console.ReadLine()

        If x > y Then
            If x >= 10 Then
                Console.WriteLine("x lon hon hoac bang 10")
            Else
                Console.WriteLine("x nho hon 10")
            End If
        Else
            If y >= 20 Then
                Console.WriteLine("y lon hon hoac bang 20")
            Else
                Console.WriteLine("y be hon 20")
            End If
        End If
        Console.WriteLine("Press Enter Key to Exit...")
        Console.ReadLine()
    End Sub
End Module
