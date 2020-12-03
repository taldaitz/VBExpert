Imports System.Data.SqlClient
Imports System.Text

Public Class Livre
    Implements IDataObject

    Private _id As Int32
    Private _titre As String
    Private _description As String
    Private _datePublication As DateTime
    Private _nbPages As Integer
    Private _editeur As String

    Public Sub New(titre As String, datePublication As Date, nbPages As Integer, editeur As String)
        _titre = titre
        _datePublication = datePublication
        _nbPages = nbPages
        _editeur = editeur
    End Sub

    Public Sub New(id As Integer, titre As String, description As String, datePublication As Date, nbPages As Integer, editeur As String)
        Me.Id = id
        Me.Titre = titre
        Me.Description = description
        Me.DatePublication = datePublication
        Me.NbPages = nbPages
        Me.Editeur = editeur
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Titre As String
        Get
            Return _titre
        End Get
        Set(value As String)
            _titre = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property DatePublication As Date
        Get
            Return _datePublication
        End Get
        Set(value As Date)
            _datePublication = value
        End Set
    End Property

    Public Property NbPages As Integer
        Get
            Return _nbPages
        End Get
        Set(value As Integer)
            _nbPages = value
        End Set
    End Property

    Public Property Editeur As String
        Get
            Return _editeur
        End Get
        Set(value As String)
            _editeur = value
        End Set
    End Property

    Public Function getInsertQuery() As String Implements IDataObject.getInsertQuery
        Dim builder As New StringBuilder()

        builder.AppendLine("INSERT INTO Livre (titre, resume, date_publication, nb_pages, editeur) ")
        builder.AppendLine("VALUES (@Titre, @Resume, @DatePublication, @NbPages, @Editeur)")

        Return builder.ToString()
    End Function

    Public Function getInsertParameters() As List(Of SqlParameter) Implements IDataObject.getInsertParameters
        Dim parameters As New List(Of SqlParameter)

        parameters.Add(New SqlParameter("@Titre", Me.Titre))
        parameters.Add(New SqlParameter("@Resume", Me.Description))
        parameters.Add(New SqlParameter("@DatePublication", Me.DatePublication))
        parameters.Add(New SqlParameter("@NbPages", Me.NbPages))
        parameters.Add(New SqlParameter("@Editeur", Me.Editeur))

        Return parameters
    End Function
End Class
