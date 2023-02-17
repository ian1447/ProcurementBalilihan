namespace Procurement_Tracking_App
{
    partial class ProcurementTrackingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurementTrackingForm));
            this.dtPurchase = new DevExpress.XtraGrid.GridControl();
            this.gvPurchase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.po_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.end_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mode_of_pr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.abc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.opening_of_bids = new DevExpress.XtraGrid.Columns.GridColumn();
            this.preproc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.posting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.predib = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailed_bid_evaluation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.award = new DevExpress.XtraGrid.Columns.GridColumn();
            this.po = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ntp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.btnrefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.bwLoadData = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Procurement_Tracking_App.WaitForm1), true, true);
            this.barMenuGrid = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnTsRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdatePurchase = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuGrid = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMenuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPurchase
            // 
            this.dtPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPurchase.Location = new System.Drawing.Point(12, 60);
            this.dtPurchase.MainView = this.gvPurchase;
            this.dtPurchase.Name = "dtPurchase";
            this.dtPurchase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemMemoEdit2});
            this.dtPurchase.Size = new System.Drawing.Size(1272, 568);
            this.dtPurchase.TabIndex = 2;
            this.dtPurchase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurchase});
            this.dtPurchase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtPurchase_MouseDown);
            // 
            // gvPurchase
            // 
            this.gvPurchase.Appearance.Preview.Options.UseTextOptions = true;
            this.gvPurchase.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvPurchase.Appearance.Row.Options.UseTextOptions = true;
            this.gvPurchase.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvPurchase.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvPurchase.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvPurchase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.po_no,
            this.description,
            this.end_user,
            this.mode_of_pr,
            this.abc,
            this.opening_of_bids,
            this.preproc,
            this.posting,
            this.predib,
            this.detailed_bid_evaluation,
            this.award,
            this.po,
            this.ntp,
            this.delivery});
            this.gvPurchase.GridControl = this.dtPurchase;
            this.gvPurchase.Name = "gvPurchase";
            this.gvPurchase.OptionsBehavior.Editable = false;
            this.gvPurchase.OptionsFind.AlwaysVisible = true;
            this.gvPurchase.OptionsFind.SearchInPreview = true;
            this.gvPurchase.OptionsView.RowAutoHeight = true;
            this.gvPurchase.OptionsView.ShowGroupPanel = false;
            this.gvPurchase.OptionsView.ShowIndicator = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // po_no
            // 
            this.po_no.AppearanceCell.Options.UseTextOptions = true;
            this.po_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.po_no.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.po_no.AppearanceHeader.Options.UseTextOptions = true;
            this.po_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.po_no.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.po_no.Caption = "PO No.";
            this.po_no.FieldName = "po_no";
            this.po_no.Name = "po_no";
            this.po_no.Visible = true;
            this.po_no.VisibleIndex = 0;
            // 
            // description
            // 
            this.description.AppearanceCell.Options.UseTextOptions = true;
            this.description.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.description.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.description.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.description.AppearanceHeader.Options.UseTextOptions = true;
            this.description.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.description.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.description.Caption = "Description";
            this.description.ColumnEdit = this.repositoryItemMemoEdit1;
            this.description.FieldName = "description";
            this.description.MinWidth = 75;
            this.description.Name = "description";
            this.description.Visible = true;
            this.description.VisibleIndex = 1;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // end_user
            // 
            this.end_user.AppearanceCell.Options.UseTextOptions = true;
            this.end_user.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.end_user.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.end_user.AppearanceHeader.Options.UseTextOptions = true;
            this.end_user.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.end_user.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.end_user.Caption = "End User";
            this.end_user.FieldName = "end_user";
            this.end_user.MinWidth = 75;
            this.end_user.Name = "end_user";
            this.end_user.Visible = true;
            this.end_user.VisibleIndex = 2;
            // 
            // mode_of_pr
            // 
            this.mode_of_pr.AppearanceCell.Options.UseTextOptions = true;
            this.mode_of_pr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mode_of_pr.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mode_of_pr.AppearanceHeader.Options.UseTextOptions = true;
            this.mode_of_pr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mode_of_pr.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mode_of_pr.Caption = "Mode of PR";
            this.mode_of_pr.ColumnEdit = this.repositoryItemMemoEdit2;
            this.mode_of_pr.FieldName = "mode_of_pr";
            this.mode_of_pr.MinWidth = 75;
            this.mode_of_pr.Name = "mode_of_pr";
            this.mode_of_pr.Visible = true;
            this.mode_of_pr.VisibleIndex = 3;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // abc
            // 
            this.abc.AppearanceCell.Options.UseTextOptions = true;
            this.abc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.abc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.abc.AppearanceHeader.Options.UseTextOptions = true;
            this.abc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.abc.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.abc.Caption = "ABC";
            this.abc.FieldName = "abc";
            this.abc.Name = "abc";
            this.abc.Visible = true;
            this.abc.VisibleIndex = 4;
            // 
            // opening_of_bids
            // 
            this.opening_of_bids.AppearanceCell.Options.UseTextOptions = true;
            this.opening_of_bids.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.opening_of_bids.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.opening_of_bids.AppearanceHeader.Options.UseTextOptions = true;
            this.opening_of_bids.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.opening_of_bids.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.opening_of_bids.Caption = "Opening of bids";
            this.opening_of_bids.FieldName = "opening_of_bids";
            this.opening_of_bids.Name = "opening_of_bids";
            this.opening_of_bids.Visible = true;
            this.opening_of_bids.VisibleIndex = 5;
            // 
            // preproc
            // 
            this.preproc.AppearanceCell.Options.UseTextOptions = true;
            this.preproc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.preproc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.preproc.AppearanceHeader.Options.UseTextOptions = true;
            this.preproc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.preproc.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.preproc.Caption = "Pre Proc";
            this.preproc.FieldName = "preproc";
            this.preproc.Name = "preproc";
            this.preproc.Visible = true;
            this.preproc.VisibleIndex = 6;
            // 
            // posting
            // 
            this.posting.AppearanceCell.Options.UseTextOptions = true;
            this.posting.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.posting.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.posting.AppearanceHeader.Options.UseTextOptions = true;
            this.posting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.posting.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.posting.Caption = "Posting";
            this.posting.FieldName = "posting";
            this.posting.Name = "posting";
            this.posting.Visible = true;
            this.posting.VisibleIndex = 7;
            // 
            // predib
            // 
            this.predib.AppearanceCell.Options.UseTextOptions = true;
            this.predib.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.predib.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.predib.AppearanceHeader.Options.UseTextOptions = true;
            this.predib.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.predib.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.predib.Caption = "Pre Bid";
            this.predib.FieldName = "prebid";
            this.predib.Name = "predib";
            this.predib.Visible = true;
            this.predib.VisibleIndex = 8;
            // 
            // detailed_bid_evaluation
            // 
            this.detailed_bid_evaluation.AppearanceCell.Options.UseTextOptions = true;
            this.detailed_bid_evaluation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.detailed_bid_evaluation.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.detailed_bid_evaluation.AppearanceHeader.Options.UseTextOptions = true;
            this.detailed_bid_evaluation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.detailed_bid_evaluation.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.detailed_bid_evaluation.Caption = "Detailed Bid Evaluation";
            this.detailed_bid_evaluation.FieldName = "detailed_bid_evaluation";
            this.detailed_bid_evaluation.Name = "detailed_bid_evaluation";
            this.detailed_bid_evaluation.Visible = true;
            this.detailed_bid_evaluation.VisibleIndex = 9;
            // 
            // award
            // 
            this.award.AppearanceCell.Options.UseTextOptions = true;
            this.award.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.award.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.award.AppearanceHeader.Options.UseTextOptions = true;
            this.award.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.award.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.award.Caption = "Award";
            this.award.FieldName = "award";
            this.award.Name = "award";
            this.award.Visible = true;
            this.award.VisibleIndex = 10;
            // 
            // po
            // 
            this.po.AppearanceCell.Options.UseTextOptions = true;
            this.po.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.po.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.po.AppearanceHeader.Options.UseTextOptions = true;
            this.po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.po.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.po.Caption = "PO";
            this.po.FieldName = "po";
            this.po.Name = "po";
            this.po.Visible = true;
            this.po.VisibleIndex = 11;
            // 
            // ntp
            // 
            this.ntp.AppearanceCell.Options.UseTextOptions = true;
            this.ntp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ntp.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ntp.AppearanceHeader.Options.UseTextOptions = true;
            this.ntp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ntp.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ntp.Caption = "NTP";
            this.ntp.FieldName = "ntp";
            this.ntp.Name = "ntp";
            this.ntp.Visible = true;
            this.ntp.VisibleIndex = 12;
            // 
            // delivery
            // 
            this.delivery.AppearanceCell.Options.UseTextOptions = true;
            this.delivery.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.delivery.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.delivery.AppearanceHeader.Options.UseTextOptions = true;
            this.delivery.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.delivery.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.delivery.Caption = "Delivery";
            this.delivery.FieldName = "delivery";
            this.delivery.Name = "delivery";
            this.delivery.Visible = true;
            this.delivery.VisibleIndex = 13;
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(1107, 12);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(177, 42);
            this.btnrefresh.TabIndex = 20;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.Location = new System.Drawing.Point(741, 12);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(177, 42);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "Update Purchase";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(924, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(177, 42);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "View Purchase";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // bwLoadData
            // 
            this.bwLoadData.WorkerSupportsCancellation = true;
            this.bwLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadData_DoWork);
            this.bwLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadData_RunWorkerCompleted);
            // 
            // barMenuGrid
            // 
            this.barMenuGrid.DockControls.Add(this.barDockControlTop);
            this.barMenuGrid.DockControls.Add(this.barDockControlBottom);
            this.barMenuGrid.DockControls.Add(this.barDockControlLeft);
            this.barMenuGrid.DockControls.Add(this.barDockControlRight);
            this.barMenuGrid.Form = this;
            this.barMenuGrid.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTsRefresh,
            this.btnUpdatePurchase,
            this.btnViewPurchase});
            this.barMenuGrid.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1296, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 640);
            this.barDockControlBottom.Size = new System.Drawing.Size(1296, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 640);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1296, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 640);
            // 
            // btnTsRefresh
            // 
            this.btnTsRefresh.Caption = "Refresh";
            this.btnTsRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTsRefresh.Glyph")));
            this.btnTsRefresh.Id = 2;
            this.btnTsRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTsRefresh.LargeGlyph")));
            this.btnTsRefresh.Name = "btnTsRefresh";
            this.btnTsRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTsRefresh_ItemClick);
            // 
            // btnUpdatePurchase
            // 
            this.btnUpdatePurchase.Caption = "Update Purchase";
            this.btnUpdatePurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUpdatePurchase.Glyph")));
            this.btnUpdatePurchase.Id = 4;
            this.btnUpdatePurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUpdatePurchase.LargeGlyph")));
            this.btnUpdatePurchase.Name = "btnUpdatePurchase";
            this.btnUpdatePurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdatePurchase_ItemClick);
            // 
            // btnViewPurchase
            // 
            this.btnViewPurchase.Caption = "View Purchase";
            this.btnViewPurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("btnViewPurchase.Glyph")));
            this.btnViewPurchase.Id = 5;
            this.btnViewPurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnViewPurchase.LargeGlyph")));
            this.btnViewPurchase.Name = "btnViewPurchase";
            this.btnViewPurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewPurchase_ItemClick);
            // 
            // popupMenuGrid
            // 
            this.popupMenuGrid.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdatePurchase, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnViewPurchase, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTsRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.popupMenuGrid.Manager = this.barMenuGrid;
            this.popupMenuGrid.Name = "popupMenuGrid";
            // 
            // ProcurementTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 640);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dtPurchase);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ProcurementTrackingForm";
            this.Text = "ProcurementTrackingForm";
            this.Shown += new System.EventHandler(this.ProcurementTrackingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMenuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtPurchase;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPurchase;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn po_no;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn end_user;
        private DevExpress.XtraGrid.Columns.GridColumn mode_of_pr;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn abc;
        private DevExpress.XtraGrid.Columns.GridColumn opening_of_bids;
        private DevExpress.XtraGrid.Columns.GridColumn preproc;
        private DevExpress.XtraGrid.Columns.GridColumn posting;
        private DevExpress.XtraGrid.Columns.GridColumn predib;
        private DevExpress.XtraGrid.Columns.GridColumn detailed_bid_evaluation;
        private DevExpress.XtraGrid.Columns.GridColumn award;
        private DevExpress.XtraGrid.Columns.GridColumn po;
        private DevExpress.XtraGrid.Columns.GridColumn ntp;
        private DevExpress.XtraGrid.Columns.GridColumn delivery;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraEditors.SimpleButton btnrefresh;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private System.ComponentModel.BackgroundWorker bwLoadData;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.BarManager barMenuGrid;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnTsRefresh;
        private DevExpress.XtraBars.BarButtonItem btnUpdatePurchase;
        private DevExpress.XtraBars.BarButtonItem btnViewPurchase;
        private DevExpress.XtraBars.PopupMenu popupMenuGrid;
    }
}