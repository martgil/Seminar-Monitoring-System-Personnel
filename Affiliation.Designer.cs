namespace Capstone.Personnel
{
    partial class Affiliation
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
            this.Update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.AffiliationText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update.BorderRadius = 0;
            this.Update.ButtonText = "Update Affiliation";
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.DisabledColor = System.Drawing.Color.Gray;
            this.Update.Iconcolor = System.Drawing.Color.Transparent;
            this.Update.Iconimage = null;
            this.Update.Iconimage_right = null;
            this.Update.Iconimage_right_Selected = null;
            this.Update.Iconimage_Selected = null;
            this.Update.IconMarginLeft = 0;
            this.Update.IconMarginRight = 0;
            this.Update.IconRightVisible = true;
            this.Update.IconRightZoom = 0D;
            this.Update.IconVisible = true;
            this.Update.IconZoom = 90D;
            this.Update.IsTab = false;
            this.Update.Location = new System.Drawing.Point(54, 171);
            this.Update.Name = "Update";
            this.Update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Update.OnHoverTextColor = System.Drawing.Color.White;
            this.Update.selected = false;
            this.Update.Size = new System.Drawing.Size(370, 48);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update Affiliation";
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Update.Textcolor = System.Drawing.Color.White;
            this.Update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type New Affiliation";
            // 
            // AffiliationText
            // 
            this.AffiliationText.BorderColorFocused = System.Drawing.Color.Blue;
            this.AffiliationText.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AffiliationText.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.AffiliationText.BorderThickness = 3;
            this.AffiliationText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AffiliationText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AffiliationText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AffiliationText.isPassword = false;
            this.AffiliationText.Location = new System.Drawing.Point(54, 119);
            this.AffiliationText.Margin = new System.Windows.Forms.Padding(4);
            this.AffiliationText.Name = "AffiliationText";
            this.AffiliationText.Size = new System.Drawing.Size(370, 44);
            this.AffiliationText.TabIndex = 3;
            this.AffiliationText.Text = "`";
            this.AffiliationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Affiliation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 330);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AffiliationText);
            this.Name = "Affiliation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affiliation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton Update;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox AffiliationText;
    }
}