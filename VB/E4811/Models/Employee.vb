Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data

Public Class Employee
	Private privateEmployeeID As Integer
	Public Property EmployeeID() As Integer
		Get
			Return privateEmployeeID
		End Get
		Set(ByVal value As Integer)
			privateEmployeeID = value
		End Set
	End Property

	Private privateFirstName As String
	Public Property FirstName() As String
		Get
			Return privateFirstName
		End Get
		Set(ByVal value As String)
			privateFirstName = value
		End Set
	End Property

	Private privateLastName As String
	Public Property LastName() As String
		Get
			Return privateLastName
		End Get
		Set(ByVal value As String)
			privateLastName = value
		End Set
	End Property

	Private Shared Function GetFromDataTable(ByVal data As DataTable) As List(Of Employee)
		If data IsNot Nothing Then
			Dim employees As New List(Of Employee)()
			For Each row As DataRow In data.Rows
				Dim employee As New Employee() With {.EmployeeID = CInt(Fix(row("EmployeeID"))), .FirstName = CStr(row("FirstName")), .LastName = CStr(row("LastName"))}
				employees.Add(employee)
			Next row
			Return employees
		End If
		Return Nothing
	End Function

	Public Shared Function GetEmployees() As List(Of Employee)
		Dim data As DataTable = DataHelper.ProcessSelectCommand("SELECT * FROM [Employees]")
		Return GetFromDataTable(data)
	End Function
End Class