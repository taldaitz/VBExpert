Imports System.Data.SqlClient

Public Class LivreRepository


    Public Shared Function GetAll() As List(Of Livre)

        Dim livres As New List(Of Livre)
        Dim db As SqlConnection = DBConnect.GetConnection()
        Dim requete As New SqlCommand("SELECT id, titre, resume, date_publication, nb_Pages, editeur FROM Livre")
        requete.Connection = db

        Dim reader As SqlDataReader

        Try

            db.Open()
            reader = requete.ExecuteReader()

            While reader.Read()

                Dim livre As New Livre(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetInt32(4), reader.GetString(5))
                livres.Add(livre)

            End While
            reader.Close()


        Catch ex As Exception
            Console.WriteLine("Erreur : {0}", ex.Message)
        Finally

            db.Close()

        End Try

        Return livres

    End Function

End Class
