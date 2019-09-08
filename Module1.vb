Module Module1

    Sub Main()
        Dim CARNAME As String
        CARNAME = ""

        Dim Counter As Integer
        Counter = 0

        Console.Write(" Write your car name: ")
        CARNAME = Console.ReadLine()

        For Counter = 1 To 5
            Console.WriteLine(CARNAME)
        Next

        Console.WriteLine("Press any key to continue..")
        Console.ReadKey()
    End Sub

End Module
