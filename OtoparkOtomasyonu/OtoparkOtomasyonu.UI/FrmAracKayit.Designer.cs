namespace OtoparkOtomasyonu.UI
{
    partial class FrmAracKayit
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.gbAracBilgileri = new System.Windows.Forms.GroupBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.cmbParkYeri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbKisiBilgileri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.gbAracBilgileri.SuspendLayout();
            this.gbKisiBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Brown;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(396, 332);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(78, 37);
            this.btnIptal.TabIndex = 21;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Teal;
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayit.Location = new System.Drawing.Point(271, 332);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKayit.Size = new System.Drawing.Size(94, 37);
            this.btnKayit.TabIndex = 20;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = false;
            // 
            // gbAracBilgileri
            // 
            this.gbAracBilgileri.Controls.Add(this.txtmodel);
            this.gbAracBilgileri.Controls.Add(this.txtMarka);
            this.gbAracBilgileri.Controls.Add(this.cmbParkYeri);
            this.gbAracBilgileri.Controls.Add(this.label8);
            this.gbAracBilgileri.Controls.Add(this.label7);
            this.gbAracBilgileri.Controls.Add(this.txtRenk);
            this.gbAracBilgileri.Controls.Add(this.label2);
            this.gbAracBilgileri.Controls.Add(this.txtPlaka);
            this.gbAracBilgileri.Controls.Add(this.label5);
            this.gbAracBilgileri.Controls.Add(this.label6);
            this.gbAracBilgileri.Location = new System.Drawing.Point(396, 81);
            this.gbAracBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.gbAracBilgileri.Name = "gbAracBilgileri";
            this.gbAracBilgileri.Padding = new System.Windows.Forms.Padding(2);
            this.gbAracBilgileri.Size = new System.Drawing.Size(270, 228);
            this.gbAracBilgileri.TabIndex = 19;
            this.gbAracBilgileri.TabStop = false;
            this.gbAracBilgileri.Text = "Araç Bilgileri";
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(94, 123);
            this.txtmodel.Margin = new System.Windows.Forms.Padding(2);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(104, 20);
            this.txtmodel.TabIndex = 19;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(94, 86);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(104, 20);
            this.txtMarka.TabIndex = 18;
            // 
            // cmbParkYeri
            // 
            this.cmbParkYeri.FormattingEnabled = true;
            this.cmbParkYeri.Location = new System.Drawing.Point(94, 190);
            this.cmbParkYeri.Margin = new System.Windows.Forms.Padding(2);
            this.cmbParkYeri.Name = "cmbParkYeri";
            this.cmbParkYeri.Size = new System.Drawing.Size(104, 21);
            this.cmbParkYeri.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Park Yeri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Renk";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(94, 159);
            this.txtRenk.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(104, 20);
            this.txtRenk.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Plaka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(94, 50);
            this.txtPlaka.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(104, 20);
            this.txtPlaka.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Model";
            // 
            // gbKisiBilgileri
            // 
            this.gbKisiBilgileri.Controls.Add(this.label1);
            this.gbKisiBilgileri.Controls.Add(this.txtTc);
            this.gbKisiBilgileri.Controls.Add(this.Ad);
            this.gbKisiBilgileri.Controls.Add(this.txtAd);
            this.gbKisiBilgileri.Controls.Add(this.label3);
            this.gbKisiBilgileri.Controls.Add(this.txtSoyad);
            this.gbKisiBilgileri.Controls.Add(this.label4);
            this.gbKisiBilgileri.Controls.Add(this.txtTel);
            this.gbKisiBilgileri.Location = new System.Drawing.Point(135, 81);
            this.gbKisiBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.gbKisiBilgileri.Name = "gbKisiBilgileri";
            this.gbKisiBilgileri.Padding = new System.Windows.Forms.Padding(2);
            this.gbKisiBilgileri.Size = new System.Drawing.Size(230, 204);
            this.gbKisiBilgileri.TabIndex = 18;
            this.gbKisiBilgileri.TabStop = false;
            this.gbKisiBilgileri.Text = "Kişi Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C No";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(108, 36);
            this.txtTc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(104, 20);
            this.txtTc.TabIndex = 1;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(51, 76);
            this.Ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(20, 13);
            this.Ad.TabIndex = 2;
            this.Ad.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(108, 76);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(104, 20);
            this.txtAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(108, 115);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(104, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(108, 155);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(104, 20);
            this.txtTel.TabIndex = 7;
            // 
            // FrmAracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.gbAracBilgileri);
            this.Controls.Add(this.gbKisiBilgileri);
            this.Name = "FrmAracKayit";
            this.Text = "FrmAracCikis";
            this.Load += new System.EventHandler(this.FrmAracKayit_Load);
            this.gbAracBilgileri.ResumeLayout(false);
            this.gbAracBilgileri.PerformLayout();
            this.gbKisiBilgileri.ResumeLayout(false);
            this.gbKisiBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.GroupBox gbAracBilgileri;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox cmbParkYeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbKisiBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
    }
}