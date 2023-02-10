namespace Procurement_Tracking_App
{
    partial class Breakdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Breakdown));
            this.gcBreakdown = new DevExpress.XtraEditors.GroupControl();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.medescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtunitcost = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtquan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtunit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtpropertyno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblPrNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtbreakdown = new DevExpress.XtraGrid.GridControl();
            this.gvbreakdown = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.property_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcBreakdown)).BeginInit();
            this.gcBreakdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunitcost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpropertyno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbreakdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvbreakdown)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBreakdown
            // 
            this.gcBreakdown.Controls.Add(this.cbSupplier);
            this.gcBreakdown.Controls.Add(this.btnadd);
            this.gcBreakdown.Controls.Add(this.btndelete);
            this.gcBreakdown.Controls.Add(this.labelControl6);
            this.gcBreakdown.Controls.Add(this.medescription);
            this.gcBreakdown.Controls.Add(this.labelControl5);
            this.gcBreakdown.Controls.Add(this.txtunitcost);
            this.gcBreakdown.Controls.Add(this.labelControl3);
            this.gcBreakdown.Controls.Add(this.txtquan);
            this.gcBreakdown.Controls.Add(this.labelControl4);
            this.gcBreakdown.Controls.Add(this.txtunit);
            this.gcBreakdown.Controls.Add(this.labelControl2);
            this.gcBreakdown.Controls.Add(this.txtpropertyno);
            this.gcBreakdown.Controls.Add(this.labelControl1);
            this.gcBreakdown.Controls.Add(this.lblPrNo);
            this.gcBreakdown.Controls.Add(this.labelControl7);
            this.gcBreakdown.Controls.Add(this.dtbreakdown);
            this.gcBreakdown.Location = new System.Drawing.Point(12, 12);
            this.gcBreakdown.Name = "gcBreakdown";
            this.gcBreakdown.Size = new System.Drawing.Size(900, 546);
            this.gcBreakdown.TabIndex = 21;
            this.gcBreakdown.Text = "Breakdown";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(704, 397);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(178, 24);
            this.cbSupplier.TabIndex = 39;
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(643, 439);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(239, 47);
            this.btnadd.TabIndex = 38;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(643, 492);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(239, 49);
            this.btndelete.TabIndex = 37;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(643, 400);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 18);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Supplier:";
            // 
            // medescription
            // 
            this.medescription.Location = new System.Drawing.Point(137, 461);
            this.medescription.Name = "medescription";
            this.medescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.medescription.Size = new System.Drawing.Size(489, 80);
            this.medescription.TabIndex = 34;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(19, 468);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(112, 18);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Item Description:";
            // 
            // txtunitcost
            // 
            this.txtunitcost.Location = new System.Drawing.Point(421, 433);
            this.txtunitcost.Name = "txtunitcost";
            this.txtunitcost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunitcost.Properties.Appearance.Options.UseFont = true;
            this.txtunitcost.Properties.Mask.EditMask = "n";
            this.txtunitcost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtunitcost.Size = new System.Drawing.Size(205, 22);
            this.txtunitcost.TabIndex = 32;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(351, 434);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 18);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Unit Cost:";
            // 
            // txtquan
            // 
            this.txtquan.Location = new System.Drawing.Point(421, 396);
            this.txtquan.Name = "txtquan";
            this.txtquan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquan.Properties.Appearance.Options.UseFont = true;
            this.txtquan.Properties.Mask.EditMask = "d";
            this.txtquan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtquan.Size = new System.Drawing.Size(205, 22);
            this.txtquan.TabIndex = 30;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(355, 397);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 18);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Quantity:";
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(137, 433);
            this.txtunit.Name = "txtunit";
            this.txtunit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunit.Properties.Appearance.Options.UseFont = true;
            this.txtunit.Size = new System.Drawing.Size(196, 22);
            this.txtunit.TabIndex = 28;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(101, 434);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Unit:";
            // 
            // txtpropertyno
            // 
            this.txtpropertyno.Location = new System.Drawing.Point(137, 396);
            this.txtpropertyno.Name = "txtpropertyno";
            this.txtpropertyno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpropertyno.Properties.Appearance.Options.UseFont = true;
            this.txtpropertyno.Size = new System.Drawing.Size(196, 22);
            this.txtpropertyno.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(38, 401);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 18);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Property No.: ";
            // 
            // lblPrNo
            // 
            this.lblPrNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrNo.Appearance.BorderColor = System.Drawing.Color.Black;
            this.lblPrNo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPrNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPrNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblPrNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPrNo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblPrNo.Location = new System.Drawing.Point(19, 47);
            this.lblPrNo.Name = "lblPrNo";
            this.lblPrNo.Size = new System.Drawing.Size(863, 44);
            this.lblPrNo.TabIndex = 23;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(19, 30);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(863, 20);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Pr No.";
            // 
            // dtbreakdown
            // 
            this.dtbreakdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtbreakdown.Location = new System.Drawing.Point(19, 97);
            this.dtbreakdown.MainView = this.gvbreakdown;
            this.dtbreakdown.Name = "dtbreakdown";
            this.dtbreakdown.Size = new System.Drawing.Size(863, 293);
            this.dtbreakdown.TabIndex = 21;
            this.dtbreakdown.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvbreakdown});
            // 
            // gvbreakdown
            // 
            this.gvbreakdown.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.property_no,
            this.unit,
            this.description,
            this.unit_cost,
            this.quantity,
            this.total_cost,
            this.supplier,
            this.id});
            this.gvbreakdown.GridControl = this.dtbreakdown;
            this.gvbreakdown.Name = "gvbreakdown";
            this.gvbreakdown.OptionsBehavior.Editable = false;
            this.gvbreakdown.OptionsFind.AlwaysVisible = true;
            this.gvbreakdown.OptionsFind.SearchInPreview = true;
            this.gvbreakdown.OptionsView.RowAutoHeight = true;
            this.gvbreakdown.OptionsView.ShowGroupPanel = false;
            this.gvbreakdown.OptionsView.ShowIndicator = false;
            // 
            // property_no
            // 
            this.property_no.AppearanceCell.Options.UseTextOptions = true;
            this.property_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.property_no.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.property_no.AppearanceHeader.Options.UseTextOptions = true;
            this.property_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.property_no.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.property_no.Caption = "Property No.";
            this.property_no.FieldName = "property_no";
            this.property_no.MinWidth = 150;
            this.property_no.Name = "property_no";
            this.property_no.Visible = true;
            this.property_no.VisibleIndex = 0;
            this.property_no.Width = 162;
            // 
            // unit
            // 
            this.unit.AppearanceCell.Options.UseTextOptions = true;
            this.unit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.unit.AppearanceHeader.Options.UseTextOptions = true;
            this.unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.unit.Caption = "Unit";
            this.unit.FieldName = "unit";
            this.unit.MinWidth = 75;
            this.unit.Name = "unit";
            this.unit.Visible = true;
            this.unit.VisibleIndex = 1;
            this.unit.Width = 116;
            // 
            // description
            // 
            this.description.AppearanceCell.Options.UseTextOptions = true;
            this.description.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.description.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.description.AppearanceHeader.Options.UseTextOptions = true;
            this.description.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.description.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.description.Caption = "Description";
            this.description.FieldName = "description";
            this.description.MinWidth = 200;
            this.description.Name = "description";
            this.description.Visible = true;
            this.description.VisibleIndex = 2;
            this.description.Width = 200;
            // 
            // unit_cost
            // 
            this.unit_cost.AppearanceCell.Options.UseTextOptions = true;
            this.unit_cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unit_cost.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.unit_cost.AppearanceHeader.Options.UseTextOptions = true;
            this.unit_cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unit_cost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.unit_cost.Caption = "Unit Cost";
            this.unit_cost.FieldName = "unit_cost";
            this.unit_cost.MinWidth = 75;
            this.unit_cost.Name = "unit_cost";
            this.unit_cost.Visible = true;
            this.unit_cost.VisibleIndex = 3;
            this.unit_cost.Width = 116;
            // 
            // quantity
            // 
            this.quantity.AppearanceCell.Options.UseTextOptions = true;
            this.quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.quantity.Caption = "Quantity";
            this.quantity.FieldName = "quantity";
            this.quantity.MinWidth = 75;
            this.quantity.Name = "quantity";
            this.quantity.Visible = true;
            this.quantity.VisibleIndex = 4;
            this.quantity.Width = 116;
            // 
            // total_cost
            // 
            this.total_cost.AppearanceCell.Options.UseTextOptions = true;
            this.total_cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.total_cost.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.total_cost.AppearanceHeader.Options.UseTextOptions = true;
            this.total_cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.total_cost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.total_cost.Caption = "Total Cost";
            this.total_cost.FieldName = "total_cost";
            this.total_cost.MinWidth = 75;
            this.total_cost.Name = "total_cost";
            this.total_cost.Visible = true;
            this.total_cost.VisibleIndex = 5;
            this.total_cost.Width = 116;
            // 
            // supplier
            // 
            this.supplier.AppearanceCell.Options.UseTextOptions = true;
            this.supplier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.supplier.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.supplier.AppearanceHeader.Options.UseTextOptions = true;
            this.supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.supplier.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.supplier.Caption = "Supplier";
            this.supplier.FieldName = "supplier";
            this.supplier.MinWidth = 75;
            this.supplier.Name = "supplier";
            this.supplier.Visible = true;
            this.supplier.VisibleIndex = 6;
            this.supplier.Width = 119;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // Breakdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 570);
            this.Controls.Add(this.gcBreakdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Breakdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Breakdown";
            this.Shown += new System.EventHandler(this.Breakdown_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcBreakdown)).EndInit();
            this.gcBreakdown.ResumeLayout(false);
            this.gcBreakdown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunitcost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpropertyno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbreakdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvbreakdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcBreakdown;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Views.Grid.GridView gvbreakdown;
        private DevExpress.XtraEditors.MemoEdit medescription;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtunitcost;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtquan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtunit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtpropertyno;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.LabelControl lblPrNo;
        private DevExpress.XtraGrid.Columns.GridColumn property_no;
        private DevExpress.XtraGrid.Columns.GridColumn unit;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn unit_cost;
        private DevExpress.XtraGrid.Columns.GridColumn quantity;
        private DevExpress.XtraGrid.Columns.GridColumn total_cost;
        private DevExpress.XtraGrid.Columns.GridColumn supplier;
        private System.Windows.Forms.ComboBox cbSupplier;
        private DevExpress.XtraGrid.GridControl dtbreakdown;
        private DevExpress.XtraGrid.Columns.GridColumn id;
    }
}