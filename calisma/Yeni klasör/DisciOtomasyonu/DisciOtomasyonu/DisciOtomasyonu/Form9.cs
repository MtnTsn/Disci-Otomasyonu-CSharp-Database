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
    public partial class Form9 : Form
    {

        String kim = "";
        public Form9()
        {
            InitializeComponent();



        }

        private void gider_Click(object sender, EventArgs e)
        {
            kim = "gider";
            Verileri_yazdirma();
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
        private void Verileri_yazdirma()
        {
            int odenenSay = 0;
            int toplamSay = 0;
            OleDbCommand komut;
            OleDbDataReader oku;

            try
            {
                Baglanti();
                komut = new OleDbCommand();
                if (kim == "gider")
                {
                    komut.CommandText = "Select * from  cari";
                    komut.Connection = baglanti;
                    oku = komut.ExecuteReader();

                    liste.Items.Clear();

                    while (oku.Read())
                    {
                        ListViewItem kayit = new ListViewItem(oku["TARIH"].ToString());
                        kayit.SubItems.Add(oku[5].ToString());

                        kayit.SubItems.Add(oku[2].ToString());
                        kayit.SubItems.Add(oku[4].ToString());

                        toplamSay = toplamSay + Int32.Parse(oku[2].ToString());
                        odenenSay = odenenSay + Int32.Parse(oku[4].ToString());
                        kayit.SubItems.Add(oku[3].ToString());


                        liste.Items.Add(kayit);

                    }
                }
                else if (kim == "gelir")
                {
                    komut.CommandText = "Select * from  hasta_borc,hasta_kayit";

                    komut.Connection = baglanti;
                    oku = komut.ExecuteReader();
                    liste.Items.Clear();
                    String isim = "";
                    String tarihDeger = "";
                    while (oku.Read())
                    {
                        tarihDeger = oku["TARIH"].ToString().Substring(0, 10);
                        ListViewItem kayit = new ListViewItem(tarihDeger);
                        isim = oku["ADI"].ToString() + " " + oku["SOYADI"].ToString();
                        kayit.SubItems.Add(isim);

                        kayit.SubItems.Add(oku["TOPLAM_BORC"].ToString());
                        kayit.SubItems.Add(oku["ODENEN"].ToString());
                        toplamSay = toplamSay + Int32.Parse(oku["TOPLAM_BORC"].ToString());
                        odenenSay = odenenSay + Int32.Parse(oku["ODENEN"].ToString());
                        kayit.SubItems.Add(oku["ACIKLAMA"].ToString());


                        liste.Items.Add(kayit);

                    }

                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }

            kalan.Text = Convert.ToString(toplamSay - odenenSay);
            odenen.Text = Convert.ToString(odenenSay);
            toplam.Text = Convert.ToString(toplamSay);
            kim = "";
        }

 
        private void geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void yeni_Click(object sender, EventArgs e)
        {


            yenikalemgider frm = new yenikalemgider();
            frm.Show();
            this.Hide();

        }

        private void gelirButonu_Click(object sender, EventArgs e)
        {
            kim = "gelir";
            Verileri_yazdirma();
        }

   



    }
}
