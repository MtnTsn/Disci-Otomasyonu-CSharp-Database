namespace DisciOtomasyonu
{
    partial class yenikalemgider
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.isim = new System.Windows.Forms.TextBox();
            this.toplamBorc = new System.Windows.Forms.TextBox();
            this.odenen = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.aciklama = new System.Windows.Forms.RichTextBox();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "YENİ KALEM GİDER GİRİŞİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "İsim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam Borç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ödenen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(178, 123);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(168, 20);
            this.isim.TabIndex = 7;
            // 
            // toplamBorc
            // 
            this.toplamBorc.Location = new System.Drawing.Point(178, 163);
            this.toplamBorc.Name = "toplamBorc";
            this.toplamBorc.Size = new System.Drawing.Size(100, 20);
            this.toplamBorc.TabIndex = 8;
            // 
            // odenen
            // 
            this.odenen.Location = new System.Drawing.Point(178, 200);
            this.odenen.Name = "odenen";
            this.odenen.Size = new System.Drawing.Size(100, 20);
            this.odenen.TabIndex = 9;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(178, 83);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(168, 20);
            this.tarih.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Açıklama";
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(178, 246);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(168, 76);
            this.aciklama.TabIndex = 13;
            this.aciklama.Text = "";
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(324, 349);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 14;
            this.geri.Text = "İptal";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // yenikalemgider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(411, 396);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.odenen);
            this.Controls.Add(this.toplamBorc);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yenikalemgider";
            this.Text = "Yeni Kalem Gider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox toplamBorc;
        private System.Windows.Forms.TextBox odenen;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox aciklama;
        private System.Windows.Forms.Button geri;

    }
}