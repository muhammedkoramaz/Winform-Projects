namespace OtelRezervasyon.UI
{
    partial class FrmRapor
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIsmeGoreFiltrele = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnTariheGoreFiltrele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lvRezervasyonlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(428, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAPOR";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(148, 111);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(134, 23);
            this.txtIsim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri Adı:";
            // 
            // btnIsmeGoreFiltrele
            // 
            this.btnIsmeGoreFiltrele.Location = new System.Drawing.Point(94, 152);
            this.btnIsmeGoreFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.btnIsmeGoreFiltrele.Name = "btnIsmeGoreFiltrele";
            this.btnIsmeGoreFiltrele.Size = new System.Drawing.Size(122, 28);
            this.btnIsmeGoreFiltrele.TabIndex = 4;
            this.btnIsmeGoreFiltrele.Text = "İsme Göre Filtrele";
            this.btnIsmeGoreFiltrele.UseVisualStyleBackColor = true;
            this.btnIsmeGoreFiltrele.Click += new System.EventHandler(this.BtnIsmeGoreFiltrele_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(668, 112);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(232, 23);
            this.dtpTarih.TabIndex = 5;
            // 
            // btnTariheGoreFiltrele
            // 
            this.btnTariheGoreFiltrele.Location = new System.Drawing.Point(720, 152);
            this.btnTariheGoreFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.btnTariheGoreFiltrele.Name = "btnTariheGoreFiltrele";
            this.btnTariheGoreFiltrele.Size = new System.Drawing.Size(122, 28);
            this.btnTariheGoreFiltrele.TabIndex = 6;
            this.btnTariheGoreFiltrele.Text = "Tarihe Göre Filtrele";
            this.btnTariheGoreFiltrele.UseVisualStyleBackColor = true;
            this.btnTariheGoreFiltrele.Click += new System.EventHandler(this.BtnTariheGoreFiltrele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(587, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarih:";
            // 
            // lvRezervasyonlar
            // 
            this.lvRezervasyonlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvRezervasyonlar.GridLines = true;
            this.lvRezervasyonlar.HideSelection = false;
            this.lvRezervasyonlar.Location = new System.Drawing.Point(12, 256);
            this.lvRezervasyonlar.Name = "lvRezervasyonlar";
            this.lvRezervasyonlar.Size = new System.Drawing.Size(957, 340);
            this.lvRezervasyonlar.TabIndex = 8;
            this.lvRezervasyonlar.UseCompatibleStateImageBehavior = false;
            this.lvRezervasyonlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri Adı";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "T.C Kimlik No";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon Numarası";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giriş Tarihi";
            this.columnHeader4.Width = 146;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Çıkış Tarihi";
            this.columnHeader5.Width = 152;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Oda No";
            this.columnHeader6.Width = 77;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ödenen Tutar";
            this.columnHeader7.Width = 137;
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 608);
            this.Controls.Add(this.lvRezervasyonlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTariheGoreFiltrele);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnIsmeGoreFiltrele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRapor";
            this.Text = "FrmRapor";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIsmeGoreFiltrele;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnTariheGoreFiltrele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvRezervasyonlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}