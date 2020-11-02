Imports CaisseConsole

Public Class Caisse

    Private order As OrderWPF

    Public Sub New()
        Me.order = New OrderWPF()
    End Sub

    Private Sub AddProductClick(sender As Object, e As RoutedEventArgs)
        Dim productName As String = TBProductName.Text
        Dim productQty As Integer = TBProductQty.Text
        Dim productUnitPrice As Double = TBProductUnitPrice.Text

        TBProductName.Text = ""
        TBProductQty.Text = ""
        TBProductUnitPrice.Text = ""

        Dim product = New ProductWPF(productName, productQty, productUnitPrice)

        order.addLine(product)

        cumulAmount.Text = order.getAmount()

        listBoxRecap.Items.Add(product.getName())


    End Sub

    Private Sub AddRefundClick(sender As Object, e As RoutedEventArgs)
        Dim refundNumber As String = TBRefundNumber.Text
        Dim refundBalance As Double = TBRefundBalance.Text

        TBRefundBalance.Text = ""
        TBRefundNumber.Text = ""

        Dim refund As New RefundWPF(refundNumber, refundBalance)

        order.addLine(refund)

        cumulAmount.Text = order.getAmount()

        listBoxRecap.Items.Add(refund.getName())

    End Sub
End Class
