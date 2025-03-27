namespace ContactList
{
    partial class AddContactForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.TextBox();
            this.ThemLienHe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Điện Thoại";
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(271, 91);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(100, 22);
            this.HoTen.TabIndex = 2;
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(271, 192);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(100, 22);
            this.SDT.TabIndex = 3;
            // 
            // ThemLienHe
            // 
            this.ThemLienHe.Location = new System.Drawing.Point(316, 265);
            this.ThemLienHe.Name = "ThemLienHe";
            this.ThemLienHe.Size = new System.Drawing.Size(75, 23);
            this.ThemLienHe.TabIndex = 4;
            this.ThemLienHe.Text = "Lưu";
            this.ThemLienHe.UseVisualStyleBackColor = true;
            this.ThemLienHe.Click += new System.EventHandler(this.ThemLienHe_Click);
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThemLienHe);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Button ThemLienHe;
    }
}