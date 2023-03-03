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
    public partial class UpdatePurchase : DevExpress.XtraEditors.XtraForm
    {
        public UpdatePurchase()
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

        public bool IsViewing = false;
        private void UpdatePurchase_Shown(object sender, EventArgs e)
        {
            if (IsViewing)
            {
                cbStatus.Enabled = false;
                cbStatus.Visible = false;
                dtpDate.Visible = false;
                dtpDate.Enabled = false;
                btnSave.Enabled = false;
                btnSave.Visible = false;
                this.Size = new Size(475, 730);
            }
        }

        string status;
        int bwUpdateStatusMaxRetries = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            status = cbStatus.Text;
            if ( dtpDate.Text == "" || cbStatus.Text == "")
            {
                MessageBox.Show("Please Fill Up Status and/or Date!");
            }
            else
            {
                if (cbStatus.Text == "Opening of Bids")
                {
                    if (!bwUpdateStatus.IsBusy)
                    {
                        bwUpdateStatusMaxRetries = PublicVariables.MaxRetries;
                        ShowLoading("Updating...");
                        bwUpdateStatus.RunWorkerAsync();
                    }
                }
                else if (cbStatus.Text == "Pre-Proc")
                {
                    if (lblOpening.Text == "")
                    {
                        MessageBox.Show("Fill up Opening Date First");
                    }
                    else
                    {
                        if (dtpDate.DateTime < Convert.ToDateTime(lblOpening.Text))
                            MessageBox.Show("Invalid Date");
                        else
                        {
                            if (!bwUpdateStatus.IsBusy)
                            {
                                bwUpdateStatusMaxRetries = PublicVariables.MaxRetries;
                                ShowLoading("Updating...");
                                bwUpdateStatus.RunWorkerAsync();
                            }
                        }
                    }
                }
                else if (cbStatus.Text == "Posting")
                {
                    if (lblPreProc.Text == "")
                        MessageBox.Show("Fill up Pre-Proc Date First");
                    else
                    {
                        if (dtpDate.DateTime < Convert.ToDateTime(lblPreProc.Text))
                        {
                            MessageBox.Show("Invalid Date");
                        }
                        else
                        {
                            if (!bwUpdateStatus.IsBusy)
                            {
                                bwUpdateStatusMaxRetries = PublicVariables.MaxRetries;
                                ShowLoading("Updating...");
                                bwUpdateStatus.RunWorkerAsync();
                            }
                        }
                    }
                }
                else if (cbStatus.Text == "Pre-Bid")
                {
                    if (lblPosting.Text == "")
                        MessageBox.Show("Fill up Posting Date First");
                    else
                    {
                        if (dtpDate.DateTime < Convert.ToDateTime(lblPosting.Text))
                        {
                            MessageBox.Show("Invalid Date");
                        }
                        else
                        {
                            if (!bwUpdateStatus.IsBusy)
                            {
                                bwUpdateStatusMaxRetries = PublicVariables.MaxRetries;
                                ShowLoading("Updating...");
                                bwUpdateStatus.RunWorkerAsync();
                            }
                        }
                    }
                }
                else if (cbStatus.Text == "Detailed Bid Evaluation")
                {
                    if (lblPreBid.Text == "")
                        MessageBox.Show("Fill up Pre-Bid Date First");
                    else
                    {
                        if (dtpDate.DateTime < Convert.ToDateTime(lblPreBid.Text))
                        {
                            MessageBox.Show("Invalid Date");
                        }
                        else
                        {
                            if (!bwUpdateStatus.IsBusy)
                            {
                                bwUpdateStatusMaxRetries = PublicVariables.MaxRetries;
                                ShowLoading("Updating...");
                                bwUpdateStatus.RunWorkerAsync();
                            }
                        }
                    }
                }
                else if (cbStatus.Text == "Award")
                {
                    if (lblBidEval.Text == "")
                        MessageBox.Show("Fill up Detailed Bid Evaluation Date First");
                    else
                    {
                        if (dtpDate.DateTime < Convert.ToDateTime(lblBidEval.Text))
                        {
                            MessageBox.Show("Invalid Date");
                        }
                        else
                        {
                            if (!bwUpdateStatus.IsBusy)
                            {
                                bwUpdateStatusMaxRetries = PublicVariables.MaxRetries;
                                ShowLoading("Updating...");
                                bwUpdateStatus.RunWorkerAsync();
                            }
                        }
                    }
                }
                else if (cbStatus.Text == "PO")
                {
                    if (lblAward.Text == "")
                        MessageBox.Show("Fill up Award Date First");
                    else
                    {
                        if (dtpDate.DateTime < Convert.ToDateTime(lblAward.Text))
                        {
                            MessageBox.Show("Invalid Date");
                        }
                        else
                        {
                            if (!bwUpdateStatus.IsBusy)
                            {
                                bwUpdateStatusMaxRetries = PublicVariables.MaxRetries;
                                ShowLoading("Updating...");
                                bwUpdateStatus.RunWorkerAsync();
                            }
                        }
                    }
                }
                else if (cbStatus.Text == "NTP")
                {
                    if (lblPO.Text == "")
                        MessageBox.Show("Fill up PO Date First");
                    else
                    {
                        if (dtpDate.DateTime < Convert.ToDateTime(lblPO.Text))
                        {
                            MessageBox.Show("Invalid Date");
                        }
                        else
                        {
                            if (!bwUpdateStatus.IsBusy)
                            {
                                bwUpdateStatusMaxRetries = PublicVariables.MaxRetries;
                                ShowLoading("Updating...");
                                bwUpdateStatus.RunWorkerAsync();
                            }
                        }
                    }
                }
                else if (cbStatus.Text == "Delivery")
                {
                    if (lblNTP.Text == "")
                        MessageBox.Show("Fill up NTP Date First");
                    else
                    {
                        if (dtpDate.DateTime < Convert.ToDateTime(lblNTP.Text) || lblNTP.Text == "")
                        {
                            MessageBox.Show("Invalid Date");
                        }
                        else
                        {
                            if (!bwUpdateStatus.IsBusy)
                            {
                                bwUpdateStatusMaxRetries = PublicVariables.MaxRetries;
                                ShowLoading("Updating...");
                                bwUpdateStatus.RunWorkerAsync();
                            }
                        }
                    }
                }
            }
        }


        private void bwUpdateStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            Purchase.UpdatePurchase(txtprno.Text, dtpDate.DateTime.ToString("yyyy-MM-dd"),status);
            bwUpdateStatus.CancelAsync();

        }

        private void bwUpdateStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwUpdateStatusMaxRetries--;
            if (Purchase.UpdatePurchaseIsGood)
            {
                HideLoading();
                MessageBox.Show("Successfully Saved");
                this.Close();
            }
            else
            {
                if (bwUpdateStatusMaxRetries > 0)
                    bwUpdateStatus.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MessageBox.Show(Purchase.UpdatePurchaseErrorMessage);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}