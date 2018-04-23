@ModelType SearchOrder
@Using Html.BeginForm()
    @<table>
        <tr>
            <td>
                Employee:
                @Html.DevExpress().ComboBox(Sub(settings)
                                                settings.Name = "EmployeeID"
                                                settings.Properties.ValueType = GetType(Integer)
                                                settings.Properties.ValueField = "EmployeeID"
               
                                                settings.Properties.Columns.Add("FirstName")
                                                settings.Properties.Columns.Add("LastName")
                                                settings.Properties.TextFormatString = "{0} {1}"
                                            End Sub
           ).BindList(Employee.GetEmployees()).Bind(Model.EmployeeID).GetHtml()
            </td>
            <td>
                Date From:
                @Html.DevExpress().DateEditFor(Function(m) m.DateFrom).GetHtml()
            </td>
            <td>
                Date To:
                @Html.DevExpress().DateEditFor(Function(m) m.DateTo).GetHtml()
            </td>
            <td>
                @Html.DevExpress().Button(Sub(settings)
                                              settings.Name = "Search"
                                              settings.Text = "Search"
                                              settings.UseSubmitBehavior = True
                                          End Sub
           ).GetHtml()
            </td>
        </tr>
        <tr>
            <td colspan="4">
                @Html.Action("OrdersGridPartial", New With {
               .EmployeeID = Model.EmployeeID,
               .DateFrom = Model.DateFrom,
               .DateTo = Model.DateTo
           })
            </td>
        </tr>
    </table>
End Using
