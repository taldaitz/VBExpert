Imports System.ComponentModel.DataAnnotations

Public Class Customer

    Private _id As Integer
    Private _firstName As String
    Private _lastName As String
    Private _email As String
    Private _birthDate As DateTime
    Private _city As String

    <Key>
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    <Required>
    <MaxLength(50)>
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    <Required>
    <MaxLength(50)>
    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property BirthDate As Date
        Get
            Return _birthDate
        End Get
        Set(value As Date)
            _birthDate = value
        End Set
    End Property

    Public Property City As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property
End Class
