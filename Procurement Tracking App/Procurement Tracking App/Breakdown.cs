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
    public partial class Breakdown : DevExpress.XtraEditors.XtraForm
    {
        public Breakdown()
        {
            InitializeComponent();
        }

        DataTable suppliertable = new DataTable();
        DataTable breakdowntable = new DataTable();
        private void Breakdown_Shown(object sender, EventArgs e)
        {
            suppliertable = Supplier.GetSuppliers();
            if (Supplier.GetSuppliersIsGood)
            {
                cbSupplier.DataSource = suppliertable;
                cbSupplier.DisplayMember = "name";
                cbSupplier.ValueMember = "id";
            }
            else
                MessageBox.Show(Supplier.GetSuppliersErrorMessage);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtpropertyno.Text == "" || txtquan.Text == "" || txtunit.Text == "" || txtunitcost.Text == "" || medescription.Text == "" || cbSupplier.Text == "")
                MessageBox.Show("Fill Up Details!");
            else
            {
                int total  = (Convert.ToInt32(txtquan.Text.ToString())) * Convert.ToInt32(txtunitcost.Text.ToString());
                Purchase.AddBreakdown(lblPrNo.Text,txtpropertyno.Text,txtunit.Text,medescription.Text,txtunitcost.Text,txtquan.Text,total.ToString(),cbSupplier.Text);
                if (Purchase.AddBreakdownIsGood)
                {
                    LoadData();
                    ResetLabels();
                }
            }
        }

        private void ResetLabels()
        {
            txtpropertyno.Text = "";
            txtquan.Text = "";
            txtunit.Text = "";
            txtunitcost.Text = "";
            medescription.Text = "";
            cbSupplier.SelectedIndex = 1;
        }

        private void LoadData()
        {
            breakdowntable = Purchase.GetPurchaseBreakdown(lblPrNo.Text);
            if (Purchase.GetPurchaseBreakdownIsGood)
            {
                MessageBox.Show("Added Succesfully!");
                dtbreakdown.DataSource = breakdowntable;
            }
            else
                MessageBox.Show(Purchase.GetPurchaseBreakdownErrorMessage);
        }



    }
}