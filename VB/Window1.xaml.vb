Imports System.Windows

Namespace PrintChart

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button_ShowPrintPreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.chartControl1.ShowPrintPreview(Me)
        End Sub

        Private Sub button_Print_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.chartControl1.Print()
        End Sub
    End Class
End Namespace
