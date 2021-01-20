namespace WinForms.Classic.Forms {
    partial class EditOrderForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrderForm));
            this.OrderLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.OrderBindingSource = new DevExpress.Xpo.XPBindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ProductNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OrderDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.FreightCalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.CustomersBindingSource = new DevExpress.Xpo.XPBindingSource(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForOrderDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFreight = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.OrderDetail = new DevExpress.XtraLayout.LayoutControlItem();
            this.OrderId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.OrderDetailBindingSource = new DevExpress.Xpo.XPBindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrderLayoutControl)).BeginInit();
            this.OrderLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreightCalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFreight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderLayoutControl
            // 
            this.OrderLayoutControl.Controls.Add(this.gridControl1);
            this.OrderLayoutControl.Controls.Add(this.ProductNameTextEdit);
            this.OrderLayoutControl.Controls.Add(this.OrderDateDateEdit);
            this.OrderLayoutControl.Controls.Add(this.FreightCalcEdit);
            this.OrderLayoutControl.Controls.Add(this.lookUpEdit1);
            this.OrderLayoutControl.Controls.Add(this.textEdit1);
            this.OrderLayoutControl.Controls.Add(this.textEdit2);
            this.OrderLayoutControl.DataSource = this.OrderBindingSource;
            this.OrderLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderLayoutControl.Location = new System.Drawing.Point(0, 193);
            this.OrderLayoutControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderLayoutControl.Name = "OrderLayoutControl";
            this.OrderLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(868, 45, 812, 500);
            this.OrderLayoutControl.Root = this.Root;
            this.OrderLayoutControl.Size = new System.Drawing.Size(904, 451);
            this.OrderLayoutControl.TabIndex = 0;
            this.OrderLayoutControl.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.OrderBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 168);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(864, 271);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DisplayableProperties = "ProductName;OrderDate;Freight;Customer!Key;OrderDetails;Oid";
            this.OrderBindingSource.ObjectType = typeof(InventoryXPO.Order);
            this.OrderBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.OrderBindingSource_ListChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colOrderDate,
            this.colFreight,
            this.gridColumn1,
            this.colOid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 94;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 25;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 1;
            this.colOrderDate.Width = 94;
            // 
            // colFreight
            // 
            this.colFreight.FieldName = "Freight";
            this.colFreight.MinWidth = 25;
            this.colFreight.Name = "colFreight";
            this.colFreight.Visible = true;
            this.colFreight.VisibleIndex = 2;
            this.colFreight.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Customer!Key";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 94;
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.MinWidth = 25;
            this.colOid.Name = "colOid";
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 4;
            this.colOid.Width = 94;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnSave,
            this.btnReload,
            this.btnClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHome});
            this.ribbonControl1.Size = new System.Drawing.Size(904, 193);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 2;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Id = 3;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnReload);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClose, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Edit";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 644);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(904, 28);
            this.ribbonStatusBar1.Visible = false;
            // 
            // ProductNameTextEdit
            // 
            this.ProductNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "ProductName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProductNameTextEdit.Location = new System.Drawing.Point(99, 38);
            this.ProductNameTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductNameTextEdit.Name = "ProductNameTextEdit";
            this.ProductNameTextEdit.Size = new System.Drawing.Size(793, 22);
            this.ProductNameTextEdit.StyleController = this.OrderLayoutControl;
            this.ProductNameTextEdit.TabIndex = 6;
            // 
            // OrderDateDateEdit
            // 
            this.OrderDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "OrderDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OrderDateDateEdit.EditValue = null;
            this.OrderDateDateEdit.Location = new System.Drawing.Point(99, 64);
            this.OrderDateDateEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderDateDateEdit.Name = "OrderDateDateEdit";
            this.OrderDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OrderDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OrderDateDateEdit.Size = new System.Drawing.Size(793, 22);
            this.OrderDateDateEdit.StyleController = this.OrderLayoutControl;
            this.OrderDateDateEdit.TabIndex = 7;
            // 
            // FreightCalcEdit
            // 
            this.FreightCalcEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Freight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FreightCalcEdit.Location = new System.Drawing.Point(99, 90);
            this.FreightCalcEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FreightCalcEdit.Name = "FreightCalcEdit";
            this.FreightCalcEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.FreightCalcEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FreightCalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FreightCalcEdit.Properties.Mask.EditMask = "G";
            this.FreightCalcEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.FreightCalcEdit.Size = new System.Drawing.Size(793, 22);
            this.FreightCalcEdit.StyleController = this.OrderLayoutControl;
            this.FreightCalcEdit.TabIndex = 8;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Customer!Key", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lookUpEdit1.Location = new System.Drawing.Point(99, 116);
            this.lookUpEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.lookUpEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.CustomersBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "ContactName";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ValueMember = "Oid";
            this.lookUpEdit1.Size = new System.Drawing.Size(793, 22);
            this.lookUpEdit1.StyleController = this.OrderLayoutControl;
            this.lookUpEdit1.TabIndex = 9;
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DisplayableProperties = "Oid;ContactName";
            this.CustomersBindingSource.ObjectType = typeof(InventoryXPO.Customer);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Customer!Key", true));
            this.textEdit1.Location = new System.Drawing.Point(99, 142);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(793, 22);
            this.textEdit1.StyleController = this.OrderLayoutControl;
            this.textEdit1.TabIndex = 10;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.OrderBindingSource, "Oid", true));
            this.textEdit2.Location = new System.Drawing.Point(99, 12);
            this.textEdit2.MenuManager = this.ribbonControl1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(793, 22);
            this.textEdit2.StyleController = this.OrderLayoutControl;
            this.textEdit2.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(904, 451);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.ItemForOrderDate,
            this.ItemForFreight,
            this.layoutControlItem3,
            this.OrderDetail,
            this.OrderId,
            this.ItemForProductName,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(884, 431);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(868, 156);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(16, 275);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForOrderDate
            // 
            this.ItemForOrderDate.Control = this.OrderDateDateEdit;
            this.ItemForOrderDate.Location = new System.Drawing.Point(0, 52);
            this.ItemForOrderDate.Name = "ItemForOrderDate";
            this.ItemForOrderDate.Size = new System.Drawing.Size(884, 26);
            this.ItemForOrderDate.Text = "Order Date";
            this.ItemForOrderDate.TextSize = new System.Drawing.Size(84, 16);
            // 
            // ItemForFreight
            // 
            this.ItemForFreight.Control = this.FreightCalcEdit;
            this.ItemForFreight.Location = new System.Drawing.Point(0, 78);
            this.ItemForFreight.Name = "ItemForFreight";
            this.ItemForFreight.Size = new System.Drawing.Size(884, 26);
            this.ItemForFreight.Text = "Freight";
            this.ItemForFreight.TextSize = new System.Drawing.Size(84, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookUpEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem3.Name = "ItemForCustomer!Key";
            this.layoutControlItem3.Size = new System.Drawing.Size(884, 26);
            this.layoutControlItem3.Text = "Customer";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 16);
            // 
            // OrderDetail
            // 
            this.OrderDetail.Control = this.textEdit1;
            this.OrderDetail.CustomizationFormText = "Order Detail Id";
            this.OrderDetail.Location = new System.Drawing.Point(0, 130);
            this.OrderDetail.Name = "OrderDetail";
            this.OrderDetail.Size = new System.Drawing.Size(884, 26);
            this.OrderDetail.Text = "Order Detail Id";
            this.OrderDetail.TextSize = new System.Drawing.Size(84, 16);
            // 
            // OrderId
            // 
            this.OrderId.Control = this.textEdit2;
            this.OrderId.Location = new System.Drawing.Point(0, 0);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(884, 26);
            this.OrderId.Text = "Order Id";
            this.OrderId.TextSize = new System.Drawing.Size(84, 16);
            // 
            // ItemForProductName
            // 
            this.ItemForProductName.Control = this.ProductNameTextEdit;
            this.ItemForProductName.Location = new System.Drawing.Point(0, 26);
            this.ItemForProductName.Name = "ItemForProductName";
            this.ItemForProductName.Size = new System.Drawing.Size(884, 26);
            this.ItemForProductName.Text = "Product Name";
            this.ItemForProductName.TextSize = new System.Drawing.Size(84, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(868, 275);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // OrderDetailBindingSource
            // 
            this.OrderDetailBindingSource.DisplayableProperties = "ProductName;OrderDate;Freight;Customer!Key;OrderDetails;Oid";
            this.OrderDetailBindingSource.ObjectType = typeof(InventoryXPO.OrderDetail);
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 672);
            this.Controls.Add(this.OrderLayoutControl);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditOrderForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Edit Order";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderLayoutControl)).EndInit();
            this.OrderLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreightCalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFreight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.XPBindingSource OrderBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl OrderLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit ProductNameTextEdit;
        private DevExpress.XtraEditors.DateEdit OrderDateDateEdit;
        private DevExpress.XtraEditors.CalcEdit FreightCalcEdit;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOrderDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFreight;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.Xpo.XPBindingSource CustomersBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem OrderDetail;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem OrderId;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Xpo.XPBindingSource OrderDetailBindingSource;
    }
}
