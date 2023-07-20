namespace Procurement_Tracking_App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtusername = new DevExpress.XtraEditors.TextEdit();
            this.txtpasswd = new DevExpress.XtraEditors.TextEdit();
            this.btnlogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnchangecon = new DevExpress.XtraEditors.SimpleButton();
            this.lblstatus = new DevExpress.XtraEditors.LabelControl();
            this.bwLogin = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Procurement_Tracking_App.WaitForm1), true, true);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.cbShow = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpasswd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(717, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4, 786);
            this.label1.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(226, -1);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(270, 237);
            this.pictureEdit1.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(814, 48);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Padding = new System.Windows.Forms.Padding(15);
            this.labelControl4.Size = new System.Drawing.Size(528, 85);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Procurement Tracker App";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(756, 162);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(181, 39);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Username: *";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Location = new System.Drawing.Point(756, 276);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(172, 39);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Password: *";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(801, 208);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Properties.Appearance.Options.UseFont = true;
            this.txtusername.Size = new System.Drawing.Size(550, 46);
            this.txtusername.TabIndex = 6;
            this.txtusername.EditValueChanged += new System.EventHandler(this.txtusername_EditValueChanged);
            // 
            // txtpasswd
            // 
            this.txtpasswd.Location = new System.Drawing.Point(801, 336);
            this.txtpasswd.Margin = new System.Windows.Forms.Padding(4);
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswd.Properties.Appearance.Options.UseFont = true;
            this.txtpasswd.Properties.PasswordChar = '*';
            this.txtpasswd.Size = new System.Drawing.Size(550, 46);
            this.txtpasswd.TabIndex = 7;
            this.txtpasswd.EditValueChanged += new System.EventHandler(this.txtpasswd_EditValueChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(944, 433);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(222, 79);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnchangecon
            // 
            this.btnchangecon.Enabled = false;
            this.btnchangecon.Location = new System.Drawing.Point(753, 582);
            this.btnchangecon.Margin = new System.Windows.Forms.Padding(4);
            this.btnchangecon.Name = "btnchangecon";
            this.btnchangecon.Size = new System.Drawing.Size(280, 57);
            this.btnchangecon.TabIndex = 9;
            this.btnchangecon.Text = "Change Connection";
            this.btnchangecon.Visible = false;
            this.btnchangecon.Click += new System.EventHandler(this.btnchangecon_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.Appearance.BackColor = System.Drawing.Color.White;
            this.lblstatus.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblstatus.Enabled = false;
            this.lblstatus.Location = new System.Drawing.Point(1148, 595);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(4);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(192, 28);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "Connection Status:";
            this.lblstatus.Visible = false;
            // 
            // bwLogin
            // 
            this.bwLogin.WorkerSupportsCancellation = true;
            this.bwLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLogin_DoWork);
            this.bwLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLogin_RunWorkerCompleted);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(154, 244);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(431, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "BOHOL ISLAND STATE UNIVERSITY";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl2.Location = new System.Drawing.Point(256, 281);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(246, 29);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "BALILIHAN CAMPUS";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl3.Location = new System.Drawing.Point(190, 317);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(361, 29);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "MAGSIJA, BALILIHAN, BOHOL";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl7.Location = new System.Drawing.Point(78, 360);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(611, 24);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Vision: A premier Science and Technology university for the ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl8.Location = new System.Drawing.Point(234, 379);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(268, 24);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "formation of a world class ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl9.Location = new System.Drawing.Point(78, 411);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(622, 24);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "and virtuous human resource for sustainable development in ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl10.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl10.Location = new System.Drawing.Point(234, 437);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(230, 24);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "Bohol and the country.";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl11.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl11.Location = new System.Drawing.Point(234, 538);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(248, 24);
            this.labelControl11.TabIndex = 18;
            this.labelControl11.Text = "undertake research and ";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl12.Location = new System.Drawing.Point(120, 519);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(544, 24);
            this.labelControl12.TabIndex = 17;
            this.labelControl12.Text = "as well as in the professional and technological fields;";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl13.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl13.Location = new System.Drawing.Point(190, 493);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(356, 24);
            this.labelControl13.TabIndex = 16;
            this.labelControl13.Text = "education in the arts and sciences, ";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl14.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl14.Location = new System.Drawing.Point(120, 469);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(533, 24);
            this.labelControl14.TabIndex = 15;
            this.labelControl14.Text = "Mission: BISU is committed to provide quality higher";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl15.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl15.Location = new System.Drawing.Point(174, 598);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(394, 24);
            this.labelControl15.TabIndex = 20;
            this.labelControl15.Text = "development of Bohol and the country.";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl16.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl16.Location = new System.Drawing.Point(110, 570);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(530, 24);
            this.labelControl16.TabIndex = 19;
            this.labelControl16.Text = "development, and extension services for sustainable";
            // 
            // cbShow
            // 
            this.cbShow.Location = new System.Drawing.Point(1311, 630);
            this.cbShow.Margin = new System.Windows.Forms.Padding(4);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(112, 34);
            this.cbShow.TabIndex = 21;
            this.cbShow.Text = "Show";
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1442, 672);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnchangecon);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpasswd);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpasswd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtusername;
        private DevExpress.XtraEditors.TextEdit txtpasswd;
        private DevExpress.XtraEditors.SimpleButton btnlogin;
        private DevExpress.XtraEditors.SimpleButton btnchangecon;
        private DevExpress.XtraEditors.LabelControl lblstatus;
        private System.ComponentModel.BackgroundWorker bwLogin;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.CheckButton cbShow;
    }
}