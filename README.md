<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/331312015/20.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T966439)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - Generate Conditional Formatting Rules from ViewModel Collection

This example demonstrates how to define conditional formatting rules in a ViewModel collection and generate GridControl format conditions based on this collection.

![](/Images/wpf_grid_mvvm_conditionalformatting126727.png)

## Files to Review

* [MainWindow.xaml](./CS/GridMVVMConditionalFormattingRules/MainWindow.xaml)
* [OrdersViewModel.cs](./CS/GridMVVMConditionalFormattingRules/OrdersViewModel.cs) (VB: [OrdersViewModel.vb](./VB/GridMVVMConditionalFormattingRules/OrdersViewModel.vb))
* [OrdersDataModel.cs](./CS/GridMVVMConditionalFormattingRules/OrdersDataModel.cs) (VB: [OrdersDataModel.vb](./VB/GridMVVMConditionalFormattingRules/OrdersDataModel.vb))
* [FormatConditionSelector.cs](./CS/GridMVVMConditionalFormattingRules/FormatConditionSelector.cs) (VB: [FormatConditionSelector.vb](./VB/GridMVVMConditionalFormattingRules/FormatConditionSelector.vb))

## Documentation

* [How to: Bind the Grid to a Collection of Conditional Formatting Rules](http://docs.devexpress.com/WPF/117884/controls-and-libraries/data-grid/mvvm-enhancements/binding-to-a-collection-of-conditional-formatting-rules)
* [TableView.FormatConditionsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.FormatConditionsSource) / [TreeListView.FormatConditionsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.FormatConditionsSource)
* [TableView.FormatConditionGeneratorTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.FormatConditionGeneratorTemplate) / [TreeListView.FormatConditionGeneratorTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.FormatConditionGeneratorTemplate)
* [TableView.FormatConditionGeneratorTemplateSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.FormatConditionGeneratorTemplateSelector) / [TreeListView.FormatConditionGeneratorTemplateSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.FormatConditionGeneratorTemplateSelector)

## More Examples

* [WPF Data Grid - Apply Conditional Formatting](https://github.com/DevExpress-Examples/wpf-data-grid-apply-conditional-formatting)
* [WPF Data Grid - Generate Columns from a ViewModel Collection](https://github.com/DevExpress-Examples/wpf-data-grid-bind-columns-to-viewmodel-collection)
* [WPF Data Grid - Generate Total and Group Summaries from a ViewModel Collection](https://github.com/DevExpress-Examples/wpf-mvvm-how-to-bind-the-gridcontrol-to-total-and-group-summaries-specified-in-viewmodel)
