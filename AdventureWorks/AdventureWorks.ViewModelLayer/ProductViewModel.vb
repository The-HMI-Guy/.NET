Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New()
        LoadProduct(680)
    End Sub

    Public Property Entity As Product

    Function LoadProduct(ByVal productID As Integer) As Product
        Return LoadProduct(productID, Nothing)
    End Function

    Function LoadProduct(ByVal productID As Integer,
                         ByVal startingFilePath As String) As Product
        'Hard-code an entity - typically would hook this into a database
        Entity = New Product() With {.ProductID = 680, .Name = "HL Road Frame - Black, 58", .ProductNumber = "FR-R92B-58", .Color = "Black", .Size = "58", .Weight = 1016.04D, .StandardCost = 1059.31D, .ListPrice = 200}
        Return Entity
    End Function
End Class
