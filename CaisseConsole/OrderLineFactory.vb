Public Class OrderLineFactory

    Public Shared Function getInstanceProduct() As Product
        Return Product.getProduct()
    End Function

    Public Shared Function getInstanceRefund() As Refund
        Return Refund.getRefund()
    End Function

    Public Shared Function getInstance(ByVal objClass As String) As IOrderLine
        Select Case objClass
            Case "Product"
                Return getInstanceProduct()
            Case "Refund"
                Return getInstanceRefund()
        End Select
    End Function


End Class
