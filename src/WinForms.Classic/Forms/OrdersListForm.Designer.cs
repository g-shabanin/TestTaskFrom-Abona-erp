namespace WinForms.Classic {
    partial class OrdersListForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersListForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.OrderDetailsPanel = new DevExpress.XtraEditors.PanelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OrdersGrid = new DevExpress.XtraGrid.GridControl();
            this.OrdersDetailsCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.OrdersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderDetailsGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderDetailPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDetailQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsPanel)).BeginInit();
            this.OrderDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDetailsCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnNew,
            this.btnDelete});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1092, 158);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New\r\nOrder";
            this.btnNew.Id = 1;
            this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNew_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDelete_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 1;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "General";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 692);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1092, 22);
            this.ribbonStatusBar1.Visible = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // OrderDetailsPanel
            // 
            this.OrderDetailsPanel.AutoSize = true;
            this.OrderDetailsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OrderDetailsPanel.Controls.Add(this.splitContainer1);
            this.OrderDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDetailsPanel.Location = new System.Drawing.Point(0, 158);
            this.OrderDetailsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderDetailsPanel.Name = "OrderDetailsPanel";
            this.OrderDetailsPanel.Size = new System.Drawing.Size(1092, 534);
            this.OrderDetailsPanel.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OrdersGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OrderDetailsGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1088, 530);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 7;
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.DataSource = this.OrdersDetailsCollection;
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersGrid.Location = new System.Drawing.Point(0, 0);
            this.OrdersGrid.MainView = this.OrdersGridView;
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.Size = new System.Drawing.Size(1088, 326);
            this.OrdersGrid.TabIndex = 2;
            this.OrdersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.OrdersGridView});
            // 
            // OrdersDetailsCollection
            // 
            this.OrdersDetailsCollection.DisplayableProperties = resources.GetString("OrdersDetailsCollection.DisplayableProperties");
            this.OrdersDetailsCollection.ObjectType = typeof(InventoryXPO.Item);
            this.OrdersDetailsCollection.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.OrdersDetailsCollection_ListChanged);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.OrdersGridView.GridControl = this.OrdersGrid;
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.OptionsBehavior.Editable = false;
            // 
            // colOid
            // 
            this.colOid.Caption = "Order ID";
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 0;
            this.colOid.Width = 120;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "OrderDetail.Order.OrderNum";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 313;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "OrderDetail.Order.OrderDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 313;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "OrderDetail.Order.OrderStatus";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 317;
            // 
            // OrderDetailsGrid
            // 
            this.OrderDetailsGrid.DataMember = "OrderDetail";
            this.OrderDetailsGrid.DataSource = this.OrdersDetailsCollection;
            this.OrderDetailsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDetailsGrid.Location = new System.Drawing.Point(0, 0);
            this.OrderDetailsGrid.MainView = this.gridView1;
            this.OrderDetailsGrid.MenuManager = this.ribbonControl1;
            this.OrderDetailsGrid.Name = "OrderDetailsGrid";
            this.OrderDetailsGrid.Size = new System.Drawing.Size(1088, 201);
            this.OrderDetailsGrid.TabIndex = 0;
            this.OrderDetailsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid1,
            this.colOrderDetailPrice,
            this.colOrderDetailQuantity});
            this.gridView1.GridControl = this.OrderDetailsGrid;
            this.gridView1.Name = "gridView1";
            // 
            // colOrderDetailPrice
            // 
            this.colOrderDetailPrice.FieldName = "OrderDetailPrice";
            this.colOrderDetailPrice.Name = "colOrderDetailPrice";
            this.colOrderDetailPrice.Visible = true;
            this.colOrderDetailPrice.VisibleIndex = 1;
            this.colOrderDetailPrice.Width = 368;
            // 
            // colOrderDetailQuantity
            // 
            this.colOrderDetailQuantity.FieldName = "OrderDetailQuantity";
            this.colOrderDetailQuantity.Name = "colOrderDetailQuantity";
            this.colOrderDetailQuantity.Visible = true;
            this.colOrderDetailQuantity.VisibleIndex = 2;
            this.colOrderDetailQuantity.Width = 370;
            // 
            // colOid1
            // 
            this.colOid1.Caption = "Order ID";
            this.colOid1.FieldName = "Oid";
            this.colOid1.Name = "colOid1";
            this.colOid1.Visible = true;
            this.colOid1.VisibleIndex = 0;
            this.colOid1.Width = 325;
            // 
            // OrdersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 714);
            this.Controls.Add(this.OrderDetailsPanel);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "OrdersListForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsPanel)).EndInit();
            this.OrderDetailsPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDetailsCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraEditors.PanelControl OrderDetailsPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl OrdersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView OrdersGridView;
        private DevExpress.Xpo.XPCollection OrdersDetailsCollection;
        private DevExpress.XtraGrid.GridControl OrderDetailsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDetailPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDetailQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colOid1;
    }
}

