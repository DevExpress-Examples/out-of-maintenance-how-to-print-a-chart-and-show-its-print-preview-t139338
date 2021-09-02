Imports System.Windows

Namespace PrintChart

	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button_ShowPrintPreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
			chartControl1.ShowPrintPreview(Me)
		End Sub

		Private Sub button_Print_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			chartControl1.Print()
		End Sub
	End Class
End Namespace
