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

namespace Procurement_Tracking_App
{
    public partial class SupplierForm : DevExpress.XtraEditors.XtraForm
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

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


        DataTable SupplierTable = new DataTable();
        private void SupplierForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        public int bwSupplierGetMaxRetries = 0;
        private void LoadData()
        {
            if (!bwSupplierGet.IsBusy)
            {
                bwSupplierGetMaxRetries = PublicVariables.MaxRetries;
                ShowLoading("Loading Data...");
                bwSupplierGet.RunWorkerAsync();
            }
        }

        private void bwSupplierGet_DoWork(object sender, DoWorkEventArgs e)
        {
            SupplierTable = Supplier.GetSuppliers();
            bwSupplierGet.CancelAsync();
        }

        private void bwSupplierGet_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwSupplierGetMaxRetries--;
            if (Supplier.GetSuppliersIsGood)
            {
                HideLoading();
                txtSupplierName.Text = "";
                txtSupplierAddress.Text = "";
                btnadd.Enabled = true;
                btnedit.Enabled = false;
                btncancel.Enabled = false;
                dtsupplier.DataSource = SupplierTable;
            }
            else
            {
                if (bwSupplierGetMaxRetries > 0)
                    bwSupplierGet.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MessageBox.Show(Supplier.GetSuppliersErrorMessage);
                }
            }
        }


        private bool SelectionPass()
        {
            try
            {
                if (gvsupplier.SelectedRowsCount > 0)
                {
                    int selectedRowId = Convert.ToInt32(gvsupplier.GetRowCellValue(gvsupplier.FocusedRowHandle, "id"));
                    return true;
                }
                else
                    return false;
            }
            catch { return false; }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "" && txtSupplierAddress.Text == "")
            {
                MessageBox.Show("Fill Up Form");
            }
            else
            {
                Supplier.AddSupplier(txtSupplierName.Text, txtSupplierAddress.Text);
                if (!Supplier.AddSupplierIsGood)
                    MessageBox.Show(Supplier.AddSupplierErrorMessage);
                else
                {
                    MessageBox.Show("Supplier Addedd!");
                    ClearFields();
                    LoadData();
                }
            }

        }

        public int supplier_id;
        private void dtsupplier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var focusRowView = (DataRowView)gvsupplier.GetFocusedRow();
            supplier_id = Convert.ToInt32(focusRowView["id"].ToString());
            txtSupplierName.Text = focusRowView["name"].ToString();
            txtSupplierAddress.Text = focusRowView["address"].ToString();
            btnadd.Enabled = false;
            btnedit.Enabled = true;
            btncancel.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtSupplierName.Text = "";
            txtSupplierAddress.Text = "";
            btnadd.Enabled = true;
            btnedit.Enabled = false;
            btncancel.Enabled = false;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Supplier.EditSupplier(txtSupplierName.Text, txtSupplierAddress.Text, supplier_id);
            if (Supplier.EditSupplierIsGood)
            {
                ClearFields();
                btnadd.Enabled = true;
                btncancel.Enabled = false;
                btnedit.Enabled = false;
                MessageBox.Show("Supplier Edited");
                LoadData();
            }
            else
                MessageBox.Show(Supplier.EditSupplierErrorMessage);
        }

        private void ClearFields()
        {
            txtSupplierAddress.Text = "";
            txtSupplierName.Text = "";
        }

        private void tsrefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        public int delete_id;
        private void dtsupplier_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var rowH = gvsupplier.FocusedRowHandle;
                    var focusRowView = (DataRowView)gvsupplier.GetFocusedRow();
                    delete_id = Convert.ToInt32(focusRowView["id"].ToString());
                    popupMenuGrid.ShowPopup(barManagerGrid, new Point(MousePosition.X, MousePosition.Y));
                }
            }
            catch { }
        }

        private void tsdelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Supplier.DeleteSupplier(delete_id);
            if (Supplier.DeleteSupplierIsGood)
            {
                MessageBox.Show("Supplier Deleted");
                LoadData();
            }
            else
                MessageBox.Show(Supplier.DeleteSupplierErrorMessage);
        }
    }
}