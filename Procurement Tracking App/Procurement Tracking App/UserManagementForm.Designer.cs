namespace Procurement_Tracking_App
{
    partial class UserManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcUserInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbpriv = new System.Windows.Forms.ComboBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRePass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditUser = new DevExpress.XtraEditors.SimpleButton();
            this.dtUsers = new DevExpress.XtraGrid.GridControl();
            this.gvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.privilege = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Procurement_Tracking_App.WaitForm1), true, true);
            this.bwGetUsers = new System.ComponentModel.BackgroundWorker();
            this.lblnousers = new DevExpress.XtraEditors.LabelControl();
            this.bwEditUser = new System.ComponentModel.BackgroundWorker();
            this.bwAddUser = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).BeginInit();
            this.gcUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(11, 53);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(294, 26);
            this.txtName.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(11, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "NAME";
            // 
            // gcUserInfo
            // 
            this.gcUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUserInfo.Controls.Add(this.labelControl5);
            this.gcUserInfo.Controls.Add(this.cmbpriv);
            this.gcUserInfo.Controls.Add(this.btnCancel);
            this.gcUserInfo.Controls.Add(this.btnAdd);
            this.gcUserInfo.Controls.Add(this.labelControl4);
            this.gcUserInfo.Controls.Add(this.txtRePass);
            this.gcUserInfo.Controls.Add(this.labelControl3);
            this.gcUserInfo.Controls.Add(this.txtPassword);
            this.gcUserInfo.Controls.Add(this.labelControl1);
            this.gcUserInfo.Controls.Add(this.txtUserName);
            this.gcUserInfo.Controls.Add(this.labelControl2);
            this.gcUserInfo.Controls.Add(this.txtName);
            this.gcUserInfo.Enabled = false;
            this.gcUserInfo.Location = new System.Drawing.Point(575, 9);
            this.gcUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gcUserInfo.Name = "gcUserInfo";
            this.gcUserInfo.Size = new System.Drawing.Size(317, 387);
            this.gcUserInfo.TabIndex = 7;
            this.gcUserInfo.Text = "USER INFORMATION";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(11, 257);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 19);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "PRIVILEGE";
            // 
            // cmbpriv
            // 
            this.cmbpriv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbpriv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpriv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpriv.FormattingEnabled = true;
            this.cmbpriv.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbpriv.Location = new System.Drawing.Point(11, 284);
            this.cmbpriv.Margin = new System.Windows.Forms.Padding(5);
            this.cmbpriv.Name = "cmbpriv";
            this.cmbpriv.Size = new System.Drawing.Size(295, 27);
            this.cmbpriv.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(11, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 42);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(141, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 42);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(11, 202);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(147, 19);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "RETYPE PASSWORD";
            // 
            // txtRePass
            // 
            this.txtRePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRePass.Location = new System.Drawing.Point(11, 227);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePass.Properties.Appearance.Options.UseFont = true;
            this.txtRePass.Properties.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(294, 26);
            this.txtRePass.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(11, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 19);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(11, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(294, 26);
            this.txtPassword.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(11, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "USERNAME";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(11, 112);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(294, 26);
            this.txtUserName.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Appearance.Options.UseFont = true;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(406, 342);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(165, 42);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUser.Image")));
            this.btnEditUser.Location = new System.Drawing.Point(236, 342);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(165, 42);
            this.btnEditUser.TabIndex = 16;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // dtUsers
            // 
            this.dtUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtUsers.Location = new System.Drawing.Point(9, 9);
            this.dtUsers.MainView = this.gvUsers;
            this.dtUsers.Name = "dtUsers";
            this.dtUsers.Size = new System.Drawing.Size(562, 328);
            this.dtUsers.TabIndex = 17;
            this.dtUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsers});
            this.dtUsers.Click += new System.EventHandler(this.dtUsers_Click);
            // 
            // gvUsers
            // 
            this.gvUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.username,
            this.privilege});
            this.gvUsers.GridControl = this.dtUsers;
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.OptionsBehavior.Editable = false;
            this.gvUsers.OptionsFind.AlwaysVisible = true;
            this.gvUsers.OptionsFind.SearchInPreview = true;
            this.gvUsers.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvUsers.OptionsView.RowAutoHeight = true;
            this.gvUsers.OptionsView.ShowGroupPanel = false;
            this.gvUsers.OptionsView.ShowIndicator = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AppearanceCell.Options.UseTextOptions = true;
            this.name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.name.AppearanceHeader.Options.UseTextOptions = true;
            this.name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.name.Caption = "User Name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // username
            // 
            this.username.AppearanceCell.Options.UseTextOptions = true;
            this.username.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.username.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.username.AppearanceHeader.Options.UseTextOptions = true;
            this.username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.username.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.username.Caption = "Username";
            this.username.FieldName = "username";
            this.username.Name = "username";
            this.username.Visible = true;
            this.username.VisibleIndex = 1;
            // 
            // privilege
            // 
            this.privilege.AppearanceHeader.Options.UseTextOptions = true;
            this.privilege.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.privilege.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.privilege.Caption = "Privilege";
            this.privilege.FieldName = "privilege";
            this.privilege.Name = "privilege";
            this.privilege.Visible = true;
            this.privilege.VisibleIndex = 2;
            // 
            // bwGetUsers
            // 
            this.bwGetUsers.WorkerSupportsCancellation = true;
            this.bwGetUsers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetUsers_DoWork);
            this.bwGetUsers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetUsers_RunWorkerCompleted);
            // 
            // lblnousers
            // 
            this.lblnousers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnousers.Location = new System.Drawing.Point(211, 144);
            this.lblnousers.Margin = new System.Windows.Forms.Padding(2);
            this.lblnousers.Name = "lblnousers";
            this.lblnousers.Size = new System.Drawing.Size(151, 13);
            this.lblnousers.TabIndex = 18;
            this.lblnousers.Text = "No users found in the database";
            this.lblnousers.Visible = false;
            // 
            // bwEditUser
            // 
            this.bwEditUser.WorkerSupportsCancellation = true;
            this.bwEditUser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwEditUser_DoWork);
            this.bwEditUser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwEditUser_RunWorkerCompleted);
            // 
            // bwAddUser
            // 
            this.bwAddUser.WorkerSupportsCancellation = true;
            this.bwAddUser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAddUser_DoWork);
            this.bwAddUser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAddUser_RunWorkerCompleted);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 419);
            this.Controls.Add(this.lblnousers);
            this.Controls.Add(this.dtUsers);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gcUserInfo);
            this.Name = "UserManagementForm";
            this.Text = "User Management";
            this.Shown += new System.EventHandler(this.UserManagementForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).EndInit();
            this.gcUserInfo.ResumeLayout(false);
            this.gcUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl gcUserInfo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtRePass;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnAddUser;
        private DevExpress.XtraEditors.SimpleButton btnEditUser;
        private DevExpress.XtraGrid.GridControl dtUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsers;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn username;
        private DevExpress.XtraGrid.Columns.GridColumn privilege;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwGetUsers;
        private DevExpress.XtraEditors.LabelControl lblnousers;
        private System.ComponentModel.BackgroundWorker bwEditUser;
        private System.ComponentModel.BackgroundWorker bwAddUser;
        private System.Windows.Forms.ComboBox cmbpriv;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}