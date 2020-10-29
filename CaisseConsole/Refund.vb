Public Class Refund
    Implements IOrderLine

    Private _balance As Double

    Public Sub New(balance As Double)
        _balance = balance
    End Sub

    Public Function getName() As String Implements IOrderLine.getName
        Return String.Format("Avoir - {0}", Me._balance)
    End Function

    Public Function getAmount() As Double Implements IOrderLine.getAmount
        Return Me._balance * -1
    End Function

    Public Shared Function getRefund() As Refund
        Console.WriteLine("Saisir le montant de l'avoir : ")
        Dim balance As Double = Console.ReadLine()

        Return New Refund(balance)
    End Function
End Class
