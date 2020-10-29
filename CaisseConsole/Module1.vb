Module Module1

    Sub Main()

        Dim order As New Order()

        While True
            Console.Clear()
            Console.WriteLine("Choisir la ligne à créer : ")
            Console.WriteLine("1 - Créer un nouveau produit ")
            Console.WriteLine("2 - Saisir un avoir ")
            Console.WriteLine("0 - Terminer")

            Dim choice As String = Console.ReadLine()

            If choice = "0" Then Exit While

            Dim line As IOrderLine

            Select Case choice
                Case "1"
                    line = Product.getProduct()

                Case "2"
                    line = Refund.getRefund()
            End Select


            order.addLine(line)
        End While

        Console.WriteLine("Le montant de la commande est : {0}", order.getAmount())

        Console.ReadLine()

    End Sub

End Module
