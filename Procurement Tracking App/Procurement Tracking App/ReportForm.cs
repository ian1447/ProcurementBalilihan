using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Procurement_Tracking_App.Dal;
using Procurement_Tracking_App.Core;
using DevExpress.XtraReports.UI;

namespace Procurement_Tracking_App
{
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        #region
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

        private void LoadData()
        {
            if (!bwLoadData.IsBusy)
            {
                bwLoadDataMaxRetries = PublicVariables.MaxRetries;
                ShowLoading("Loading...");
                bwLoadData.RunWorkerAsync();
            }
        }

        DataTable PurchaseTable = new DataTable();
        //background worker
        private void bwLoadProcurement_DoWork(object sender, DoWorkEventArgs e)
        {
            if (PublicVariables.UserPrivilege == "User")
            {
                PurchaseTable = Purchase.GetPurchaseReport(dtpFrom.DateTime, dtpTo.DateTime, 1,PublicVariables.UserFullName);
                bwLoadData.CancelAsync();
            }
            else
            {
                PurchaseTable = Purchase.GetPurchaseReport(dtpFrom.DateTime, dtpTo.DateTime, 0);
                bwLoadData.CancelAsync();
            }
        }
        public int bwLoadDataMaxRetries;
        private void bwLoadProcurement_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwLoadDataMaxRetries--;
            if (Purchase.GetPurchasReporteIsGood)
            {
                HideLoading();
                dtReport.DataSource = PurchaseTable;
                btnPrintReport.Enabled = false;
            }
            else
            {
                if (bwLoadDataMaxRetries > 0)
                    bwLoadData.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MessageBox.Show(Purchase.GetPurchaseReportErrorMessage);
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

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            LoadBreakdown();

        }
        private void LoadBreakdown()
        {

            if (!bwLoadBreakdown.IsBusy)
            {
                ShowLoading("loading breakdown. . . ");
                bwLoadBreakdown.RunWorkerAsync();
            }
        }

        private void ReportForm_Shown(object sender, EventArgs e)
        {
            cmbDateSpan.Properties.DataSource = dataPeriod;
            cmbDateSpan.Properties.DisplayMember = "Period";
            cmbDateSpan.Properties.ValueMember = "Period";
            cmbDateSpan.EditValue = "This Month's Record";
            GetEndUsers();
            LoadData();
    
        }
        string rowselected;

        private void dtReport_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                rowselected = (gvReport.GetRowCellValue(gvReport.FocusedRowHandle, "po_no")).ToString();
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
        DateTime dateFrom = new DateTime();
        DateTime dateTo = new DateTime();
        DataTable dataPeriod = new DataTable();

