namespace DVLD_Full_Proj.Applications.Forms
{
    partial class Frm_EditApplicationType
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label_Id = new System.Windows.Forms.Label();
            this.Txt_ApplicationFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_ApplicationTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.Ctrl_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Ctrl_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Btn_Cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Lbl_Fees = new System.Windows.Forms.Label();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2CustomGradientPanel1;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.Btn_Cancel);
            this.guna2CustomGradientPanel1.Controls.Add(this.Btn_Save);
            this.guna2CustomGradientPanel1.Controls.Add(this.Lbl_Id);
            this.guna2CustomGradientPanel1.Controls.Add(this.label_Id);
            this.guna2CustomGradientPanel1.Controls.Add(this.Lbl_Fees);
            this.guna2CustomGradientPanel1.Controls.Add(this.Lbl_Title);
            this.guna2CustomGradientPanel1.Controls.Add(this.Txt_ApplicationFees);
            this.guna2CustomGradientPanel1.Controls.Add(this.Txt_ApplicationTitle);
            this.guna2CustomGradientPanel1.Controls.Add(this.Ctrl_Minimize);
            this.guna2CustomGradientPanel1.Controls.Add(this.Ctrl_Close);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(726, 416);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.BackColor = System.Drawing.Color.Transparent;
            this.label_Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.ForeColor = System.Drawing.Color.White;
            this.label_Id.Location = new System.Drawing.Point(308, 88);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(67, 33);
            this.label_Id.TabIndex = 164;
            this.label_Id.Text = "    ??";
            // 
            // Txt_ApplicationFees
            // 
            this.Txt_ApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.Txt_ApplicationFees.BorderRadius = 7;
            this.Txt_ApplicationFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_ApplicationFees.DefaultText = "";
            this.Txt_ApplicationFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_ApplicationFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_ApplicationFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_ApplicationFees.DisabledState.Parent = this.Txt_ApplicationFees;
            this.Txt_ApplicationFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_ApplicationFees.FillColor = System.Drawing.Color.DimGray;
            this.Txt_ApplicationFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_ApplicationFees.FocusedState.Parent = this.Txt_ApplicationFees;
            this.Txt_ApplicationFees.ForeColor = System.Drawing.Color.White;
            this.Txt_ApplicationFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_ApplicationFees.HoverState.Parent = this.Txt_ApplicationFees;
            this.Txt_ApplicationFees.Location = new System.Drawing.Point(314, 220);
            this.Txt_ApplicationFees.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Txt_ApplicationFees.Name = "Txt_ApplicationFees";
            this.Txt_ApplicationFees.PasswordChar = '\0';
            this.Txt_ApplicationFees.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_ApplicationFees.PlaceholderText = "";
            this.Txt_ApplicationFees.SelectedText = "";
            this.Txt_ApplicationFees.ShadowDecoration.Parent = this.Txt_ApplicationFees;
            this.Txt_ApplicationFees.Size = new System.Drawing.Size(214, 38);
            this.Txt_ApplicationFees.TabIndex = 161;
            // 
            // Txt_ApplicationTitle
            // 
            this.Txt_ApplicationTitle.BackColor = System.Drawing.Color.Transparent;
            this.Txt_ApplicationTitle.BorderRadius = 7;
            this.Txt_ApplicationTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_ApplicationTitle.DefaultText = "";
            this.Txt_ApplicationTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_ApplicationTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_ApplicationTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_ApplicationTitle.DisabledState.Parent = this.Txt_ApplicationTitle;
            this.Txt_ApplicationTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_ApplicationTitle.FillColor = System.Drawing.Color.DimGray;
            this.Txt_ApplicationTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_ApplicationTitle.FocusedState.Parent = this.Txt_ApplicationTitle;
            this.Txt_ApplicationTitle.ForeColor = System.Drawing.Color.White;
            this.Txt_ApplicationTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_ApplicationTitle.HoverState.Parent = this.Txt_ApplicationTitle;
            this.Txt_ApplicationTitle.Location = new System.Drawing.Point(314, 153);
            this.Txt_ApplicationTitle.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Txt_ApplicationTitle.Name = "Txt_ApplicationTitle";
            this.Txt_ApplicationTitle.PasswordChar = '\0';
            this.Txt_ApplicationTitle.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_ApplicationTitle.PlaceholderText = "";
            this.Txt_ApplicationTitle.SelectedText = "";
            this.Txt_ApplicationTitle.ShadowDecoration.Parent = this.Txt_ApplicationTitle;
            this.Txt_ApplicationTitle.Size = new System.Drawing.Size(333, 38);
            this.Txt_ApplicationTitle.TabIndex = 160;
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
            this.Ctrl_Minimize.HoverState.FillColor = System.Drawing.Color.White;
            this.Ctrl_Minimize.HoverState.IconColor = System.Drawing.Color.Black;
            this.Ctrl_Minimize.HoverState.Parent = this.Ctrl_Minimize;
            this.Ctrl_Minimize.IconColor = System.Drawing.Color.White;
            this.Ctrl_Minimize.Location = new System.Drawing.Point(650, 12);
            this.Ctrl_Minimize.Name = "Ctrl_Minimize";
            this.Ctrl_Minimize.ShadowDecoration.Parent = this.Ctrl_Minimize;
            this.Ctrl_Minimize.Size = new System.Drawing.Size(29, 23);
            this.Ctrl_Minimize.TabIndex = 117;
            // 
            // Ctrl_Close
            // 
            this.Ctrl_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ctrl_Close.BackColor = System.Drawing.Color.Transparent;
            this.Ctrl_Close.BorderColor = System.Drawing.Color.Transparent;
            this.Ctrl_Close.BorderRadius = 7;
            this.Ctrl_Close.CustomIconSize = 20F;
            this.Ctrl_Close.FillColor = System.Drawing.Color.Transparent;
            this.Ctrl_Close.HoverState.FillColor = System.Drawing.Color.White;
            this.Ctrl_Close.HoverState.IconColor = System.Drawing.Color.Black;
            this.Ctrl_Close.HoverState.Parent = this.Ctrl_Close;
            this.Ctrl_Close.IconColor = System.Drawing.Color.White;
            this.Ctrl_Close.Location = new System.Drawing.Point(685, 12);
            this.Ctrl_Close.Name = "Ctrl_Close";
            this.Ctrl_Close.ShadowDecoration.Parent = this.Ctrl_Close;
            this.Ctrl_Close.Size = new System.Drawing.Size(29, 23);
            this.Ctrl_Close.TabIndex = 118;
            // 
            // Btn_Cancel
            // 
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
            this.Btn_Cancel.Location = new System.Drawing.Point(227, 323);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.ShadowDecoration.Parent = this.Btn_Cancel;
            this.Btn_Cancel.Size = new System.Drawing.Size(120, 39);
            this.Btn_Cancel.TabIndex = 167;
            this.Btn_Cancel.Text = "    Cancel";
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BorderColor = System.Drawing.Color.White;
            this.Btn_Save.BorderRadius = 7;
            this.Btn_Save.BorderThickness = 1;
            this.Btn_Save.CheckedState.Parent = this.Btn_Save;
            this.Btn_Save.CustomImages.Parent = this.Btn_Save;
            this.Btn_Save.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Save.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.HoverState.Parent = this.Btn_Save;
            this.Btn_Save.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_save_48;
            this.Btn_Save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Save.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Save.Location = new System.Drawing.Point(382, 323);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ShadowDecoration.Parent = this.Btn_Save;
            this.Btn_Save.Size = new System.Drawing.Size(120, 39);
            this.Btn_Save.TabIndex = 166;
            this.Btn_Save.Text = "   Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id.ForeColor = System.Drawing.Color.White;
            this.Lbl_Id.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_id_32;
            this.Lbl_Id.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Id.Location = new System.Drawing.Point(179, 89);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(113, 32);
            this.Lbl_Id.TabIndex = 165;
            this.Lbl_Id.Text = "Id  :";
            this.Lbl_Id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Fees
            // 
            this.Lbl_Fees.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Fees.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fees.ForeColor = System.Drawing.Color.White;
            this.Lbl_Fees.Image = global::DVLD_Full_Proj.Properties.Resources.Fees;
            this.Lbl_Fees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Fees.Location = new System.Drawing.Point(175, 226);
            this.Lbl_Fees.Name = "Lbl_Fees";
            this.Lbl_Fees.Size = new System.Drawing.Size(117, 32);
            this.Lbl_Fees.TabIndex = 163;
            this.Lbl_Fees.Text = "Fees :";
            this.Lbl_Fees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Image = global::DVLD_Full_Proj.Properties.Resources.Title;
            this.Lbl_Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Title.Location = new System.Drawing.Point(179, 159);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(113, 32);
            this.Lbl_Title.TabIndex = 162;
            this.Lbl_Title.Text = "Title :";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm_EditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 416);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EditApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EditApplicationType";
            this.Load += new System.EventHandler(this.Frm_EditApplicationType_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox Ctrl_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Ctrl_Close;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label Lbl_Fees;
        private System.Windows.Forms.Label Lbl_Title;
        private Guna.UI2.WinForms.Guna2TextBox Txt_ApplicationFees;
        private Guna.UI2.WinForms.Guna2TextBox Txt_ApplicationTitle;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Cancel;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Save;
    }
}