Imports System.Collections.ObjectModel
Imports System.Configuration
Imports AdventureWorks.EntityLayer
Imports Common.Library
Public Class ProductManager
    Inherits DataManagerBase

    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts(Nothing)
    End Function
    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        'Create a new instance of the product manager class
        Dim ret = New ObservableCollection(Of Product)()
        Try
            'Attempt to read from XML file
            Dim doc = MyBase.LoadXElemnt(
                ConfigurationManager.AppSettings("ProductsFile"),
                startingFilePath)
            Dim products = From prod In doc.<Product>
                           Select New Product With {
                               .ProductID = Convert.ToInt32(prod.Element("ProductID").Value)}
        Catch ex As Exception

        End Try
    End Function
End Class
