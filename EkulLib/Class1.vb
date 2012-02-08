Namespace maths
    Public Module Stats
        Function Average(ByVal IArrValues() As Integer) As Decimal
            Dim BIalpha As Integer = 0
            For Each Ival As Integer In IArrValues
                BIalpha += Ival
            Next
            Dim Decanswer As Decimal = (BIalpha / (IArrValues.Length))
            Return Decanswer
        End Function

    End Module
End Namespace
Namespace Array

    Public Module Core
        Sub append(ByRef arr As System.Array, ByVal objecttoadd As Object)

        End Sub
    End Module
End Namespace

