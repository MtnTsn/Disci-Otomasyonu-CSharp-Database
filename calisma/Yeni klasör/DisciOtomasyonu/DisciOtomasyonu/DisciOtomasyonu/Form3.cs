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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

 


        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);

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

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

 

        

     
    }
}
