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
    public partial class PurchaseForm : DevExpress.XtraEditors.XtraForm
    {
        public PurchaseForm()
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

        DataTable PurchaseTable = new DataTable();
        string prno;
        string rownumber;
        private void PurchaseForm_Shown(object sender, EventArgs e)
        {
            LoadData();
            if (PublicVariables.UserPrivilege == "User")
            {
                btnEditPurchase.Enabled = false;
                btnEditBreakdown.Enabled = false;
                btnUpdatePurchase.Enabled = false;
                btnadd.Enabled = false;
                btnViewPur.Enabled = true;
                btnViewBreak.Enabled = true;
                btnadd.Enabled = false;
            }
        }

        public int bwLoadDataMaxRetries;
        private void LoadData()
        {
            if (!bwLoadData.IsBusy)
            {
                bwLoadDataMaxRetries = PublicVariables.MaxRetries;
                ShowLoading("Loading Data...");
                bwLoadData.RunWorkerAsync();
            }
        }

        private void bwLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            PurchaseTable = Purchase.GetPurchase();
            bwLoadData.CancelAsync();
        }

        private void bwLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwLoadDataMaxRetries--;
            if (Purchase.GetPurchaseIsGood)
            {
                HideLoading();
                dtPurchase.DataSource = PurchaseTable;
                string YearLabel = DateTime.Now.Year.ToString();
                string MonthLabel = DateTime.Now.Month.ToString();
                rownumber = PurchaseTable.Rows.Count.ToString();
                prno = YearLabel + "-" + MonthLabel + " " + rownumber;
                txtPrNo.Text = prno;
                if (PublicVariables.UserPrivilege == "Admin")
                    btnadd.Enabled = true;
                else
                    btnadd.Enabled = false;
                btncancel.Enabled = false;
                btnedit.Enabled = false;
                btnupdate.Enabled = false;
                btnViewBreak.Enabled = false;
                btnViewPur.Enabled = false;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtabc.Text == "" || txtDescription.Text == "" || txtPrNo.Text == "" || cbEndUser.Text == "" || cbmode.Text == "")
                MessageBox.Show("Please Fill Up Data!");
            else
            {
                bool isflag;
                isflag = Purchase.GetPr(txtPrNo.Text);
                if (Purchase.GetPrIsGood)
                {
                    if (isflag)
                    {
                        Purchase.AddPr(txtPrNo.Text, txtDescription.Text, cbEndUser.Text, cbmode.Text, txtabc.Text);
                        if (!Purchase.AddPrIsGood)
                            MessageBox.Show(Purchase.AddPrErrorMessage);
                        else
                        {
                            MessageBox.Show("Purchase Added!");
                            Breakdown b = new Breakdown();
                            b.lblPrNo.Text = txtPrNo.Text;
                            b.ShowDialog();
                            LoadData();
                        }
                    }
                    else
                        MessageBox.Show("Pr No Already Exists!");
                }
                else
                    MessageBox.Show(Purchase.GetPrErrorMessage);
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

        private void dtPurchase_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowEditPurchase();
        }

        private void ShowEditPurchase()
        {
            if (SelectionPass())
            {
                if (PublicVariables.UserPrivilege == "Admin")
                {
                    var focusRowView = (DataRowView)gvPurchase.GetFocusedRow();
                    txtPrNo.Text = focusRowView.Row[1].ToString();
                    txtDescription.Text = focusRowView.Row[2].ToString();
                    cbEndUser.Text = focusRowView.Row[3].ToString();
                    cbmode.Text = focusRowView.Row[4].ToString();
                    txtabc.Text = focusRowView.Row[5].ToString();
                    txtPrNo.Enabled = false;
                    btnadd.Enabled = false;
                    btncancel.Enabled = true;
                    btnedit.Enabled = true;
                    btnupdate.Enabled = true;
                    btnViewBreak.Enabled = true;
                    btnViewPur.Enabled = true;
                }
                else
                {
                    var focusRowView = (DataRowView)gvPurchase.GetFocusedRow();
                    txtPrNo.Text = focusRowView.Row[1].ToString();
                    txtDescription.Text = focusRowView.Row[2].ToString();
                    cbEndUser.Text = focusRowView.Row[3].ToString();
                    cbmode.Text = focusRowView.Row[4].ToString();
                    txtabc.Text = focusRowView.Row[5].ToString();
                    txtPrNo.Enabled = false;
                    txtDescription.Enabled = false;
                    cbEndUser.Enabled = false;
                    cbmode.Enabled = false;
                    txtabc.Enabled = false;
                    btnadd.Enabled = false;
                    btncancel.Enabled = true;
                    btnedit.Enabled = false;
                    btnupdate.Enabled = false;
                    btnViewBreak.Enabled = true;
                    btnViewPur.Enabled = true;
                }
                
            }
            else
                MessageBox.Show("No Row Selected.");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (PublicVariables.UserPrivilege == "Admin")
                btnadd.Enabled = true;
            else
                btnadd.Enabled = false;
            txtPrNo.Text = "";
            txtDescription.Text = "";
            cbEndUser.SelectedIndex = 1;
            cbEndUser.SelectedItem = 1;
            cbmode.Text = "";
            txtabc.Text = "";
            txtPrNo.Enabled = true;
            btncancel.Enabled = false;
            btnedit.Enabled = false;
            btnupdate.Enabled = false;
            btnViewBreak.Enabled = false;
            btnViewPur.Enabled = false;
            string YearLabel = DateTime.Now.Year.ToString();
            string MonthLabel = DateTime.Now.Month.ToString();
            rownumber = PurchaseTable.Rows.Count.ToString();
            prno = YearLabel + "-" + MonthLabel + " " + rownumber;
            txtPrNo.Text = prno;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Purchase.EditPurchase(txtPrNo.Text, txtDescription.Text, cbEndUser.Text, cbmode.Text, txtabc.Text);
            if (Purchase.EditPurchaseIsGood)
            {
                MessageBox.Show("Purchase Details Edited!");
                btncancel.PerformClick();
                LoadData();
            }
            else
                MessageBox.Show(Purchase.EditPurchaseErrorMessage);
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
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

        private void btnEditPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowEditPurchase();
        }

        private void btnViewBreakdown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SelectionPass())
            {
                var focusRowView = (DataRowView)gvPurchase.GetFocusedRow();
                Breakdown b = new Breakdown();
                b.view = true;
                b.lblPrNo.Text = focusRowView.Row[1].ToString();
                b.ShowDialog();
            }
            else
                MessageBox.Show("No Row Selected.");
        }

        private void btnEditBreakdown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SelectionPass())
            {
                var focusRowView = (DataRowView)gvPurchase.GetFocusedRow();
                Breakdown b = new Breakdown();
                b.lblPrNo.Text = focusRowView.Row[1].ToString();
                b.ShowDialog();
            }
            else
                MessageBox.Show("No Row Selected.");
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
                btncancel.PerformClick();
                btnRefresh.PerformClick();
            }
            else
                MessageBox.Show("No Row Selected.");
        }

        private void btnUpdatePurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    up.lblOpening.Text = Convert.ToDateTime(focusRowView.Row[6]).ToString("dd/MM/yyyy");
                if (focusRowView.Row[7].ToString() != "")
                    up.lblPreProc.Text = Convert.ToDateTime(focusRowView.Row[7]).ToString("dd/MM/yyyy");
                if (focusRowView.Row[8].ToString() != "")
                    up.lblPosting.Text = Convert.ToDateTime(focusRowView.Row[8]).ToString("dd/MM/yyyy");
                if (focusRowView.Row[9].ToString() != "")
                    up.lblPreBid.Text = Convert.ToDateTime(focusRowView.Row[9]).ToString("dd/MM/yyyy");
                if (focusRowView.Row[10].ToString() != "")
                    up.lblBidEval.Text = Convert.ToDateTime(focusRowView.Row[10]).ToString("dd/MM/yyyy");
                if (focusRowView.Row[11].ToString() != "")
                    up.lblAward.Text = Convert.ToDateTime(focusRowView.Row[11]).ToString("dd/MM/yyyy");
                if (focusRowView.Row[12].ToString() != "")
                    up.lblPO.Text = Convert.ToDateTime(focusRowView.Row[12]).ToString("dd/MM/yyyy");
                if (focusRowView.Row[13].ToString() != "")
                    up.lblNTP.Text = Convert.ToDateTime(focusRowView.Row[13]).ToString("dd/MM/yyyy");
                if (focusRowView.Row[14].ToString() != "")
                    up.lblDelivery.Text = Convert.ToDateTime(focusRowView.Row[14]).ToString("dd/MM/yyyy");
                up.ShowDialog();
                btncancel.PerformClick();
                btnRefresh.PerformClick();
            }
            else
                MessageBox.Show("No Row Selected.");
        }

        private void btnViewPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                btncancel.PerformClick();
                btnRefresh.PerformClick();
            }
            else
                MessageBox.Show("No Row Selected.");
        }

        private void btnViewPur_Click(object sender, EventArgs e)
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
                btncancel.PerformClick();
                btnRefresh.PerformClick();
            }
            else
                MessageBox.Show("No Row Selected.");
        }

        private void btnViewBreak_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                var focusRowView = (DataRowView)gvPurchase.GetFocusedRow();
                Breakdown b = new Breakdown();
                b.view = true;
                b.lblPrNo.Text = focusRowView.Row[1].ToString();
                b.ShowDialog();
            }
            else
                MessageBox.Show("No Row Selected.");
        }
    }
}