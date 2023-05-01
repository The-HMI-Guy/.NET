Imports System

Module MainModule
    Sub Main()
        'Array Example - Start
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
        'Array Example - End

        'ArrayList Example - Start
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
        'ArrayList Example - End
        Console.ReadKey()

    End Sub
End Module
