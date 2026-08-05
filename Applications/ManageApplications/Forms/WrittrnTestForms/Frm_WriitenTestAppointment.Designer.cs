namespace DVLD_Full_Proj.Applications.ManageApplications.Forms.WrittrnTestForms
{
    partial class Frm_WriitenTestAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Ctrl_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Ctrl_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Btn_SchudleVisionTest = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Dg_TestAppointment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Btn_Cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cms_AppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTesttoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_TestAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.Cms_AppMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.Ctrl_Minimize);
            this.guna2CustomGradientPanel1.Controls.Add(this.Ctrl_Close);
            this.guna2CustomGradientPanel1.Controls.Add(this.Btn_SchudleVisionTest);
            this.guna2CustomGradientPanel1.Controls.Add(this.Dg_TestAppointment);
            this.guna2CustomGradientPanel1.Controls.Add(this.Btn_Cancel);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbl_Title);
            this.guna2CustomGradientPanel1.Controls.Add(this.panel1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1144, 924);
            this.guna2CustomGradientPanel1.TabIndex = 1;
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
            this.Ctrl_Minimize.Location = new System.Drawing.Point(1068, 12);
            this.Ctrl_Minimize.Name = "Ctrl_Minimize";
            this.Ctrl_Minimize.ShadowDecoration.Parent = this.Ctrl_Minimize;
            this.Ctrl_Minimize.Size = new System.Drawing.Size(29, 23);
            this.Ctrl_Minimize.TabIndex = 125;
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
            this.Ctrl_Close.Location = new System.Drawing.Point(1103, 12);
            this.Ctrl_Close.Name = "Ctrl_Close";
            this.Ctrl_Close.ShadowDecoration.Parent = this.Ctrl_Close;
            this.Ctrl_Close.Size = new System.Drawing.Size(29, 23);
            this.Ctrl_Close.TabIndex = 126;
            // 
            // Btn_SchudleVisionTest
            // 
            this.Btn_SchudleVisionTest.BackColor = System.Drawing.Color.Transparent;
            this.Btn_SchudleVisionTest.BorderColor = System.Drawing.Color.White;
            this.Btn_SchudleVisionTest.BorderRadius = 7;
            this.Btn_SchudleVisionTest.CheckedState.Parent = this.Btn_SchudleVisionTest;
            this.Btn_SchudleVisionTest.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Btn_SchudleVisionTest.CustomImages.Parent = this.Btn_SchudleVisionTest;
            this.Btn_SchudleVisionTest.FillColor = System.Drawing.Color.Transparent;
            this.Btn_SchudleVisionTest.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_SchudleVisionTest.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SchudleVisionTest.ForeColor = System.Drawing.Color.White;
            this.Btn_SchudleVisionTest.HoverState.Parent = this.Btn_SchudleVisionTest;
            this.Btn_SchudleVisionTest.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_add_64;
            this.Btn_SchudleVisionTest.ImageSize = new System.Drawing.Size(45, 45);
            this.Btn_SchudleVisionTest.Location = new System.Drawing.Point(991, 540);
            this.Btn_SchudleVisionTest.Name = "Btn_SchudleVisionTest";
            this.Btn_SchudleVisionTest.PressedColor = System.Drawing.Color.Transparent;
            this.Btn_SchudleVisionTest.ShadowDecoration.Parent = this.Btn_SchudleVisionTest;
            this.Btn_SchudleVisionTest.Size = new System.Drawing.Size(68, 48);
            this.Btn_SchudleVisionTest.TabIndex = 124;
            this.Btn_SchudleVisionTest.Click += new System.EventHandler(this.Btn_AddSchudleWrittenTest_Click);
            // 
            // Dg_TestAppointment
            // 
            this.Dg_TestAppointment.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Dg_TestAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg_TestAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dg_TestAppointment.BackgroundColor = System.Drawing.Color.DarkGray;
            this.Dg_TestAppointment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dg_TestAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dg_TestAppointment.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Dg_TestAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_TestAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dg_TestAppointment.ColumnHeadersHeight = 56;
            this.Dg_TestAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.AppointmentDate,
            this.PaidFees,
            this.IsLocked});
            this.Dg_TestAppointment.ContextMenuStrip = this.Cms_AppMenu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_TestAppointment.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dg_TestAppointment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dg_TestAppointment.EnableHeadersVisualStyles = false;
            this.Dg_TestAppointment.GridColor = System.Drawing.Color.White;
            this.Dg_TestAppointment.Location = new System.Drawing.Point(111, 606);
            this.Dg_TestAppointment.Name = "Dg_TestAppointment";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_TestAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dg_TestAppointment.RowHeadersVisible = false;
            this.Dg_TestAppointment.RowHeadersWidth = 51;
            this.Dg_TestAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Dg_TestAppointment.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dg_TestAppointment.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dg_TestAppointment.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.Dg_TestAppointment.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dg_TestAppointment.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Dg_TestAppointment.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.Dg_TestAppointment.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Dg_TestAppointment.RowTemplate.Height = 30;
            this.Dg_TestAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_TestAppointment.Size = new System.Drawing.Size(948, 198);
            this.Dg_TestAppointment.TabIndex = 123;
            this.Dg_TestAppointment.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Dg_TestAppointment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.DimGray;
            this.Dg_TestAppointment.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dg_TestAppointment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dg_TestAppointment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dg_TestAppointment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Dg_TestAppointment.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.Dg_TestAppointment.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.Dg_TestAppointment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.Dg_TestAppointment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dg_TestAppointment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dg_TestAppointment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dg_TestAppointment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dg_TestAppointment.ThemeStyle.HeaderStyle.Height = 56;
            this.Dg_TestAppointment.ThemeStyle.ReadOnly = false;
            this.Dg_TestAppointment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dg_TestAppointment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dg_TestAppointment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dg_TestAppointment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dg_TestAppointment.ThemeStyle.RowsStyle.Height = 30;
            this.Dg_TestAppointment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.Dg_TestAppointment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // AppointmentID
            // 
            this.AppointmentID.DataPropertyName = "TestAppointmentID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            this.AppointmentID.DefaultCellStyle = dataGridViewCellStyle3;
            this.AppointmentID.FillWeight = 25.00104F;
            this.AppointmentID.HeaderText = "AppointmentID";
            this.AppointmentID.MinimumWidth = 6;
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.DataPropertyName = "AppointmentDate";
            this.AppointmentDate.FillWeight = 25.00104F;
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.MinimumWidth = 6;
            this.AppointmentDate.Name = "AppointmentDate";
            // 
            // PaidFees
            // 
            this.PaidFees.DataPropertyName = "PaidFees";
            this.PaidFees.FillWeight = 25.00104F;
            this.PaidFees.HeaderText = "Paid Fees";
            this.PaidFees.MinimumWidth = 6;
            this.PaidFees.Name = "PaidFees";
            // 
            // IsLocked
            // 
            this.IsLocked.DataPropertyName = "IsLocked";
            this.IsLocked.FillWeight = 25.00104F;
            this.IsLocked.HeaderText = "IsLocked";
            this.IsLocked.MinimumWidth = 6;
            this.IsLocked.Name = "IsLocked";
            this.IsLocked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsLocked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancel.BorderColor = System.Drawing.Color.White;
            this.Btn_Cancel.BorderRadius = 7;
            this.Btn_Cancel.BorderThickness = 1;
            this.Btn_Cancel.CheckedState.Parent = this.Btn_Cancel;
            this.Btn_Cancel.CustomImages.Parent = this.Btn_Cancel;
            this.Btn_Cancel.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Cancel.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_Cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel.HoverState.Parent = this.Btn_Cancel;
            this.Btn_Cancel.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_cancelWhite_48;
            this.Btn_Cancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Cancel.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Cancel.Location = new System.Drawing.Point(939, 825);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.ShadowDecoration.Parent = this.Btn_Cancel;
            this.Btn_Cancel.Size = new System.Drawing.Size(120, 39);
            this.Btn_Cancel.TabIndex = 122;
            this.Btn_Cancel.Text = "    Cancel";
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.BackgroundImage = global::DVLD_Full_Proj.Properties.Resources.icons8_hand_with_pen_48;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(747, 34);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(117, 70);
            this.guna2CirclePictureBox1.TabIndex = 46;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Title.Location = new System.Drawing.Point(340, 48);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(407, 46);
            this.lbl_Title.TabIndex = 45;
            this.lbl_Title.Text = "Written Test Application";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(111, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 395);
            this.panel1.TabIndex = 44;
            // 
            // Cms_AppMenu
            // 
            this.Cms_AppMenu.BackColor = System.Drawing.Color.DimGray;
            this.Cms_AppMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cms_AppMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.Cms_AppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.TakeTesttoolStripMenuItem1});
            this.Cms_AppMenu.Name = "Cms_UserMenu";
            this.Cms_AppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Cms_AppMenu.Size = new System.Drawing.Size(157, 56);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.EditToolStripMenuItem.Text = "Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // TakeTesttoolStripMenuItem1
            // 
            this.TakeTesttoolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.TakeTesttoolStripMenuItem1.Name = "TakeTesttoolStripMenuItem1";
            this.TakeTesttoolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.TakeTesttoolStripMenuItem1.Text = "Take Test";
            this.TakeTesttoolStripMenuItem1.Click += new System.EventHandler(this.TakeTesttoolStripMenuItem1_Click);
            // 
            // Frm_WriitenTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 924);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_WriitenTestAppointment";
            this.Text = "Frm_WriitenTestAppointment";
            this.Load += new System.EventHandler(this.Frm_WrittenTest_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_TestAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.Cms_AppMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox Ctrl_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Ctrl_Close;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_SchudleVisionTest;
        private Guna.UI2.WinForms.Guna2DataGridView Dg_TestAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLocked;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Cancel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip Cms_AppMenu;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TakeTesttoolStripMenuItem1;
    }
}