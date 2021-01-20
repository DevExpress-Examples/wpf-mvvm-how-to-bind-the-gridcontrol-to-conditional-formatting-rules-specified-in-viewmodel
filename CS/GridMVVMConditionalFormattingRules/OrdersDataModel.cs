using System.Collections.Generic;

namespace GridMVVMConditionalFormattingRules { 
    public class Order {
        public string City { get; set; }
        public double Discount { get; set; }
        public double Freight { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
    }

    public class OrdersDataModel {
        public static List<Order> GetOrders() {
            List<Order> list = new List<Order> {
                new Order() { City = "Aachen", Discount = 0, Freight = 30.54, Quantity = 20, UnitPrice = 10 },
                new Order() { City = "Graz", Discount = 0, Freight = 215.63, Quantity = 12, UnitPrice = 6.2 },
                new Order() { City = "Resende", Discount = 0, Freight = 38.94, Quantity = 12, UnitPrice = 14.4 },
                new Order() { City = "Bern", Discount = 0, Freight = 4.45, Quantity = 18, UnitPrice = 4.8 },
                new Order() { City = "Charleroi", Discount = 0.03, Freight = 33.35, Quantity = 20, UnitPrice = 21 },
                new Order() { City = "Lyon", Discount = 0, Freight = 149.74, Quantity = 7, UnitPrice = 6 },
                new Order() { City = "Barcelona", Discount = 0, Freight = 10.14, Quantity = 5, UnitPrice = 16.8 },
                new Order() { City = "Rio de Janeiro", Discount = 0, Freight = 10.14, Quantity = 45, UnitPrice = 6.2 },
                new Order() { City = "Reims", Discount = 0.06, Freight = 18.69, Quantity = 5, UnitPrice = 14.4 }
            };
            return list;
        }
    }
}