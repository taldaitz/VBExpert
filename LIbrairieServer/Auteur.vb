Public Class Auteur

    Private _id As Integer
    Private _nom As String
    Private _prenom As String
    Private _dateNaissance As DateTime

    Public Sub New(id As Integer, nom As String, prenom As String, dateNaissance As Date)
        _id = id
        _nom = nom
        _prenom = prenom
        _dateNaissance = dateNaissance
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property

    Public Property Prenom As String
        Get
            Return _prenom
        End Get
        Set(value As String)
            _prenom = value
        End Set
    End Property

    Public Property DateNaissance As Date
        Get
            Return _dateNaissance
        End Get
        Set(value As Date)
            _dateNaissance = value
        End Set
    End Property
End Class
