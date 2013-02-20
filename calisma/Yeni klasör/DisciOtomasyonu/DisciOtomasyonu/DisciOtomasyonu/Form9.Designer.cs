namespace DisciOtomasyonu
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yeni = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.kalan = new System.Windows.Forms.TextBox();
            this.odenen = new System.Windows.Forms.TextBox();
            this.toplam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gelirButonu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yeni);
            this.groupBox2.Controls.Add(this.liste);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.geri);
            this.groupBox2.Controls.Add(this.kalan);
            this.groupBox2.Controls.Add(this.odenen);
            this.groupBox2.Controls.Add(this.toplam);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.gelirButonu);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 395);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CARİ BİLGİLER";
            // 
            // yeni
            // 
            this.yeni.BackColor = System.Drawing.Color.RosyBrown;
            this.yeni.Location = new System.Drawing.Point(378, 267);
            this.yeni.Name = "yeni";
            this.yeni.Size = new System.Drawing.Size(158, 49);
            this.yeni.TabIndex = 11;
            this.yeni.Text = "Yeni Kalem Gider Gir";
            this.yeni.UseVisualStyleBackColor = false;
            this.yeni.Click += new System.EventHandler(this.yeni_Click);
            // 
            // liste
            // 
            this.liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.liste.FullRowSelect = true;
            this.liste.GridLines = true;
            this.liste.Location = new System.Drawing.Point(6, 84);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(615, 156);
            this.liste.TabIndex = 10;
            this.liste.UseCompatibleStateImageBehavior = false;
            this.liste.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Toplam Borc";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Odenen";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Açıklama";
            this.columnHeader5.Width = 200;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(343, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Gider";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.gider_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.SystemColors.GrayText;
            this.geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.Location = new System.Drawing.Point(511, 366);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 8;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // kalan
            // 
            this.kalan.Enabled = false;
            this.kalan.ForeColor = System.Drawing.Color.Black;
            this.kalan.Location = new System.Drawing.Point(197, 334);
            this.kalan.Name = "kalan";
            this.kalan.Size = new System.Drawing.Size(100, 20);
            this.kalan.TabIndex = 7;
            // 
            // odenen
            // 
            this.odenen.Enabled = false;
            this.odenen.Location = new System.Drawing.Point(197, 300);
            this.odenen.Name = "odenen";
            this.odenen.Size = new System.Drawing.Size(100, 20);
            this.odenen.TabIndex = 6;
            // 
            // toplam
            // 
            this.toplam.Enabled = false;
            this.toplam.Location = new System.Drawing.Point(197, 267);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(100, 20);
            this.toplam.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(87, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kalan Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(87, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ödenen Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Tutar:";
            // 
            // gelirButonu
            // 
            this.gelirButonu.BackColor = System.Drawing.Color.SeaGreen;
            this.gelirButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirButonu.Location = new System.Drawing.Point(197, 34);
            this.gelirButonu.Name = "gelirButonu";
            this.gelirButonu.Size = new System.Drawing.Size(82, 23);
            this.gelirButonu.TabIndex = 1;
            this.gelirButonu.Text = "Gelir";
            this.gelirButonu.UseVisualStyleBackColor = false;
            this.gelirButonu.Click += new System.EventHandler(this.gelirButonu_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 418);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Bilgiler";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.TextBox kalan;
        private System.Windows.Forms.TextBox odenen;
        private System.Windows.Forms.TextBox toplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gelirButonu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView liste;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button yeni;
    }
}