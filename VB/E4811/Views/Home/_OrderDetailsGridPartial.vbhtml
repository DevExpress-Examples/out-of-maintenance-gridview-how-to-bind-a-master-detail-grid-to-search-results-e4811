@Html.DevExpress().GridView(
    Sub(settings)
            settings.Name = String.Format("detailGrid{0}", ViewData("OrderID"))
            settings.CallbackRouteValues = New With {
                .Controller = "Home",
                .Action = "OrderDetailsGridPartial",
                .OrderID = ViewData("OrderID")
            }

            settings.Columns.Add("ProductID")
            settings.Columns.Add("UnitPrice")
            settings.Columns.Add("Quantity")
    End Sub
).Bind(Model).GetHtml()
