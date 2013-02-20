using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisciOtomasyonu
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sor = MessageBox.Show("Çıkmak İstiyor musunuz?", "Çıkış", MessageBoxButtons.YesNoCancel);
            if (sor == DialogResult.Yes)
            {
                Application.Exit();
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
        }

   

        
    }
}
