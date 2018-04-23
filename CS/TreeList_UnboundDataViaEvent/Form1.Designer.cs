namespace TreeList_UnboundDataViaEvent {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.tlMain = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.colRegion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlBandPrevYear = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.colMarchSalesPrev = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlBandThisYear = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.colMarchSales = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Bands.AddRange(new DevExpress.XtraTreeList.Columns.TreeListBand[] {
            this.tlMain,
            this.tlBandPrevYear,
            this.tlBandThisYear});
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colRegion,
            this.colMarchSales,
            this.colMarchSalesPrev,
            this.colID});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.ParentFieldName = "RegionID";
            this.treeList1.Size = new System.Drawing.Size(690, 415);
            this.treeList1.TabIndex = 0;
            // 
            // tlMain
            // 
            this.tlMain.Caption = "Main";
            this.tlMain.Columns.Add(this.colRegion);
            this.tlMain.Name = "tlMain";
            this.tlMain.Width = 161;
            // 
            // colRegion
            // 
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.Visible = true;
            this.colRegion.VisibleIndex = 0;
            this.colRegion.Width = 161;
            // 
            // tlBandPrevYear
            // 
            this.tlBandPrevYear.Caption = "Previous Year";
            this.tlBandPrevYear.Columns.Add(this.colMarchSalesPrev);
            this.tlBandPrevYear.Name = "tlBandPrevYear";
            this.tlBandPrevYear.Width = 254;
            // 
            // colMarchSalesPrev
            // 
            this.colMarchSalesPrev.Caption = "Previous March Sales";
            this.colMarchSalesPrev.FieldName = "MarchSalesPrev";
            this.colMarchSalesPrev.Name = "colMarchSalesPrev";
            this.colMarchSalesPrev.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colMarchSalesPrev.Visible = true;
            this.colMarchSalesPrev.VisibleIndex = 1;
            this.colMarchSalesPrev.Width = 254;
            // 
            // tlBandThisYear
            // 
            this.tlBandThisYear.Caption = "This Year";
            this.tlBandThisYear.Columns.Add(this.colMarchSales);
            this.tlBandThisYear.Name = "tlBandThisYear";
            this.tlBandThisYear.Width = 227;
            // 
            // colMarchSales
            // 
            this.colMarchSales.FieldName = "MarchSales";
            this.colMarchSales.Name = "colMarchSales";
            this.colMarchSales.Visible = true;
            this.colMarchSales.VisibleIndex = 2;
            this.colMarchSales.Width = 242;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 415);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRegion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMarchSales;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMarchSalesPrev;
        private DevExpress.XtraTreeList.Columns.TreeListBand tlMain;
        private DevExpress.XtraTreeList.Columns.TreeListBand tlBandPrevYear;
        private DevExpress.XtraTreeList.Columns.TreeListBand tlBandThisYear;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colID;
    }
}
