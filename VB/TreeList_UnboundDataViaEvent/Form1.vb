Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraTreeList.Columns

Namespace TreeList_UnboundDataViaEvent

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            InitTreeList()
        End Sub

        Private Sub InitTreeList()
            treeList1.DataSource = SalesDataGenerator.CreateData()
            ' Create and customize an unbound column.
            Dim unbColumnMarchChange As TreeListColumn = New TreeListColumn()
            unbColumnMarchChange.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Decimal
            unbColumnMarchChange.Visible = True
            unbColumnMarchChange.OptionsColumn.AllowEdit = False
            unbColumnMarchChange.FieldName = "ChangeFromPrevYear"
            unbColumnMarchChange.Caption = "Change from Previous Year"
            unbColumnMarchChange.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            unbColumnMarchChange.Format.FormatString = "p2"
            tlBandThisYear.Columns.Add(unbColumnMarchChange)
            ' Change the appearance settings after the column is added to the TreeList.
            unbColumnMarchChange.AppearanceHeader.Font = New Font(unbColumnMarchChange.AppearanceHeader.Font, FontStyle.Bold)
            unbColumnMarchChange.AppearanceCell.BackColor = Color.LightYellow
            ' Subcribe to the event that provides data for unbound columns.
            AddHandler treeList1.CustomUnboundColumnData, AddressOf TreeList1_CustomUnboundColumnData
            ' Resize columns proportionally.
            treeList1.ForceInitialize()
            treeList1.BestFitColumns()
        End Sub

        Private Sub TreeList1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.TreeListCustomColumnDataEventArgs)
            If e.IsGetData AndAlso Equals(e.Column.FieldName, "ChangeFromPrevYear") Then
                Dim currentRow As SalesData = TryCast(e.Row, SalesData)
                If currentRow Is Nothing Then Return
                e.Value =(currentRow.MarchSales - currentRow.MarchSalesPrev) / currentRow.MarchSalesPrev
            End If
        End Sub
    End Class

    Public Class SalesData

        Public Sub New(ByVal id As Integer, ByVal regionId As Integer, ByVal region As String, ByVal marchSales As Decimal, ByVal marchSalesPrev As Decimal)
            Me.ID = id
            Me.RegionID = regionId
            Me.Region = region
            Me.MarchSales = marchSales
            Me.MarchSalesPrev = marchSalesPrev
        End Sub

        Public Property ID As Integer

        Public Property RegionID As Integer

        Public Property Region As String

        Public Property MarchSales As Decimal

        Public Property MarchSalesPrev As Decimal
    End Class

    Public Class SalesDataGenerator

        Public Shared Function CreateData() As List(Of SalesData)
            Dim sales As List(Of SalesData) = New List(Of SalesData)()
            sales.Add(New SalesData(0, -1, "Western Europe", 30540, 33000))
            sales.Add(New SalesData(1, 0, "Austria", 22000, 20000))
            sales.Add(New SalesData(2, 0, "Belgium", 13000, 9640))
            sales.Add(New SalesData(3, 0, "Denmark", 21000, 18100))
            sales.Add(New SalesData(4, 0, "Finland", 17000, 17420))
            sales.Add(New SalesData(5, 0, "France", 23020, 27000))
            sales.Add(New SalesData(6, 0, "Germany", 30540, 33000))
            sales.Add(New SalesData(7, 0, "Greece", 15600, 13200))
            sales.Add(New SalesData(8, 0, "Ireland", 9530, 10939))
            sales.Add(New SalesData(9, 0, "Italy", 17299, 19321))
            sales.Add(New SalesData(11, 0, "Netherlands", 8902, 9214))
            sales.Add(New SalesData(12, 0, "Norway", 5400, 7310))
            sales.Add(New SalesData(13, 0, "Portugal", 9220, 4271))
            sales.Add(New SalesData(14, 0, "Spain", 12900, 10300))
            sales.Add(New SalesData(15, 0, "Switzerland", 9323, 10730))
            sales.Add(New SalesData(16, 0, "United Kingdom", 14580, 13967))
            sales.Add(New SalesData(17, -1, "Eastern Europe", 22500, 24580))
            sales.Add(New SalesData(18, 17, "Belarus", 7315, 18800))
            sales.Add(New SalesData(19, 17, "Bulgaria", 6300, 2821))
            sales.Add(New SalesData(20, 17, "Croatia", 4200, 3890))
            sales.Add(New SalesData(21, 17, "Czech Republic", 19500, 15340))
            sales.Add(New SalesData(22, 17, "Hungary", 13495, 13900))
            sales.Add(New SalesData(23, 17, "Poland", 8930, 9440))
            sales.Add(New SalesData(24, 17, "Romania", 4900, 5100))
            sales.Add(New SalesData(25, 17, "Russia", 22500, 24580))
            sales.Add(New SalesData(26, -1, "North America", 31400, 32800))
            sales.Add(New SalesData(27, 26, "USA", 31400, 32800))
            sales.Add(New SalesData(28, 26, "Canada", 25390, 27000))
            sales.Add(New SalesData(29, -1, "South America", 16380, 15590))
            sales.Add(New SalesData(30, 29, "Argentina", 16380, 15590))
            sales.Add(New SalesData(31, 29, "Brazil", 4560, 5480))
            sales.Add(New SalesData(32, -1, "Asia", 20388, 22547))
            sales.Add(New SalesData(34, 32, "India", 4642, 5320))
            sales.Add(New SalesData(35, 32, "Japan", 9457, 12859))
            sales.Add(New SalesData(36, 32, "China", 20388, 22547))
            Return sales
        End Function
    End Class
End Namespace
