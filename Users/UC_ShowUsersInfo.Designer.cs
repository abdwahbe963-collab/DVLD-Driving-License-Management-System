namespace DVLD_Full_Proj.Users
{
    partial class UC_ShowUsersInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cmb_IsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Txt_FillterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.Cb_FilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Records = new System.Windows.Forms.Label();
            this.dg_Users = new Guna.UI2.WinForms.Guna2DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Is_Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cms_UserSetings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteUsertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Btn_Back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_People = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ChangePasswordToolStripMenultem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Users)).BeginInit();
            this.Cms_UserSetings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_IsActive
            // 
            this.Cmb_IsActive.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Personid",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Email",
            "Phone"});
            this.Cmb_IsActive.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_IsActive.BorderColor = System.Drawing.Color.White;
            this.Cmb_IsActive.BorderRadius = 7;
            this.Cmb_IsActive.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cmb_IsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_IsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_IsActive.FillColor = System.Drawing.Color.DimGray;
            this.Cmb_IsActive.FocusedColor = System.Drawing.Color.Empty;
            this.Cmb_IsActive.FocusedState.Parent = this.Cmb_IsActive;
            this.Cmb_IsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmb_IsActive.ForeColor = System.Drawing.Color.White;
            this.Cmb_IsActive.FormattingEnabled = true;
            this.Cmb_IsActive.HoverState.Parent = this.Cmb_IsActive;
            this.Cmb_IsActive.ItemHeight = 30;
            this.Cmb_IsActive.Items.AddRange(new object[] {
            "All",
            "Is Active",
            "Not Active"});
            this.Cmb_IsActive.ItemsAppearance.Parent = this.Cmb_IsActive;
            this.Cmb_IsActive.Location = new System.Drawing.Point(505, 175);
            this.Cmb_IsActive.Name = "Cmb_IsActive";
            this.Cmb_IsActive.ShadowDecoration.Parent = this.Cmb_IsActive;
            this.Cmb_IsActive.Size = new System.Drawing.Size(158, 36);
            this.Cmb_IsActive.TabIndex = 37;
            this.Cmb_IsActive.Visible = false;
            this.Cmb_IsActive.SelectedIndexChanged += new System.EventHandler(this.Cmb_IsActive_SelectedIndexChanged);
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
            this.Txt_FillterBy.Location = new System.Drawing.Point(505, 176);
            this.Txt_FillterBy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Txt_FillterBy.Name = "Txt_FillterBy";
            this.Txt_FillterBy.PasswordChar = '\0';
            this.Txt_FillterBy.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_FillterBy.PlaceholderText = "";
            this.Txt_FillterBy.SelectedText = "";
            this.Txt_FillterBy.ShadowDecoration.Parent = this.Txt_FillterBy;
            this.Txt_FillterBy.Size = new System.Drawing.Size(219, 35);
            this.Txt_FillterBy.TabIndex = 36;
            this.Txt_FillterBy.TextChanged += new System.EventHandler(this.Txt_FillterBy_TextChanged);
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Filter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filter.ForeColor = System.Drawing.Color.White;
            this.lbl_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Filter.Location = new System.Drawing.Point(149, 177);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(105, 52);
            this.lbl_Filter.TabIndex = 34;
            this.lbl_Filter.Text = "FilterBy: ";
            // 
            // Cb_FilterBy
            // 
            this.Cb_FilterBy.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Personid",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Email",
            "Phone"});
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
            "UserID",
            "PersonID",
            "UserName",
            "IsActive"});
            this.Cb_FilterBy.ItemsAppearance.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Location = new System.Drawing.Point(260, 176);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.ShadowDecoration.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Size = new System.Drawing.Size(208, 36);
            this.Cb_FilterBy.TabIndex = 33;
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cmb_FillterBy_SelectedIndexChanged);
            // 
            // lbl_Records
            // 
            this.lbl_Records.AutoSize = true;
            this.lbl_Records.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Records.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Records.ForeColor = System.Drawing.Color.White;
            this.lbl_Records.Location = new System.Drawing.Point(85, 625);
            this.lbl_Records.Name = "lbl_Records";
            this.lbl_Records.Size = new System.Drawing.Size(67, 26);
            this.lbl_Records.TabIndex = 31;
            this.lbl_Records.Text = "label1";
            // 
            // dg_Users
            // 
            this.dg_Users.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Users.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dg_Users.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_Users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_Users.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dg_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Users.ColumnHeadersHeight = 56;
            this.dg_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.Person_ID,
            this.User_Name,
            this.FullName,
            this.Is_Active});
            this.dg_Users.ContextMenuStrip = this.Cms_UserSetings;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Users.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_Users.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Users.EnableHeadersVisualStyles = false;
            this.dg_Users.GridColor = System.Drawing.Color.White;
            this.dg_Users.Location = new System.Drawing.Point(26, 260);
            this.dg_Users.Name = "dg_Users";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_Users.RowHeadersVisible = false;
            this.dg_Users.RowHeadersWidth = 51;
            this.dg_Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Users.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_Users.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_Users.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_Users.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_Users.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dg_Users.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dg_Users.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Users.RowTemplate.Height = 30;
            this.dg_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Users.Size = new System.Drawing.Size(1095, 323);
            this.dg_Users.TabIndex = 30;
            this.dg_Users.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg_Users.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_Users.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_Users.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_Users.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_Users.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Users.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dg_Users.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dg_Users.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_Users.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_Users.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_Users.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_Users.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_Users.ThemeStyle.HeaderStyle.Height = 56;
            this.dg_Users.ThemeStyle.ReadOnly = false;
            this.dg_Users.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_Users.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_Users.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_Users.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_Users.ThemeStyle.RowsStyle.Height = 30;
            this.dg_Users.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dg_Users.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // User_ID
            // 
            this.User_ID.DataPropertyName = "UserID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            this.User_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.User_ID.FillWeight = 25.00104F;
            this.User_ID.HeaderText = "UserID";
            this.User_ID.MinimumWidth = 6;
            this.User_ID.Name = "User_ID";
            this.User_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Person_ID
            // 
            this.Person_ID.DataPropertyName = "PersonID";
            this.Person_ID.FillWeight = 25.00104F;
            this.Person_ID.HeaderText = "PersonID";
            this.Person_ID.MinimumWidth = 6;
            this.Person_ID.Name = "Person_ID";
            // 
            // User_Name
            // 
            this.User_Name.DataPropertyName = "UserName";
            this.User_Name.FillWeight = 25.00104F;
            this.User_Name.HeaderText = "UserName";
            this.User_Name.MinimumWidth = 6;
            this.User_Name.Name = "User_Name";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Is_Active
            // 
            this.Is_Active.DataPropertyName = "IsActive";
            this.Is_Active.FillWeight = 25.00104F;
            this.Is_Active.HeaderText = "IsActive";
            this.Is_Active.MinimumWidth = 6;
            this.Is_Active.Name = "Is_Active";
            this.Is_Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Is_Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cms_UserSetings
            // 
            this.Cms_UserSetings.BackColor = System.Drawing.Color.DimGray;
            this.Cms_UserSetings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cms_UserSetings.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.Cms_UserSetings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetailsToolStripMenuItem,
            this.EditUserToolStripMenuItem,
            this.AddUserToolStripMenuItem,
            this.DeleteUsertoolStripMenuItem,
            this.ChangePasswordToolStripMenultem,
            this.phoneCallToolStripMenuItem,
            this.sendEmailToolStripMenuItem});
            this.Cms_UserSetings.Name = "Cms_UserMenu";
            this.Cms_UserSetings.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Cms_UserSetings.Size = new System.Drawing.Size(231, 284);
            // 
            // ShowDetailsToolStripMenuItem
            // 
            this.ShowDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ShowDetailsToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_show_DetailesWhite_no_backGround_24;
            this.ShowDetailsToolStripMenuItem.Name = "ShowDetailsToolStripMenuItem";
            this.ShowDetailsToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.ShowDetailsToolStripMenuItem.Text = "Show Ditails";
            this.ShowDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowDetailsToolStripMenuItem_Click);
            // 
            // EditUserToolStripMenuItem
            // 
            this.EditUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EditUserToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_editWhite_no_backGround_24;
            this.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem";
            this.EditUserToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.EditUserToolStripMenuItem.Text = "Edit User";
            this.EditUserToolStripMenuItem.Click += new System.EventHandler(this.EditUserToolStripMenuItem_Click);
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AddUserToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_add_30;
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.AddUserToolStripMenuItem.Text = "Add User";
            this.AddUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // DeleteUsertoolStripMenuItem
            // 
            this.DeleteUsertoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DeleteUsertoolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_deleteWhite_no_backGround_24;
            this.DeleteUsertoolStripMenuItem.Name = "DeleteUsertoolStripMenuItem";
            this.DeleteUsertoolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.DeleteUsertoolStripMenuItem.Text = "Delete User";
            this.DeleteUsertoolStripMenuItem.Click += new System.EventHandler(this.DeleteUsertoolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.phoneCallToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_phone_callWhite_no_backGround_24;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sendEmailToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_emailWhite_no_backGround_24;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Title.Location = new System.Drawing.Point(137, 54);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(294, 46);
            this.lbl_Title.TabIndex = 38;
            this.lbl_Title.Text = "User Mangments";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackgroundImage = global::DVLD_Full_Proj.Properties.Resources.icons8_users_60;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(437, 17);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(138, 107);
            this.guna2CirclePictureBox1.TabIndex = 39;
            this.guna2CirclePictureBox1.TabStop = false;
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
            this.Btn_Back.Location = new System.Drawing.Point(1005, 600);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.ShadowDecoration.Parent = this.Btn_Back;
            this.Btn_Back.Size = new System.Drawing.Size(92, 70);
            this.Btn_Back.TabIndex = 41;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click_1);
            // 
            // Btn_People
            // 
            this.Btn_People.BackColor = System.Drawing.Color.Transparent;
            this.Btn_People.BorderColor = System.Drawing.Color.White;
            this.Btn_People.BorderRadius = 7;
            this.Btn_People.CheckedState.Parent = this.Btn_People;
            this.Btn_People.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Btn_People.CustomImages.Parent = this.Btn_People;
            this.Btn_People.FillColor = System.Drawing.Color.Transparent;
            this.Btn_People.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_People.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_People.ForeColor = System.Drawing.Color.White;
            this.Btn_People.HoverState.Parent = this.Btn_People;
            this.Btn_People.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_add_64;
            this.Btn_People.ImageSize = new System.Drawing.Size(60, 60);
            this.Btn_People.Location = new System.Drawing.Point(1005, 159);
            this.Btn_People.Name = "Btn_People";
            this.Btn_People.PressedColor = System.Drawing.Color.Transparent;
            this.Btn_People.ShadowDecoration.Parent = this.Btn_People;
            this.Btn_People.Size = new System.Drawing.Size(92, 70);
            this.Btn_People.TabIndex = 40;
            this.Btn_People.Click += new System.EventHandler(this.Btn_AddUser_Click);
            // 
            // ChangePasswordToolStripMenultem
            // 
            this.ChangePasswordToolStripMenultem.ForeColor = System.Drawing.Color.White;
            this.ChangePasswordToolStripMenultem.Image = global::DVLD_Full_Proj.Properties.Resources.ChangePasswordIcon32;
            this.ChangePasswordToolStripMenultem.Name = "ChangePasswordToolStripMenultem";
            this.ChangePasswordToolStripMenultem.Size = new System.Drawing.Size(230, 36);
            this.ChangePasswordToolStripMenultem.Text = "ChangePassword";
            this.ChangePasswordToolStripMenultem.Click += new System.EventHandler(this.ChangePasswordToolStripMenultem_Click);
            // 
            // UC_ShowUsersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_People);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.Cmb_IsActive);
            this.Controls.Add(this.Txt_FillterBy);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.Cb_FilterBy);
            this.Controls.Add(this.lbl_Records);
            this.Controls.Add(this.dg_Users);
            this.Name = "UC_ShowUsersInfo";
            this.Size = new System.Drawing.Size(1146, 805);
            this.Load += new System.EventHandler(this.UC_ShowUsersInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Users)).EndInit();
            this.Cms_UserSetings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox Cmb_IsActive;
        private Guna.UI2.WinForms.Guna2TextBox Txt_FillterBy;
        private System.Windows.Forms.Label lbl_Filter;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_FilterBy;
        private System.Windows.Forms.Label lbl_Records;
        private Guna.UI2.WinForms.Guna2DataGridView dg_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Is_Active;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Back;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_People;
        private System.Windows.Forms.ContextMenuStrip Cms_UserSetings;
        private System.Windows.Forms.ToolStripMenuItem ShowDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteUsertoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenultem;
    }
}
