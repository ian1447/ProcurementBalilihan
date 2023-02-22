using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Procurement_Tracking_App.Dal;
using Procurement_Tracking_App.Core;

namespace Procurement_Tracking_App
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = PublicVariables.ProjectName;
            if (PublicVariables.UserPrivilege == "User")
            {
                btnusermanagement.Enabled = false;
                btnusermanagement.Visibility = BarItemVisibility.Never;
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnmainlogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginForm.UserLogout = true;
            this.Hide();
        }

        private void btnlogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginForm.UserLogout = true;
            this.Hide();
        }

        public static bool IsSupplierForm = false;
        private void btnsupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsSupplierForm)
            {
                IsSupplierForm = true;
                SupplierForm sf = new SupplierForm();
                sf.MdiParent = this;
                sf.WindowState = FormWindowState.Maximized;
                sf.Show();
            }
            else
            {
                Form fc = Application.OpenForms["SupplierForm"];
                if (fc == null)
                {
                    SupplierForm a1 = new SupplierForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }

        public static bool IsPurchaseForm = false;
        private void btnpurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsPurchaseForm)
            {
                IsPurchaseForm = true;
                PurchaseForm pf = new PurchaseForm();
                pf.MdiParent = this;
                pf.WindowState = FormWindowState.Maximized;
                pf.Show();
            }
            else
            {
                Form fc = Application.OpenForms["PurchaseForm"];
                if (fc == null)
                {
                    PurchaseForm a1 = new PurchaseForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }

        public static bool IsPrintForm = false;
        private void btnprint_ItemClick(object sender, ItemClickEventArgs e)
        {
        //if (!IsPrintForm)
        //    {
        //        IsPrintForm = true;
        //        PrintForm prf = new PrintForm();
        //        prf.MdiParent = this;
        //        prf.WindowState = FormWindowState.Maximized;
        //        prf.Show();
        //    }
        //    else
        //    {
        //        Form fc = Application.OpenForms["PrintForm"];
        //        if (fc == null)
        //        {
        //            PrintForm a1 = new PrintForm();
        //            a1.MdiParent = this;
        //            a1.Show();
        //        }
        //        else
        //            fc.Activate();
        //    }
        }

        public static bool IsUserManagementForm = false;
        private void btnusermanagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsUserManagementForm)
            {
                IsUserManagementForm = true;
                UserManagementForm umf = new UserManagementForm();
                umf.MdiParent = this;
                umf.WindowState = FormWindowState.Maximized;
                umf.Show();
            }
            else
            {
                Form fc = Application.OpenForms["UserManagementForm"];
                if (fc == null)
                {
                    UserManagementForm a1 = new UserManagementForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }

        public static bool IsReportForm = false;
        private void btnreport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsReportForm)
            {
                IsReportForm = true;
                ReportForm rpf = new ReportForm();
                rpf.MdiParent = this;
                rpf.WindowState = FormWindowState.Maximized;
                rpf.Show();
            }
            else
            {
                Form fc = Application.OpenForms["ReportForm"];
                if (fc == null)
                {
                    ReportForm a1 = new ReportForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }

        public static bool IsProcurementTrackingForm = false;
        private void btnprocurementtracking_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IsProcurementTrackingForm)
            {
                IsProcurementTrackingForm = true;
                ProcurementTrackingForm ptf = new ProcurementTrackingForm();
                ptf.MdiParent = this;
                ptf.WindowState = FormWindowState.Maximized;
                ptf.Show();
            }
            else
            {
                Form fc = Application.OpenForms["ProcurementTrackingForm"];
                if (fc == null)
                {
                    ProcurementTrackingForm a1 = new ProcurementTrackingForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }
    }
}