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

        '***Generic List(Of T) Example - Start***
        'Dim products = LoadProducts()

        'List(of T) class is a collection. It is zero-based. Idex number ref below
        'Console.WriteLine(products(0).Name)

        'See if a specific key exists in the list
        'Console.WriteLine(
        'products.Exists(Function(p) p.ProductID = 704))

        'Display the total number of items in the list
        'Console.WriteLine(products.Count)

        'Remove an item by index
        'products.RemoveAt(1)
        'Console.WriteLine(products.Count)

        'Remove an item by a product object
        'products.Remove(products.Find(Function(p) p.ProductID = 704))
        'Console.WriteLine(products.Count)

        'Remove all items
        'products.Clear()

        'LINQ Expressions

        'Display the sum of all the list prices
        'Console.WriteLine(
        'products.Sum(Function(p) p.ListPrice).ToString("c"))

        'Display the average of all the list prices
        'Console.WriteLine(
        'products.Average(Function(p) p.ListPrice).ToString("c"))

        'Display the minimum of all the list prices
        'Console.WriteLine(
        'products.Min(Function(p) p.ListPrice).ToString("c"))

        'Display the maximum of all the list prices
        'Console.WriteLine(
        ' products.Max(Function(p) p.ListPrice).ToString("c"))

        'Console.WriteLine(products.Count)
        '***Generic List(Of T) Example - End***

        '***Do While, Loop While, Exit Example - Start***
        'Dim products = LoadProducts()
        'Dim index As Integer = 0
        'Dim sum As Decimal = 0

        'Do While Example
        'Do While index < (products.Count - 1) 'Use a Do While statement when you want to test whether or not to enter the loop at least one time. 
        'Console.WriteLine(products(index).ToString())
        'sum += products(index).ListPrice

        'index += 1
        'Loop
        'Console.WriteLine("Sum: " & sum.ToString("c"))

        'Do Loop While Example
        'Do 'Use a Loop While statement when you want to enter the loop at least one time. Condition is checked at the end.
        'Console.WriteLine(products(index).ToString())
        'sum += products(index).ListPrice

        'index += 1
        'Loop While index < (products.Count)

        'Exit Do Example
        'Do
        'Console.WriteLine(products(index).ToString())
        'sum += products(index).ListPrice

        'Exit Do
        'index += 1
        'Loop While index < (products.Count)
        'Console.WriteLine("Sum: " & sum.ToString("c"))
        '***Do While, Loop While, Exit Example - End***

        '***Do Until, Loop Until, Example - Start***
        'Dim products = LoadProducts()
        'Dim index As Integer = 0
        'Dim min As Decimal = Decimal.MaxValue
        'Dim max As Decimal = Decimal.MinValue

        'Do Until index > (products.Count - 1)
        '    Console.WriteLine(products(index).ToString())

        '    min = Convert.ToDecimal(
        '        IIf(products(index).ListPrice < min, 'IIF() is a short-hand for an If...Else statement
        '            products(index).ListPrice,
        '            min))
        '    index += 1
        'Loop
        'Do
        '    Console.WriteLine(products(index).ToString())

        '    max = Convert.ToDecimal(
        '        IIf(products(index).ListPrice > max, 'IIF() is a short-hand for an If...Else statement
        '            products(index).ListPrice,
        '            max))
        '    index += 1
        'Loop Until index > (products.Count - 1)
        'Console.WriteLine("Min: " & min.ToString("c"))
        '***Do Until, Loop Until, Example - End***

        '***For Next/For Each Example - Start***
        'Dim products = LoadProducts()
        'We can eliminate a line of code using a For Loop because we no
        'longer have to increment the index variable.
        'For index As Integer = 0 To (products.Count - 1)
        '    Console.WriteLine(products(index).ToString())
        'Next

        'The step statement allows you to specify by how much the index is
        'incremented or decremented each time through the loop
        'For index As Integer = (products.Count - 1) To 0 Step -1
        '    Console.WriteLine(products(index).ToString())
        'Next

        'You will probably use a For Each statement much more than a simple For Loop.
        'The For Each statement automatically increments an internal index number each
        'time the Next statement is encountered. 
        'For Each prod As Product In products
        '    Console.WriteLine(prod.ToString())
        'Next

        'For Each prod As Product In products
        '    Console.WriteLine(prod.ToString())
        '    Exit For
        'Next
        '***For Next/For Each Example - End***
        Console.ReadKey()

    End Sub
    '***Dictionary/LINQ Example - Start***
    'Function LoadProducts() As Dictionary(Of Integer, Product)
    '    Dim products As New Dictionary(Of Integer, Product)
    '    Dim prod As Product

    '    prod = New Product() With {.ProductID = 1, .Name = "Bob"}
    '    products.Add(key:=prod.ProductID, value:=prod)

    '    prod = New Product() With {.ProductID = 2, .Name = "Alice"}
    '    products.Add(key:=prod.ProductID, value:=prod)

    '    prod = New Product() With {.ProductID = 3, .Name = "Fred"}
    '    products.Add(key:=prod.ProductID, value:=prod)

    '    Return products
    'End Function
    Function LoadProducts() As List(Of Product)
        Dim products As New List(Of Product) From {
            New Product() With {.ProductID = 680, .Name = "Bob", .ListPrice = 745}}
        Return products
    End Function
    '***Dictionary Example - End***
End Module
