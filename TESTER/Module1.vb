Module Module1

    Sub Main()
        Dim a(2) As Integer
        a = {100, 12, 19, 24, 312, 412, 67, 88, 99, 100, 12, 24, 312, 312, 312}
        EkulLib.Array.append(a, 4)
        Console.WriteLine("min: " + EkulLib.maths.Min(a).int1.ToString)
        Console.WriteLine("max: " + EkulLib.maths.Max(a).int1.ToString)
        Console.WriteLine("Mean: " + EkulLib.maths.Average(a).ToString)
        Console.WriteLine("mode: " + EkulLib.maths.Mode(a).ToString)
        EkulLib.maths.Insertionsort(a)
        a = a
        Console.ReadKey()
    End Sub

End Module
