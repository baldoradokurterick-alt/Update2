Public Class Category
    Dim CategoryID As Integer
    Dim CategoryName As String
    Dim CategoryDescription As String

    Public Sub New(CategoryID As Integer, CategoryName As String, CategoryDescription As String)
        Me.CategoryID = CategoryID
        Me.CategoryName = CategoryName
        Me.CategoryDescription = CategoryDescription
    End Sub

    ' This call is required by the designer.
    Public Function Add() As Boolean
        ' Code to save the category data to a database or file
        ' This is just a placeholder and should be replaced with actual implementation
        Return True
    End Function

    Public Function Update() As Boolean
        ' Code to update the category data in a database or file
        ' This is just a placeholder and should be replaced with actual implementation
        Return True
    End Function

    Public Function Delete() As Boolean
        ' Code to delete the category data from a database or file
        ' This is just a placeholder and should be replaced with actual implementation
        Return True
    End Function

    Public Function GetAll() As List(Of Category)
        ' Code to retrieve all category data from a database or file
        ' This is just a placeholder and should be replaced with actual implementation
        Return New List(Of Category)()
    End Function

    Public Function GetByID(CategoryID As Integer) As Category
        ' Code to retrieve a category by ID from a database or file
        ' This is just a placeholder and should be replaced with actual implementation
        Return New Category(CategoryID, "Sample Category", "This is a sample category description.")
    End Function

    ' Add any initialization after the InitializeComponent() call.


End Class
