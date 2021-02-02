Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc


Namespace E4811.Controllers
	Public Class HomeController
		Inherits Controller

		<HttpGet>
		Public Function Index() As ActionResult
			Return View(New SearchOrder() With {
				.EmployeeID = 1,
				.DateFrom= New Date(1995, 5, 1),
				.DateTo = New Date(1996, 2, 29)
			})
		End Function

		<HttpPost>
		Public Function Index(ByVal model As SearchOrder) As ActionResult
			Return View(model)
		End Function

		Public Function OrdersGridPartial(ByVal employeeID As Integer, ByVal dateFrom As Date, ByVal dateTo As Date) As ActionResult
			Dim search As New SearchOrder() With {
				.EmployeeID = employeeID,
				.DateFrom = dateFrom,
				.DateTo = dateTo
			}
			ViewData("SearchOrder") = search
			Return PartialView("_OrdersGridPartial", Order.SearchOrders(search))
		End Function

		Public Function OrderDetailsGridPartial(ByVal orderID As Integer) As ActionResult
			ViewData("OrderID") = orderID
			Return PartialView("_OrderDetailsGridPartial", OrderDetail.GetOrderDetails(orderID))
		End Function
	End Class
End Namespace