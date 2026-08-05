namespace DVLD_Full_Proj.TestTypes
{
    partial class UC_TestTypes
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.dg_TestTypes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ApplicationTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cms_TestsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_TestTypes)).BeginInit();
            this.Cms_TestsMenu.SuspendLayout();
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
            this.lbl_Title.Location = new System.Drawing.Point(390, 99);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(184, 46);
            this.lbl_Title.TabIndex = 170;
            this.lbl_Title.Text = "Test Types";
            // 
            // dg_TestTypes
            // 
            this.dg_TestTypes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_TestTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_TestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_TestTypes.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dg_TestTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_TestTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_TestTypes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dg_TestTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_TestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_TestTypes.ColumnHeadersHeight = 56;
            this.dg_TestTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationTypeID,
            this.ApplicationTypeTitle,
            this.TestTypeDescription,
            this.ApplicationFees});
            this.dg_TestTypes.ContextMenuStrip = this.Cms_TestsMenu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_TestTypes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_TestTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_TestTypes.EnableHeadersVisualStyles = false;
            this.dg_TestTypes.GridColor = System.Drawing.Color.White;
            this.dg_TestTypes.Location = new System.Drawing.Point(32, 262);
            this.dg_TestTypes.Name = "dg_TestTypes";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_TestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_TestTypes.RowHeadersVisible = false;
            this.dg_TestTypes.RowHeadersWidth = 51;
            this.dg_TestTypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_TestTypes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_TestTypes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_TestTypes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_TestTypes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_TestTypes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dg_TestTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dg_TestTypes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_TestTypes.RowTemplate.Height = 30;
            this.dg_TestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_TestTypes.Size = new System.Drawing.Size(1095, 323);
            this.dg_TestTypes.TabIndex = 169;
            this.dg_TestTypes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg_TestTypes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_TestTypes.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_TestTypes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_TestTypes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_TestTypes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_TestTypes.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dg_TestTypes.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dg_TestTypes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_TestTypes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_TestTypes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_TestTypes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_TestTypes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_TestTypes.ThemeStyle.HeaderStyle.Height = 56;
            this.dg_TestTypes.ThemeStyle.ReadOnly = false;
            this.dg_TestTypes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_TestTypes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_TestTypes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_TestTypes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_TestTypes.ThemeStyle.RowsStyle.Height = 30;
            this.dg_TestTypes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dg_TestTypes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ApplicationTypeID
            // 
            this.ApplicationTypeID.DataPropertyName = "TestTypeID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            this.ApplicationTypeID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ApplicationTypeID.FillWeight = 25.00104F;
            this.ApplicationTypeID.HeaderText = "TestTypeID";
            this.ApplicationTypeID.MinimumWidth = 6;
            this.ApplicationTypeID.Name = "ApplicationTypeID";
            this.ApplicationTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ApplicationTypeTitle
            // 
            this.ApplicationTypeTitle.DataPropertyName = "TestTypeTitle";
            this.ApplicationTypeTitle.FillWeight = 25.00104F;
            this.ApplicationTypeTitle.HeaderText = "TestTypeTitle";
            this.ApplicationTypeTitle.MinimumWidth = 6;
            this.ApplicationTypeTitle.Name = "ApplicationTypeTitle";
            // 
            // TestTypeDescription
            // 
            this.TestTypeDescription.DataPropertyName = "TestTypeDescription";
            this.TestTypeDescription.HeaderText = "TestTypeDescription";
            this.TestTypeDescription.MinimumWidth = 6;
            this.TestTypeDescription.Name = "TestTypeDescription";
            // 
            // ApplicationFees
            // 
            this.ApplicationFees.DataPropertyName = "TestTypeFees";
            this.ApplicationFees.FillWeight = 25.00104F;
            this.ApplicationFees.HeaderText = "TestTypeFees";
            this.ApplicationFees.MinimumWidth = 6;
            this.ApplicationFees.Name = "ApplicationFees";
            // 
            // Cms_TestsMenu
            // 
            this.Cms_TestsMenu.BackColor = System.Drawing.Color.DimGray;
            this.Cms_TestsMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cms_TestsMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.Cms_TestsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateToolStripMenuItem});
            this.Cms_TestsMenu.Name = "Cms_UserMenu";
            this.Cms_TestsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Cms_TestsMenu.Size = new System.Drawing.Size(114, 30);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.UpdateToolStripMenuItem.Text = "Edit";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BorderColor = System.Drawing.Color.White;
            this.Btn_Close.BorderRadius = 7;
            this.Btn_Close.BorderThickness = 1;
            this.Btn_Close.CheckedState.Parent = this.Btn_Close;
            this.Btn_Close.CustomImages.Parent = this.Btn_Close;
            this.Btn_Close.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Close.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.HoverState.Parent = this.Btn_Close;
            this.Btn_Close.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_cancelWhite_48;
            this.Btn_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Close.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Close.Location = new System.Drawing.Point(47, 649);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.ShadowDecoration.Parent = this.Btn_Close;
            this.Btn_Close.Size = new System.Drawing.Size(120, 39);
            this.Btn_Close.TabIndex = 172;
            this.Btn_Close.Text = "   Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackgroundImage = global::DVLD_Full_Proj.Properties.Resources.TestTypes;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(603, 75);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(121, 84);
            this.guna2CirclePictureBox1.TabIndex = 171;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UC_TestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dg_TestTypes);
            this.Name = "UC_TestTypes";
            this.Size = new System.Drawing.Size(1160, 867);
            this.Load += new System.EventHandler(this.UC_TestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_TestTypes)).EndInit();
            this.Cms_TestsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2DataGridView dg_TestTypes;
        private System.Windows.Forms.ContextMenuStrip Cms_TestsMenu;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestTypeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationFees;
    }
}
