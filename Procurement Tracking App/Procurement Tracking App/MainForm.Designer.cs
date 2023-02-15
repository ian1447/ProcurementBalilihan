namespace Procurement_Tracking_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnlogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnsupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnpurchase = new DevExpress.XtraBars.BarButtonItem();
            this.btnprocurementtracking = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnusermanagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnreport = new DevExpress.XtraBars.BarButtonItem();
            this.btnmainlogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnlogout,
            this.btnsupplier,
            this.btnpurchase,
            this.btnprocurementtracking,
            this.barButtonItem4,
            this.btnusermanagement,
            this.btnreport,
            this.btnmainlogout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btnlogout);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(898, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnlogout
            // 
            this.btnlogout.Caption = "Logout";
            this.btnlogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnlogout.Glyph")));
            this.btnlogout.Id = 1;
            this.btnlogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnlogout.LargeGlyph")));
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnlogout_ItemClick);
            // 
            // btnsupplier
            // 
            this.btnsupplier.Caption = "Supplier";
            this.btnsupplier.Glyph = ((System.Drawing.Image)(resources.GetObject("btnsupplier.Glyph")));
            this.btnsupplier.Id = 2;
            this.btnsupplier.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnsupplier.LargeGlyph")));
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsupplier_ItemClick);
            // 
            // btnpurchase
            // 
            this.btnpurchase.Caption = "Purchase";
            this.btnpurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("btnpurchase.Glyph")));
            this.btnpurchase.Id = 3;
            this.btnpurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnpurchase.LargeGlyph")));
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnpurchase_ItemClick);
            // 
            // btnprocurementtracking
            // 
            this.btnprocurementtracking.Caption = "Procurement Tracking";
            this.btnprocurementtracking.Glyph = ((System.Drawing.Image)(resources.GetObject("btnprocurementtracking.Glyph")));
            this.btnprocurementtracking.Id = 4;
            this.btnprocurementtracking.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnprocurementtracking.LargeGlyph")));
            this.btnprocurementtracking.Name = "btnprocurementtracking";
            this.btnprocurementtracking.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnprocurementtracking_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Report";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnusermanagement
            // 
            this.btnusermanagement.Caption = "User Management";
            this.btnusermanagement.Glyph = ((System.Drawing.Image)(resources.GetObject("btnusermanagement.Glyph")));
            this.btnusermanagement.Id = 7;
            this.btnusermanagement.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnusermanagement.LargeGlyph")));
            this.btnusermanagement.Name = "btnusermanagement";
            this.btnusermanagement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnusermanagement_ItemClick);
            // 
            // btnreport
            // 
            this.btnreport.Caption = "Report";
            this.btnreport.Glyph = ((System.Drawing.Image)(resources.GetObject("btnreport.Glyph")));
            this.btnreport.Id = 8;
            this.btnreport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnreport.LargeGlyph")));
            this.btnreport.Name = "btnreport";
            this.btnreport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnreport_ItemClick);
            // 
            // btnmainlogout
            // 
            this.btnmainlogout.Caption = "Logout";
            this.btnmainlogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnmainlogout.Glyph")));
            this.btnmainlogout.Id = 9;
            this.btnmainlogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnmainlogout.LargeGlyph")));
            this.btnmainlogout.Name = "btnmainlogout";
            this.btnmainlogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnmainlogout_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnsupplier);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnpurchase);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnreport);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnprocurementtracking);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnusermanagement);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnmainlogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 502);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(898, 31);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1,
            this.noDocumentsView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 533);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnlogout;
        private DevExpress.XtraBars.BarButtonItem btnsupplier;
        private DevExpress.XtraBars.BarButtonItem btnpurchase;
        private DevExpress.XtraBars.BarButtonItem btnprocurementtracking;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnusermanagement;
        private DevExpress.XtraBars.BarButtonItem btnreport;
        private DevExpress.XtraBars.BarButtonItem btnmainlogout;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}