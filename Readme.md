<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638055/15.2.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T369036)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms TreeList - Create an unbound column

This example creates an [unbound column](https://docs.devexpress.com/WindowsForms/17831/controls-and-libraries/tree-list/feature-center/data-binding/unbound-columns) and handles the [CustomUnboundColumnData](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.CustomUnboundColumnData) event to supply unbound data:

```csharp
// Creates and customizes an unbound column.
TreeListColumn unbColumnMarchChange = new TreeListColumn();
unbColumnMarchChange.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Decimal;
unbColumnMarchChange.Visible = true;
unbColumnMarchChange.OptionsColumn.AllowEdit = false;
unbColumnMarchChange.FieldName = "ChangeFromPrevYear";
unbColumnMarchChange.Caption = "Change from Previous Year";
unbColumnMarchChange.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
unbColumnMarchChange.Format.FormatString = "p2";
tlBandThisYear.Columns.Add(unbColumnMarchChange);
treeList1.CustomUnboundColumnData += TreeList1_CustomUnboundColumnData;
// ...

private void TreeList1_CustomUnboundColumnData(object sender, DevExpress.XtraTreeList.TreeListCustomColumnDataEventArgs e) {
    if(e.IsGetData && e.Column.FieldName == "ChangeFromPrevYear") {
        SalesData currentRow = e.Row as SalesData;
        if (currentRow == null) return;
        e.Value = (currentRow.MarchSales - currentRow.MarchSalesPrev) / currentRow.MarchSalesPrev;
    }
}
```


## Files to Review

* [Form1.cs](./CS/TreeList_UnboundDataViaEvent/Form1.cs) (VB: [Form1.vb](./VB/TreeList_UnboundDataViaEvent/Form1.vb))


## Documentation

* [Unbound Columns - WinForms TreeList](https://docs.devexpress.com/WindowsForms/17831/controls-and-libraries/tree-list/feature-center/data-binding/unbound-columns)
