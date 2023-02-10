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
            if (SelectionPass())
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
            }
            else
                MessageBox.Show("No Row Selected.");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtPrNo.Text = "";
            txtDescription.Text = "";
            cbEndUser.SelectedIndex = 1;
            cbEndUser.SelectedItem = 1;
            cbmode.Text = "";
            txtabc.Text = "";
            txtPrNo.Enabled = true;
            btnadd.Enabled = true;
            btncancel.Enabled = false;
            btnedit.Enabled = false;
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
    }
}