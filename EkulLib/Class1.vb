Namespace maths
    ''' <summary>
    ''' Contains Maths and Maths related functions
    ''' </summary>
    ''' <remarks>
    ''' Organised into rough Modules according to where I normally come across said terms.
    ''' </remarks>
    Public Module Stats
        ''' <summary>
        ''' Calculates Mean value from an array of integers
        ''' </summary>
        ''' <param name="IArrValues">Array of integers to calculate from.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function Average(ByVal IArrValues() As Integer) As Decimal
            Dim BIalpha As Integer = 0
            For Each Ival As Integer In IArrValues
                BIalpha += Ival
            Next
            Dim Decanswer As Decimal = (BIalpha / (IArrValues.Length))
            Return Decanswer
        End Function
        Function Mode(ByVal Iarrinput() As Integer)
            Dim Iarrvals(-1) As Integer
            Dim Iarrnumof(-1) As Integer
            For Each Iinput As Integer In Iarrinput
                If Iarrvals.Count = 0 Then
                    EkulLib.Array.append(Iarrvals, Iinput)
                    EkulLib.Array.append(Iarrnumof, 1)
                Else
                    Dim Icounter As Integer = 0
                    Dim added As Boolean = False
                    For Each value In Iarrvals
                        If value = Iinput Then
                            Iarrnumof(Icounter) += 1
                            added = True
                        End If
                        Icounter += 1
                    Next
                    If added = False Then
                        EkulLib.Array.append(Iarrvals, Iinput)
                        EkulLib.Array.append(Iarrnumof, 1)
                    End If
                End If
            Next
            Iarrnumof = Iarrnumof
            Iarrvals = Iarrvals
            Return Iarrvals(Max(Iarrnumof).int2)
        End Function
        Function Max(ByVal Iarrinputvalue() As Integer) As EkulLib.returneditems.Doubleint
            Dim Icounter As Integer = 1
            Dim Imaxval As Integer = Iarrinputvalue(0)
            Dim Imaxposition As Integer = 0
            Do Until Iarrinputvalue.Length - 1 = Icounter
                If Iarrinputvalue(Icounter) > Imaxval Then
                    Imaxval = Iarrinputvalue(Icounter)
                    Imaxposition = Icounter
                End If
                Icounter += 1
            Loop
            Return New EkulLib.returneditems.Doubleint(Imaxval, Imaxposition)
        End Function
        Function Min(ByVal Iarrinputvalue() As Integer) As EkulLib.returneditems.Doubleint
            Dim Icounter As Integer = 1
            Dim Imaxval As Integer = Iarrinputvalue(0)
            Dim Imaxposition As Integer = 0
            Do Until Iarrinputvalue.Length - 1 = Icounter
                If Iarrinputvalue(Icounter) < Imaxval Then
                    Imaxval = Iarrinputvalue(Icounter)
                    Imaxposition = Icounter
                End If
                Icounter += 1
            Loop
            Return New EkulLib.returneditems.Doubleint(Imaxval, Imaxposition)
        End Function
    End Module

    Public Module Decision
        'Sub Insertionsort(ByRef IarrInput() As Integer)
        '    Dim counter As Integer = 0
        '    Dim temparr() As Integer = IarrInput
        '    Do Until counter = IarrInput.Count - 1


        '    Loop
        'End Sub
        'Sub checksort(ByRef IarrInput() As Integer)
        '    Dim IarrOutput(-1) As Integer
        '    Dim a As EkulLib.returneditems.Doubleint = EkulLib.maths.Min(IarrInput)
        '   IarrInput.Skip( a.int1()
        'End Sub
    End Module
End Namespace
Namespace Array
    ''' <summary>
    ''' contains array related functions.
    ''' </summary>
    ''' <remarks></remarks>

    Public Module Core

        ''' <summary>
        ''' Adds a new item onto the end of an array, expands it and then adds item in new location. Preserves existing data
        ''' </summary>
        ''' <param name="arr">array to add object too.</param>
        ''' <param name="objecttoadd">Object to add to array.</param>
        ''' <remarks></remarks>
        Sub append(Of T)(ByRef arr() As T, ByVal objecttoadd As T)
            ReDim Preserve arr(arr.Length)
            arr(arr.Length - 1) = objecttoadd
        End Sub
        Sub append(Of T)(ByRef arr() As IEnumerable(Of T), ByVal objecttoadd As T)
            ReDim Preserve arr(arr.Length)
            arr(arr.Length - 1) = objecttoadd
        End Sub
    End Module
End Namespace
Namespace returneditems
    Public Class Doubleint
        Sub New(ByVal I1 As Integer, ByVal I2 As Integer)
            int1 = I1
            int2 = I2
        End Sub
        Public int1 As Integer
        Public int2 As Integer
    End Class
End Namespace
