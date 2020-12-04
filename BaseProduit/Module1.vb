Module Module1

    Sub Main()

        createData()

        Dim db As New ProductBase()

        Console.WriteLine("Selectionnez la liste souhaité : ")
        Console.WriteLine("1 - Liste des Produits")
        Console.WriteLine("2 - Liste des Avoirs")
        Console.WriteLine("3 - Liste des Clients")

        Dim choice As String = Console.ReadLine()

        Select Case choice
            Case "1"

                For Each product As Product In db.Products.ToList()
                    Console.WriteLine("*************************************")
                    Console.WriteLine("Nom : {0}", product.Name)
                    Console.WriteLine("Description : {0}", product.Description)
                    Console.WriteLine("Prix : {0}", product.UnitPrice)
                    Console.WriteLine("*************************************")
                Next

            Case "2"

                For Each refund As Refund In db.Refunds.ToList()
                    Console.WriteLine("*************************************")
                    Console.WriteLine("Numéro : {0}", refund.Number)
                    Console.WriteLine("Date : {0}", refund.CreatedDate)
                    Console.WriteLine("Montant : {0}", refund.Amount)
                    Console.WriteLine("*************************************")
                Next

            Case "3"

                For Each customer As Customer In db.Customers.ToList()
                    Console.WriteLine("*************************************")
                    Console.WriteLine("Prénom : {0}", customer.FirstName)
                    Console.WriteLine("Nom : {0}", customer.LastName)
                    Console.WriteLine("Email : {0}", customer.Email)
                    Console.WriteLine("*************************************")
                Next

        End Select

        db.Dispose()

        Console.ReadLine()

    End Sub


    Sub createData()

        Dim db As New ProductBase()

        Dim product As New Product()
        product.Name = "Souris"
        product.Description = "Souris d'ordinateur sans fil"
        product.UnitPrice = 17
        product.Status = "En stock"


        Dim refund As New Refund()
        refund.Number = "000004"
        refund.CreatedDate = DateTime.Now
        refund.Amount = 23
        refund.IsUsed = False

        Dim refund2 As New Refund()
        refund2.Number = "000005"
        refund2.CreatedDate = DateTime.Now
        refund2.Amount = 12
        refund2.IsUsed = True

        db.Refunds.Add(refund)
        db.Refunds.Add(refund2)

        Dim cust1 As New Customer()
        cust1.FirstName = "Thomas"
        cust1.LastName = "Aldaitz"
        cust1.Email = "toto"
        cust1.BirthDate = New DateTime(1985, 4, 28)
        cust1.City = "Lyon"

        Dim cust2 As New Customer()
        cust2.FirstName = "Robert"
        cust2.LastName = "Test"
        cust2.Email = "rere"
        cust2.BirthDate = New DateTime(1958, 4, 12)
        cust2.City = "Paris"

        'Dim cust3 As New Customer()
        'cust3.FirstName = "Jean"
        'cust3.LastName = "Test"
        'cust3.Email = "jtest@dawan.fr"
        'cust3.BirthDate = New DateTime(1960, 11, 23)
        'cust3.City = "Nantes"

        Dim customer As Customer = db.Customers.Where(Function(c) c.Id = 2).FirstOrDefault()

        db.Customers.Add(cust1)
        db.Customers.Add(cust2)
        'db.Customers.Add(cust3)

        db.SaveChanges()


    End Sub

End Module
