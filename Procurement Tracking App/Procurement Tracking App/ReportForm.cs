using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
<<<<<<< Updated upstream
using Procurement_Tracking_App.Core;
using Procurement_Tracking_App.Dal;
=======
using Procurement_Tracking_App.Dal;
using Procurement_Tracking_App.Core;
using DevExpress.XtraReports.UI;
>>>>>>> Stashed changes

namespace Procurement_Tracking_App
{
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream

        #region
=======
        #region loading screen
>>>>>>> Stashed changes
        bool loadingIsAlreadyShowing = false;
        private void ShowLoading(string message)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                if (!loadingIsAlreadyShowing)
                {
                    loadingIsAlreadyShowing = true;
                    splashScreenManager1.ShowWaitForm();
                }
                splashScreenManager1.SetWaitFormDescription(message);
            }
            catch { }
        }

        private void HideLoading()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }

                loadingIsAlreadyShowing = false;
                splashScreenManager1.CloseWaitForm();
            }
            catch { }
        }
        #endregion

<<<<<<< Updated upstream
        private void ReportForm_Shown(object sender, EventArgs e)
        {

        }

        int bwLoadDataMaxRetries = 0;
        private void LoadData()
        {
            if (!bwLoadData.IsBusy)
            {
                bwLoadDataMaxRetries = PublicVariables.MaxRetries;
                ShowLoading("Loading...");
                bwLoadData.RunWorkerAsync();
            }
        }

        DataTable proctable = new DataTable();
        private void bwLoadData_DoWork(object sender, DoWorkEventArgs e)
        {

            proctable = Purchase.GetPurchase();
            bwLoadData.CancelAsync();
        }

        private void bwLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
=======
        DataTable PurchaseTable = new DataTable();
        //background worker
        private void bwLoadProcurement_DoWork(object sender, DoWorkEventArgs e)
        {
            PurchaseTable = Purchase.GetPurchase();
            bwLoadProcurement.CancelAsync();
        }
        public int bwLoadDataMaxRetries;
        private void bwLoadProcurement_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwLoadDataMaxRetries--;
            if (Purchase.GetPurchaseIsGood)
            {
                HideLoading();
                dtReport.DataSource = PurchaseTable;
            }
            else
            {
                if (bwLoadDataMaxRetries > 0)
                    bwLoadProcurement.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MessageBox.Show(Purchase.GetPurchaseErrorMessage);
                }
            }
        }
        private bool SelectionPass()
        {
            try
            {
                if (gvReport.SelectedRowsCount > 0)
                {
                    int selectedRowId = Convert.ToInt32(gvReport.GetRowCellValue(gvReport.FocusedRowHandle, "id"));
                    return true;
                }
                else
                    return false;
            }
            catch { return false; }
        }
        void load_data() {

            if (!bwLoadProcurement.IsBusy)
            {
                bwLoadDataMaxRetries = PublicVariables.MaxRetries;
                ShowLoading("Loading Data...");
                bwLoadProcurement.RunWorkerAsync();
            }
        }
        
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            LoadBreakdown();

        }
        private void LoadBreakdown() {

            if (!bwLoadBreakdown.IsBusy)
            {
                ShowLoading("loading breakdown. . . ");
                bwLoadBreakdown.RunWorkerAsync();
            }
        }

        private void ReportForm_Shown(object sender, EventArgs e)
        {
            load_data();
            btnPrintReport.Enabled = false;
        }
        int rowselected = 0;
        private void dtReport_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                rowselected = Convert.ToInt32(gvReport.GetRowCellValue(gvReport.FocusedRowHandle, "po_no"));
                btnPrintReport.Enabled = true;
            }
        }
        DataTable breakdown_list;
        private void bwLoadBreakdown_DoWork(object sender, DoWorkEventArgs e)
        {
            breakdown_list = Purchase.GetPurchaseBreakdown(rowselected.ToString());
            bwLoadBreakdown.CancelAsync();
        }

        private void bwLoadBreakdown_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Purchase.GetPurchaseBreakdownIsGood)
            {
                HideLoading();
                ProcurementReport pr = new ProcurementReport();
                pr.lblprno.Text = (gvReport.GetRowCellValue(gvReport.FocusedRowHandle, "po_no")).ToString();
                pr.lblpurpose.Text = (gvReport.GetRowCellValue(gvReport.FocusedRowHandle, "description")).ToString();
                pr.lblname.Text = (gvReport.GetRowCellValue(gvReport.FocusedRowHandle, "end_user")).ToString();
                pr.lblprdate.Text = (gvReport.GetRowCellValue(gvReport.FocusedRowHandle, "po")).ToString();
                pr.DataSource = breakdown_list;
                pr.DataMember = "CustomSQLQuery1";
                pr.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show(Purchase.GetPurchaseBreakdownErrorMessage);
            }
        }


>>>>>>> Stashed changes
    }
}