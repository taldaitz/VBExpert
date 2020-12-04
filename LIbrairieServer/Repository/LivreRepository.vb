Imports System.Data.SqlClient

Public Class LivreRepository


    Public Shared Function GetAll() As List(Of Livre)

        Dim livres As New List(Of Livre)
        Dim db As SqlConnection = DBConnect.GetConnection()
        Dim requete As New SqlCommand("SELECT li.id, li.titre, li.resume, li.date_publication, li.nb_Pages, li.editeur, 
                                        au.id, au.nom, au.prenom, au.date_naissance 
                                        FROM Livre li JOIN Auteur au ON li.auteur_id = au.id")
        requete.Connection = db

        Dim reader As SqlDataReader

        Try

            db.Open()
            reader = requete.ExecuteReader()

            While reader.Read()

                Dim auteur As New Auteur(reader.GetInt32(6), reader.GetString(7), reader.GetString(8), reader.GetDateTime(9))

                Dim livre As New Livre(reader.GetInt32(0), reader.GetString(1),
                                       reader.GetString(2), reader.GetDateTime(3),
                                       reader.GetInt32(4), reader.GetString(5), auteur)
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

    Public Shared Function GetById(id As Integer) As Livre

        Dim livre As Livre

        Dim db As SqlConnection = DBConnect.GetConnection()

        Dim query As New SqlCommand("SELECT li.id, li.titre, li.resume, li.date_publication, li.nb_Pages, li.editeur, 
                                        au.id, au.nom, au.prenom, au.date_naissance 
                                        FROM Livre li JOIN Auteur au ON li.auteur_id = au.id
                                        WHERE li.id = @livreId", db)

        query.Parameters.AddWithValue("@livreId", id)

        Dim reader As SqlDataReader

        Try

            db.Open()

            reader = query.ExecuteReader()

            While reader.Read()
                Dim auteur As New Auteur(reader.GetInt32(6), reader.GetString(7), reader.GetString(8), reader.GetDateTime(9))

                livre = New Livre(reader.GetInt32(0), reader.GetString(1),
                                       reader.GetString(2), reader.GetDateTime(3),
                                       reader.GetInt32(4), reader.GetString(5), auteur)
            End While

            reader.Close()

        Catch ex As Exception
            Console.WriteLine("Erreur : {0}", ex.Message)
        Finally

            db.Close()

        End Try

        Return livre

    End Function

    Public Shared Function GetNbLivreByAuteur(auteurId As Integer) As Integer

        Dim nbLivre As Integer
        Dim db As SqlConnection = DBConnect.GetConnection()

        Dim query As New SqlCommand("SELECT COUNT(*) FROM Livre WHERE auteur_id = @auteurId", db)

        query.Parameters.AddWithValue("@auteurId", auteurId)

        Dim reader As SqlDataReader

        Try

            db.Open()

            reader = query.ExecuteReader()

            While reader.Read()
                nbLivre = reader.GetInt32(0)
            End While

            reader.Close()

        Catch ex As Exception
            Console.WriteLine("Erreur : {0}", ex.Message)
        Finally

            db.Close()

        End Try

        Return nbLivre

    End Function

End Class
