namespace DVLD_Full_Proj.Applications.ManageApplications.Detain_License
{
    partial class UC_ManageDetainLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txt_FillterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.Cb_FilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_DetainLicense = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbl_Records = new System.Windows.Forms.Label();
            this.dg_DetainedicenseApplications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cms_DetainedLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LicenseHistorytoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_ReleaseLicense = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DetainedicenseApplications)).BeginInit();
            this.Cms_DetainedLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_FillterBy
            // 
            this.Txt_FillterBy.BackColor = System.Drawing.Color.Transparent;
            this.Txt_FillterBy.BorderRadius = 7;
            this.Txt_FillterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_FillterBy.DefaultText = "";
            this.Txt_FillterBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_FillterBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_FillterBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_FillterBy.DisabledState.Parent = this.Txt_FillterBy;
            this.Txt_FillterBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_FillterBy.FillColor = System.Drawing.Color.DimGray;
            this.Txt_FillterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_FillterBy.FocusedState.Parent = this.Txt_FillterBy;
            this.Txt_FillterBy.ForeColor = System.Drawing.Color.White;
            this.Txt_FillterBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_FillterBy.HoverState.Parent = this.Txt_FillterBy;
            this.Txt_FillterBy.Location = new System.Drawing.Point(543, 216);
            this.Txt_FillterBy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Txt_FillterBy.Name = "Txt_FillterBy";
            this.Txt_FillterBy.PasswordChar = '\0';
            this.Txt_FillterBy.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_FillterBy.PlaceholderText = "";
            this.Txt_FillterBy.SelectedText = "";
            this.Txt_FillterBy.ShadowDecoration.Parent = this.Txt_FillterBy;
            this.Txt_FillterBy.Size = new System.Drawing.Size(219, 35);
            this.Txt_FillterBy.TabIndex = 62;
            this.Txt_FillterBy.TextChanged += new System.EventHandler(this.Txt_FillterBy_TextChanged);
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Filter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filter.ForeColor = System.Drawing.Color.White;
            this.lbl_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Filter.Location = new System.Drawing.Point(187, 217);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(105, 52);
            this.lbl_Filter.TabIndex = 61;
            this.lbl_Filter.Text = "FilterBy: ";
            // 
            // Cb_FilterBy
            // 
            this.Cb_FilterBy.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "L.D.L.AppID"});
            this.Cb_FilterBy.BackColor = System.Drawing.Color.Transparent;
            this.Cb_FilterBy.BorderColor = System.Drawing.Color.White;
            this.Cb_FilterBy.BorderRadius = 7;
            this.Cb_FilterBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cb_FilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_FilterBy.FillColor = System.Drawing.Color.DimGray;
            this.Cb_FilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.Cb_FilterBy.FocusedState.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cb_FilterBy.ForeColor = System.Drawing.Color.White;
            this.Cb_FilterBy.FormattingEnabled = true;
            this.Cb_FilterBy.HoverState.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.ItemHeight = 30;
            this.Cb_FilterBy.Items.AddRange(new object[] {
            "None",
            "DetainID",
            "LicenseID",
            "NationalNo",
            "FullName"});
            this.Cb_FilterBy.ItemsAppearance.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Location = new System.Drawing.Point(298, 216);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.ShadowDecoration.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Size = new System.Drawing.Size(208, 36);
            this.Cb_FilterBy.TabIndex = 60;
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cb_FilterBy_SelectedIndexChanged);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.BackgroundImage = global::DVLD_Full_Proj.Properties.Resources.icons8_handRelease_32;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(697, 69);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(138, 107);
            this.guna2CirclePictureBox1.TabIndex = 58;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Title.Location = new System.Drawing.Point(131, 104);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(626, 46);
            this.lbl_Title.TabIndex = 57;
            this.lbl_Title.Text = "Detained Driving License Mangments";
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Back.BorderColor = System.Drawing.Color.White;
            this.Btn_Back.BorderRadius = 7;
            this.Btn_Back.CheckedState.Parent = this.Btn_Back;
            this.Btn_Back.CustomBorderColor = System.Drawing.Color.Black;
            this.Btn_Back.CustomImages.Parent = this.Btn_Back;
            this.Btn_Back.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Back.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_Back.Font = new System.Drawing.Font("Tw Cen MT Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.ForeColor = System.Drawing.Color.White;
            this.Btn_Back.HoverState.Parent = this.Btn_Back;
            this.Btn_Back.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_Back_64;
            this.Btn_Back.ImageSize = new System.Drawing.Size(60, 55);
            this.Btn_Back.Location = new System.Drawing.Point(1052, 642);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.ShadowDecoration.Parent = this.Btn_Back;
            this.Btn_Back.Size = new System.Drawing.Size(92, 70);
            this.Btn_Back.TabIndex = 56;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_DetainLicense
            // 
            this.Btn_DetainLicense.BackColor = System.Drawing.Color.Transparent;
            this.Btn_DetainLicense.BorderColor = System.Drawing.Color.White;
            this.Btn_DetainLicense.BorderRadius = 7;
            this.Btn_DetainLicense.CheckedState.Parent = this.Btn_DetainLicense;
            this.Btn_DetainLicense.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Btn_DetainLicense.CustomImages.Parent = this.Btn_DetainLicense;
            this.Btn_DetainLicense.FillColor = System.Drawing.Color.Transparent;
            this.Btn_DetainLicense.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_DetainLicense.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DetainLicense.ForeColor = System.Drawing.Color.White;
            this.Btn_DetainLicense.HoverState.Parent = this.Btn_DetainLicense;
            this.Btn_DetainLicense.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_hand_30;
            this.Btn_DetainLicense.ImageSize = new System.Drawing.Size(60, 60);
            this.Btn_DetainLicense.Location = new System.Drawing.Point(1046, 199);
            this.Btn_DetainLicense.Name = "Btn_DetainLicense";
            this.Btn_DetainLicense.PressedColor = System.Drawing.Color.Transparent;
            this.Btn_DetainLicense.ShadowDecoration.Parent = this.Btn_DetainLicense;
            this.Btn_DetainLicense.Size = new System.Drawing.Size(92, 70);
            this.Btn_DetainLicense.TabIndex = 55;
            this.Btn_DetainLicense.Click += new System.EventHandler(this.Btn_DetainDrivingLicenseApp_Click);
            // 
            // lbl_Records
            // 
            this.lbl_Records.AutoSize = true;
            this.lbl_Records.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Records.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Records.ForeColor = System.Drawing.Color.White;
            this.lbl_Records.Location = new System.Drawing.Point(82, 664);
            this.lbl_Records.Name = "lbl_Records";
            this.lbl_Records.Size = new System.Drawing.Size(67, 26);
            this.lbl_Records.TabIndex = 54;
            this.lbl_Records.Text = "label1";
            // 
            // dg_DetainedicenseApplications
            // 
            this.dg_DetainedicenseApplications.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_DetainedicenseApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_DetainedicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_DetainedicenseApplications.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dg_DetainedicenseApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_DetainedicenseApplications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_DetainedicenseApplications.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dg_DetainedicenseApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_DetainedicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_DetainedicenseApplications.ColumnHeadersHeight = 56;
            this.dg_DetainedicenseApplications.ContextMenuStrip = this.Cms_DetainedLicense;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_DetainedicenseApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_DetainedicenseApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_DetainedicenseApplications.EnableHeadersVisualStyles = false;
            this.dg_DetainedicenseApplications.GridColor = System.Drawing.Color.White;
            this.dg_DetainedicenseApplications.Location = new System.Drawing.Point(10, 294);
            this.dg_DetainedicenseApplications.Name = "dg_DetainedicenseApplications";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_DetainedicenseApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_DetainedicenseApplications.RowHeadersVisible = false;
            this.dg_DetainedicenseApplications.RowHeadersWidth = 51;
            this.dg_DetainedicenseApplications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_DetainedicenseApplications.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_DetainedicenseApplications.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_DetainedicenseApplications.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_DetainedicenseApplications.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_DetainedicenseApplications.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dg_DetainedicenseApplications.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dg_DetainedicenseApplications.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_DetainedicenseApplications.RowTemplate.Height = 30;
            this.dg_DetainedicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_DetainedicenseApplications.Size = new System.Drawing.Size(1134, 323);
            this.dg_DetainedicenseApplications.TabIndex = 53;
            this.dg_DetainedicenseApplications.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg_DetainedicenseApplications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_DetainedicenseApplications.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_DetainedicenseApplications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_DetainedicenseApplications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_DetainedicenseApplications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_DetainedicenseApplications.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dg_DetainedicenseApplications.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dg_DetainedicenseApplications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_DetainedicenseApplications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_DetainedicenseApplications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_DetainedicenseApplications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_DetainedicenseApplications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_DetainedicenseApplications.ThemeStyle.HeaderStyle.Height = 56;
            this.dg_DetainedicenseApplications.ThemeStyle.ReadOnly = false;
            this.dg_DetainedicenseApplications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_DetainedicenseApplications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_DetainedicenseApplications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_DetainedicenseApplications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_DetainedicenseApplications.ThemeStyle.RowsStyle.Height = 30;
            this.dg_DetainedicenseApplications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dg_DetainedicenseApplications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Cms_DetainedLicense
            // 
            this.Cms_DetainedLicense.BackColor = System.Drawing.Color.DimGray;
            this.Cms_DetainedLicense.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cms_DetainedLicense.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.Cms_DetainedLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonInfoToolStripMenuItem,
            this.ShowLicenseToolStripMenuItem,
            this.LicenseHistorytoolStripMenuItem1});
            this.Cms_DetainedLicense.Name = "Cms_UserMenu";
            this.Cms_DetainedLicense.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Cms_DetainedLicense.Size = new System.Drawing.Size(329, 112);
            // 
            // ShowPersonInfoToolStripMenuItem
            // 
            this.ShowPersonInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ShowPersonInfoToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_show_DetailesWhite_no_backGround_24;
            this.ShowPersonInfoToolStripMenuItem.Name = "ShowPersonInfoToolStripMenuItem";
            this.ShowPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(328, 36);
            this.ShowPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.ShowPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonInfoToolStripMenuItem_Click);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            this.ShowLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ShowLicenseToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_driver_license_White_50;
            this.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            this.ShowLicenseToolStripMenuItem.Size = new System.Drawing.Size(328, 36);
            this.ShowLicenseToolStripMenuItem.Text = "Show License";
            this.ShowLicenseToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseToolStripMenuItem_Click);
            // 
            // LicenseHistorytoolStripMenuItem1
            // 
            this.LicenseHistorytoolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.LicenseHistorytoolStripMenuItem1.Image = global::DVLD_Full_Proj.Properties.Resources.licnese_Classes_Info;
            this.LicenseHistorytoolStripMenuItem1.Name = "LicenseHistorytoolStripMenuItem1";
            this.LicenseHistorytoolStripMenuItem1.Size = new System.Drawing.Size(328, 36);
            this.LicenseHistorytoolStripMenuItem1.Text = "Show Person License History";
            this.LicenseHistorytoolStripMenuItem1.Click += new System.EventHandler(this.LicenseHistorytoolStripMenuItem1_Click);
            // 
            // Btn_ReleaseLicense
            // 
            this.Btn_ReleaseLicense.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ReleaseLicense.BorderColor = System.Drawing.Color.White;
            this.Btn_ReleaseLicense.BorderRadius = 7;
            this.Btn_ReleaseLicense.CheckedState.Parent = this.Btn_ReleaseLicense;
            this.Btn_ReleaseLicense.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Btn_ReleaseLicense.CustomImages.Parent = this.Btn_ReleaseLicense;
            this.Btn_ReleaseLicense.FillColor = System.Drawing.Color.Transparent;
            this.Btn_ReleaseLicense.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_ReleaseLicense.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReleaseLicense.ForeColor = System.Drawing.Color.White;
            this.Btn_ReleaseLicense.HoverState.Parent = this.Btn_ReleaseLicense;
            this.Btn_ReleaseLicense.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_handRelease_32;
            this.Btn_ReleaseLicense.ImageSize = new System.Drawing.Size(60, 60);
            this.Btn_ReleaseLicense.Location = new System.Drawing.Point(938, 199);
            this.Btn_ReleaseLicense.Name = "Btn_ReleaseLicense";
            this.Btn_ReleaseLicense.PressedColor = System.Drawing.Color.Transparent;
            this.Btn_ReleaseLicense.ShadowDecoration.Parent = this.Btn_ReleaseLicense;
            this.Btn_ReleaseLicense.Size = new System.Drawing.Size(92, 70);
            this.Btn_ReleaseLicense.TabIndex = 65;
            this.Btn_ReleaseLicense.Click += new System.EventHandler(this.Btn_ReleaseLicense_Click);
            // 
            // UC_ManageDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Btn_ReleaseLicense);
            this.Controls.Add(this.Txt_FillterBy);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.Cb_FilterBy);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_DetainLicense);
            this.Controls.Add(this.lbl_Records);
            this.Controls.Add(this.dg_DetainedicenseApplications);
            this.Name = "UC_ManageDetainLicense";
            this.Size = new System.Drawing.Size(1174, 785);
            this.Load += new System.EventHandler(this.UC_ManageDetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DetainedicenseApplications)).EndInit();
            this.Cms_DetainedLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox Txt_FillterBy;
        private System.Windows.Forms.Label lbl_Filter;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_FilterBy;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Back;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_DetainLicense;
        private System.Windows.Forms.Label lbl_Records;
        private Guna.UI2.WinForms.Guna2DataGridView dg_DetainedicenseApplications;
        private System.Windows.Forms.ContextMenuStrip Cms_DetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LicenseHistorytoolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_ReleaseLicense;
    }
}
