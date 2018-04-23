Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data

Public Class OrderDetail
	Private privateProductID As Integer
	Public Property ProductID() As Integer
		Get
			Return privateProductID
		End Get
		Set(ByVal value As Integer)
			privateProductID = value
		End Set
	End Property

	Private privateUnitPrice As Decimal
	Public Property UnitPrice() As Decimal
		Get
			Return privateUnitPrice
		End Get
		Set(ByVal value As Decimal)
			privateUnitPrice = value
		End Set
	End Property

	Private privateQuantity As Integer
	Public Property Quantity() As Integer
		Get
			Return privateQuantity
		End Get
		Set(ByVal value As Integer)
			privateQuantity = value
		End Set
	End Property

	Private Shared Function GetFromDataTable(ByVal data As DataTable) As List(Of OrderDetail)
		If data IsNot Nothing Then
			Dim orders As New List(Of OrderDetail)()
			For Each row As DataRow In data.Rows
				Dim order As New OrderDetail() With {.ProductID = CInt(Fix(row("ProductID"))), .UnitPrice = CDec(row("UnitPrice")), .Quantity = CShort(Fix(row("Quantity")))}
				orders.Add(order)
			Next row
			Return orders
		End If
		Return Nothing
	End Function

	Public Shared Function GetOrderDetails(ByVal orderID As Integer) As List(Of OrderDetail)
		Dim data As DataTable = DataHelper.ProcessSelectCommand("SELECT * FROM [Order Details] WHERE [OrderID] = {0}", orderID)
		Return GetFromDataTable(data)
	End Function
End Class