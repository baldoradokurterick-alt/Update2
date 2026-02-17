Public Class Sale
    Dim ProductID As Integer
    Dim Price As Decimal
    Dim Discount As Decimal
    Dim Category As String
    Dim Itemsold As Integer
    Dim Stock As Integer

    Public Sub New(productID As Integer, price As Decimal, discount As Decimal, category As String, itemsold As Integer, stock As Integer)
        Me.ProductID = productID
        Me.Price = price
        Me.Discount = discount
        Me.Category = category
        Me.Itemsold = itemsold
        Me.Stock = stock
    End Sub
    Public Function Add() As Boolean
        ' Code to save the sale data to a database or file
        ' This is just a placeholder and should be replaced with actual implementation

        Return True
    End Function

    Public Function Update() As Boolean
        ' Code to update the sale data in a database or file
        ' This is just a placeholder and should be replaced with actual implementation
        Return True
    End Function

    Public Function Delete() As Boolean
        ' Code to delete the sale data from a database or file
        ' This is just a placeholder and should be replaced with actual implementation
        Return True
    End Function

    Public Function GetAll() As List(Of Sale)
        ' Code to retrieve all sale data from a database or file
        ' This is just a placeholder and should be replaced with actual implementation
        Return New List(Of Sale)()
    End Function

    Public Function GetByID(ProductID As Integer) As Sale
        ' Code to retrieve a sale by ID from a database or file
        ' This is just a placeholder and should be replaced with actual implementation
        Return New Sale(ProductID, 0, 0, "Sample Category", 0, 0)
    End Function


End Class
