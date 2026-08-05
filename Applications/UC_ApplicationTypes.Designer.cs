namespace DVLD_Full_Proj.Applications
{
    partial class UC_ApplicationTypes
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
            this.dg_ApplicationTypes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ApplicationTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cms_AppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ApplicationTypes)).BeginInit();
            this.Cms_AppMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ApplicationTypes
            // 
            this.dg_ApplicationTypes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_ApplicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_ApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_ApplicationTypes.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dg_ApplicationTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_ApplicationTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_ApplicationTypes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dg_ApplicationTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_ApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_ApplicationTypes.ColumnHeadersHeight = 56;
            this.dg_ApplicationTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationTypeID,
            this.ApplicationTypeTitle,
            this.ApplicationFees});
            this.dg_ApplicationTypes.ContextMenuStrip = this.Cms_AppMenu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_ApplicationTypes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_ApplicationTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_ApplicationTypes.EnableHeadersVisualStyles = false;
            this.dg_ApplicationTypes.GridColor = System.Drawing.Color.White;
            this.dg_ApplicationTypes.Location = new System.Drawing.Point(33, 280);
            this.dg_ApplicationTypes.Name = "dg_ApplicationTypes";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_ApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_ApplicationTypes.RowHeadersVisible = false;
            this.dg_ApplicationTypes.RowHeadersWidth = 51;
            this.dg_ApplicationTypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_ApplicationTypes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_ApplicationTypes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_ApplicationTypes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_ApplicationTypes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_ApplicationTypes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dg_ApplicationTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dg_ApplicationTypes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_ApplicationTypes.RowTemplate.Height = 30;
            this.dg_ApplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_ApplicationTypes.Size = new System.Drawing.Size(1095, 323);
            this.dg_ApplicationTypes.TabIndex = 31;
            this.dg_ApplicationTypes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg_ApplicationTypes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_ApplicationTypes.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_ApplicationTypes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_ApplicationTypes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_ApplicationTypes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_ApplicationTypes.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dg_ApplicationTypes.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dg_ApplicationTypes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.dg_ApplicationTypes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_ApplicationTypes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_ApplicationTypes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_ApplicationTypes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_ApplicationTypes.ThemeStyle.HeaderStyle.Height = 56;
            this.dg_ApplicationTypes.ThemeStyle.ReadOnly = false;
            this.dg_ApplicationTypes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_ApplicationTypes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_ApplicationTypes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_ApplicationTypes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dg_ApplicationTypes.ThemeStyle.RowsStyle.Height = 30;
            this.dg_ApplicationTypes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dg_ApplicationTypes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ApplicationTypeID
            // 
            this.ApplicationTypeID.DataPropertyName = "ApplicationTypeID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            this.ApplicationTypeID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ApplicationTypeID.FillWeight = 25.00104F;
            this.ApplicationTypeID.HeaderText = "ApplicationId";
            this.ApplicationTypeID.MinimumWidth = 6;
            this.ApplicationTypeID.Name = "ApplicationTypeID";
            this.ApplicationTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ApplicationTypeTitle
            // 
            this.ApplicationTypeTitle.DataPropertyName = "ApplicationTypeTitle";
            this.ApplicationTypeTitle.FillWeight = 25.00104F;
            this.ApplicationTypeTitle.HeaderText = "Application Title";
            this.ApplicationTypeTitle.MinimumWidth = 6;
            this.ApplicationTypeTitle.Name = "ApplicationTypeTitle";
            // 
            // ApplicationFees
            // 
            this.ApplicationFees.DataPropertyName = "ApplicationFees";
            this.ApplicationFees.FillWeight = 25.00104F;
            this.ApplicationFees.HeaderText = "Application Fees";
            this.ApplicationFees.MinimumWidth = 6;
            this.ApplicationFees.Name = "ApplicationFees";
            // 
            // Cms_AppMenu
            // 
            this.Cms_AppMenu.BackColor = System.Drawing.Color.DimGray;
            this.Cms_AppMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cms_AppMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.Cms_AppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateToolStripMenuItem});
            this.Cms_AppMenu.Name = "Cms_UserMenu";
            this.Cms_AppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Cms_AppMenu.Size = new System.Drawing.Size(211, 58);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.UpdateToolStripMenuItem.Text = "Edit";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Title.Location = new System.Drawing.Point(314, 120);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(307, 46);
            this.lbl_Title.TabIndex = 40;
            this.lbl_Title.Text = "Application Types";
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
            this.Btn_Close.Location = new System.Drawing.Point(48, 667);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.ShadowDecoration.Parent = this.Btn_Close;
            this.Btn_Close.Size = new System.Drawing.Size(120, 39);
            this.Btn_Close.TabIndex = 168;
            this.Btn_Close.Text = "   Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackgroundImage = global::DVLD_Full_Proj.Properties.Resources.icons8_applications_48;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(627, 91);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(121, 84);
            this.guna2CirclePictureBox1.TabIndex = 41;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UC_ApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dg_ApplicationTypes);
            this.Name = "UC_ApplicationTypes";
            this.Size = new System.Drawing.Size(1184, 735);
            this.Load += new System.EventHandler(this.UC_ApplicationMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ApplicationTypes)).EndInit();
            this.Cms_AppMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dg_ApplicationTypes;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationFees;
        private System.Windows.Forms.ContextMenuStrip Cms_AppMenu;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
    }
}
