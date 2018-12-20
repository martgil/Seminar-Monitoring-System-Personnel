namespace Capstone.Personnel.Actions
{
    partial class uRegister
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
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.UniHelper = new System.Windows.Forms.Panel();
            this.CollegeCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.CourseCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.LevelCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SectionCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.Balance = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PaymentCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.MiddleInitial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterPanel.SuspendLayout();
            this.UniHelper.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackColor = System.Drawing.Color.White;
            this.RegisterPanel.Controls.Add(this.UniHelper);
            this.RegisterPanel.Controls.Add(this.Balance);
            this.RegisterPanel.Controls.Add(this.label11);
            this.RegisterPanel.Controls.Add(this.label10);
            this.RegisterPanel.Controls.Add(this.PaymentCombo);
            this.RegisterPanel.Controls.Add(this.MiddleInitial);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.LastName);
            this.RegisterPanel.Controls.Add(this.label3);
            this.RegisterPanel.Controls.Add(this.FirstName);
            this.RegisterPanel.Controls.Add(this.bunifuFlatButton1);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.bunifuCheckbox1);
            this.RegisterPanel.Controls.Add(this.label2);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.ForeColor = System.Drawing.Color.White;
            this.RegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(1051, 673);
            this.RegisterPanel.TabIndex = 0;
            // 
            // UniHelper
            // 
            this.UniHelper.Controls.Add(this.CollegeCombo);
            this.UniHelper.Controls.Add(this.label6);
            this.UniHelper.Controls.Add(this.CourseCombo);
            this.UniHelper.Controls.Add(this.label7);
            this.UniHelper.Controls.Add(this.LevelCombo);
            this.UniHelper.Controls.Add(this.label9);
            this.UniHelper.Controls.Add(this.label8);
            this.UniHelper.Controls.Add(this.SectionCombo);
            this.UniHelper.Location = new System.Drawing.Point(159, 331);
            this.UniHelper.Name = "UniHelper";
            this.UniHelper.Size = new System.Drawing.Size(730, 100);
            this.UniHelper.TabIndex = 40;
            this.UniHelper.Visible = false;
            // 
            // CollegeCombo
            // 
            this.CollegeCombo.BackColor = System.Drawing.Color.Transparent;
            this.CollegeCombo.BorderRadius = 3;
            this.CollegeCombo.DisabledColor = System.Drawing.Color.Gray;
            this.CollegeCombo.ForeColor = System.Drawing.Color.White;
            this.CollegeCombo.Items = new string[0];
            this.CollegeCombo.Location = new System.Drawing.Point(29, 43);
            this.CollegeCombo.Name = "CollegeCombo";
            this.CollegeCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CollegeCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CollegeCombo.selectedIndex = -1;
            this.CollegeCombo.Size = new System.Drawing.Size(262, 35);
            this.CollegeCombo.TabIndex = 30;
            this.CollegeCombo.onItemSelected += new System.EventHandler(this.CollegeCombo_onItemSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label6.Location = new System.Drawing.Point(44, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "College";
            // 
            // CourseCombo
            // 
            this.CourseCombo.BackColor = System.Drawing.Color.Transparent;
            this.CourseCombo.BorderRadius = 3;
            this.CourseCombo.DisabledColor = System.Drawing.Color.Gray;
            this.CourseCombo.ForeColor = System.Drawing.Color.White;
            this.CourseCombo.Items = new string[0];
            this.CourseCombo.Location = new System.Drawing.Point(297, 43);
            this.CourseCombo.Name = "CourseCombo";
            this.CourseCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CourseCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CourseCombo.selectedIndex = -1;
            this.CourseCombo.Size = new System.Drawing.Size(251, 35);
            this.CourseCombo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label7.Location = new System.Drawing.Point(307, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Course";
            // 
            // LevelCombo
            // 
            this.LevelCombo.BackColor = System.Drawing.Color.Transparent;
            this.LevelCombo.BorderRadius = 3;
            this.LevelCombo.DisabledColor = System.Drawing.Color.Gray;
            this.LevelCombo.ForeColor = System.Drawing.Color.White;
            this.LevelCombo.Items = new string[] {
        "1st",
        "2nd",
        "3rd",
        "4th",
        "5th"};
            this.LevelCombo.Location = new System.Drawing.Point(554, 43);
            this.LevelCombo.Name = "LevelCombo";
            this.LevelCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.LevelCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.LevelCombo.selectedIndex = -1;
            this.LevelCombo.Size = new System.Drawing.Size(74, 35);
            this.LevelCombo.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label9.Location = new System.Drawing.Point(644, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label8.Location = new System.Drawing.Point(564, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Level";
            // 
            // SectionCombo
            // 
            this.SectionCombo.BackColor = System.Drawing.Color.Transparent;
            this.SectionCombo.BorderRadius = 3;
            this.SectionCombo.DisabledColor = System.Drawing.Color.Gray;
            this.SectionCombo.ForeColor = System.Drawing.Color.White;
            this.SectionCombo.Items = new string[] {
        "A",
        "B",
        "C",
        "D",
        "E",
        "F",
        "G",
        "H",
        "I",
        "J",
        "K",
        "L",
        "M",
        "N",
        "O",
        "P",
        "Q",
        "R",
        "S",
        "T",
        "U",
        "V",
        "W",
        "X",
        "Y",
        "Z"};
            this.SectionCombo.Location = new System.Drawing.Point(634, 43);
            this.SectionCombo.Name = "SectionCombo";
            this.SectionCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SectionCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SectionCombo.selectedIndex = -1;
            this.SectionCombo.Size = new System.Drawing.Size(74, 35);
            this.SectionCombo.TabIndex = 34;
            // 
            // Balance
            // 
            this.Balance.BorderColorFocused = System.Drawing.Color.Blue;
            this.Balance.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Balance.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Balance.BorderThickness = 3;
            this.Balance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Balance.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Balance.isPassword = false;
            this.Balance.Location = new System.Drawing.Point(704, 147);
            this.Balance.Margin = new System.Windows.Forms.Padding(4);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(154, 44);
            this.Balance.TabIndex = 39;
            this.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label11.Location = new System.Drawing.Point(625, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 38;
            this.label11.Text = "Payment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label10.Location = new System.Drawing.Point(255, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 37;
            this.label10.Text = "Ticket Cost";
            // 
            // PaymentCombo
            // 
            this.PaymentCombo.BackColor = System.Drawing.Color.Transparent;
            this.PaymentCombo.BorderRadius = 3;
            this.PaymentCombo.DisabledColor = System.Drawing.Color.Gray;
            this.PaymentCombo.ForeColor = System.Drawing.Color.White;
            this.PaymentCombo.Items = new string[0];
            this.PaymentCombo.Location = new System.Drawing.Point(349, 156);
            this.PaymentCombo.Name = "PaymentCombo";
            this.PaymentCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PaymentCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PaymentCombo.selectedIndex = -1;
            this.PaymentCombo.Size = new System.Drawing.Size(262, 35);
            this.PaymentCombo.TabIndex = 36;
            // 
            // MiddleInitial
            // 
            this.MiddleInitial.BorderColorFocused = System.Drawing.Color.Blue;
            this.MiddleInitial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MiddleInitial.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.MiddleInitial.BorderThickness = 3;
            this.MiddleInitial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MiddleInitial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MiddleInitial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MiddleInitial.isPassword = false;
            this.MiddleInitial.Location = new System.Drawing.Point(447, 248);
            this.MiddleInitial.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleInitial.Name = "MiddleInitial";
            this.MiddleInitial.Size = new System.Drawing.Size(174, 44);
            this.MiddleInitial.TabIndex = 29;
            this.MiddleInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(443, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Middle Initial";
            // 
            // LastName
            // 
            this.LastName.BorderColorFocused = System.Drawing.Color.Blue;
            this.LastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.LastName.BorderThickness = 3;
            this.LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastName.isPassword = false;
            this.LastName.Location = new System.Drawing.Point(629, 248);
            this.LastName.Margin = new System.Windows.Forms.Padding(4);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(228, 44);
            this.LastName.TabIndex = 27;
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(638, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.BorderColorFocused = System.Drawing.Color.Blue;
            this.FirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.FirstName.BorderThickness = 3;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstName.isPassword = false;
            this.FirstName.Location = new System.Drawing.Point(179, 248);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(262, 44);
            this.FirstName.TabIndex = 25;
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "NEXT";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(181, 486);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(691, 46);
            this.bunifuFlatButton1.TabIndex = 24;
            this.bunifuFlatButton1.Text = "NEXT";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(155, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Student";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(225, 162);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 20;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(194, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(427, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Register Attendee";
            // 
            // uRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.RegisterPanel);
            this.Name = "uRegister";
            this.Size = new System.Drawing.Size(1051, 673);
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.UniHelper.ResumeLayout(false);
            this.UniHelper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterPanel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox FirstName;
        private Bunifu.Framework.UI.BunifuMetroTextbox MiddleInitial;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDropdown SectionCombo;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDropdown LevelCombo;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDropdown CourseCombo;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDropdown CollegeCombo;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuDropdown PaymentCombo;
        private Bunifu.Framework.UI.BunifuMetroTextbox Balance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel UniHelper;
    }
}
