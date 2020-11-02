Public Class Product
    Implements IOrderLine


    Protected _name As String
    Protected _quantity As Integer
    Protected _unitPrice As Double

    Public Sub New(name As String, quantity As Integer, unitPrice As Double)
        _name = name
        _quantity = quantity
        _unitPrice = unitPrice
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return _quantity
        End Get
        Set(value As Integer)
            _quantity = value
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

    Private Function getTotal() As Double
        Return _quantity * _unitPrice
    End Function

    Public Function getName() As String Implements IOrderLine.getName
        Return _name
    End Function

    Public Function getAmount() As Double Implements IOrderLine.getAmount
        Return getTotal()
    End Function


    Public Shared Function getProduct() As Product
        Console.WriteLine("Saisir un produit :")
        Dim productName As String = Console.ReadLine()
        Dim quantity As Integer = Console.ReadLine()
        Dim price As Double = Console.ReadLine()

        Dim product As New Product(productName, quantity, price)

        Return product
    End Function
End Class
