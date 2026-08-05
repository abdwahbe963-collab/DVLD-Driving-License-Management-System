namespace DVLD_Full_Proj.Users
{
    partial class UC_ChangeUserPassword
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
            this.lbl_ConfirmPass = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_ConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_NewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_CurrentPassword = new System.Windows.Forms.Label();
            this.Txt_CurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_Cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uC_ShowUserInfo1 = new DVLD_Full_Proj.Users.UC_ShowUserInfo();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ConfirmPass
            // 
            this.lbl_ConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ConfirmPass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmPass.ForeColor = System.Drawing.Color.White;
            this.lbl_ConfirmPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ConfirmPass.Location = new System.Drawing.Point(741, 626);
            this.lbl_ConfirmPass.Name = "lbl_ConfirmPass";
            this.lbl_ConfirmPass.Size = new System.Drawing.Size(194, 32);
            this.lbl_ConfirmPass.TabIndex = 119;
            this.lbl_ConfirmPass.Text = "Confirm pass :";
            this.lbl_ConfirmPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Password.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Password.ForeColor = System.Drawing.Color.White;
            this.Lbl_Password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Password.Location = new System.Drawing.Point(415, 626);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(130, 32);
            this.Lbl_Password.TabIndex = 118;
            this.Lbl_Password.Text = "Newpass:";
            this.Lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_ConfirmPassword
            // 
            this.Txt_ConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.Txt_ConfirmPassword.BorderRadius = 7;
            this.Txt_ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_ConfirmPassword.DefaultText = "";
            this.Txt_ConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_ConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_ConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_ConfirmPassword.DisabledState.Parent = this.Txt_ConfirmPassword;
            this.Txt_ConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_ConfirmPassword.FillColor = System.Drawing.Color.DimGray;
            this.Txt_ConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_ConfirmPassword.FocusedState.Parent = this.Txt_ConfirmPassword;
            this.Txt_ConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.Txt_ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_ConfirmPassword.HoverState.Parent = this.Txt_ConfirmPassword;
            this.Txt_ConfirmPassword.Location = new System.Drawing.Point(939, 622);
            this.Txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Txt_ConfirmPassword.Name = "Txt_ConfirmPassword";
            this.Txt_ConfirmPassword.PasswordChar = '\0';
            this.Txt_ConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_ConfirmPassword.PlaceholderText = "";
            this.Txt_ConfirmPassword.SelectedText = "";
            this.Txt_ConfirmPassword.ShadowDecoration.Parent = this.Txt_ConfirmPassword;
            this.Txt_ConfirmPassword.Size = new System.Drawing.Size(165, 36);
            this.Txt_ConfirmPassword.TabIndex = 117;
            this.Txt_ConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // Txt_NewPassword
            // 
            this.Txt_NewPassword.BackColor = System.Drawing.Color.Transparent;
            this.Txt_NewPassword.BorderRadius = 7;
            this.Txt_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_NewPassword.DefaultText = "";
            this.Txt_NewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_NewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_NewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_NewPassword.DisabledState.Parent = this.Txt_NewPassword;
            this.Txt_NewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_NewPassword.FillColor = System.Drawing.Color.DimGray;
            this.Txt_NewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_NewPassword.FocusedState.Parent = this.Txt_NewPassword;
            this.Txt_NewPassword.ForeColor = System.Drawing.Color.White;
            this.Txt_NewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_NewPassword.HoverState.Parent = this.Txt_NewPassword;
            this.Txt_NewPassword.Location = new System.Drawing.Point(558, 622);
            this.Txt_NewPassword.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Txt_NewPassword.Name = "Txt_NewPassword";
            this.Txt_NewPassword.PasswordChar = '\0';
            this.Txt_NewPassword.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_NewPassword.PlaceholderText = "";
            this.Txt_NewPassword.SelectedText = "";
            this.Txt_NewPassword.ShadowDecoration.Parent = this.Txt_NewPassword;
            this.Txt_NewPassword.Size = new System.Drawing.Size(170, 36);
            this.Txt_NewPassword.TabIndex = 116;
            this.Txt_NewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // lbl_CurrentPassword
            // 
            this.lbl_CurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentPassword.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPassword.ForeColor = System.Drawing.Color.White;
            this.lbl_CurrentPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_CurrentPassword.Location = new System.Drawing.Point(20, 616);
            this.lbl_CurrentPassword.Name = "lbl_CurrentPassword";
            this.lbl_CurrentPassword.Size = new System.Drawing.Size(187, 52);
            this.lbl_CurrentPassword.TabIndex = 121;
            this.lbl_CurrentPassword.Text = "Current Pass:";
            this.lbl_CurrentPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_CurrentPassword
            // 
            this.Txt_CurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.Txt_CurrentPassword.BorderRadius = 7;
            this.Txt_CurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_CurrentPassword.DefaultText = "";
            this.Txt_CurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_CurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_CurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_CurrentPassword.DisabledState.Parent = this.Txt_CurrentPassword;
            this.Txt_CurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_CurrentPassword.FillColor = System.Drawing.Color.DimGray;
            this.Txt_CurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_CurrentPassword.FocusedState.Parent = this.Txt_CurrentPassword;
            this.Txt_CurrentPassword.ForeColor = System.Drawing.Color.White;
            this.Txt_CurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_CurrentPassword.HoverState.Parent = this.Txt_CurrentPassword;
            this.Txt_CurrentPassword.Location = new System.Drawing.Point(220, 622);
            this.Txt_CurrentPassword.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Txt_CurrentPassword.Name = "Txt_CurrentPassword";
            this.Txt_CurrentPassword.PasswordChar = '\0';
            this.Txt_CurrentPassword.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_CurrentPassword.PlaceholderText = "";
            this.Txt_CurrentPassword.SelectedText = "";
            this.Txt_CurrentPassword.ShadowDecoration.Parent = this.Txt_CurrentPassword;
            this.Txt_CurrentPassword.Size = new System.Drawing.Size(170, 36);
            this.Txt_CurrentPassword.TabIndex = 120;
            this.Txt_CurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
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
            this.Btn_Cancel.Location = new System.Drawing.Point(376, 721);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.ShadowDecoration.Parent = this.Btn_Cancel;
            this.Btn_Cancel.Size = new System.Drawing.Size(120, 39);
            this.Btn_Cancel.TabIndex = 123;
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
            this.Btn_Save.Location = new System.Drawing.Point(578, 721);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ShadowDecoration.Parent = this.Btn_Save;
            this.Btn_Save.Size = new System.Drawing.Size(120, 39);
            this.Btn_Save.TabIndex = 122;
            this.Btn_Save.Text = "   Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uC_ShowUserInfo1
            // 
            this.uC_ShowUserInfo1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ShowUserInfo1.Location = new System.Drawing.Point(0, -43);
            this.uC_ShowUserInfo1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uC_ShowUserInfo1.Name = "uC_ShowUserInfo1";
            this.uC_ShowUserInfo1.Size = new System.Drawing.Size(1119, 629);
            this.uC_ShowUserInfo1.TabIndex = 0;
            // 
            // UC_ChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.lbl_CurrentPassword);
            this.Controls.Add(this.Txt_CurrentPassword);
            this.Controls.Add(this.lbl_ConfirmPass);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Txt_ConfirmPassword);
            this.Controls.Add(this.Txt_NewPassword);
            this.Controls.Add(this.uC_ShowUserInfo1);
            this.Name = "UC_ChangeUserPassword";
            this.Size = new System.Drawing.Size(1143, 791);
            this.Load += new System.EventHandler(this.UC_ChangeUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_ShowUserInfo uC_ShowUserInfo1;
        private System.Windows.Forms.Label lbl_ConfirmPass;
        private System.Windows.Forms.Label Lbl_Password;
        private Guna.UI2.WinForms.Guna2TextBox Txt_ConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox Txt_NewPassword;
        private System.Windows.Forms.Label lbl_CurrentPassword;
        private Guna.UI2.WinForms.Guna2TextBox Txt_CurrentPassword;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Cancel;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
