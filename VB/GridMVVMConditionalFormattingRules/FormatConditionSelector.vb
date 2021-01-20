Imports System.Windows
Imports System.Windows.Controls

Namespace GridMVVMConditionalFormattingRules
	Public Class FormatConditionSelector
		Inherits DataTemplateSelector

		Public Property BackgroundTemplate() As DataTemplate
		Public Property FontTemplate() As DataTemplate

		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim rule As FormattingRule = TryCast(item, FormattingRule)
			If rule Is Nothing Then
				Return Nothing
			End If
			Select Case rule.Type
				Case FormattingType.Font
					Return FontTemplate
				Case FormattingType.Background
					Return BackgroundTemplate
			End Select
			Return Nothing
		End Function
	End Class
End Namespace