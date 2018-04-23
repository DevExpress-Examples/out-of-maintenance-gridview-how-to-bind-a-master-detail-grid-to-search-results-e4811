using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

public class Employee {
    public int EmployeeID {
        get;
        set;
    }

    public string FirstName {
        get;
        set;
    }

    public string LastName {
        get;
        set;
    }

    static List<Employee> GetFromDataTable(DataTable data) {
        if (data != null) {
            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in data.Rows) {
                Employee employee = new Employee() {
                    EmployeeID = (int) row["EmployeeID"],
                    FirstName = (string) row["FirstName"],
                    LastName = (string) row["LastName"]                    
                };
                employees.Add(employee);
            }
            return employees;
        }
        return null;
    }

    public static List<Employee> GetEmployees() {
        DataTable data = DataHelper.ProcessSelectCommand("SELECT * FROM [Employees]");
        return GetFromDataTable(data);
    }
}