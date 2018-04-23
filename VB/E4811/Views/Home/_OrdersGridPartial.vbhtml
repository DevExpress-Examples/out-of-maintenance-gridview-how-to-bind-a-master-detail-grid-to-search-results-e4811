@Code
    Dim search As SearchOrder = ViewData("SearchOrder")
End Code
@Html.DevExpress().GridView(Sub(settings)
                                settings.Name = "masterGrid"
                                settings.CallbackRouteValues = New With {
                                    .Controller = "Home",
                                    .Action = "OrdersGridPartial",
                                    .EmployeeID = search.EmployeeID,
                                    .DateFrom = search.DateFrom,
                                    .DateTo = search.DateTo
                                }
                                settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)

                                settings.KeyFieldName = "OrderID"
                                settings.Columns.Add("OrderID")
                                settings.Columns.Add(Sub(columnSettings)
                                                         columnSettings.FieldName = "OrderDate"
                                                         columnSettings.PropertiesEdit.DisplayFormatString = "d"
                                                     End Sub)
                                settings.Columns.Add("CustomerID")
                                settings.Columns.Add("ShipCountry")

                                settings.SettingsDetail.ShowDetailRow = True
        
                                settings.SetDetailRowTemplateContent(Sub(container)
                                                                         Html.RenderAction("OrderDetailsGridPartial", New With {
                                                                             .OrderID = container.KeyValue
                                                                         })
                                                                     End Sub)
                            End Sub
).Bind(Model).GetHtml()
