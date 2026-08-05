namespace DVLD_Full_Proj.Drivers.Controls
{
    partial class UC_ShowDraivers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.Cb_FilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Records = new System.Windows.Forms.Label();
            this.dg_Drivers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Txt_FillterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_Back = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Drivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Title.Location = new System.Drawing.Point(326, 61);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(337, 46);
            this.lbl_Title.TabIndex = 136;
            this.lbl_Title.Text = "Drivers Mangments";
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Filter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filter.ForeColor = System.Drawing.Color.White;
            this.lbl_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Filter.Location = new System.Drawing.Point(186, 191);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(105, 52);
            this.lbl_Filter.TabIndex = 135;
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
            "Driverid",
            "Personid",
            "National No",
            "FullName"});
            this.Cb_FilterBy.ItemsAppearance.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Location = new System.Drawing.Point(297, 190);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.ShadowDecoration.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Size = new System.Drawing.Size(208, 36);
            this.Cb_FilterBy.TabIndex = 134;
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cb_FilterBy_SelectedIndexChanged);
            // 
            // lbl_Records
            // 
            this.lbl_Records.AutoSize = true;
            this.lbl_Records.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Records.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Records.ForeColor = System.Drawing.Color.White;
            this.lbl_Records.Location = new System.Drawing.Point(131, 633);
            this.lbl_Records.Name = "lbl_Records";
            this.lbl_Records.Size = new System.Drawing.Size(67, 26);
            this.lbl_Records.TabIndex = 133;
            this.lbl_Records.Text = "label1";
            // 
            // dg_Drivers
            // 
            this.dg_Drivers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Drivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Drivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Drivers.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dg_Drivers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_Drivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_Drivers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dg_Drivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Drivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Drivers.ColumnHeadersHeight = 56;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Drivers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_Drivers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Drivers.EnableHeadersVisualStyles = false;
            this.dg_Drivers.GridColor = System.Drawing.Color.White;
            this.dg_Drivers.Location = new System.Drawing.Point(59, 263);
            this.dg_Drivers.Name = "dg_Drivers";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Drivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_Drivers.RowHeadersVisible = false;
            this.dg_Drivers.RowHeadersWidth = 51;
            this.dg_Drivers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Drivers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_Drivers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_Drivers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_Drivers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_Drivers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dg_Drivers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dg_Drivers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Drivers.RowTemplate.Height = 30;
            this.dg_Drivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Drivers.Size = new System.Drawing.Size(1012, 323);
            this.dg_Drivers.TabIndex = 132;
            this.dg_Drivers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg_Drivers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_Drivers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_Drivers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_Drivers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_Drivers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Drivers.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dg_Drivers.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dg_Drivers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_Drivers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_Drivers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_Drivers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_Drivers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_Drivers.ThemeStyle.HeaderStyle.Height = 56;
            this.dg_Drivers.ThemeStyle.ReadOnly = false;
            this.dg_Drivers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_Drivers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_Drivers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_Drivers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_Drivers.ThemeStyle.RowsStyle.Height = 30;
            this.dg_Drivers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dg_Drivers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.BackgroundImage = global::DVLD_Full_Proj.Properties.Resources.icons8_steering_wheel_50;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(669, 27);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(138, 107);
            this.guna2CirclePictureBox1.TabIndex = 137;
            this.guna2CirclePictureBox1.TabStop = false;
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
            this.Txt_FillterBy.Location = new System.Drawing.Point(537, 190);
            this.Txt_FillterBy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Txt_FillterBy.Name = "Txt_FillterBy";
            this.Txt_FillterBy.PasswordChar = '\0';
            this.Txt_FillterBy.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_FillterBy.PlaceholderText = "";
            this.Txt_FillterBy.SelectedText = "";
            this.Txt_FillterBy.ShadowDecoration.Parent = this.Txt_FillterBy;
            this.Txt_FillterBy.Size = new System.Drawing.Size(219, 35);
            this.Txt_FillterBy.TabIndex = 138;
            this.Txt_FillterBy.TextChanged += new System.EventHandler(this.Txt_FillterBy_TextChanged);
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
            this.Btn_Back.Location = new System.Drawing.Point(979, 613);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.ShadowDecoration.Parent = this.Btn_Back;
            this.Btn_Back.Size = new System.Drawing.Size(92, 70);
            this.Btn_Back.TabIndex = 139;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // UC_ShowDraivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Txt_FillterBy);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.Cb_FilterBy);
            this.Controls.Add(this.lbl_Records);
            this.Controls.Add(this.dg_Drivers);
            this.Name = "UC_ShowDraivers";
            this.Size = new System.Drawing.Size(1141, 721);
            this.Load += new System.EventHandler(this.UC_ShowDraivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Drivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Filter;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_FilterBy;
        private System.Windows.Forms.Label lbl_Records;
        private Guna.UI2.WinForms.Guna2DataGridView dg_Drivers;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox Txt_FillterBy;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Back;
    }
}
