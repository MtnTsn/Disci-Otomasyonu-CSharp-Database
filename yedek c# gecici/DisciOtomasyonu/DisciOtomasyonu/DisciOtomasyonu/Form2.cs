using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DisciOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sifre = "admin";
            if (textBox1.Text == sifre)
            {
                string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=disciotomasyonu.mdb";
                OleDbConnection baglanti = new OleDbConnection(kaynak);
                DialogResult Sor = MessageBox.Show("Yeni Kayıt Eklensin Mi ?", "Kayıt Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Sor == DialogResult.Yes)
                {
                    try
                    {
                        OleDbCommand cmd = new OleDbCommand("INSERT INTO personel(ADI,SOYADI,EV_TELEFON,CEP_TELEFON,ADRES,TC,SOSYAL_GUVENLIK_NO,UNVAN,CINSIYET,KULLANICI_ADI,SIFRE) VALUES ('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", baglanti);
                        baglanti.Open();
                        cmd.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kayıt Tamamlandı...");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("!!...HATA...!!" + "\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Admin şifresini yanlış girdiniz!!...");
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                //MessageBox.Show("App won´t close");
            }
            if (result == DialogResult.Yes)
            {
                //this.Dispose();
                Application.Exit();
            }
        }

       

       
    }
}
