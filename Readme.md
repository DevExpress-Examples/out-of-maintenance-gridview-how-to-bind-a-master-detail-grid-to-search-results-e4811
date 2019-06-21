<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E4811/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E4811/Controllers/HomeController.vb))
* [DataHelper.cs](./CS/E4811/Models/DataHelper.cs) (VB: [DataHelper.vb](./VB/E4811/Models/DataHelper.vb))
* [Employee.cs](./CS/E4811/Models/Employee.cs) (VB: [Employee.vb](./VB/E4811/Models/Employee.vb))
* [Order.cs](./CS/E4811/Models/Order.cs) (VB: [Order.vb](./VB/E4811/Models/Order.vb))
* [OrderDetail.cs](./CS/E4811/Models/OrderDetail.cs) (VB: [OrderDetail.vb](./VB/E4811/Models/OrderDetail.vb))
* [SearchOrder.cs](./CS/E4811/Models/SearchOrder.cs) (VB: [SearchOrder.vb](./VB/E4811/Models/SearchOrder.vb))
* [_OrderDetailsGridPartial.cshtml](./CS/E4811/Views/Home/_OrderDetailsGridPartial.cshtml)
* [_OrdersGridPartial.cshtml](./CS/E4811/Views/Home/_OrdersGridPartial.cshtml)
* **[Index.cshtml](./CS/E4811/Views/Home/Index.cshtml)**
<!-- default file list end -->
# GridView - How to bind a master-detail grid to search results
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4811)**
<!-- run online end -->


<p>This example demonstrates how to pass search parameters to the master grid Partial View and pass the master row key to the detail grid Partial View to bind grids to correct data.</p><br />
<p>In the "Index" View, search parameters are passed to the View as a Model. So, when the "Search" Button is clicked, the model is submitted.</p><p><br />
To pass search parameters to the master GridView, I have used the action route values collection. Then, in the "OrdersGridPartial" action, these parameters are used to get the correct Model, which will be used to bind the master GridView to the search result. To pass these parameters to this action on a GridView callback, I have passed them to the GridViewSettings.CallbackRouteValues collection by using the ViewData.</p><br />
<p>The same approach is used to pass the master row key to the detail GridView and bind it to the correct detail data.</p>

<br/>


