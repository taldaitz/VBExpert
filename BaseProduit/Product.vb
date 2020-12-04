Imports System.ComponentModel.DataAnnotations

Public Class Product

    Private _id As Integer
    Private _name As String
    Private _description As String
    Private _unitPrice As Double
    Private _status As String


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
    <MaxLength(100)>
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
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

    Public Property UnitPrice As Double
        Get
            Return _unitPrice
        End Get
        Set(value As Double)
            _unitPrice = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property
End Class
