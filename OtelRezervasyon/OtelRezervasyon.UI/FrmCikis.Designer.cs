namespace OtelRezervasyon.UI
{
    partial class FrmCikis
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
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAdSoyad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMiniDolap = new System.Windows.Forms.ListBox();
            this.lblBorc = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbBuzdolabi = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.gbBuzdolabi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(426, 494);
            this.btnCikisYap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(88, 46);
            this.btnCikisYap.TabIndex = 15;
            this.btnCikisYap.Text = "Çıkışını Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbAdSoyad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpCikis);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(14, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(442, 366);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // cmbAdSoyad
            // 
            this.cmbAdSoyad.FormattingEnabled = true;
            this.cmbAdSoyad.Location = new System.Drawing.Point(150, 135);
            this.cmbAdSoyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbAdSoyad.Name = "cmbAdSoyad";
            this.cmbAdSoyad.Size = new System.Drawing.Size(233, 24);
            this.cmbAdSoyad.TabIndex = 15;
            this.cmbAdSoyad.SelectedIndexChanged += new System.EventHandler(this.cmbAdSoyad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad Soyad";
            // 
            // dtpCikis
            // 
            this.dtpCikis.Enabled = false;
            this.dtpCikis.Location = new System.Drawing.Point(150, 189);
            this.dtpCikis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(233, 23);
            this.dtpCikis.TabIndex = 10;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Çıkış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(79, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Toplam Borç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Alınanlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mini Buzdolabı";
            // 
            // listBoxMiniDolap
            // 
            this.listBoxMiniDolap.FormattingEnabled = true;
            this.listBoxMiniDolap.ItemHeight = 16;
            this.listBoxMiniDolap.Location = new System.Drawing.Point(7, 50);
            this.listBoxMiniDolap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxMiniDolap.Name = "listBoxMiniDolap";
            this.listBoxMiniDolap.Size = new System.Drawing.Size(167, 292);
            this.listBoxMiniDolap.TabIndex = 13;
            this.listBoxMiniDolap.SelectedIndexChanged += new System.EventHandler(this.listBoxMiniDolap_SelectedIndexChanged);
            // 
            // lblBorc
            // 
            this.lblBorc.AutoSize = true;
            this.lblBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorc.ForeColor = System.Drawing.Color.Red;
            this.lblBorc.Location = new System.Drawing.Point(177, 483);
            this.lblBorc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(66, 24);
            this.lblBorc.TabIndex = 4;
            this.lblBorc.Text = "label7";
            this.lblBorc.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(224, 50);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(308, 290);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Toplam Fiyat";
            this.columnHeader4.Width = 79;
            // 
            // gbBuzdolabi
            // 
            this.gbBuzdolabi.Controls.Add(this.listBoxMiniDolap);
            this.gbBuzdolabi.Controls.Add(this.label2);
            this.gbBuzdolabi.Controls.Add(this.listView1);
            this.gbBuzdolabi.Controls.Add(this.label3);
            this.gbBuzdolabi.Enabled = false;
            this.gbBuzdolabi.Location = new System.Drawing.Point(482, 64);
            this.gbBuzdolabi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbBuzdolabi.Name = "gbBuzdolabi";
            this.gbBuzdolabi.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbBuzdolabi.Size = new System.Drawing.Size(545, 366);
            this.gbBuzdolabi.TabIndex = 20;
            this.gbBuzdolabi.TabStop = false;
            this.gbBuzdolabi.Text = "Buzdolabı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(79, 494);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Toplam Borç";
            // 
            // FrmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 583);
            this.Controls.Add(this.gbBuzdolabi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblBorc);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCikis";
            this.Text = "FrmCikis";
            this.Load += new System.EventHandler(this.FrmCikis_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbBuzdolabi.ResumeLayout(false);
            this.gbBuzdolabi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxMiniDolap;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox gbBuzdolabi;
        private System.Windows.Forms.Label label5;
    }
}