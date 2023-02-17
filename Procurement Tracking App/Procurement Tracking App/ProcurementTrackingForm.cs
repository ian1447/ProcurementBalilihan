using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Procurement_Tracking_App.Core;
using Procurement_Tracking_App.Dal;

namespace Procurement_Tracking_App
{
    public partial class ProcurementTrackingForm : DevExpress.XtraEditors.XtraForm
    {
        public ProcurementTrackingForm()
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

        int bwLoadDataMaxRetries = 0;
        DataTable proctable = new DataTable();
        private void ProcurementTrackingForm_Shown(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            if (!bwLoadData.IsBusy)
            {
                bwLoadDataMaxRetries = PublicVariables.MaxRetries;
                ShowLoading("Loading...");
                bwLoadData.RunWorkerAsync();
            }
        }

        private void bwLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            proctable = Purchase.GetPurchase();
            bwLoadData.CancelAsync();
        }

        private void bwLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwLoadDataMaxRetries--;
            if (Purchase.GetPurchaseIsGood)
            {
                HideLoading();
                dtPurchase.DataSource = proctable;
            }
            else
            {
                if (bwLoadDataMaxRetries > 0)
                    bwLoadData.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MessageBox.Show(Purchase.GetPurchaseErrorMessage);
                }
            }
        }

        public bool SelectionPass()
        {
            try
            {
                if (gvPurchase.SelectedRowsCount > 0)
                {
                    int selectedRowId = Convert.ToInt32(gvPurchase.GetRowCellValue(gvPurchase.FocusedRowHandle, "id"));
                    return true;
                }
                else
                    return false;
            }
            catch { return false; }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                var focusRowView = (DataRowView)gvPurchase.GetFocusedRow();
                UpdatePurchase up = new UpdatePurchase();
                up.IsViewing = true;
                up.lblPrNo.Text = focusRowView.Row[1].ToString();
                up.txtprno.Text = focusRowView.Row[1].ToString();
                up.medesc.Text = focusRowView.Row[2].ToString();
                up.txtenduser.Text = focusRowView.Row[3].ToString();
                up.memode.Text = focusRowView.Row[4].ToString();
                up.txtabc.Text = focusRowView.Row[5].ToString();
                if (focusRowView.Row[6].ToString() != "")
                    up.lblOpening.Text = Convert.ToDateTime(focusRowView.Row[6]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[7].ToString() != "")
                    up.lblPreProc.Text = Convert.ToDateTime(focusRowView.Row[7]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[8].ToString() != "")
                    up.lblPosting.Text = Convert.ToDateTime(focusRowView.Row[8]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[9].ToString() != "")
                    up.lblPreBid.Text = Convert.ToDateTime(focusRowView.Row[9]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[10].ToString() != "")
                    up.lblBidEval.Text = Convert.ToDateTime(focusRowView.Row[10]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[11].ToString() != "")
                    up.lblAward.Text = Convert.ToDateTime(focusRowView.Row[11]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[12].ToString() != "")
                    up.lblPO.Text = Convert.ToDateTime(focusRowView.Row[12]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[13].ToString() != "")
                    up.lblNTP.Text = Convert.ToDateTime(focusRowView.Row[13]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[14].ToString() != "")
                    up.lblDelivery.Text = Convert.ToDateTime(focusRowView.Row[14]).ToString("MM/dd/yyyy");
                up.ShowDialog();
            }
            else
                MessageBox.Show("No row selected!");
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                var focusRowView = (DataRowView)gvPurchase.GetFocusedRow();
                UpdatePurchase up = new UpdatePurchase();
                up.lblPrNo.Text = focusRowView.Row[1].ToString();
                up.txtprno.Text = focusRowView.Row[1].ToString();
                up.medesc.Text = focusRowView.Row[2].ToString();
                up.txtenduser.Text = focusRowView.Row[3].ToString();
                up.memode.Text = focusRowView.Row[4].ToString();
                up.txtabc.Text = focusRowView.Row[5].ToString();
                if (focusRowView.Row[6].ToString() != "")
                    up.lblOpening.Text = Convert.ToDateTime(focusRowView.Row[6]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[7].ToString() != "")
                    up.lblPreProc.Text = Convert.ToDateTime(focusRowView.Row[7]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[8].ToString() != "")
                    up.lblPosting.Text = Convert.ToDateTime(focusRowView.Row[8]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[9].ToString() != "")
                    up.lblPreBid.Text = Convert.ToDateTime(focusRowView.Row[9]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[10].ToString() != "")
                    up.lblBidEval.Text = Convert.ToDateTime(focusRowView.Row[10]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[11].ToString() != "")
                    up.lblAward.Text = Convert.ToDateTime(focusRowView.Row[11]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[12].ToString() != "")
                    up.lblPO.Text = Convert.ToDateTime(focusRowView.Row[12]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[13].ToString() != "")
                    up.lblNTP.Text = Convert.ToDateTime(focusRowView.Row[13]).ToString("MM/dd/yyyy");
                if (focusRowView.Row[14].ToString() != "")
                    up.lblDelivery.Text = Convert.ToDateTime(focusRowView.Row[14]).ToString("MM/dd/yyyy");
                up.ShowDialog();
                LoadData();
            }
            else
                MessageBox.Show("No row selected!");
        }

        private void btnTsRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnViewPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnView.PerformClick();
        }

        private void btnUpdatePurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnupdate.PerformClick();
        }

        private void dtPurchase_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var rowH = gvPurchase.FocusedRowHandle;
                    var focusRowView = (DataRowView)gvPurchase.GetFocusedRow();
                    popupMenuGrid.ShowPopup(barMenuGrid, new Point(MousePosition.X, MousePosition.Y));
                }
            }
            catch { }
        }



    }
}