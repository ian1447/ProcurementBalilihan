namespace Procurement_Tracking_App
{
    partial class SupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.dtsupplier = new DevExpress.XtraGrid.GridControl();
            this.gvsupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplierName = new DevExpress.XtraEditors.MemoEdit();
            this.txtSupplierAddress = new DevExpress.XtraEditors.MemoEdit();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.barManagerGrid = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsrefresh = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuGrid = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bwSupplierGet = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Procurement_Tracking_App.WaitForm1), true, true);
            this.tsdelete = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtsupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsupplier
            // 
            this.dtsupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtsupplier.Location = new System.Drawing.Point(342, 12);
            this.dtsupplier.MainView = this.gvsupplier;
            this.dtsupplier.Name = "dtsupplier";
            this.dtsupplier.Size = new System.Drawing.Size(526, 463);
            this.dtsupplier.TabIndex = 0;
            this.dtsupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvsupplier});
            this.dtsupplier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtsupplier_MouseDoubleClick);
            this.dtsupplier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtsupplier_MouseDown);
            // 
            // gvsupplier
            // 
            this.gvsupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.address});
            this.gvsupplier.GridControl = this.dtsupplier;
            this.gvsupplier.Name = "gvsupplier";
            this.gvsupplier.OptionsBehavior.Editable = false;
            this.gvsupplier.OptionsFind.AlwaysVisible = true;
            this.gvsupplier.OptionsFind.SearchInPreview = true;
            this.gvsupplier.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvsupplier.OptionsView.RowAutoHeight = true;
            this.gvsupplier.OptionsView.ShowGroupPanel = false;
            this.gvsupplier.OptionsView.ShowIndicator = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AppearanceCell.Options.UseTextOptions = true;
            this.name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.name.AppearanceHeader.Options.UseTextOptions = true;
            this.name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.name.Caption = "Supplier Name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // address
            // 
            this.address.AppearanceCell.Options.UseTextOptions = true;
            this.address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.address.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.address.AppearanceHeader.Options.UseTextOptions = true;
            this.address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.address.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.address.Caption = "Supplier Address";
            this.address.FieldName = "address";
            this.address.Name = "address";
            this.address.Visible = true;
            this.address.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(259, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "SUPPLIERS INFORMATION";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "SUPPLIER\'S NAME: *";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 207);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(160, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "SUPPLIER\'S ADDRESS: *";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(49, 96);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierName.Size = new System.Drawing.Size(274, 96);
            this.txtSupplierName.TabIndex = 5;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(49, 244);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierAddress.Size = new System.Drawing.Size(274, 96);
            this.txtSupplierAddress.TabIndex = 6;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncancel.Enabled = false;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.Location = new System.Drawing.Point(12, 433);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(104, 42);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnedit.Enabled = false;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(122, 433);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(104, 42);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Edit";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(232, 433);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(104, 42);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // barManagerGrid
            // 
            this.barManagerGrid.DockControls.Add(this.barDockControlTop);
            this.barManagerGrid.DockControls.Add(this.barDockControlBottom);
            this.barManagerGrid.DockControls.Add(this.barDockControlLeft);
            this.barManagerGrid.DockControls.Add(this.barDockControlRight);
            this.barManagerGrid.Form = this;
            this.barManagerGrid.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tsrefresh,
            this.tsdelete});
            this.barManagerGrid.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(880, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 487);
            this.barDockControlBottom.Size = new System.Drawing.Size(880, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 487);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(880, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 487);
            // 
            // tsrefresh
            // 
            this.tsrefresh.Caption = "Refresh";
            this.tsrefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("tsrefresh.Glyph")));
            this.tsrefresh.Id = 0;
            this.tsrefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsrefresh.LargeGlyph")));
            this.tsrefresh.Name = "tsrefresh";
            this.tsrefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsrefresh_ItemClick);
            // 
            // popupMenuGrid
            // 
            this.popupMenuGrid.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsrefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.tsdelete)});
            this.popupMenuGrid.Manager = this.barManagerGrid;
            this.popupMenuGrid.Name = "popupMenuGrid";
            // 
            // bwSupplierGet
            // 
            this.bwSupplierGet.WorkerSupportsCancellation = true;
            this.bwSupplierGet.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSupplierGet_DoWork);
            this.bwSupplierGet.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSupplierGet_RunWorkerCompleted);
            // 
            // tsdelete
            // 
            this.tsdelete.Caption = "Delete";
            this.tsdelete.Glyph = ((System.Drawing.Image)(resources.GetObject("tsdelete.Glyph")));
            this.tsdelete.Id = 1;
            this.tsdelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsdelete.LargeGlyph")));
            this.tsdelete.Name = "tsdelete";
            this.tsdelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsdelete_ItemClick);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 487);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtsupplier);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Shown += new System.EventHandler(this.SupplierForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtsupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtsupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gvsupplier;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtSupplierName;
        private DevExpress.XtraEditors.MemoEdit txtSupplierAddress;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn address;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraBars.BarManager barManagerGrid;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem tsrefresh;
        private DevExpress.XtraBars.PopupMenu popupMenuGrid;
        private System.ComponentModel.BackgroundWorker bwSupplierGet;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.BarButtonItem tsdelete;
    }
}