        private void cmbDateSpan_EditValueChanged(object sender, EventArgs e)
        {
            pnlDates.Visible = cmbDateSpan.Text.Equals("Pick a date..") ? true : false;
            dtReport.Enabled = cmbDateSpan.Text.Equals("Pick a date..") ? true : false;
            DateTime baseDate = DateTime.Now;

            if (cmbDateSpan.Text.Equals("Today's Record"))
            {
                dtpTo.EditValue = DateTime.Now;
                dtpFrom.EditValue = DateTime.Now;

                dateFrom = DateTime.Now;
                dateTo = DateTime.Now;
                 LoadData();
            }
            else if (cmbDateSpan.Text.Equals("This Week's Record"))
            {
                dtpFrom.EditValue = baseDate.AddDays(-(int)baseDate.DayOfWeek);
                dtpTo.EditValue = Convert.ToDateTime(dtpFrom.EditValue).AddDays(7).AddSeconds(-1);

                dateFrom = baseDate.AddDays(-(int)baseDate.DayOfWeek);
                dateTo = Convert.ToDateTime(dtpFrom.EditValue).AddDays(7).AddSeconds(-1);
                LoadData();
            }
            else if (cmbDateSpan.Text.Equals("This Month's Record"))
            {
                dtpFrom.EditValue = baseDate.AddDays(1 - baseDate.Day);
                dtpTo.EditValue = Convert.ToDateTime(dtpFrom.EditValue).AddMonths(1).AddSeconds(-1);

                dateFrom = baseDate.AddDays(1 - baseDate.Day);
                dateTo = Convert.ToDateTime(dtpFrom.EditValue).AddMonths(1).AddSeconds(-1);
                LoadData();
            }
            else if (cmbDateSpan.Text.Equals("This Year's Records"))
            {
                dtpFrom.EditValue = "01-01-" + DateTime.Now.Year;
                dtpTo.EditValue = "12-31-" + DateTime.Now.Year;

                dateFrom = Convert.ToDateTime(dtpFrom.EditValue);
                dateTo = Convert.ToDateTime(dtpFrom.EditValue);
                LoadData();
            }
            else if (cmbDateSpan.Text.Equals("All Records"))
            {
                dtpFrom.EditValue = baseDate.AddYears(-100);
                dtpTo.EditValue = Convert.ToDateTime(dtpFrom.EditValue).AddYears(100);

                dateFrom = baseDate.AddYears(-100);
                dateTo = Convert.ToDateTime(dtpFrom.EditValue).AddYears(100);
                LoadData();
            }
            else
            {
                //dtpFrom.EditValue = baseDate.AddYears(-5);
                //dtpTo.EditValue = Convert.ToDateTime(dtpFrom.EditValue).AddYears(5);

                //dateFrom = baseDate.AddYears(-100);
                //dateTo = Convert.ToDateTime(dtpFrom.EditValue).AddYears(100);
                //LoadPayeeTransaction();
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            dataPeriod.Columns.Add("Period", typeof(string));
            dataPeriod.Rows.Add("Today's Record");
            dataPeriod.Rows.Add("This Week's Record");
            dataPeriod.Rows.Add("This Month's Record");
            dataPeriod.Rows.Add("This Year's Records");
            dataPeriod.Rows.Add("All Records");
            dataPeriod.Rows.Add("Pick a date..");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dateFrom = Convert.ToDateTime(dtpFrom.EditValue);
            dateTo = Convert.ToDateTime(dtpTo.EditValue);
            LoadData();
            pnlDates.Visible = false;
        }

        private void btnproreport_Click(object sender, EventArgs e)
        {
            YearlyReport yr = new YearlyReport();
            if (dateFrom.Year.ToString() == dateTo.Year.ToString())
            {
                yr.lblTitleYear.Text = "PROCUREMENT STATUS " + dateFrom.Year.ToString();
            }
            else
            {
                yr.lblTitleYear.Text = "PROCUREMENT STATUS " + dateFrom.Year.ToString() + " - " + dateTo.Year.ToString();
            }
            if (End_User == "ALL END USERS" || cmbEnduser.Text == cmbEnduser.Properties.NullText)
            {
                yr.DataSource = PurchaseTable;
                yr.DataMember = "CustomSQLQuery1";
                yr.ShowPreviewDialog();
            }
            else
            {
                yr.DataSource = FilteredTable;
                yr.DataMember = "CustomSQLQuery1";
                yr.ShowPreviewDialog();
            }
        }
        string End_User;
        DataTable FilteredTable = new DataTable();
        private void cmbEnduser_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                End_User = cmbEnduser.EditValue.ToString();
                if (End_User != "ALL END USERS")
                {
                    End_User = cmbEnduser.EditValue.ToString().ToLower();
                    DataView barDataView = new DataView(PurchaseTable);
                    barDataView.RowFilter = "[end_user] LIKE '%" + End_User + "%'";
                    DataTable barFiltered = barDataView.ToTable();
                    dtReport.DataSource = barFiltered;
                    FilteredTable = barFiltered;
                }
                else
                {
                    LoadData();
                }
            }
            catch
            {
                cmbEnduser.EditValue = -1;
            }
            
   

        }
        DataTable dtusers = new DataTable();
        private void bwLoadEndUser_DoWork(object sender, DoWorkEventArgs e)
        {
            dtusers = Purchase.GetEndUsers();
            bwLoadEndUser.CancelAsync();
        }

        private void bwLoadEndUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purchase.GetEndUserIsGood)
            {
                dtusers.Rows.Add("ALL END USERS");
                cmbEnduser.Properties.DataSource = dtusers;
                cmbEnduser.Properties.DisplayMember = "end_user";
                cmbEnduser.Properties.ValueMember = "end_user";
               
            }
            else
            {
                MessageBox.Show(Purchase.GetEndUserErrorMessage, "Error!");
            }
        }
        private void GetEndUsers() {
            if (!bwLoadEndUser.IsBusy)
            {
                ShowLoading("Loading...");
                bwLoadEndUser.RunWorkerAsync();
            }
        }
    }
}