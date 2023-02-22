namespace Procurement_Tracking_App
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtabc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.cbEndUser = new System.Windows.Forms.ComboBox();
            this.cbmode = new System.Windows.Forms.ComboBox();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.barMenuGrid = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnEditPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditBreakdown = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewBreakdown = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdatePurchase = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuGrid = new DevExpress.XtraBars.PopupMenu(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Procurement_Tracking_App.WaitForm1), true, true);
            this.bwLoadData = new System.ComponentModel.BackgroundWorker();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewPur = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewBreak = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtabc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMenuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPurchase
            // 
            this.dtPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPurchase.Location = new System.Drawing.Point(12, 12);
            this.dtPurchase.MainView = this.gvPurchase;
            this.dtPurchase.Name = "dtPurchase";
            this.dtPurchase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemMemoEdit2});
            this.dtPurchase.Size = new System.Drawing.Size(570, 648);
            this.dtPurchase.TabIndex = 1;
            this.dtPurchase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurchase});
            this.dtPurchase.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtPurchase_MouseDoubleClick);
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
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(601, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 33);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Purchase";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(601, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "PR. NO  *";
            // 
            // txtPrNo
            // 
            this.txtPrNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrNo.Location = new System.Drawing.Point(617, 116);
            this.txtPrNo.Name = "txtPrNo";
            this.txtPrNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrNo.Properties.Appearance.Options.UseFont = true;
            this.txtPrNo.Size = new System.Drawing.Size(338, 26);
            this.txtPrNo.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(601, 157);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(117, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "DESCRIPTION *";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(601, 302);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "END USER *";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(601, 374);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(201, 19);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "MODE OF PROCUREMENT *";
            // 
            // txtabc
            // 
            this.txtabc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtabc.Location = new System.Drawing.Point(617, 476);
            this.txtabc.Name = "txtabc";
            this.txtabc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtabc.Properties.Appearance.Options.UseFont = true;
            this.txtabc.Properties.Mask.EditMask = "n";
            this.txtabc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtabc.Size = new System.Drawing.Size(338, 26);
            this.txtabc.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(601, 447);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(334, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "AMOUNT BUDGET FOR THE CONTRACT(ABC)";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(617, 188);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.Size = new System.Drawing.Size(338, 96);
            this.txtDescription.TabIndex = 13;
            // 
            // cbEndUser
            // 
            this.cbEndUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEndUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEndUser.FormattingEnabled = true;
            this.cbEndUser.Items.AddRange(new object[] {
            "DR. JEAN F. NEBREA",
            "DR. JOCELYN P. LUMACTUD",
            "DR. EVANGIELYN P. LUMANTAS",
            "IRENE G. MAGLAHOS",
            "DR. DHOREE MAY R. MARAVILLA",
            "MARC BENIGNO C. OLAGUIR",
            "DR. SHELLA C. OLAGUIR",
            "DR. BENJAMIN N. OMAMALIN",
            "JUN REY J. POYOS",
            "RIAME T. TUICO",
            "ESTRELLA MARIE V. BUNGABONG",
            "VIRGINIA S. PONOLLERA",
            "ERNESTO B. ALIJAY JR.",
            "IVY JANE S. ASILO",
            "JHONMAR S. AVERGONZADO",
            "MARRY JOYCE P. GUDMALIN",
            "MA. KATHLEEN DUREEN M. TRAVERO",
            "IRVIN B. DUMAPIAS",
            "VICTOR S. MANIWANG JR."});
            this.cbEndUser.Location = new System.Drawing.Point(617, 327);
            this.cbEndUser.Name = "cbEndUser";
            this.cbEndUser.Size = new System.Drawing.Size(338, 27);
            this.cbEndUser.TabIndex = 15;
            // 
            // cbmode
            // 
            this.cbmode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbmode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmode.FormattingEnabled = true;
            this.cbmode.Items.AddRange(new object[] {
            "PUBLIC BIDDING",
            "NEGOTIATED PROCUREMENT (SVP)",
            "NEGOTIATED PROCUREMENT UNDER EMERGENCY CASES"});
            this.cbmode.Location = new System.Drawing.Point(617, 399);
            this.cbmode.Margin = new System.Windows.Forms.Padding(5);
            this.cbmode.Name = "cbmode";
            this.cbmode.Size = new System.Drawing.Size(338, 27);
            this.cbmode.TabIndex = 16;
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(592, 615);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(195, 42);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "Save";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.Enabled = false;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(592, 567);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(195, 42);
            this.btnedit.TabIndex = 18;
            this.btnedit.Text = "Edit Purchase Details";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Enabled = false;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.Location = new System.Drawing.Point(793, 615);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(177, 42);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // barMenuGrid
            // 
            this.barMenuGrid.DockControls.Add(this.barDockControlTop);
            this.barMenuGrid.DockControls.Add(this.barDockControlBottom);
            this.barMenuGrid.DockControls.Add(this.barDockControlLeft);
            this.barMenuGrid.DockControls.Add(this.barDockControlRight);
            this.barMenuGrid.Form = this;
            this.barMenuGrid.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnEditPurchase,
            this.btnEditBreakdown,
            this.btnRefresh,
            this.btnViewBreakdown,
            this.btnUpdatePurchase,
            this.btnViewPurchase});
            this.barMenuGrid.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(982, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 672);
            this.barDockControlBottom.Size = new System.Drawing.Size(982, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 672);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(982, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 672);
            // 
            // btnEditPurchase
            // 
            this.btnEditPurchase.Caption = "Edit Purchase";
            this.btnEditPurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditPurchase.Glyph")));
            this.btnEditPurchase.Id = 0;
            this.btnEditPurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditPurchase.LargeGlyph")));
            this.btnEditPurchase.Name = "btnEditPurchase";
            this.btnEditPurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditPurchase_ItemClick);
            // 
            // btnEditBreakdown
            // 
            this.btnEditBreakdown.Caption = "Edit Breakdown";
            this.btnEditBreakdown.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditBreakdown.Glyph")));
            this.btnEditBreakdown.Id = 1;
            this.btnEditBreakdown.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditBreakdown.LargeGlyph")));
            this.btnEditBreakdown.Name = "btnEditBreakdown";
            this.btnEditBreakdown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditBreakdown_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 2;
            this.btnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.LargeGlyph")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnViewBreakdown
            // 
            this.btnViewBreakdown.Caption = "View Breakdown";
            this.btnViewBreakdown.Glyph = ((System.Drawing.Image)(resources.GetObject("btnViewBreakdown.Glyph")));
            this.btnViewBreakdown.Id = 3;
            this.btnViewBreakdown.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnViewBreakdown.LargeGlyph")));
            this.btnViewBreakdown.Name = "btnViewBreakdown";
            this.btnViewBreakdown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewBreakdown_ItemClick);
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEditPurchase, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEditBreakdown, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnViewBreakdown, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdatePurchase, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnViewPurchase, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.popupMenuGrid.Manager = this.barMenuGrid;
            this.popupMenuGrid.Name = "popupMenuGrid";
            // 
            // bwLoadData
            // 
            this.bwLoadData.WorkerSupportsCancellation = true;
            this.bwLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadData_DoWork);
            this.bwLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadData_RunWorkerCompleted);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.Enabled = false;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.Location = new System.Drawing.Point(592, 519);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(195, 42);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update Purchase";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnViewPur
            // 
            this.btnViewPur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewPur.Enabled = false;
            this.btnViewPur.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPur.Image")));
            this.btnViewPur.Location = new System.Drawing.Point(793, 519);
            this.btnViewPur.Name = "btnViewPur";
            this.btnViewPur.Size = new System.Drawing.Size(177, 42);
            this.btnViewPur.TabIndex = 30;
            this.btnViewPur.Text = "View Purchase";
            this.btnViewPur.Click += new System.EventHandler(this.btnViewPur_Click);
            // 
            // btnViewBreak
            // 
            this.btnViewBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewBreak.Enabled = false;
            this.btnViewBreak.Image = ((System.Drawing.Image)(resources.GetObject("btnViewBreak.Image")));
            this.btnViewBreak.Location = new System.Drawing.Point(793, 567);
            this.btnViewBreak.Name = "btnViewBreak";
            this.btnViewBreak.Size = new System.Drawing.Size(177, 42);
            this.btnViewBreak.TabIndex = 29;
            this.btnViewBreak.Text = "View Purchase Details";
            this.btnViewBreak.Click += new System.EventHandler(this.btnViewBreak_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 672);
            this.Controls.Add(this.btnViewPur);
            this.Controls.Add(this.btnViewBreak);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.cbmode);
            this.Controls.Add(this.cbEndUser);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtabc);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPrNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtPurchase);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.PurchaseForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtabc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMenuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtPurchase;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPurchase;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPrNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtabc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.ComboBox cbEndUser;
        private System.Windows.Forms.ComboBox cbmode;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraGrid.Columns.GridColumn po_no;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn end_user;
        private DevExpress.XtraGrid.Columns.GridColumn mode_of_pr;
        private DevExpress.XtraGrid.Columns.GridColumn abc;
        private DevExpress.XtraGrid.Columns.GridColumn posting;
        private DevExpress.XtraGrid.Columns.GridColumn opening_of_bids;
        private DevExpress.XtraGrid.Columns.GridColumn preproc;
        private DevExpress.XtraGrid.Columns.GridColumn predib;
        private DevExpress.XtraGrid.Columns.GridColumn detailed_bid_evaluation;
        private DevExpress.XtraGrid.Columns.GridColumn award;
        private DevExpress.XtraGrid.Columns.GridColumn po;
        private DevExpress.XtraGrid.Columns.GridColumn ntp;
        private DevExpress.XtraGrid.Columns.GridColumn delivery;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraBars.BarManager barMenuGrid;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnEditPurchase;
        private DevExpress.XtraBars.BarButtonItem btnEditBreakdown;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.PopupMenu popupMenuGrid;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwLoadData;
        private DevExpress.XtraBars.BarButtonItem btnViewBreakdown;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraBars.BarButtonItem btnUpdatePurchase;
        private DevExpress.XtraBars.BarButtonItem btnViewPurchase;
        private DevExpress.XtraEditors.SimpleButton btnViewPur;
        private DevExpress.XtraEditors.SimpleButton btnViewBreak;
    }
}