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
End Class
