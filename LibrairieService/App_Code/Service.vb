' REMARQUE : vous pouvez utiliser la commande Renommer du menu contextuel pour changer le nom de classe "Service" dans le code, le fichier svc et le fichier de configuration.
Imports LIbrairieServer

Public Class Service
    Implements IService

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements IService.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

    Public Function GetNbAuteur() As Integer Implements IService.GetNbAuteur
        Return AuteurRepository.GetAll().Count()
    End Function

    Public Function GetAllAuteur() As List(Of Auteur) Implements IService.GetAllAuteur
        Return AuteurRepository.GetAll()
    End Function

    Public Function GetNBLivreByAuteur(auteurId As Integer) As Integer Implements IService.GetNBLivreByAuteur
        Return LivreRepository.GetNbLivreByAuteur(auteurId)
    End Function
End Class
