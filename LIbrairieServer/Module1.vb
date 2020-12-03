Module Module1

    Sub Main()

        'Console.WriteLine("Saisir les informations d'un livre ")
        'Console.WriteLine("Titre : ")
        'Dim titre As String = Console.ReadLine()
        'Console.WriteLine("Résumé : ")
        'Dim description As String = Console.ReadLine()
        'Console.WriteLine("Date de Publication : ")
        'Dim datePublication As String = Console.ReadLine()
        'Console.WriteLine("Nb de pages : ")
        'Dim nbPage As Int32 = Console.ReadLine()
        'Console.WriteLine("Editeur : ")
        'Dim editeur As String = Console.ReadLine()


        'Dim livre As New Livre(titre, DateTime.Parse(datePublication), nbPage, editeur)
        'livre.Description = description

        'DBConnect.SaveQuery(livre)

        'Console.WriteLine("Livre sauvegardé ! ")


        Dim livres As List(Of Livre) = LivreRepository.GetAll()

        For Each livre As Livre In livres
            Console.WriteLine("{0} - {1} édité chez {2}", livre.Titre, livre.NbPages, livre.Editeur)
        Next

        Console.ReadLine()

    End Sub

End Module
