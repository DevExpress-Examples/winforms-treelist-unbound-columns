using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraTreeList.Columns;

namespace TreeList_UnboundDataViaEvent {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            InitTreeList();
        }
        
        void InitTreeList() {
            treeList1.DataSource = SalesDataGenerator.CreateData();

            // Create and customize an unbound column.
            TreeListColumn unbColumnMarchChange = new TreeListColumn();
            unbColumnMarchChange.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Decimal;
            unbColumnMarchChange.Visible = true;
            unbColumnMarchChange.OptionsColumn.AllowEdit = false;
            unbColumnMarchChange.FieldName = "ChangeFromPrevYear";
            unbColumnMarchChange.Caption = "Change from Previous Year";
            unbColumnMarchChange.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            unbColumnMarchChange.Format.FormatString = "p2";
            tlBandThisYear.Columns.Add(unbColumnMarchChange);
            // Change the appearance settings after the column is added to the TreeList.
            unbColumnMarchChange.AppearanceHeader.Font = new Font(unbColumnMarchChange.AppearanceHeader.Font, FontStyle.Bold);
            unbColumnMarchChange.AppearanceCell.BackColor = Color.LightYellow;
            // Subcribe to the event that provides data for unbound columns.
            treeList1.CustomUnboundColumnData += TreeList1_CustomUnboundColumnData;
            // Resize columns proportionally.
            treeList1.ForceInitialize();
            treeList1.BestFitColumns();
        }

        private void TreeList1_CustomUnboundColumnData(object sender, DevExpress.XtraTreeList.TreeListCustomColumnDataEventArgs e) {
            if(e.IsGetData && e.Column.FieldName == "ChangeFromPrevYear") {
                SalesData currentRow = e.Row as SalesData;
                if (currentRow == null) return;
                e.Value = (currentRow.MarchSales - currentRow.MarchSalesPrev) / currentRow.MarchSalesPrev;
            }
        }
    }

    public class SalesData {
        public SalesData(int id, int regionId, string region, decimal marchSales, decimal marchSalesPrev) {
            ID = id;
            RegionID = regionId;
            Region = region;
            MarchSales = marchSales;
            MarchSalesPrev = marchSalesPrev;
        }
        public int ID { get; set; }
        public int RegionID { get; set; }
        public string Region { get; set; }
        public decimal MarchSales { get; set; }
        public decimal MarchSalesPrev { get; set; }
        
    }
    public class SalesDataGenerator {
        public static List<SalesData> CreateData() {
            List<SalesData> sales = new List<SalesData>();
            sales.Add(new SalesData(0, -1, "Western Europe", 30540, 33000));
            sales.Add(new SalesData(1, 0, "Austria", 22000, 20000));
            sales.Add(new SalesData(2, 0, "Belgium", 13000, 9640));
            sales.Add(new SalesData(3, 0, "Denmark", 21000, 18100));
            sales.Add(new SalesData(4, 0, "Finland", 17000, 17420));
            sales.Add(new SalesData(5, 0, "France", 23020, 27000));
            sales.Add(new SalesData(6, 0, "Germany", 30540, 33000));
            sales.Add(new SalesData(7, 0, "Greece", 15600, 13200));
            sales.Add(new SalesData(8, 0, "Ireland", 9530, 10939));
            sales.Add(new SalesData(9, 0, "Italy", 17299, 19321));
            sales.Add(new SalesData(11, 0, "Netherlands", 8902, 9214));
            sales.Add(new SalesData(12, 0, "Norway", 5400, 7310));
            sales.Add(new SalesData(13, 0, "Portugal", 9220, 4271));
            sales.Add(new SalesData(14, 0, "Spain", 12900, 10300));
            sales.Add(new SalesData(15, 0, "Switzerland", 9323, 10730));
            sales.Add(new SalesData(16, 0, "United Kingdom", 14580, 13967));

            sales.Add(new SalesData(17, -1, "Eastern Europe", 22500, 24580));
            sales.Add(new SalesData(18, 17, "Belarus", 7315, 18800));
            sales.Add(new SalesData(19, 17, "Bulgaria", 6300, 2821));
            sales.Add(new SalesData(20, 17, "Croatia", 4200, 3890));
            sales.Add(new SalesData(21, 17, "Czech Republic", 19500, 15340));
            sales.Add(new SalesData(22, 17, "Hungary", 13495, 13900));
            sales.Add(new SalesData(23, 17, "Poland", 8930, 9440));
            sales.Add(new SalesData(24, 17, "Romania", 4900, 5100));
            sales.Add(new SalesData(25, 17, "Russia", 22500, 24580));

            sales.Add(new SalesData(26, -1, "North America", 31400, 32800));
            sales.Add(new SalesData(27, 26, "USA", 31400, 32800));
            sales.Add(new SalesData(28, 26, "Canada", 25390, 27000));

            sales.Add(new SalesData(29, -1, "South America", 16380, 15590));
            sales.Add(new SalesData(30, 29, "Argentina", 16380, 15590));
            sales.Add(new SalesData(31, 29, "Brazil", 4560, 5480));

            sales.Add(new SalesData(32, -1, "Asia", 20388, 22547));
            sales.Add(new SalesData(34, 32, "India", 4642, 5320));
            sales.Add(new SalesData(35, 32, "Japan", 9457, 12859));
            sales.Add(new SalesData(36, 32, "China", 20388, 22547));
            return sales;
        }
    }

}