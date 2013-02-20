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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("İptal Etmek İstiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                //MessageBox.Show("App won´t close");
            }
            if (result == DialogResult.Yes)
            {
                //this.Dispose();
                this.Hide();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=disciotomasyonu.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            DialogResult Sor = MessageBox.Show("Yeni Kayıt Eklensin Mi ?", "Kayıt Ekle", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Sor == DialogResult.Yes)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO hasta_kayit(TCKNO,ADI,SOYADI,DOGUM_YERI,DOGUM_TARI,BABA_ADI,ANNE_ADI,MESLEK,KAN_GRUBU,EV_TELEFON,CEP_TELEFO,E_MAIL,ANLASMALI_,ANLAMALI_K,MEDENI_DUR,CINSIYET,KAYIT_TARIHI) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + maskedTextBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" +dateTimePicker2.Text + "')", baglanti);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt tamamlandı...");
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
                    textBox13.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("!!...HATA...!!" + "\n" + ex.Message);
                }
            }

        }

       
    }
}
