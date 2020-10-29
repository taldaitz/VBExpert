Public Class Order

    Private _orderLines As New List(Of IOrderLine)
    Private _totalAmount As Double
    Private _number As Integer

    Public Sub addLine(ByVal line As IOrderLine)
        Me._orderLines.Add(line)
    End Sub

    Private Sub computeTotalAmount()
        For Each line As IOrderLine In Me._orderLines
            Me._totalAmount += line.getAmount()
        Next
    End Sub

    Public Function getAmount() As Double
        If Me._totalAmount = Nothing Then
            computeTotalAmount()
        End If

        Return Me._totalAmount
    End Function

End Class
