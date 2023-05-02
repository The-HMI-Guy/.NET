Imports System

Module MainModule
    Sub Main()
        '***Array Example - Start***
        'Dim products(3) As String

        'products(0) = "10 Speed Bike"
        'products(1) = "Bike Helmet"
        'products(2) = "Inner Tube"

        'OR initialize this way

        'Dim products As String() =
        '{"10 Speed Bike", "Bike Helmet", "Inner Tube"}

        'Console.WriteLine(products(0))
        'Console.WriteLine(products(1))
        'Console.WriteLine(products(2)) 

        'Console.WriteLine(products.Length)
        '***Array Example - End***

        '***ArrayList Example - Start***
        'Dim products As New ArrayList From {
        '    "10 Speed Bike",
        '    "Bike Helmet",
        '    "Inner Tube",
        '    1,
        '    3.35D,
        '    New Product With {.ProductNumber = "1"}
        '    }
        'Console.WriteLine(products(0))
        'Console.WriteLine(products(1))
        'Console.WriteLine(products(2))

        'Console.WriteLine(products.Count)

        'Dim products As New ArrayList From {
        '    New Product() With {.ProductNumber = "2", .Name = "Bob"}}
        'Console.WriteLine(DirectCast(products(0), Product).Name)
        '***ArrayList Example - End***
        '***Dictionary Example - Start***
        'Dim products = LoadProducts()

        'Passing in the key and NOT the index
        'Console.WriteLine(products(1).Name)
        'Console.WriteLine(products(2).Name)
        'Console.WriteLine(products(3).Name)

        'See if a specific key exists in the dictionary
        'Console.WriteLine(products.ContainsKey(1))

        'Display the total number of items in the dictionary
        'Console.WriteLine(products.Count)

        'Remove an item by the key
        'products.Remove(1)

        'Remove all items
        'products.Clear()
        '***Dictionary Example - End***

        '***LINQ Example - Start***
        'Dim products = LoadProducts()

        'Display the sum of all list prices - "c" = currency, which ToString formats as
        'Console.WriteLine(
        '    products.Sum(Function(p)
        '                     Return p.Value.ListPrice
        '                 End Function).ToString("c"))

        'Display the average of all list prices (short-hand) - "c" = currency, which ToString formats as
        'Console.WriteLine(
        '    products.Average(Function(p) p.Value.ListPrice).ToString("c"))

        'Display the minimum of all list prices - "c" = currency, which ToString formats as
        'Console.WriteLine(
        '    products.Min(Function(p) p.Value.ListPrice).ToString("c"))

        'Display the maxiumim of all list prices - "c" = currency, which ToString formats as
        'Console.WriteLine(
        '    products.Max(Function(p) p.Value.ListPrice).ToString("c"))
        '***LINQ Example - End***
        Console.ReadKey()

    End Sub
    '***Dictionary Example - Start***
    Function LoadProducts() As Dictionary(Of Integer, Product)
        Dim products As New Dictionary(Of Integer, Product)
        Dim prod As Product

        prod = New Product() With {.ProductID = 1, .Name = "Bob"}
        products.Add(key:=prod.ProductID, value:=prod)

        prod = New Product() With {.ProductID = 2, .Name = "Alice"}
        products.Add(key:=prod.ProductID, value:=prod)

        prod = New Product() With {.ProductID = 3, .Name = "Fred"}
        products.Add(key:=prod.ProductID, value:=prod)

        Return products
    End Function
    '***Dictionary Example - End***
End Module
