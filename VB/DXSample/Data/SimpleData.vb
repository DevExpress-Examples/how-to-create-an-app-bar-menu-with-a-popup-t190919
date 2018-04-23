Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Collections.Generic

Namespace DXSample
	Public Class SimpleData
		Inherits SimpleDataBase

		Private _Bool As Boolean
		Private _Name As String
		Private _ID As Integer

		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				If _ID = value Then
					Return
				End If
				_ID = value
                OnPropertyChanged("ID")
			End Set
		End Property

		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				If _Name = value Then
					Return
				End If
				_Name = value
                OnPropertyChanged("Name")
			End Set
		End Property

		Public Property Bool() As Boolean
			Get
				Return _Bool
			End Get
			Set(ByVal value As Boolean)
				If _Bool = value Then
					Return
				End If
				_Bool = value
                OnPropertyChanged("Bool")
			End Set
		End Property
	End Class
End Namespace
