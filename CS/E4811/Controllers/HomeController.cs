using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E4811.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        public ActionResult Index() {            
            return View(new SearchOrder() { 
                EmployeeID = 1,
                DateFrom= new DateTime(1995, 5, 1),
                DateTo = new DateTime(1996, 2, 29)
            });
        }

        [HttpPost]
        public ActionResult Index(SearchOrder model) {
            return View(model);
        }

        public ActionResult OrdersGridPartial(int employeeID, DateTime dateFrom, DateTime dateTo) {
            SearchOrder search = new SearchOrder() {
                EmployeeID = employeeID,
                DateFrom = dateFrom,
                DateTo = dateTo
            };
            ViewData["SearchOrder"] = search;
            return PartialView("_OrdersGridPartial", Order.SearchOrders(search));
        }

        public ActionResult OrderDetailsGridPartial(int orderID) {
            ViewData["OrderID"] = orderID;
            return PartialView("_OrderDetailsGridPartial", OrderDetail.GetOrderDetails(orderID));
        }
    }
}