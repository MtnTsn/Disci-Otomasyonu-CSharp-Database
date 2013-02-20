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
    public partial class yenikalemgider : Form
    {
        public yenikalemgider()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm = new Form9();
            frm.Show();
        }
        String kime = "";
        String acikla= "";
        int ode = 0;
        int toplam = 0;
     
        string tarihDeger="";
        private void button1_Click(object sender, EventArgs e)
        {

            if (aciklama.Text == "" || toplamBorc.Text == "" || isim.Text == "")
            {

                return;


            }
            
            kime = isim.Text;
            acikla = aciklama.Text;
            ode = Int32.Parse(odenen.Text);
            toplam = Int32.Parse(toplamBorc.Text);
            tarihDeger= tarih.Text.Substring(0,23);




            OleDbCommand komut;
            OleDbDataReader oku;
            DialogResult Sor = MessageBox.Show("Yeni Kayıt Eklensin Mi ?", "Kayıt Ekle", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Sor == DialogResult.Yes)
            {
                try
                {
                    Baglanti();
                    komut = new OleDbCommand();


                    komut.CommandText = "INSERT INTO cari(TARIH,TOPLAM_BORC,ACIKLAMA,ODENEN,KIME)VALUES('" + tarihDeger + "'," + toplam + ",'" + acikla + "'," + ode + ",'" + kime + "');";

                    komut.Connection = baglanti;
                    oku = komut.ExecuteReader();


                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                odenen.Text = "";
                toplamBorc.Text = "";
                isim.Text = "";
                aciklama.Text = "";
                this.Hide();
                Form9 frm = new Form9();
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
