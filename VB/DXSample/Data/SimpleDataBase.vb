Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.ComponentModel
Imports System.Linq.Expressions
Imports System.Collections.Generic

Namespace DXSample
	Public Class SimpleDataBase
		Implements INotifyPropertyChanged

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        

		Protected Sub OnPropertyChanged(ByVal [property] As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs([property]))
		End Sub
	End Class
End Namespace
