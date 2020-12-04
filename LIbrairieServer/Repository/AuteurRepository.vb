Imports System.Data.SqlClient

Public Class AuteurRepository

    Public Shared Function GetAll() As List(Of Auteur)

        Dim auteurs As New List(Of Auteur)
        Dim db As SqlConnection = DBConnect.GetConnection()
        Dim requete As New SqlCommand("SELECT au.id, au.nom, au.prenom, au.date_naissance 
                                        FROM Auteur au")
        requete.Connection = db

        Dim reader As SqlDataReader

        Try

            db.Open()
            reader = requete.ExecuteReader()

            While reader.Read()

                Dim auteur As New Auteur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3))

                auteurs.Add(auteur)

            End While
            reader.Close()


        Catch ex As Exception
            Console.WriteLine("Erreur : {0}", ex.Message)
        Finally

            db.Close()

        End Try

        Return auteurs

    End Function

    Public Shared Function GetById(id As Integer) As Auteur

        Dim auteur As Auteur

        Dim db As SqlConnection = DBConnect.GetConnection()

        Dim query As New SqlCommand("SELECT au.id, au.nom, au.prenom, au.date_naissance 
                                        FROM Auteur au WHERE au.id = @auteurId", db)

        query.Parameters.AddWithValue("@auteurId", id)

        Dim reader As SqlDataReader

        Try

            db.Open()

            reader = query.ExecuteReader()

            While reader.Read()
                auteur = New Auteur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3))
            End While

            reader.Close()

        Catch ex As Exception
            Console.WriteLine("Erreur : {0}", ex.Message)
        Finally

            db.Close()

        End Try

        Return auteur

    End Function

End Class
