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
            this.gcUsers = new DevExpress.XtraGrid.GridControl();
            this.gvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcUserInfo = new DevExpress.XtraEditors.GroupControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).BeginInit();
            this.gcUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsers
            // 
            this.gcUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUsers.Location = new System.Drawing.Point(12, 12);
            this.gcUsers.MainView = this.gvUsers;
            this.gcUsers.Name = "gcUsers";
            this.gcUsers.Size = new System.Drawing.Size(841, 369);
            this.gcUsers.TabIndex = 0;
            this.gcUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsers});
            // 
            // gvUsers
            // 
            this.gvUsers.GridControl = this.gcUsers;
            this.gvUsers.Name = "gvUsers";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(17, 78);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(441, 36);
            this.txtName.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(17, 41);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 29);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "NAME";
            // 
            // gcUserInfo
            // 
            this.gcUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gcUserInfo.Location = new System.Drawing.Point(856, 13);
            this.gcUserInfo.Name = "gcUserInfo";
            this.gcUserInfo.Size = new System.Drawing.Size(476, 475);
            this.gcUserInfo.TabIndex = 7;
            this.gcUserInfo.Text = "USER INFORMATION";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(17, 397);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 61);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "CANCEL";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(211, 397);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(247, 61);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(17, 295);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(213, 29);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "RETYPE PASSWORD";
            // 
            // txtRePass
            // 
            this.txtRePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRePass.Location = new System.Drawing.Point(17, 332);
            this.txtRePass.Margin = new System.Windows.Forms.Padding(4);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePass.Properties.Appearance.Options.UseFont = true;
            this.txtRePass.Properties.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(441, 36);
            this.txtRePass.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(17, 210);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(123, 29);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(17, 247);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(441, 36);
            this.txtPassword.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(17, 126);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 29);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "USERNAME";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(17, 163);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(441, 36);
            this.txtUserName.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Location = new System.Drawing.Point(602, 410);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(247, 61);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "ADD USER";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.Location = new System.Drawing.Point(347, 410);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(247, 61);
            this.btnEditUser.TabIndex = 16;
            this.btnEditUser.Text = "EDIT USER";
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 523);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gcUserInfo);
            this.Controls.Add(this.gcUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).EndInit();
            this.gcUserInfo.ResumeLayout(false);
            this.gcUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsers;
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
    }
}