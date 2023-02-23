namespace Procurement_Tracking_App
{
    partial class ReportForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.dtReport = new DevExpress.XtraGrid.GridControl();
            this.gvReport = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.btnPrintReport = new DevExpress.XtraEditors.SimpleButton();
            this.bwLoadData = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Procurement_Tracking_App.WaitForm1), true, true);
            this.bwLoadBreakdown = new System.ComponentModel.BackgroundWorker();
            this.pnlDates = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtpTo = new DevExpress.XtraEditors.DateEdit();
            this.dtpFrom = new DevExpress.XtraEditors.DateEdit();
            this.cmbDateSpan = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDates)).BeginInit();
            this.pnlDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateSpan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtReport
            // 
            this.dtReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtReport.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            gridLevelNode1.RelationName = "Level1";
            this.dtReport.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dtReport.Location = new System.Drawing.Point(13, 84);
            this.dtReport.MainView = this.gvReport;
            this.dtReport.Margin = new System.Windows.Forms.Padding(4);
            this.dtReport.Name = "dtReport";
            this.dtReport.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemMemoEdit2});
            this.dtReport.Size = new System.Drawing.Size(1527, 704);
            this.dtReport.TabIndex = 2;
            this.dtReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReport});
            this.dtReport.Click += new System.EventHandler(this.dtReport_Click);
            // 
            // gvReport
            // 
            this.gvReport.Appearance.Preview.Options.UseTextOptions = true;
            this.gvReport.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvReport.Appearance.Row.Options.UseTextOptions = true;
            this.gvReport.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvReport.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvReport.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gvReport.GridControl = this.dtReport;
            this.gvReport.Name = "gvReport";
            this.gvReport.OptionsBehavior.Editable = false;
            this.gvReport.OptionsFind.AlwaysVisible = true;
            this.gvReport.OptionsFind.SearchInPreview = true;
            this.gvReport.OptionsView.RowAutoHeight = true;
            this.gvReport.OptionsView.ShowGroupPanel = false;
            this.gvReport.OptionsView.ShowIndicator = false;
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
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintReport.Image")));
            this.btnPrintReport.Location = new System.Drawing.Point(1274, 15);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(266, 61);
            this.btnPrintReport.TabIndex = 20;
            this.btnPrintReport.Text = "Print";
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // bwLoadData
            // 
            this.bwLoadData.WorkerSupportsCancellation = true;
            this.bwLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadProcurement_DoWork);
            this.bwLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadProcurement_RunWorkerCompleted);
            // 
            // bwLoadBreakdown
            // 
            this.bwLoadBreakdown.WorkerSupportsCancellation = true;
            this.bwLoadBreakdown.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadBreakdown_DoWork);
            this.bwLoadBreakdown.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadBreakdown_RunWorkerCompleted);
            // 
            // pnlDates
            // 
            this.pnlDates.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlDates.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pnlDates.Appearance.Options.UseBackColor = true;
            this.pnlDates.Appearance.Options.UseFont = true;
            this.pnlDates.Controls.Add(this.labelControl8);
            this.pnlDates.Controls.Add(this.btnSearch);
            this.pnlDates.Controls.Add(this.labelControl6);
            this.pnlDates.Controls.Add(this.dtpTo);
            this.pnlDates.Controls.Add(this.dtpFrom);
            this.pnlDates.Location = new System.Drawing.Point(309, 4);
            this.pnlDates.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(627, 82);
            this.pnlDates.TabIndex = 382;
            this.pnlDates.Visible = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(22, 4);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 21);
            this.labelControl8.TabIndex = 370;
            this.labelControl8.Text = "From :";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(490, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 39);
            this.btnSearch.TabIndex = 365;
            this.btnSearch.Text = "Load";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(256, 4);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 21);
            this.labelControl6.TabIndex = 369;
            this.labelControl6.Text = "To :";
            // 
            // dtpTo
            // 
            this.dtpTo.EditValue = null;
            this.dtpTo.Location = new System.Drawing.Point(256, 34);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(6);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpTo.Properties.Appearance.Options.UseFont = true;
            this.dtpTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Properties.DisplayFormat.FormatString = "MMM. dd, yyyy";
            this.dtpTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTo.Properties.EditFormat.FormatString = "MMM. dd, yyyy";
            this.dtpTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTo.Properties.Mask.EditMask = "MMM. dd, yyyy";
            this.dtpTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpTo.Size = new System.Drawing.Size(222, 34);
            this.dtpTo.TabIndex = 364;
            // 
            // dtpFrom
            // 
            this.dtpFrom.EditValue = null;
            this.dtpFrom.Location = new System.Drawing.Point(22, 34);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpFrom.Properties.Appearance.Options.UseFont = true;
            this.dtpFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Properties.DisplayFormat.FormatString = "MMM. dd, yyyy";
            this.dtpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFrom.Properties.EditFormat.FormatString = "MMM. dd, yyyy";
            this.dtpFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFrom.Properties.Mask.EditMask = "MMM. dd, yyyy";
            this.dtpFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpFrom.Size = new System.Drawing.Size(222, 34);
            this.dtpFrom.TabIndex = 362;
            // 
            // cmbDateSpan
            // 
            this.cmbDateSpan.EditValue = "-- Select Period --";
            this.cmbDateSpan.Location = new System.Drawing.Point(15, 42);
            this.cmbDateSpan.Margin = new System.Windows.Forms.Padding(6);
            this.cmbDateSpan.Name = "cmbDateSpan";
            this.cmbDateSpan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.cmbDateSpan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbDateSpan.Properties.Appearance.Options.UseBackColor = true;
            this.cmbDateSpan.Properties.Appearance.Options.UseFont = true;
            this.cmbDateSpan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDateSpan.Properties.NullText = "-- Select Period --";
            this.cmbDateSpan.Properties.View = this.gridView1;
            this.cmbDateSpan.Size = new System.Drawing.Size(284, 34);
            this.cmbDateSpan.TabIndex = 381;
            this.cmbDateSpan.EditValueChanged += new System.EventHandler(this.cmbDateSpan_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 801);
            this.Controls.Add(this.pnlDates);
            this.Controls.Add(this.cmbDateSpan);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.dtReport);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReportForm";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.Shown += new System.EventHandler(this.ReportForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDates)).EndInit();
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateSpan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReport;
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
        private DevExpress.XtraEditors.SimpleButton btnPrintReport;
        private System.ComponentModel.BackgroundWorker bwLoadData;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwLoadProcurement;
        private System.ComponentModel.BackgroundWorker bwLoadBreakdown;
        private DevExpress.XtraEditors.PanelControl pnlDates;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtpTo;
        private DevExpress.XtraEditors.DateEdit dtpFrom;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbDateSpan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}