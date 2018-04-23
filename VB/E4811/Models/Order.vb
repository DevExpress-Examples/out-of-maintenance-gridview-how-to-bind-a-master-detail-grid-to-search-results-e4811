Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data

Public Class Order
	Private privateOrderID As Integer
	Public Property OrderID() As Integer
		Get
			Return privateOrderID
		End Get
		Set(ByVal value As Integer)
			privateOrderID = value
		End Set
	End Property

	Private privateOrderDate As DateTime
	Public Property OrderDate() As DateTime
		Get
			Return privateOrderDate
		End Get
		Set(ByVal value As DateTime)
			privateOrderDate = value
		End Set
	End Property

	Private privateCustomerID As String
	Public Property CustomerID() As String
		Get
			Return privateCustomerID
		End Get
		Set(ByVal value As String)
			privateCustomerID = value
		End Set
	End Property

	Private privateShipCountry As String
	Public Property ShipCountry() As String
		Get
			Return privateShipCountry
		End Get
		Set(ByVal value As String)
			privateShipCountry = value
		End Set
	End Property

	Private Shared Function GetFromDataTable(ByVal data As DataTable) As List(Of Order)
		If data IsNot Nothing Then
			Dim orders As New List(Of Order)()
			For Each row As DataRow In data.Rows
				Dim order As New Order() With {.OrderID = CInt(Fix(row("OrderID"))), .OrderDate = CDate(row("OrderDate")), .CustomerID = CStr(row("CustomerID")), .ShipCountry = CStr(row("ShipCountry"))}
				orders.Add(order)
			Next row
			Return orders
		End If
		Return Nothing
	End Function

	Public Shared Function SearchOrders(ByVal search As SearchOrder) As List(Of Order)
		Dim data As DataTable = DataHelper.ProcessSelectCommand("SELECT * FROM [Orders] WHERE ([EmployeeID] = {0} AND [OrderDate] >= #{1}# AND [OrderDate] <= #{2}#)", search.EmployeeID, search.DateFrom.ToShortDateString(), search.DateTo.ToShortDateString())
		Return GetFromDataTable(data)
	End Function
End Class