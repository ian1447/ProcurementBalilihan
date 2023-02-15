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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( dtpDate.Text == "" || cbStatus.Text == "")
            {
                MessageBox.Show("Please Fill Up Status and/or Date!");
            }
            else
            {
                if (cbStatus.Text == "Opening of Bids")
                {
                    Purchase.UpdatePurchase(txtprno.Text, dtpDate.DateTime.ToString("yyyy-MM-dd"));
                    if (Purchase.UpdatePurchaseIsGood)
                        MessageBox.Show("Done");
                    else
                        MessageBox.Show(Purchase.UpdatePurchaseErrorMessage);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bwUpdateStatus_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bwUpdateStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

    }
}