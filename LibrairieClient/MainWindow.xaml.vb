Imports LibrairieClient.LibService

Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        Dim client As New ServiceClient()

        Dim nbAuteur As Integer = client.GetNbAuteur()
        labelNbAuteur.Content = String.Format("Nombre d'auteur : {0}", nbAuteur)


        Dim auteurs As Auteur() = client.GetAllAuteur()

        For Each auteur As Auteur In auteurs

            listAuteurs.Items.Add(auteur)

        Next

    End Sub

    Private Sub listAuteurs_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles listAuteurs.SelectionChanged

        Dim auteur As Auteur = listAuteurs.SelectedItem
        Dim client As New ServiceClient()

        labelNbLivre.Content = String.Format("a écrit {0} livres", client.GetNBLivreByAuteur(auteur.Id))



    End Sub
End Class
