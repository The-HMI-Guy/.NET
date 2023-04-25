Imports System

Module MainModule
    'Dim Name As String = "Mountain Bike"
    Sub Main()

        'Dim isActive As Boolean = ClassConstants.DEFAULT_ACTIVE

        Dim prod As New Product
        Dim sellDate As DateTime

        prod.SellStartDate = #5/1/2019#

        sellDate = prod.CalculateSellEndDate(30)


        Console.WriteLine(sellDate)

        Console.ReadKey()



    End Sub
End Module
