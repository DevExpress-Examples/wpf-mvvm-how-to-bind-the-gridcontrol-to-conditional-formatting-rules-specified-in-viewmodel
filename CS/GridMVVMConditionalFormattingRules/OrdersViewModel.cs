using DevExpress.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GridMVVMConditionalFormattingRules {
    public enum FormattingType { Font, Background }
    public enum ConditionRule { Less, Greater }

    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Orders = OrdersDataModel.GetOrders();
            Rules = new ObservableCollection<FormattingRule>() {
                new FormattingRule(
                    "Total",
                    ConditionRule.Less,
                    0,
                    true,
                    FormattingType.Background
                ),
                new FormattingRule(
                    nameof(Order.Discount),
                    ConditionRule.Greater,
                    0,
                    false,
                    FormattingType.Font
                )
            };
        }
        public List<Order> Orders { get; }
        public ObservableCollection<FormattingRule> Rules { get; }
    }

    public class FormattingRule : BindableBase {
        public FormattingRule(string fieldname, ConditionRule rule, int value, bool applytorow, FormattingType type) {
            FieldName = fieldname;
            Rule = rule;
            Value = value;
            ApplyToRow = applytorow;
            Type = type;
        }
        public virtual string FieldName { get; }
        public virtual ConditionRule Rule { get; }
        public virtual int Value { get; }
        public virtual bool ApplyToRow { get; }
        public virtual FormattingType Type { get; }
    }
}