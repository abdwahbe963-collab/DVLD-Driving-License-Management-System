namespace DVLD_Full_Proj
{
    partial class UC_ShowPeopleInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Txt_FillterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.Cb_FilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Records = new System.Windows.Forms.Label();
            this.dg_People = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PersonlD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Btn_Back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_People = new Guna.UI2.WinForms.Guna2GradientButton();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_People)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.phoneCallToolStripMenuItem,
            this.sendEmailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 220);
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
            this.Txt_FillterBy.Location = new System.Drawing.Point(510, 212);
            this.Txt_FillterBy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Txt_FillterBy.Name = "Txt_FillterBy";
            this.Txt_FillterBy.PasswordChar = '\0';
            this.Txt_FillterBy.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_FillterBy.PlaceholderText = "";
            this.Txt_FillterBy.SelectedText = "";
            this.Txt_FillterBy.ShadowDecoration.Parent = this.Txt_FillterBy;
            this.Txt_FillterBy.Size = new System.Drawing.Size(219, 35);
            this.Txt_FillterBy.TabIndex = 18;
            this.Txt_FillterBy.TextChanged += new System.EventHandler(this.Txt_FillterBy_TextChanged);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Title.Location = new System.Drawing.Point(148, 95);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(325, 46);
            this.lbl_Title.TabIndex = 17;
            this.lbl_Title.Text = "People Mangments";
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Filter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filter.ForeColor = System.Drawing.Color.White;
            this.lbl_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Filter.Location = new System.Drawing.Point(154, 213);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(105, 52);
            this.lbl_Filter.TabIndex = 15;
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
            "Personid",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Phone",
            "Email",
            "Nationalty"});
            this.Cb_FilterBy.ItemsAppearance.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Location = new System.Drawing.Point(265, 212);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.ShadowDecoration.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Size = new System.Drawing.Size(208, 36);
            this.Cb_FilterBy.TabIndex = 14;
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // lbl_Records
            // 
            this.lbl_Records.AutoSize = true;
            this.lbl_Records.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Records.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Records.ForeColor = System.Drawing.Color.White;
            this.lbl_Records.Location = new System.Drawing.Point(99, 655);
            this.lbl_Records.Name = "lbl_Records";
            this.lbl_Records.Size = new System.Drawing.Size(67, 26);
            this.lbl_Records.TabIndex = 12;
            this.lbl_Records.Text = "label1";
            // 
            // dg_People
            // 
            this.dg_People.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_People.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_People.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_People.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dg_People.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_People.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_People.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dg_People.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_People.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_People.ColumnHeadersHeight = 56;
            this.dg_People.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonlD,
            this.NationalNo,
            this.FirstName,
            this.SecondName,
            this.ThirdName,
            this.LastName,
            this.DateOfBirth,
            this.GenderCaption,
            this.Nationalty,
            this.Phone,
            this.Email});
            this.dg_People.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_People.DefaultCellStyle = dataGridViewCellStyle5;
            this.dg_People.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_People.EnableHeadersVisualStyles = false;
            this.dg_People.GridColor = System.Drawing.Color.White;
            this.dg_People.Location = new System.Drawing.Point(27, 285);
            this.dg_People.Name = "dg_People";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_People.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_People.RowHeadersVisible = false;
            this.dg_People.RowHeadersWidth = 51;
            this.dg_People.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_People.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dg_People.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_People.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_People.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_People.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dg_People.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dg_People.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_People.RowTemplate.Height = 30;
            this.dg_People.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_People.Size = new System.Drawing.Size(1095, 323);
            this.dg_People.TabIndex = 11;
            this.dg_People.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg_People.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_People.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_People.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_People.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_People.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_People.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dg_People.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dg_People.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_People.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_People.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_People.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_People.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_People.ThemeStyle.HeaderStyle.Height = 56;
            this.dg_People.ThemeStyle.ReadOnly = false;
            this.dg_People.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_People.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_People.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_People.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_People.ThemeStyle.RowsStyle.Height = 30;
            this.dg_People.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dg_People.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // PersonlD
            // 
            this.PersonlD.DataPropertyName = "PersonID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.PersonlD.DefaultCellStyle = dataGridViewCellStyle3;
            this.PersonlD.FillWeight = 15F;
            this.PersonlD.HeaderText = "ID";
            this.PersonlD.MinimumWidth = 6;
            this.PersonlD.Name = "PersonlD";
            // 
            // NationalNo
            // 
            this.NationalNo.DataPropertyName = "NationalNo";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            this.NationalNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.NationalNo.FillWeight = 25.00104F;
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.FillWeight = 25.00104F;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // SecondName
            // 
            this.SecondName.DataPropertyName = "SecondName";
            this.SecondName.FillWeight = 25.00104F;
            this.SecondName.HeaderText = "Second Name";
            this.SecondName.MinimumWidth = 6;
            this.SecondName.Name = "SecondName";
            // 
            // ThirdName
            // 
            this.ThirdName.DataPropertyName = "ThirdName";
            this.ThirdName.FillWeight = 25.00104F;
            this.ThirdName.HeaderText = "Third Name";
            this.ThirdName.MinimumWidth = 6;
            this.ThirdName.Name = "ThirdName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.FillWeight = 25.00104F;
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.FillWeight = 34F;
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // GenderCaption
            // 
            this.GenderCaption.DataPropertyName = "GenderCaption";
            this.GenderCaption.FillWeight = 20F;
            this.GenderCaption.HeaderText = "Gender";
            this.GenderCaption.MinimumWidth = 6;
            this.GenderCaption.Name = "GenderCaption";
            // 
            // Nationalty
            // 
            this.Nationalty.DataPropertyName = "CountryName";
            this.Nationalty.FillWeight = 25.00104F;
            this.Nationalty.HeaderText = "Nationalty";
            this.Nationalty.MinimumWidth = 6;
            this.Nationalty.Name = "Nationalty";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 30F;
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 40F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackgroundImage = global::DVLD_Full_Proj.Properties.Resources.icons8_crowd_64;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(456, 56);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(138, 107);
            this.guna2CirclePictureBox1.TabIndex = 19;
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
            this.Btn_Back.Location = new System.Drawing.Point(1038, 637);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.ShadowDecoration.Parent = this.Btn_Back;
            this.Btn_Back.Size = new System.Drawing.Size(92, 70);
            this.Btn_Back.TabIndex = 16;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
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
            this.Btn_People.Location = new System.Drawing.Point(1030, 187);
            this.Btn_People.Name = "Btn_People";
            this.Btn_People.PressedColor = System.Drawing.Color.Transparent;
            this.Btn_People.ShadowDecoration.Parent = this.Btn_People;
            this.Btn_People.Size = new System.Drawing.Size(92, 70);
            this.Btn_People.TabIndex = 13;
            this.Btn_People.Click += new System.EventHandler(this.Btn_AddPeople_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_show_DetailesWhite_no_backGround_24;
            this.showDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDetailsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_add_30;
            this.addToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.DimGray;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_editWhite_no_backGround_24;
            this.editToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_deleteWhite_no_backGround_24;
            this.deleteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.phoneCallToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_phone_callWhite_no_backGround_24;
            this.phoneCallToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sendEmailToolStripMenuItem.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_emailWhite_no_backGround_24;
            this.sendEmailToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // UC_ShowPeopleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.Txt_FillterBy);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.Cb_FilterBy);
            this.Controls.Add(this.Btn_People);
            this.Controls.Add(this.lbl_Records);
            this.Controls.Add(this.dg_People);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_ShowPeopleInfo";
            this.Size = new System.Drawing.Size(1207, 773);
            this.Load += new System.EventHandler(this.UC_ShowPeopleInfo_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_People)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TextBox Txt_FillterBy;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Back;
        private System.Windows.Forms.Label lbl_Filter;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_FilterBy;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_People;
        private System.Windows.Forms.Label lbl_Records;
        private Guna.UI2.WinForms.Guna2DataGridView dg_People;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonlD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
