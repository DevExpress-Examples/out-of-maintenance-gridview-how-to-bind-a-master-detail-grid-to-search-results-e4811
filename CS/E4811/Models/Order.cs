using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

public class Order {
    public int OrderID {
        get;
        set;
    }

    public DateTime OrderDate {
        get;
        set;
    }

    public string CustomerID {
        get;
        set;
    }

    public string ShipCountry {
        get;
        set;
    }

    static List<Order> GetFromDataTable(DataTable data) {
        if (data != null) {
            List<Order> orders = new List<Order>();
            foreach (DataRow row in data.Rows) {
                Order order = new Order() {
                    OrderID = (int) row["OrderID"],
                    OrderDate = (DateTime) row["OrderDate"],
                    CustomerID = (string) row["CustomerID"],
                    ShipCountry = (string) row["ShipCountry"]
                };
                orders.Add(order);
            }
            return orders;
        }
        return null;
    }

    public static List<Order> SearchOrders(SearchOrder search) {
        DataTable data = DataHelper.ProcessSelectCommand("SELECT * FROM [Orders] WHERE ([EmployeeID] = {0} AND [OrderDate] >= #{1}# AND [OrderDate] <= #{2}#)", search.EmployeeID, search.DateFrom.ToShortDateString(), search.DateTo.ToShortDateString());
        return GetFromDataTable(data);
    }
}