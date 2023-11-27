Imports System.Collections.Generic

Namespace GridMVVMConditionalFormattingRules

    Public Class Order

        Public Property City As String

        Public Property Discount As Double

        Public Property Freight As Double

        Public Property Quantity As Double

        Public Property UnitPrice As Double
    End Class

    Public Class OrdersDataModel

        Public Shared Function GetOrders() As List(Of Order)
            Dim list As List(Of Order) = New List(Of Order) From {New Order() With {.City = "Aachen", .Discount = 0, .Freight = 30.54, .Quantity = 20, .UnitPrice = 10}, New Order() With {.City = "Graz", .Discount = 0, .Freight = 215.63, .Quantity = 12, .UnitPrice = 6.2}, New Order() With {.City = "Resende", .Discount = 0, .Freight = 38.94, .Quantity = 12, .UnitPrice = 14.4}, New Order() With {.City = "Bern", .Discount = 0, .Freight = 4.45, .Quantity = 18, .UnitPrice = 4.8}, New Order() With {.City = "Charleroi", .Discount = 0.03, .Freight = 33.35, .Quantity = 20, .UnitPrice = 21}, New Order() With {.City = "Lyon", .Discount = 0, .Freight = 149.74, .Quantity = 7, .UnitPrice = 6}, New Order() With {.City = "Barcelona", .Discount = 0, .Freight = 10.14, .Quantity = 5, .UnitPrice = 16.8}, New Order() With {.City = "Rio de Janeiro", .Discount = 0, .Freight = 10.14, .Quantity = 45, .UnitPrice = 6.2}, New Order() With {.City = "Reims", .Discount = 0.06, .Freight = 18.69, .Quantity = 5, .UnitPrice = 14.4}}
            Return list
        End Function
    End Class
End Namespace
