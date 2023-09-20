Namespace TreeList_UnboundDataViaEvent

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.tlMain = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.colRegion = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.tlBandPrevYear = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.colMarchSalesPrev = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.tlBandThisYear = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.colMarchSales = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Bands.AddRange(New DevExpress.XtraTreeList.Columns.TreeListBand() {Me.tlMain, Me.tlBandPrevYear, Me.tlBandThisYear})
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colRegion, Me.colMarchSales, Me.colMarchSalesPrev, Me.colID})
            Me.treeList1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.ParentFieldName = "RegionID"
            Me.treeList1.Size = New System.Drawing.Size(690, 415)
            Me.treeList1.TabIndex = 0
            ' 
            ' tlMain
            ' 
            Me.tlMain.Caption = "Main"
            Me.tlMain.Columns.Add(Me.colRegion)
            Me.tlMain.Name = "tlMain"
            Me.tlMain.Width = 161
            ' 
            ' colRegion
            ' 
            Me.colRegion.FieldName = "Region"
            Me.colRegion.Name = "colRegion"
            Me.colRegion.Visible = True
            Me.colRegion.VisibleIndex = 0
            Me.colRegion.Width = 161
            ' 
            ' tlBandPrevYear
            ' 
            Me.tlBandPrevYear.Caption = "Previous Year"
            Me.tlBandPrevYear.Columns.Add(Me.colMarchSalesPrev)
            Me.tlBandPrevYear.Name = "tlBandPrevYear"
            Me.tlBandPrevYear.Width = 254
            ' 
            ' colMarchSalesPrev
            ' 
            Me.colMarchSalesPrev.Caption = "Previous March Sales"
            Me.colMarchSalesPrev.FieldName = "MarchSalesPrev"
            Me.colMarchSalesPrev.Name = "colMarchSalesPrev"
            Me.colMarchSalesPrev.SortOrder = System.Windows.Forms.SortOrder.Ascending
            Me.colMarchSalesPrev.Visible = True
            Me.colMarchSalesPrev.VisibleIndex = 1
            Me.colMarchSalesPrev.Width = 254
            ' 
            ' tlBandThisYear
            ' 
            Me.tlBandThisYear.Caption = "This Year"
            Me.tlBandThisYear.Columns.Add(Me.colMarchSales)
            Me.tlBandThisYear.Name = "tlBandThisYear"
            Me.tlBandThisYear.Width = 227
            ' 
            ' colMarchSales
            ' 
            Me.colMarchSales.FieldName = "MarchSales"
            Me.colMarchSales.Name = "colMarchSales"
            Me.colMarchSales.Visible = True
            Me.colMarchSales.VisibleIndex = 2
            Me.colMarchSales.Width = 242
            ' 
            ' colID
            ' 
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 3
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(690, 415)
            Me.Controls.Add(Me.treeList1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private colRegion As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colMarchSales As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colMarchSalesPrev As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private tlMain As DevExpress.XtraTreeList.Columns.TreeListBand

        Private tlBandPrevYear As DevExpress.XtraTreeList.Columns.TreeListBand

        Private tlBandThisYear As DevExpress.XtraTreeList.Columns.TreeListBand

        Private colID As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace
