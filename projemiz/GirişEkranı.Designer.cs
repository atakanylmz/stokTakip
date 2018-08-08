namespace projemiz
{
    partial class GirişEkranı
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
            this.BtnYetkiliGiriş = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYetkiliTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYetkiliŞifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnYetkiliGiriş
            // 
            this.BtnYetkiliGiriş.Location = new System.Drawing.Point(13, 91);
            this.BtnYetkiliGiriş.Name = "BtnYetkiliGiriş";
            this.BtnYetkiliGiriş.Size = new System.Drawing.Size(173, 47);
            this.BtnYetkiliGiriş.TabIndex = 0;
            this.BtnYetkiliGiriş.Text = "Yetkili Girişi Yap";
            this.BtnYetkiliGiriş.UseVisualStyleBackColor = true;
            this.BtnYetkiliGiriş.Click += new System.EventHandler(this.BtnYetkiliGiriş_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tc Kimlik No:";
            // 
            // txtYetkiliTC
            // 
            this.txtYetkiliTC.Location = new System.Drawing.Point(86, 19);
            this.txtYetkiliTC.Name = "txtYetkiliTC";
            this.txtYetkiliTC.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiliTC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtYetkiliŞifre
            // 
            this.txtYetkiliŞifre.Location = new System.Drawing.Point(86, 55);
            this.txtYetkiliŞifre.Name = "txtYetkiliŞifre";
            this.txtYetkiliŞifre.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiliŞifre.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtYetkiliTC);
            this.groupBox1.Controls.Add(this.BtnYetkiliGiriş);
            this.groupBox1.Controls.Add(this.txtYetkiliŞifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YETKİLİ";
            // 
            // GirişEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "GirişEkranı";
            this.Text = "Giriş ";
            this.Load += new System.EventHandler(this.GirişEkranı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnYetkiliGiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYetkiliTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYetkiliŞifre;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

