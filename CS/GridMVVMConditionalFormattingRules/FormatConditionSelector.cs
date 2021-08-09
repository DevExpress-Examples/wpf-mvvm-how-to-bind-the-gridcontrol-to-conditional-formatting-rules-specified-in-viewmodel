using System.Windows;
using System.Windows.Controls;

namespace GridMVVMConditionalFormattingRules {
    public class FormatConditionSelector : DataTemplateSelector {

        public DataTemplate BackgroundTemplate { get; set; }
        public DataTemplate FontTemplate { get; set; }
        public DataTemplate IconTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            FormattingRule rule = item as FormattingRule;
            if(rule == null) return null;
            switch(rule.Type) {
                case FormattingType.Font:
                    return FontTemplate;
                case FormattingType.Background:
                    return BackgroundTemplate;
                case FormattingType.Icon:
                    return IconTemplate;
            }
            return null;
        }
    }
}