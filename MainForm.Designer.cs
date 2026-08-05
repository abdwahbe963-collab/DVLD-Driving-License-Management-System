namespace DVLD_Full_Proj
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Pnl_Left_MainForm = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Btn_Drivers = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_Applications = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_Users = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_People = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_CurrentUser = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Cms_UserMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_Right_MainForm = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PicBox_MainForm = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Ctrl_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Ctrl_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Pnl_Left_MainForm.SuspendLayout();
            this.Cms_UserMenu.SuspendLayout();
            this.Pnl_Right_MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_MainForm)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // Pnl_Left_MainForm
            // 
            this.Pnl_Left_MainForm.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Left_MainForm.BorderColor = System.Drawing.Color.DimGray;
            this.Pnl_Left_MainForm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Pnl_Left_MainForm.Controls.Add(this.Btn_Drivers);
            this.Pnl_Left_MainForm.Controls.Add(this.Btn_Applications);
            this.Pnl_Left_MainForm.Controls.Add(this.Btn_Users);
            this.Pnl_Left_MainForm.Controls.Add(this.Btn_People);
            this.Pnl_Left_MainForm.Controls.Add(this.Btn_CurrentUser);
            this.Pnl_Left_MainForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Left_MainForm.FillColor = System.Drawing.Color.Black;
            this.Pnl_Left_MainForm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pnl_Left_MainForm.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pnl_Left_MainForm.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pnl_Left_MainForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Left_MainForm.Name = "Pnl_Left_MainForm";
            this.Pnl_Left_MainForm.ShadowDecoration.Parent = this.Pnl_Left_MainForm;
            this.Pnl_Left_MainForm.Size = new System.Drawing.Size(332, 792);
            this.Pnl_Left_MainForm.TabIndex = 17;
            // 
            // Btn_Drivers
            // 
            this.Btn_Drivers.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Drivers.BorderColor = System.Drawing.Color.White;
            this.Btn_Drivers.BorderRadius = 7;
            this.Btn_Drivers.CheckedState.Parent = this.Btn_Drivers;
            this.Btn_Drivers.CustomBorderColor = System.Drawing.Color.Black;
            this.Btn_Drivers.CustomImages.Parent = this.Btn_Drivers;
            this.Btn_Drivers.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Drivers.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_Drivers.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Drivers.ForeColor = System.Drawing.Color.White;
            this.Btn_Drivers.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.Btn_Drivers.HoverState.FillColor2 = System.Drawing.Color.Gray;
            this.Btn_Drivers.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Drivers.HoverState.Parent = this.Btn_Drivers;
            this.Btn_Drivers.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_steering_wheel_50;
            this.Btn_Drivers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Btn_Drivers.ImageOffset = new System.Drawing.Point(19, -2);
            this.Btn_Drivers.ImageSize = new System.Drawing.Size(45, 45);
            this.Btn_Drivers.Location = new System.Drawing.Point(0, 455);
            this.Btn_Drivers.Name = "Btn_Drivers";
            this.Btn_Drivers.ShadowDecoration.Parent = this.Btn_Drivers;
            this.Btn_Drivers.Size = new System.Drawing.Size(332, 78);
            this.Btn_Drivers.TabIndex = 23;
            this.Btn_Drivers.Text = "   Drivers";
            this.Btn_Drivers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Drivers.Click += new System.EventHandler(this.Btn_Drivers_Click);
            // 
            // Btn_Applications
            // 
            this.Btn_Applications.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Applications.BorderColor = System.Drawing.Color.White;
            this.Btn_Applications.BorderRadius = 7;
            this.Btn_Applications.CheckedState.Parent = this.Btn_Applications;
            this.Btn_Applications.CustomBorderColor = System.Drawing.Color.Black;
            this.Btn_Applications.CustomImages.Parent = this.Btn_Applications;
            this.Btn_Applications.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Applications.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_Applications.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Applications.ForeColor = System.Drawing.Color.White;
            this.Btn_Applications.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.Btn_Applications.HoverState.FillColor2 = System.Drawing.Color.Gray;
            this.Btn_Applications.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Applications.HoverState.Parent = this.Btn_Applications;
            this.Btn_Applications.Image = global::DVLD_Full_Proj.Properties.Resources.Applications1;
            this.Btn_Applications.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Btn_Applications.ImageOffset = new System.Drawing.Point(24, -2);
            this.Btn_Applications.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Applications.Location = new System.Drawing.Point(3, 550);
            this.Btn_Applications.Name = "Btn_Applications";
            this.Btn_Applications.ShadowDecoration.Parent = this.Btn_Applications;
            this.Btn_Applications.Size = new System.Drawing.Size(332, 78);
            this.Btn_Applications.TabIndex = 22;
            this.Btn_Applications.Text = "  Applications";
            this.Btn_Applications.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Applications.Click += new System.EventHandler(this.BtnMainApplications_Click);
            // 
            // Btn_Users
            // 
            this.Btn_Users.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Users.BorderColor = System.Drawing.Color.White;
            this.Btn_Users.BorderRadius = 7;
            this.Btn_Users.CheckedState.Parent = this.Btn_Users;
            this.Btn_Users.CustomBorderColor = System.Drawing.Color.Black;
            this.Btn_Users.CustomImages.Parent = this.Btn_Users;
            this.Btn_Users.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Users.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_Users.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Users.ForeColor = System.Drawing.Color.White;
            this.Btn_Users.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.Btn_Users.HoverState.FillColor2 = System.Drawing.Color.Gray;
            this.Btn_Users.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Users.HoverState.Parent = this.Btn_Users;
            this.Btn_Users.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_users_60;
            this.Btn_Users.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Btn_Users.ImageOffset = new System.Drawing.Point(20, -2);
            this.Btn_Users.ImageSize = new System.Drawing.Size(45, 45);
            this.Btn_Users.Location = new System.Drawing.Point(3, 267);
            this.Btn_Users.Name = "Btn_Users";
            this.Btn_Users.ShadowDecoration.Parent = this.Btn_Users;
            this.Btn_Users.Size = new System.Drawing.Size(332, 78);
            this.Btn_Users.TabIndex = 21;
            this.Btn_Users.Text = "   Users                   ";
            this.Btn_Users.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Users.Click += new System.EventHandler(this.Btn_Users_Click);
            // 
            // Btn_People
            // 
            this.Btn_People.BackColor = System.Drawing.Color.Transparent;
            this.Btn_People.BorderColor = System.Drawing.Color.White;
            this.Btn_People.BorderRadius = 7;
            this.Btn_People.CheckedState.Parent = this.Btn_People;
            this.Btn_People.CustomBorderColor = System.Drawing.Color.Black;
            this.Btn_People.CustomImages.Parent = this.Btn_People;
            this.Btn_People.FillColor = System.Drawing.Color.Transparent;
            this.Btn_People.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_People.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_People.ForeColor = System.Drawing.Color.White;
            this.Btn_People.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.Btn_People.HoverState.FillColor2 = System.Drawing.Color.Gray;
            this.Btn_People.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_People.HoverState.Parent = this.Btn_People;
            this.Btn_People.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_crowd_64;
            this.Btn_People.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Btn_People.ImageOffset = new System.Drawing.Point(19, -2);
            this.Btn_People.ImageSize = new System.Drawing.Size(45, 45);
            this.Btn_People.Location = new System.Drawing.Point(0, 360);
            this.Btn_People.Name = "Btn_People";
            this.Btn_People.ShadowDecoration.Parent = this.Btn_People;
            this.Btn_People.Size = new System.Drawing.Size(332, 78);
            this.Btn_People.TabIndex = 1;
            this.Btn_People.Text = "   People";
            this.Btn_People.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_People.Click += new System.EventHandler(this.Btn_People_Click_1);
            // 
            // Btn_CurrentUser
            // 
            this.Btn_CurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CurrentUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_CurrentUser.CheckedState.Parent = this.Btn_CurrentUser;
            this.Btn_CurrentUser.ContextMenuStrip = this.Cms_UserMenu;
            this.Btn_CurrentUser.CustomImages.Parent = this.Btn_CurrentUser;
            this.Btn_CurrentUser.FillColor = System.Drawing.Color.Transparent;
            this.Btn_CurrentUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_CurrentUser.ForeColor = System.Drawing.Color.White;
            this.Btn_CurrentUser.HoverState.Parent = this.Btn_CurrentUser;
            this.Btn_CurrentUser.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_account_settings_64;
            this.Btn_CurrentUser.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_CurrentUser.Location = new System.Drawing.Point(12, 12);
            this.Btn_CurrentUser.Name = "Btn_CurrentUser";
            this.Btn_CurrentUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_CurrentUser.ShadowDecoration.Parent = this.Btn_CurrentUser;
            this.Btn_CurrentUser.Size = new System.Drawing.Size(66, 57);
            this.Btn_CurrentUser.TabIndex = 20;
            this.Btn_CurrentUser.Click += new System.EventHandler(this.Btn_CurrentUser_Click);
            // 
            // Cms_UserMenu
            // 
            this.Cms_UserMenu.BackColor = System.Drawing.Color.DimGray;
            this.Cms_UserMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cms_UserMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.Cms_UserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.Cms_UserMenu.Name = "Cms_UserMenu";
            this.Cms_UserMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Cms_UserMenu.Size = new System.Drawing.Size(231, 100);
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.currentUserToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.Current_UserWhite;
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.currentUserToolStripMenuItem.Text = "Current User";
            this.currentUserToolStripMenuItem.Click += new System.EventHandler(this.currentUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changePasswordToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.ChangePasswordIcon32;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.signOutToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.Sighn_out;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.signOutToolStripMenuItem.Text = "SignOut";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // Pnl_Right_MainForm
            // 
            this.Pnl_Right_MainForm.Controls.Add(this.PicBox_MainForm);
            this.Pnl_Right_MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Right_MainForm.FillColor = System.Drawing.Color.Black;
            this.Pnl_Right_MainForm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pnl_Right_MainForm.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pnl_Right_MainForm.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pnl_Right_MainForm.Location = new System.Drawing.Point(332, 0);
            this.Pnl_Right_MainForm.Name = "Pnl_Right_MainForm";
            this.Pnl_Right_MainForm.ShadowDecoration.Parent = this.Pnl_Right_MainForm;
            this.Pnl_Right_MainForm.Size = new System.Drawing.Size(1144, 792);
            this.Pnl_Right_MainForm.TabIndex = 18;
            // 
            // PicBox_MainForm
            // 
            this.PicBox_MainForm.BackColor = System.Drawing.Color.Transparent;
            this.PicBox_MainForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicBox_MainForm.BackgroundImage")));
            this.PicBox_MainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBox_MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBox_MainForm.Location = new System.Drawing.Point(0, 0);
            this.PicBox_MainForm.Name = "PicBox_MainForm";
            this.PicBox_MainForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PicBox_MainForm.ShadowDecoration.Parent = this.PicBox_MainForm;
            this.PicBox_MainForm.Size = new System.Drawing.Size(1144, 792);
            this.PicBox_MainForm.TabIndex = 1;
            this.PicBox_MainForm.TabStop = false;
            this.PicBox_MainForm.Click += new System.EventHandler(this.PicBox_MainForm_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.Ctrl_Minimize);
            this.guna2CustomGradientPanel1.Controls.Add(this.Ctrl_Close);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(332, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1144, 31);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // Ctrl_Minimize
            // 
            this.Ctrl_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ctrl_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Ctrl_Minimize.BorderColor = System.Drawing.Color.Transparent;
            this.Ctrl_Minimize.BorderRadius = 7;
            this.Ctrl_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Ctrl_Minimize.CustomIconSize = 20F;
            this.Ctrl_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Ctrl_Minimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Ctrl_Minimize.HoverState.IconColor = System.Drawing.Color.Black;
            this.Ctrl_Minimize.HoverState.Parent = this.Ctrl_Minimize;
            this.Ctrl_Minimize.IconColor = System.Drawing.Color.White;
            this.Ctrl_Minimize.Location = new System.Drawing.Point(1077, 5);
            this.Ctrl_Minimize.Name = "Ctrl_Minimize";
            this.Ctrl_Minimize.ShadowDecoration.Parent = this.Ctrl_Minimize;
            this.Ctrl_Minimize.Size = new System.Drawing.Size(29, 23);
            this.Ctrl_Minimize.TabIndex = 19;
            // 
            // Ctrl_Close
            // 
            this.Ctrl_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ctrl_Close.BackColor = System.Drawing.Color.Transparent;
            this.Ctrl_Close.BorderColor = System.Drawing.Color.Transparent;
            this.Ctrl_Close.BorderRadius = 7;
            this.Ctrl_Close.CustomIconSize = 20F;
            this.Ctrl_Close.FillColor = System.Drawing.Color.Transparent;
            this.Ctrl_Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Ctrl_Close.HoverState.IconColor = System.Drawing.Color.Black;
            this.Ctrl_Close.HoverState.Parent = this.Ctrl_Close;
            this.Ctrl_Close.IconColor = System.Drawing.Color.White;
            this.Ctrl_Close.Location = new System.Drawing.Point(1112, 5);
            this.Ctrl_Close.Name = "Ctrl_Close";
            this.Ctrl_Close.ShadowDecoration.Parent = this.Ctrl_Close;
            this.Ctrl_Close.Size = new System.Drawing.Size(29, 23);
            this.Ctrl_Close.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1476, 792);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.Pnl_Right_MainForm);
            this.Controls.Add(this.Pnl_Left_MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Pnl_Left_MainForm.ResumeLayout(false);
            this.Cms_UserMenu.ResumeLayout(false);
            this.Pnl_Right_MainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_MainForm)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Pnl_Left_MainForm;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_People;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Pnl_Right_MainForm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox Ctrl_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Ctrl_Close;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PicBox_MainForm;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_CurrentUser;
        private System.Windows.Forms.ContextMenuStrip Cms_UserMenu;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Users;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Applications;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Drivers;
    }
}