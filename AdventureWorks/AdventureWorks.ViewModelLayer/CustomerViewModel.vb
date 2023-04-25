Imports AdventureWorks.EntityLayer
Imports Common.Library
Public Class CustomerViewModel

    Sub New()
        LoadCustomer(1)
    End Sub

    Public Property Entity As Customer

    Function LoadCustomer(ByVal customerID As Integer) As Customer
        'Hard-code an entity
        Entity = New Customer() With {.CustomerID = 1, .FirstName = "Satoshi", .LastName = "Nakamoto", .CompanyName = "Bitcoin Computer Consultants"}
        Return Entity
    End Function
End Class
