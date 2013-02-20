using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DisciOtomasyonu
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=disciotomasyonu.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);       //data basedeki verileri okuma komutu               
            OleDbCommand veri = new OleDbCommand("SELECT * FROM hasta_kayit", baglanti);
            OleDbDataReader oku;
            baglanti.Open();//baglantıyı acar              
            oku = veri.ExecuteReader();//verileri cekme komutunu calıstırır          
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["adi"].ToString());
                comboBox2.Items.Add(oku["soyadi"].ToString());
            }
            oku.Close();
            OleDbCommand verioku = new OleDbCommand("SELECT * FROM personel where unvan='doktor'", baglanti);
            OleDbDataReader veriler;
            veriler = verioku.ExecuteReader();//verileri cekme komutunu calıstırır          
            while (veriler.Read())
            {
                comboBox3.Items.Add(veriler["id"].ToString() + " " + veriler["adi"].ToString() + " " + veriler["soyadi"].ToString());
            }
            oku.Close();
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult Sor = MessageBox.Show("Randevu Verilsin mi ?", "Randevu Ver", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Sor == DialogResult.Yes)
            {
                try
                {
                    string kaynak2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=disciotomasyonu.mdb";
                    OleDbConnection baglanti = new OleDbConnection(kaynak2);
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO randevu2(ad,soyad,randevutarihi,randevusaati,doktorid,Sirano) VALUES ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + maskedTextBox1.Text + "','" + comboBox5.Text + "'," +3+ ",'" + comboBox4.Text + "')", baglanti);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt tamamlandı...");
                    comboBox1.Text = "";
                  
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("!!...HATA...!!" + "\n" + ex.Message);
                }
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 frm = new Form3();
            frm.Show();

        }
    }
}
