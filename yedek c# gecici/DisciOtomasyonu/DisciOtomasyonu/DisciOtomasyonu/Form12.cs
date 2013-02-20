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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=disciotomasyonu.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);       //data basedeki verileri okuma komutu               
            OleDbCommand veri = new OleDbCommand("SELECT * FROM hasta_kayit", baglanti);
            OleDbDataReader oku;
            baglanti.Open();//baglantıyı acar              
            oku = veri.ExecuteReader();//verileri cekme komutunu calıstırır          
            while (oku.Read())
            {
               ListViewItem itm = new ListViewItem(oku["tckno"].ToString());//listview nesnesi oluştrduk
                itm.SubItems.Add( oku["adi"].ToString());
                itm.SubItems.Add(oku["soyadi"].ToString());
                itm.SubItems.Add(oku["kan_grubu"].ToString());      //listviewlere veri tabanından veri ekledik
                itm.SubItems.Add(oku["DOGUM_TARI"].ToString());
                itm.SubItems.Add(oku["ANLASMALI_"].ToString());
                itm.SubItems.Add(oku["ANLAMALI_K"].ToString());
                listView1.Items.Add(itm);
            }
            oku.Close();
            baglanti.Close();
        }
    }
}
