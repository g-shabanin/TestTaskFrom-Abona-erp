namespace WinForms.Classic {
    partial class CustomersListForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersListForm));
            this.GridLinkCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.CustomersBindingSource = new DevExpress.Xpo.XPBindingSource(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.CustomersPanel = new DevExpress.XtraEditors.PanelControl();
            this.CustomersGridControl = new DevExpress.XtraGrid.GridControl();
            this.CustomersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerFullNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrdersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrdersPanel = new DevExpress.XtraEditors.PanelControl();
            this.OrdersGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridLinkCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersPanel)).BeginInit();
            this.CustomersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersPanel)).BeginInit();
            this.OrdersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLinkCollection
            // 
            this.GridLinkCollection.ObjectType = typeof(InventoryXPO.Customer);
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DisplayableProperties = "Oid;ContactName";
            this.CustomersBindingSource.ObjectType = typeof(InventoryXPO.Customer);
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
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHome});
            this.ribbonControl1.Size = new System.Drawing.Size(824, 193);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New\r\nCustomer";
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
            // ribbonPageHome
            // 
            this.ribbonPageHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageHome.MergeOrder = 1;
            this.ribbonPageHome.Name = "ribbonPageHome";
            this.ribbonPageHome.Text = "Home";
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
            this.ribbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 639);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(824, 28);
            this.ribbonStatusBar1.Visible = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.splitterControl1.Appearance.Options.UseBackColor = true;
            this.splitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 655);
            this.splitterControl1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.splitterControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(824, 12);
            this.splitterControl1.TabIndex = 5;
            this.splitterControl1.TabStop = false;
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.AutoSize = true;
            this.CustomersPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CustomersPanel.Controls.Add(this.CustomersGridControl);
            this.CustomersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersPanel.Location = new System.Drawing.Point(0, 193);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(824, 462);
            this.CustomersPanel.TabIndex = 8;
            // 
            // CustomersGridControl
            // 
            this.CustomersGridControl.DataSource = this.GridLinkCollection;
            this.CustomersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersGridControl.Location = new System.Drawing.Point(2, 2);
            this.CustomersGridControl.MainView = this.CustomersGridView;
            this.CustomersGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersGridControl.Name = "CustomersGridControl";
            this.CustomersGridControl.Size = new System.Drawing.Size(820, 458);
            this.CustomersGridControl.TabIndex = 3;
            this.CustomersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CustomersGridView,
            this.OrdersGridView,
            this.OrderGridView});
            // 
            // CustomersGridView
            // 
            this.CustomersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.CustomerFullNameGridColumn,
            this.gridColumn2});
            this.CustomersGridView.DetailHeight = 431;
            this.CustomersGridView.GridControl = this.CustomersGridControl;
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.OptionsBehavior.Editable = false;
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.MinWidth = 23;
            this.colOid.Name = "colOid";
            this.colOid.Width = 87;
            // 
            // CustomerFullNameGridColumn
            // 
            this.CustomerFullNameGridColumn.Caption = "Customer Full Name";
            this.CustomerFullNameGridColumn.FieldName = "ContactName";
            this.CustomerFullNameGridColumn.MinWidth = 25;
            this.CustomerFullNameGridColumn.Name = "CustomerFullNameGridColumn";
            this.CustomerFullNameGridColumn.Visible = true;
            this.CustomerFullNameGridColumn.VisibleIndex = 1;
            this.CustomerFullNameGridColumn.Width = 703;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Id";
            this.gridColumn2.FieldName = "Oid";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 87;
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.GridControl = this.CustomersGridControl;
            this.OrdersGridView.Name = "OrdersGridView";
            // 
            // OrderGridView
            // 
            this.OrderGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.OrderGridView.GridControl = this.CustomersGridControl;
            this.OrderGridView.Name = "OrderGridView";
            // 
            // gridColumn1
            // 
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.AutoSize = true;
            this.OrdersPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OrdersPanel.Controls.Add(this.OrdersGridControl);
            this.OrdersPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrdersPanel.Location = new System.Drawing.Point(0, 490);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(824, 165);
            this.OrdersPanel.TabIndex = 9;
            // 
            // OrdersGridControl
            // 
            this.OrdersGridControl.DataMember = "Orders";
            this.OrdersGridControl.DataSource = this.GridLinkCollection;
            this.OrdersGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrdersGridControl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersGridControl.Location = new System.Drawing.Point(2, 2);
            this.OrdersGridControl.MainView = this.gridView1;
            this.OrdersGridControl.MenuManager = this.ribbonControl1;
            this.OrdersGridControl.Name = "OrdersGridControl";
            this.OrdersGridControl.Size = new System.Drawing.Size(820, 161);
            this.OrdersGridControl.TabIndex = 4;
            this.OrdersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid1,
            this.colProductName,
            this.colOrderDate,
            this.colFreight,
            this.colOrderNum,
            this.colOrderStatus});
            this.gridView1.GridControl = this.OrdersGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colOid1
            // 
            this.colOid1.Caption = "Order Id";
            this.colOid1.FieldName = "Oid";
            this.colOid1.MinWidth = 25;
            this.colOid1.Name = "colOid1";
            this.colOid1.Visible = true;
            this.colOid1.VisibleIndex = 0;
            this.colOid1.Width = 94;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 3;
            this.colProductName.Width = 94;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "Date";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 25;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 2;
            this.colOrderDate.Width = 94;
            // 
            // colFreight
            // 
            this.colFreight.Caption = "Freight";
            this.colFreight.FieldName = "Freight";
            this.colFreight.MinWidth = 25;
            this.colFreight.Name = "colFreight";
            this.colFreight.Visible = true;
            this.colFreight.VisibleIndex = 4;
            this.colFreight.Width = 94;
            // 
            // colOrderNum
            // 
            this.colOrderNum.Caption = "Order Number";
            this.colOrderNum.FieldName = "OrderNum";
            this.colOrderNum.MinWidth = 25;
            this.colOrderNum.Name = "colOrderNum";
            this.colOrderNum.Visible = true;
            this.colOrderNum.VisibleIndex = 1;
            this.colOrderNum.Width = 94;
            // 
            // colOrderStatus
            // 
            this.colOrderStatus.Caption = "Status";
            this.colOrderStatus.FieldName = "OrderStatus";
            this.colOrderStatus.MinWidth = 25;
            this.colOrderStatus.Name = "colOrderStatus";
            this.colOrderStatus.Visible = true;
            this.colOrderStatus.VisibleIndex = 5;
            this.colOrderStatus.Width = 94;
            // 
            // CustomersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 667);
            this.Controls.Add(this.OrdersPanel);
            this.Controls.Add(this.CustomersPanel);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomersListForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLinkCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersPanel)).EndInit();
            this.CustomersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersPanel)).EndInit();
            this.OrdersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.XPBindingSource CustomersBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.Xpo.XPCollection GridLinkCollection;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl CustomersPanel;
        private DevExpress.XtraGrid.GridControl CustomersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CustomersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerFullNameGridColumn;
        private DevExpress.XtraGrid.Views.Grid.GridView OrdersGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView OrderGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.PanelControl OrdersPanel;
        private DevExpress.XtraGrid.GridControl OrdersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNum;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colOid1;
    }
}

