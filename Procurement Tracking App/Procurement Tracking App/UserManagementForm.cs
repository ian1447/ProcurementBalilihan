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
namespace Procurement_Tracking_App
{
    public partial class UserManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public UserManagementForm()
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


        private void UserManagementForm_Shown(object sender, EventArgs e)
        {
            LoadUsers();
            cmbpriv.Text = "User";
        }
        private void Button_Control(bool operation)
        {
            gcUserInfo.Enabled = operation;
        }
        //bw get users
        DataTable userdt = new DataTable();
        private void bwGetUsers_DoWork(object sender, DoWorkEventArgs e)
        {
            userdt = Users.GetUsers();
            bwGetUsers.CancelAsync();
        }

        private void bwGetUsers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Users.GetUsersSuccessfull)
            {
                HideLoading();
                lblnousers.Visible = userdt.Rows.Count > 0 ? false : true;
                dtUsers.DataSource = userdt;
            }
            else
            {
                MessageBox.Show(Users.GetUsersErrorMessage);
            }
            Button_Control(false);
        }
        private void LoadUsers() {
            if (!bwGetUsers.IsBusy)
            {
                ShowLoading("Loading users . . .");
                bwGetUsers.RunWorkerAsync();
            }
        }
        int selectedRowId;
        public bool SelectionPass()
        {
            try
            {
                if (gvUsers.SelectedRowsCount > 0)
                {
                    selectedRowId = Convert.ToInt32(gvUsers.GetRowCellValue(gvUsers.FocusedRowHandle, "id"));
                    return true;
                }
                else
                    return false;
            }
            catch { return false; }
        }

        private void dtUsers_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            { 
                txtName.Text = (gvUsers.GetRowCellValue(gvUsers.FocusedRowHandle, "name")).ToString();
                txtUserName.Text = (gvUsers.GetRowCellValue(gvUsers.FocusedRowHandle, "username")).ToString();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                txtName.Text = (gvUsers.GetRowCellValue(gvUsers.FocusedRowHandle, "name")).ToString();
                txtUserName.Text = (gvUsers.GetRowCellValue(gvUsers.FocusedRowHandle, "username")).ToString();

                dtUsers.Enabled = false;
                btnAddUser.Enabled = false;
                btnEditUser.Enabled = false;

                gcUserInfo.Enabled = true;
                btnAdd.Text = "SAVE";
            }
            else
            {
                MessageBox.Show("Please select a user to edit!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearfields();
            Button_Control(false);
            btnAddUser.Enabled = true;
            btnEditUser.Enabled = true;
            dtUsers.Enabled = true;
            btnAdd.Text = "ADD";
        }
        private void clearfields() {
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRePass.Text = string.Empty;
            txtUserName.Text = string.Empty;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            clearfields();
            Button_Control(true);
            btnAdd.Text = "ADD";
        }

        //edit users
        private void EditUser() {
            if (!bwEditUser.IsBusy)
            {
                ShowLoading("loading . . .");
                bwEditUser.RunWorkerAsync();
            }
        }
        private void bwEditUser_DoWork(object sender, DoWorkEventArgs e)
        {
            Users.EditUser(txtName.Text, txtUserName.Text, txtPassword.Text, selectedRowId);
            bwEditUser.CancelAsync();
        }

        private void bwEditUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Users.EditUserIsGood)
            {
                HideLoading();
                MessageBox.Show("User updated successfully!");
                btnCancel.PerformClick();
                LoadUsers();
            }
            else
            {
                MessageBox.Show(Users.EditUserErrorMessage);
            }
        }
        //add users
        private void AddUsers() {
            if (!bwAddUser.IsBusy)
            {
                ShowLoading("loading . . .");
                bwAddUser.RunWorkerAsync();
            }
        }
        private void bwAddUser_DoWork(object sender, DoWorkEventArgs e)
        {
            Users.AddUser(txtName.Text, txtUserName.Text, txtPassword.Text);
            bwAddUser.CancelAsync();
        }

        private void bwAddUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Users.AddUserSuccessfull)
            {
                HideLoading();
                MessageBox.Show("User added successfully!");
                btnCancel.PerformClick();
                LoadUsers();
                
            }
            else
            {
                MessageBox.Show(Users.AddUserErrorMessage);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Input Name!");
            }
            else
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("Please Input Username!");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Please Input Password!");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtRePass.Text))
                        {
                            MessageBox.Show("Please Retype Password!");
                        }
                        else
                        {
                            if (txtPassword.Text != txtRePass.Text)
                            {
                                MessageBox.Show("Password does not match!");
                            }
                            else
                            {
                                if (btnAdd.Text == "ADD")
                                {
                                    AddUsers();
                                }
                                else
                                {
                                    EditUser();
                                }
                            }

                        }
                    }
                }
            }
        }
    }
}