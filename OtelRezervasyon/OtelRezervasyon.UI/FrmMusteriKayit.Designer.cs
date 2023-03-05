namespace OtelRezervasyon.UI
{
    partial class FrmMusteriKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriKayit));
            this.flRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.gbMusteriBilgiler = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtTC = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKral = new System.Windows.Forms.Button();
            this.gbMusteriBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // flRooms
            // 
            this.flRooms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flRooms.Location = new System.Drawing.Point(47, 43);
            this.flRooms.Margin = new System.Windows.Forms.Padding(4);
            this.flRooms.Name = "flRooms";
            this.flRooms.Size = new System.Drawing.Size(545, 488);
            this.flRooms.TabIndex = 0;
            // 
            // gbMusteriBilgiler
            // 
            this.gbMusteriBilgiler.Controls.Add(this.txtTel);
            this.gbMusteriBilgiler.Controls.Add(this.txtTC);
            this.gbMusteriBilgiler.Controls.Add(this.btnKaydet);
            this.gbMusteriBilgiler.Controls.Add(this.dtpGiris);
            this.gbMusteriBilgiler.Controls.Add(this.label6);
            this.gbMusteriBilgiler.Controls.Add(this.txtMusteriAd);
            this.gbMusteriBilgiler.Controls.Add(this.label3);
            this.gbMusteriBilgiler.Controls.Add(this.label2);
            this.gbMusteriBilgiler.Controls.Add(this.label1);
            this.gbMusteriBilgiler.Enabled = false;
            this.gbMusteriBilgiler.Location = new System.Drawing.Point(746, 43);
            this.gbMusteriBilgiler.Margin = new System.Windows.Forms.Padding(4);
            this.gbMusteriBilgiler.Name = "gbMusteriBilgiler";
            this.gbMusteriBilgiler.Padding = new System.Windows.Forms.Padding(4);
            this.gbMusteriBilgiler.Size = new System.Drawing.Size(413, 498);
            this.gbMusteriBilgiler.TabIndex = 1;
            this.gbMusteriBilgiler.TabStop = false;
            this.gbMusteriBilgiler.Text = "Müşteri Bilgileri";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(142, 247);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Mask = "00000000000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(233, 23);
            this.txtTel.TabIndex = 11;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(142, 206);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.Mask = "00000000000";
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(233, 23);
            this.txtTC.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(183, 406);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 46);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.KaydetButton_Click);
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(142, 283);
            this.dtpGiris.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(233, 23);
            this.dtpGiris.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giriş Tarihi";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(142, 164);
            this.txtMusteriAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(233, 23);
            this.txtMusteriAd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(906, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "oda bilgisi";
            // 
            // btnKral
            // 
            this.btnKral.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKral.BackgroundImage")));
            this.btnKral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKral.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKral.Location = new System.Drawing.Point(271, 396);
            this.btnKral.Margin = new System.Windows.Forms.Padding(4);
            this.btnKral.Name = "btnKral";
            this.btnKral.Size = new System.Drawing.Size(97, 99);
            this.btnKral.TabIndex = 5;
            this.btnKral.UseVisualStyleBackColor = false;
            this.btnKral.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OdaButton_Click);
            // 
            // FrmMusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbMusteriBilgiler);
            this.Controls.Add(this.btnKral);
            this.Controls.Add(this.flRooms);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriKayit";
            this.Text = "FrmMusteriKayit";
            this.Load += new System.EventHandler(this.FrmMusteriKayit_Load);
            this.gbMusteriBilgiler.ResumeLayout(false);
            this.gbMusteriBilgiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flRooms;
        private System.Windows.Forms.GroupBox gbMusteriBilgiler;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtTC;
        public System.Windows.Forms.Label label1;
    }
}