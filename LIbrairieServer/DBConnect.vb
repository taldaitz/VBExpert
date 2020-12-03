Imports System.Data.SqlClient

Public Class DBConnect

    Public Shared Sub SaveQuery(obj As IDataObject)

        Dim connexion As SqlConnection = GetConnection()

        Dim requete As New SqlCommand(obj.getInsertQuery())

        For Each parameter As SqlParameter In obj.getInsertParameters()
            requete.Parameters.Add(parameter)
        Next

        requete.Connection = connexion

        Try

            connexion.Open()
            requete.ExecuteNonQuery()

        Catch ex As Exception

            Console.WriteLine("Erreur : {0}", ex.Message)

        Finally
            connexion.Close()
        End Try

    End Sub

    Public Shared Function GetConnection()
        Dim connexion As New SqlConnection()
        connexion.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Librairie;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Return connexion
    End Function

End Class
