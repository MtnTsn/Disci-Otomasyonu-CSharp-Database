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
    public partial class Form5 : Form
    {
        public Form5()
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
     
                    komut.CommandText = "Select * from   hasta_kayit";

                    komut.Connection = baglanti;
                    oku = komut.ExecuteReader();
                    liste.Items.Clear();
                    String isim = "";
                    String tarihDeger = "";
                    while (oku.Read())
                    {
                        tarihDeger = oku["KAYIT_TARIHI"].ToString().Substring(0, 10);
                        ListViewItem kayit = new ListViewItem(tarihDeger);
                        isim = oku["ADI"].ToString() + " " + oku["SOYADI"].ToString();
                        kayit.SubItems.Add(isim);

                        kayit.SubItems.Add(oku["ANLASMALI"].ToString());
                        kayit.SubItems.Add(oku["ANLASMALI_K"].ToString());
                        kayit.SubItems.Add(oku["TCKNO"].ToString());


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
