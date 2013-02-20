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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNoCancel);

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
        void baglantim()
        {
            string kadi = textBox1.Text;
            string sifre = textBox2.Text;

            if ((textBox1.Text == "") && (textBox2.Text == ""))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Girmediniz");
            }

            try
            {
                if (kadi != null & sifre != null)
                {
                    string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=disciotomasyonu.mdb";
                    OleDbConnection baglanti = new OleDbConnection(kaynak);
                    OleDbCommand sorgu = new OleDbCommand("SELECT * FROM personel", baglanti);
                    OleDbDataReader okuyucu;
                    bool onay1 = false;
                    bool onay2 = false;

                    try
                    {
                        baglanti.Open();
                        okuyucu = sorgu.ExecuteReader();

                        while (okuyucu.Read())
                        {
                            if ((kadi == "dr" + okuyucu["KULLANICI_ADI"].ToString()) && (sifre == okuyucu["SIFRE"].ToString()) || (kadi =="st"+okuyucu["KULLANICI_ADI"].ToString()) && (sifre == okuyucu["SIFRE"].ToString()))
                            {
                                onay1 = true;
                                onay2 = true;
                                break;
                            }
                        }
                        baglanti.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (onay1 == true)
                    {
                        baglanti.Open();
                        okuyucu = sorgu.ExecuteReader();

                        while (okuyucu.Read())
                        {
                            if ((kadi == "st" + okuyucu["KULLANICI_ADI"].ToString()) && (sifre == okuyucu["SIFRE"].ToString()))
                            {
                                Form3 frm3 = new Form3();
                                frm3.Show();
                                this.Hide();

                            }
                        }
                        baglanti.Close();
                        
                    }
                    if (onay2 == true)
                    {
                        baglanti.Open();
                        okuyucu = sorgu.ExecuteReader();

                        while (okuyucu.Read())
                        {
                            if ((kadi == "dr" + okuyucu["KULLANICI_ADI"].ToString()) && (sifre == okuyucu["SIFRE"].ToString()))
                            {
                               Form10 frm10 = new Form10();
                               frm10.Show();
                               this.Hide();
                                
                            }
                        }
                        baglanti.Close();
                        

                    }
                    else
                    {
                        baglanti.Close();
                        MessageBox.Show("Kullanıcı adı veya şifreyi yanlış girdiginiz !", ":: Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           baglantim();
         //  Form3 frm3 = new Form3();
        //    frm3.Show();
            this.Hide();
           // Form10 frm10 = new Form10();
            //frm10.Show();
            
        }

       

       
    }
}
