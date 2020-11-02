Imports CaisseConsole

Public Class RefundWPF
    Inherits Refund

    Private _number As String

    Public Sub New(number As String, balance As Double)
        MyBase.New(balance)
        Me._number = number
    End Sub

    Public Shadows Function getName() As String
        Return String.Format("Avoir N°{0} = -{1}", Me._number, Me._balance)
    End Function
End Class
