Imports System.Collections.Generic
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading

Public Class Vitamins

    Private AppropriateTrimesterToTake As String
    Private Vitamin As String
    Private ManufactureName As String
    Private ScientificName As String
    Private PricePerPiece As Decimal
    Private Quantity As Integer

    Public Sub New(ByVal appropriateTrimesterToTake As String, ByVal vitamin As String, ByVal manufactureName As String, ByVal scientificName As String, ByVal pricePerPiece As Decimal, ByVal quantity As Integer)
        Me.Vitamin1 = vitamin
        Me.ManufactureName1 = manufactureName
        Me.ScientificName1 = scientificName
        Me.Quantity1 = quantity
        Me.AppropriateTrimesterToTake1 = appropriateTrimesterToTake
        Me.PricePerPiece1 = pricePerPiece
    End Sub

    Public Property Vitamin1 As String
        Get
            Return Vitamin
        End Get
        Set(value As String)
            Vitamin = value
        End Set
    End Property

    Public Property ManufactureName1 As String
        Get
            Return ManufactureName
        End Get
        Set(value As String)
            ManufactureName = value
        End Set
    End Property

    Public Property ScientificName1 As String
        Get
            Return ScientificName
        End Get
        Set(value As String)
            ScientificName = value
        End Set
    End Property

    Public Property Quantity1 As String
        Get
            Return Quantity
        End Get
        Set(value As String)
            Quantity = value
        End Set
    End Property

    Public Property AppropriateTrimesterToTake1 As String
        Get
            Return AppropriateTrimesterToTake
        End Get
        Set(value As String)
            AppropriateTrimesterToTake = value
        End Set
    End Property

    Public Property PricePerPiece1 As Decimal
        Get
            Return PricePerPiece
        End Get
        Set(value As Decimal)
            PricePerPiece = value
        End Set
    End Property
End Class


