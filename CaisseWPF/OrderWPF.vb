Imports CaisseConsole

Public Class OrderWPF
    Inherits Order

    Public Shadows Function getAmount() As Double
        Me._totalAmount = Nothing
        Return IIf(MyBase.getAmount() > 0, MyBase.getAmount(), 0)
    End Function

    Public Function getRecap() As List(Of String)
        Dim recap As New List(Of String)

        For Each line As IOrderLine In Me._orderLines
            recap.Add(line.getName())
        Next

        Return recap
    End Function

End Class
