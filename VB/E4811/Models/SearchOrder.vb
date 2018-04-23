Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Class SearchOrder
	Private privateEmployeeID As Integer
	Public Property EmployeeID() As Integer
		Get
			Return privateEmployeeID
		End Get
		Set(ByVal value As Integer)
			privateEmployeeID = value
		End Set
	End Property

	Private privateDateFrom As DateTime
	Public Property DateFrom() As DateTime
		Get
			Return privateDateFrom
		End Get
		Set(ByVal value As DateTime)
			privateDateFrom = value
		End Set
	End Property

	Private privateDateTo As DateTime
	Public Property DateTo() As DateTime
		Get
			Return privateDateTo
		End Get
		Set(ByVal value As DateTime)
			privateDateTo = value
		End Set
	End Property
End Class