using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

public class OrderDetail {
    public int ProductID {
        get;
        set;
    }

    public decimal UnitPrice {
        get;
        set;
    }

    public int Quantity {
        get;
        set;
    }

    static List<OrderDetail> GetFromDataTable(DataTable data) {
        if (data != null) {
            List<OrderDetail> orders = new List<OrderDetail>();
            foreach (DataRow row in data.Rows) {
                OrderDetail order = new OrderDetail() {
                    ProductID = (int) row["ProductID"],
                    UnitPrice = (decimal) row["UnitPrice"],
                    Quantity = (short) row["Quantity"]
                };
                orders.Add(order);
            }
            return orders;
        }
        return null;
    }

    public static List<OrderDetail> GetOrderDetails(int orderID) {
        DataTable data = DataHelper.ProcessSelectCommand("SELECT * FROM [Order Details] WHERE [OrderID] = {0}", orderID);
        return GetFromDataTable(data);
    }
}