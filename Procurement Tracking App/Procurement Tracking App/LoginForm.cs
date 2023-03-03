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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region WaitForm
        bool loadingIsAlreadyShowing = false;
        private void ShowLoading(string message)
        {
            try
            {
                this.Enabled = false;
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
                this.Enabled = true;
                loadingIsAlreadyShowing = false;
                splashScreenManager1.CloseWaitForm();
            }
            catch { }
        }
        #endregion

        public static bool UserLogout = true;
        DataTable UserTable = new DataTable();
        int bwLoginMaxRetries = 0;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!bwLogin.IsBusy)
            {
                bwLoginMaxRetries = PublicVariables.MaxRetries;
                ShowLoading("Getting Data");
                bwLogin.RunWorkerAsync();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                Login.TryConnection();
                if (Login.isConnection)
                {
                    lblstatus.Text = "Connection is Good!";
                    lblstatus.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
                }
                else
                {
                    lblstatus.Text = "Error in Connection!";
                    lblstatus.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
                    btnlogin.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnchangecon_Click(object sender, EventArgs e)
        {
            ChangeConnectionForm ccf = new ChangeConnectionForm();
            ccf.ShowDialog();
        }

        private void bwLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            UserTable = Login.GetLogin(txtusername.Text, txtpasswd.Text);
            bwLogin.CancelAsync();
        }

        private void bwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwLoginMaxRetries--;
            if (Login.GetUserDataSuccessful)
            {
                HideLoading();
                if (UserTable != null)
                {
                    foreach (DataRow row in UserTable.Rows)
                    {
                        PublicVariables.UserPrivilege = row[4].ToString();
                        UserLogout = false;
                        loginsuccess();
                    }
                }
                else
                    MessageBox.Show("Invalid Username or Password");
            }
            else
            {
                if (bwLoginMaxRetries > 0)
                    bwLogin.RunWorkerAsync();
                else
                {
                    HideLoading();
                    MessageBox.Show(Login.GetUserDataError);
                }
            }
        }

        private void loginsuccess()
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.ShowDialog();
            if (UserLogout)
            {
                this.Show();
                txtusername.Text = string.Empty;
                txtpasswd.Text = string.Empty;
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                btnchangecon.Enabled = true;
                btnchangecon.Visible = true;
                lblstatus.Enabled = true;
                lblstatus.Visible = true;
            }
            else
            {
                btnchangecon.Enabled = false;
                btnchangecon.Visible = false;
                lblstatus.Enabled = false;
                lblstatus.Visible = false;
            }
        }
    }
}