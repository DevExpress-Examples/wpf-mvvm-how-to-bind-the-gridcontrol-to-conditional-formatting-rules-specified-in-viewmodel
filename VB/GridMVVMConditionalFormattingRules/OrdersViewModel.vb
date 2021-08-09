Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace GridMVVMConditionalFormattingRules
	Public Enum FormattingType
		Background
		Font
		Icon
	End Enum
	Public Enum ConditionRule
		Less
		Greater
	End Enum

	Public Class ViewModel
		Inherits ViewModelBase

		Public Sub New()
			Orders = OrdersDataModel.GetOrders()
			Rules = New ObservableCollection(Of FormattingRule)() From {
				New FormattingRule("Total", ConditionRule.Less, 0, True, FormattingType.Background),
				New FormattingRule(NameOf(Order.Discount), ConditionRule.Greater, 0, False, FormattingType.Font),
				New FormattingRule(NameOf(Order.Discount), ConditionRule.Greater, 0, False, FormattingType.Icon)
			}
		End Sub
		Public ReadOnly Property Orders() As List(Of Order)
		Public ReadOnly Property Rules() As ObservableCollection(Of FormattingRule)
	End Class

	Public Class FormattingRule
		Inherits BindableBase

		Public Sub New(ByVal fieldname As String, ByVal valuerule As ConditionRule, ByVal value As Integer, ByVal applytorow As Boolean, ByVal type As FormattingType)
			Me.FieldName = fieldname
			Me.ValueRule = valuerule
			Me.Value = value
			Me.ApplyToRow = applytorow
			Me.Type = type
		End Sub
		Public Overridable ReadOnly Property FieldName() As String
		Public Overridable ReadOnly Property ValueRule() As ConditionRule
		Public Overridable ReadOnly Property Value() As Integer
		Public Overridable ReadOnly Property ApplyToRow() As Boolean
		Public Overridable ReadOnly Property Type() As FormattingType
	End Class
End Namespace