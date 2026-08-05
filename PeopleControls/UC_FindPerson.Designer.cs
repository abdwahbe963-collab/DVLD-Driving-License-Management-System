namespace DVLD_Full_Proj.PeopleControls
{
    partial class UC_FindPerson
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Gp_Fillter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Btn_FindPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_People = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Txt_FillterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.Cb_FilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.uC_SmalPersonInfo1 = new DVLD_Full_Proj.PeopleControls.UC_SmalPersonInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Gp_Fillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gp_Fillter
            // 
            this.Gp_Fillter.BorderThickness = 0;
            this.Gp_Fillter.Controls.Add(this.Btn_FindPerson);
            this.Gp_Fillter.Controls.Add(this.Btn_People);
            this.Gp_Fillter.Controls.Add(this.Txt_FillterBy);
            this.Gp_Fillter.Controls.Add(this.lbl_Filter);
            this.Gp_Fillter.Controls.Add(this.Cb_FilterBy);
            this.Gp_Fillter.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Gp_Fillter.FillColor = System.Drawing.Color.Transparent;
            this.Gp_Fillter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Gp_Fillter.ForeColor = System.Drawing.Color.White;
            this.Gp_Fillter.Location = new System.Drawing.Point(48, 3);
            this.Gp_Fillter.Name = "Gp_Fillter";
            this.Gp_Fillter.ShadowDecoration.Parent = this.Gp_Fillter;
            this.Gp_Fillter.Size = new System.Drawing.Size(835, 116);
            this.Gp_Fillter.TabIndex = 30;
            this.Gp_Fillter.Text = "Fillter";
            this.Gp_Fillter.Click += new System.EventHandler(this.Gp_Fillter_Click);
            // 
            // Btn_FindPerson
            // 
            this.Btn_FindPerson.BackColor = System.Drawing.Color.Transparent;
            this.Btn_FindPerson.BorderColor = System.Drawing.Color.White;
            this.Btn_FindPerson.BorderRadius = 7;
            this.Btn_FindPerson.CheckedState.Parent = this.Btn_FindPerson;
            this.Btn_FindPerson.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Btn_FindPerson.CustomImages.Parent = this.Btn_FindPerson;
            this.Btn_FindPerson.FillColor = System.Drawing.Color.Transparent;
            this.Btn_FindPerson.FillColor2 = System.Drawing.Color.Transparent;
            this.Btn_FindPerson.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FindPerson.ForeColor = System.Drawing.Color.White;
            this.Btn_FindPerson.HoverState.Parent = this.Btn_FindPerson;
            this.Btn_FindPerson.Image = global::DVLD_Full_Proj.Properties.Resources.icons8_find_user_48;
            this.Btn_FindPerson.ImageSize = new System.Drawing.Size(55, 55);
            this.Btn_FindPerson.Location = new System.Drawing.Point(577, 41);
            this.Btn_FindPerson.Name = "Btn_FindPerson";
            this.Btn_FindPerson.PressedColor = System.Drawing.Color.Transparent;
            this.Btn_FindPerson.ShadowDecoration.Parent = this.Btn_FindPerson;
            this.Btn_FindPerson.Size = new System.Drawing.Size(81, 62);
            this.Btn_FindPerson.TabIndex = 39;
            this.Btn_FindPerson.Click += new System.EventHandler(this.Btn_FindPerson_Click);
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
            this.Btn_People.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_People.Location = new System.Drawing.Point(655, 41);
            this.Btn_People.Name = "Btn_People";
            this.Btn_People.PressedColor = System.Drawing.Color.Transparent;
            this.Btn_People.ShadowDecoration.Parent = this.Btn_People;
            this.Btn_People.Size = new System.Drawing.Size(81, 62);
            this.Btn_People.TabIndex = 38;
            this.Btn_People.Click += new System.EventHandler(this.Btn_AddPerson_Click);
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
            this.Txt_FillterBy.Location = new System.Drawing.Point(350, 50);
            this.Txt_FillterBy.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Txt_FillterBy.Name = "Txt_FillterBy";
            this.Txt_FillterBy.PasswordChar = '\0';
            this.Txt_FillterBy.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Txt_FillterBy.PlaceholderText = "";
            this.Txt_FillterBy.SelectedText = "";
            this.Txt_FillterBy.ShadowDecoration.Parent = this.Txt_FillterBy;
            this.Txt_FillterBy.Size = new System.Drawing.Size(214, 38);
            this.Txt_FillterBy.TabIndex = 37;
            this.Txt_FillterBy.TextChanged += new System.EventHandler(this.Txt_FillterBy_TextChanged);
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Filter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filter.ForeColor = System.Drawing.Color.White;
            this.lbl_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Filter.Location = new System.Drawing.Point(18, 51);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(105, 52);
            this.lbl_Filter.TabIndex = 36;
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
            "Personid",
            "National No"});
            this.Cb_FilterBy.ItemsAppearance.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Location = new System.Drawing.Point(129, 50);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.ShadowDecoration.Parent = this.Cb_FilterBy;
            this.Cb_FilterBy.Size = new System.Drawing.Size(208, 36);
            this.Cb_FilterBy.TabIndex = 35;
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cb_FilterBy_SelectedIndexChanged);
            // 
            // uC_SmalPersonInfo1
            // 
            this.uC_SmalPersonInfo1.BackColor = System.Drawing.Color.Transparent;
            this.uC_SmalPersonInfo1.Location = new System.Drawing.Point(12, 113);
            this.uC_SmalPersonInfo1.Name = "uC_SmalPersonInfo1";
            this.uC_SmalPersonInfo1.Size = new System.Drawing.Size(932, 413);
            this.uC_SmalPersonInfo1.TabIndex = 29;
            this.uC_SmalPersonInfo1.Load += new System.EventHandler(this.uC_SmalPersonInfo1_Load);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_FindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Gp_Fillter);
            this.Controls.Add(this.uC_SmalPersonInfo1);
            this.Name = "UC_FindPerson";
            this.Size = new System.Drawing.Size(924, 554);
            this.Load += new System.EventHandler(this.UC_FindPerson_Load);
            this.Gp_Fillter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private UC_SmalPersonInfo uC_SmalPersonInfo1;
        private Guna.UI2.WinForms.Guna2GroupBox Gp_Fillter;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_FindPerson;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_People;
        private Guna.UI2.WinForms.Guna2TextBox Txt_FillterBy;
        private System.Windows.Forms.Label lbl_Filter;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_FilterBy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
