# GridView - How to bind a master-detail grid to search results


<p>This example demonstrates how to pass search parameters to the master grid Partial View and pass the master row key to the detail grid Partial View to bind grids to correct data.</p><br />
<p>In the "Index" View, search parameters are passed to the View as a Model. So, when the "Search" Button is clicked, the model is submitted.</p><p><br />
To pass search parameters to the master GridView, I have used the action route values collection. Then, in the "OrdersGridPartial" action, these parameters are used to get the correct Model, which will be used to bind the master GridView to the search result. To pass these parameters to this action on a GridView callback, I have passed them to the GridViewSettings.CallbackRouteValues collection by using the ViewData.</p><br />
<p>The same approach is used to pass the master row key to the detail GridView and bind it to the correct detail data.</p>

<br/>


