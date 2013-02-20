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
    public partial class Form8 : Form
    {
        public int p;
        String[] cevap;
        public Form8(int p)
        {
            this.p =p;
            cevap = new String[7];
            InitializeComponent();
            RadioButton[] evet = new RadioButton[7];
            evet[0] = radioButton1;
            evet[1] = radioButton3;
            evet[2] = radioButton5;
            evet[3] = radioButton7;
            evet[4] = radioButton9;
            evet[5] = radioButton13;
            evet[6] = radioButton15;
            RadioButton[] hayır = new RadioButton[7];
            hayır[0] = radioButton2;
            hayır[1] = radioButton4;
            hayır[2] = radioButton8;
            hayır[3] = radioButton8;
            hayır[4] = radioButton10;
            hayır[5] = radioButton15;
            hayır[6] = radioButton16;

            hayır[0] = radioButton2;
        }

        

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cevap[0] = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cevap[0] = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cevap[1] = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            cevap[1] = radioButton4.Text;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            cevap[2] = radioButton5.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            cevap[2] = radioButton6.Text;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            cevap[3] = radioButton7.Text;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            cevap[3] = radioButton8.Text;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            cevap[4] = radioButton9.Text;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            cevap[4] = radioButton9.Text;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            cevap[5] = radioButton13.Text;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            cevap[5] = radioButton13.Text;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            cevap[6] = radioButton15.Text;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            cevap[6] = radioButton15.Text;
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            //  OleDbCommand cmd = new OleDbCommand("INSERT INTO anamnez_formu(HASTA_ID,SORU,CEVAP) VALUES (" + p + "," + i + ",'" + cevap[0] + "')", baglanti);

            OleDbCommand komut;
            OleDbDataReader oku;
            DialogResult Sor = MessageBox.Show("Yeni Kayıt Eklensin Mi ?", "Kayıt Ekle", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Sor == DialogResult.Yes)
            {
                Baglanti();

                  for (int i = 0; i < cevap.Length;i++ ){
                try
                {
                    
                    komut = new OleDbCommand();

                  
                        komut.CommandText = "INSERT INTO anamnez_formu(HASTA_ID,SORU,CEVAP)VALUES(" + p + "," + i + ",'" + cevap[i] + "');";
                        komut.Connection = baglanti;
                     oku = komut.ExecuteReader();

                  

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }

               


             }


                  this.Hide();
                  Form3 frm = new Form3();
                  frm.Show();




            }
        }
        public OleDbConnection baglanti;
        public void Baglanti()
        {
            try
            {
                baglanti = new OleDbConnection
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=disciotomasyonu.mdb");
                baglanti.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





    }
}
