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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.dtPurchase = new DevExpress.XtraGrid.GridControl();
            this.gvPurchase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.po_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.end_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mode_of_pr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.abc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.posting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.opening_of_bids = new DevExpress.XtraGrid.Columns.GridColumn();
            this.preproc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.predib = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailed_bid_evaluation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.award = new DevExpress.XtraGrid.Columns.GridColumn();
            this.po = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ntp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delivery = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtabc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
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
            this.dtPurchase.Size = new System.Drawing.Size(970, 599);
            this.dtPurchase.TabIndex = 1;
            this.dtPurchase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurchase});
            // 
            // gvPurchase
            // 
            this.gvPurchase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.po_no,
            this.description,
            this.end_user,
            this.mode_of_pr,
            this.abc,
            this.posting,
            this.opening_of_bids,
            this.preproc,
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
            this.gvPurchase.OptionsSelection.EnableAppearanceFocusedRow = false;
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
            this.po_no.Caption = "PO No.";
            this.po_no.FieldName = "po_no";
            this.po_no.Name = "po_no";
            this.po_no.Visible = true;
            this.po_no.VisibleIndex = 0;
            // 
            // description
            // 
            this.description.Caption = "Description";
            this.description.FieldName = "description";
            this.description.Name = "description";
            this.description.Visible = true;
            this.description.VisibleIndex = 1;
            // 
            // end_user
            // 
            this.end_user.Caption = "End User";
            this.end_user.FieldName = "end_user";
            this.end_user.Name = "end_user";
            this.end_user.Visible = true;
            this.end_user.VisibleIndex = 2;
            // 
            // mode_of_pr
            // 
            this.mode_of_pr.Caption = "Mode of PR";
            this.mode_of_pr.FieldName = "mode_of_pr";
            this.mode_of_pr.Name = "mode_of_pr";
            this.mode_of_pr.Visible = true;
            this.mode_of_pr.VisibleIndex = 3;
            // 
            // abc
            // 
            this.abc.Caption = "ABC";
            this.abc.FieldName = "abc";
            this.abc.Name = "abc";
            this.abc.Visible = true;
            this.abc.VisibleIndex = 4;
            // 
            // posting
            // 
            this.posting.Caption = "Posting";
            this.posting.FieldName = "posting";
            this.posting.Name = "posting";
            this.posting.Visible = true;
            this.posting.VisibleIndex = 5;
            // 
            // opening_of_bids
            // 
            this.opening_of_bids.Caption = "Opening of bids";
            this.opening_of_bids.FieldName = "opening_of_bids";
            this.opening_of_bids.Name = "opening_of_bids";
            this.opening_of_bids.Visible = true;
            this.opening_of_bids.VisibleIndex = 6;
            // 
            // preproc
            // 
            this.preproc.Caption = "Pre Proc";
            this.preproc.FieldName = "preproc";
            this.preproc.Name = "preproc";
            this.preproc.Visible = true;
            this.preproc.VisibleIndex = 7;
            // 
            // predib
            // 
            this.predib.Caption = "Pre Bid";
            this.predib.FieldName = "prebid";
            this.predib.Name = "predib";
            this.predib.Visible = true;
            this.predib.VisibleIndex = 8;
            // 
            // detailed_bid_evaluation
            // 
            this.detailed_bid_evaluation.Caption = "Detailed Bid Evaluation";
            this.detailed_bid_evaluation.FieldName = "detailed_bid_evaluation";
            this.detailed_bid_evaluation.Name = "detailed_bid_evaluation";
            this.detailed_bid_evaluation.Visible = true;
            this.detailed_bid_evaluation.VisibleIndex = 9;
            // 
            // award
            // 
            this.award.Caption = "Award";
            this.award.FieldName = "award";
            this.award.Name = "award";
            this.award.Visible = true;
            this.award.VisibleIndex = 10;
            // 
            // po
            // 
            this.po.Caption = "PO";
            this.po.FieldName = "po";
            this.po.Name = "po";
            this.po.Visible = true;
            this.po.VisibleIndex = 11;
            // 
            // ntp
            // 
            this.ntp.Caption = "NTP";
            this.ntp.FieldName = "ntp";
            this.ntp.Name = "ntp";
            this.ntp.Visible = true;
            this.ntp.VisibleIndex = 12;
            // 
            // delivery
            // 
            this.delivery.Caption = "Delivery";
            this.delivery.FieldName = "delivery";
            this.delivery.Name = "delivery";
            this.delivery.Visible = true;
            this.delivery.VisibleIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(1001, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 33);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Purchase";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(1001, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "PR. NO  *";
            // 
            // txtPrNo
            // 
            this.txtPrNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrNo.Location = new System.Drawing.Point(1017, 116);
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
            this.labelControl3.Location = new System.Drawing.Point(1001, 157);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(117, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "DESCRIPTION *";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(1001, 302);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "END USER *";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(1001, 374);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(201, 19);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "MODE OF PROCUREMENT *";
            // 
            // txtabc
            // 
            this.txtabc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtabc.Location = new System.Drawing.Point(1017, 476);
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
            this.labelControl6.Location = new System.Drawing.Point(1001, 447);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(334, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "AMOUNT BUDGET FOR THE CONTRACT(ABC)";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(1017, 188);
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
            this.cbEndUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbEndUser.Location = new System.Drawing.Point(1017, 327);
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
            this.cbmode.Location = new System.Drawing.Point(1017, 399);
            this.cbmode.Margin = new System.Windows.Forms.Padding(5);
            this.cbmode.Name = "cbmode";
            this.cbmode.Size = new System.Drawing.Size(338, 27);
            this.cbmode.TabIndex = 16;
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(1247, 559);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(123, 42);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "Save";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.Enabled = false;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(1114, 559);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(126, 42);
            this.btnedit.TabIndex = 18;
            this.btnedit.Text = "Edit";
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Enabled = false;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.Location = new System.Drawing.Point(988, 559);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(120, 42);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "Cancel";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 623);
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
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.Shown += new System.EventHandler(this.PurchaseForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtabc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
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
    }
}