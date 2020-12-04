Imports System.ComponentModel.DataAnnotations

Public Class Refund

    Private _id As Integer
    Private _number As String
    Private _createdDate As DateTime
    Private _amount As Double
    Private _isUsed As Boolean


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
    <MaxLength(20)>
    Public Property Number As String
        Get
            Return _number
        End Get
        Set(value As String)
            _number = value
        End Set
    End Property


    Public Property CreatedDate As Date
        Get
            Return _createdDate
        End Get
        Set(value As Date)
            _createdDate = value
        End Set
    End Property

    Public Property Amount As Double
        Get
            Return _amount
        End Get
        Set(value As Double)
            _amount = value
        End Set
    End Property

    Public Property IsUsed As Boolean
        Get
            Return _isUsed
        End Get
        Set(value As Boolean)
            _isUsed = value
        End Set
    End Property
End Class
