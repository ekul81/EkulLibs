Imports System.Numerics
Public Module Maths
    Function Average(ByVal IArrValues() As Integer)
        Dim BIalpha As BigInteger = 0
        For Each Ival As Integer In IArrValues
            BIalpha += Ival
        Next
        Return BIalpha / (IArrValues.Length)
    End Function
End Module
