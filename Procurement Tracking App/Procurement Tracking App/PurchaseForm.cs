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

        DataTable PurchaseTable = new DataTable();
        private void PurchaseForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            PurchaseTable = Purchase.GetPurchase();
            if (Purchase.GetPurchaseIsGood)
                dtPurchase.DataSource = PurchaseTable;
            else
                MessageBox.Show(Purchase.GetPurchaseErrorMessage);
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
    }
}