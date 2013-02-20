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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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
           
            OleDbCommand komut;
            OleDbDataReader oku;

            try
            {
                Baglanti();
                komut = new OleDbCommand();

                komut.CommandText = "Select * from  randevu2,personel   where randevu2.doktorid=personel.ID";

                    komut.Connection = baglanti;
                    oku = komut.ExecuteReader();
                    liste.Items.Clear();
                    String isim = "";
                    String DRisim = "";
                    String tarihDeger = "";
                    while (oku.Read())
                    {
                        tarihDeger = oku["randevutarihi"].ToString().Substring(0, 10);
                        ListViewItem kayit = new ListViewItem(tarihDeger);
                        isim = oku["ad"].ToString() + " " + oku["soyad"].ToString();
                        kayit.SubItems.Add(isim);

                        kayit.SubItems.Add(oku["randevusaati"].ToString());
                        kayit.SubItems.Add(oku["Sirano"].ToString());
                        DRisim = oku["ADI"].ToString() + " " + oku["SOYADI"].ToString();
                        kayit.SubItems.Add(DRisim);


                        liste.Items.Add(kayit);

                    }

                }

           
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
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
