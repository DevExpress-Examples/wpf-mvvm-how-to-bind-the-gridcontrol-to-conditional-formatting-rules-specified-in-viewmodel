using DevExpress.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GridMVVMConditionalFormattingRules {
    public enum FormattingType { Background, Font, Icon }
    public enum ConditionRule { Less, Greater }

    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Orders = OrdersDataModel.GetOrders();
            Rules = new ObservableCollection<FormattingRule>() {
                new FormattingRule("Total", ConditionRule.Less, 0, true, FormattingType.Background),
                new FormattingRule( nameof(Order.Discount), ConditionRule.Greater, 0, false, FormattingType.Font),
                new FormattingRule( nameof(Order.Discount), ConditionRule.Greater, 0, false, FormattingType.Icon)
            };
        }
        public List<Order> Orders { get; }
        public ObservableCollection<FormattingRule> Rules { get; }
    }

    public class FormattingRule : BindableBase {
        public FormattingRule(string fieldname, ConditionRule valuerule, int value, bool applytorow, FormattingType type) {
            FieldName = fieldname;
            ValueRule = valuerule;
            Value = value;
            ApplyToRow = applytorow;
            Type = type;
        }
        public virtual string FieldName { get; }
        public virtual ConditionRule ValueRule { get; }
        public virtual int Value { get; }
        public virtual bool ApplyToRow { get; }
        public virtual FormattingType Type { get; }
    }
}