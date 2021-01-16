using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KulanıciKayitRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Record Started. 00:00:000";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Record Ended 01:00:569";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5154-15QG-6D44-WDS5-HX1NMX";
        }

        private void button4_Click(object sender, EventArgs e) //Komut verecegimiz alanın altına tıkladıktan sonra bildirinin nerde orunecegi = bildirinin ne olacagı seciliyor. buton = bildirim alanı = veri giris alanı
        {
            label1.Text = textBox1.Text;
            textBox9.Text = "Lisans Number Recorded as the Name of" +" "+textBox3.Text + " " + "for" + " " + textBox7.Text;
            textBox8.Text = ".Check Number : 89514oZ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
