Imports CaisseConsole

Public Class ProductWPF
    Inherits Product

    Public Sub New(name As String, quantity As Integer, unitPrice As Double)
        MyBase.New(name, quantity, unitPrice)
    End Sub

    Public Shadows Function getName()
        Return String.Format("{0} {1} = {2}", Me._quantity, Me._name, Me._unitPrice * Me._quantity)
    End Function
End Class
