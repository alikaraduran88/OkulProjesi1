using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
           pictureBox1.Load(textBox1.Text);   
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Dosya seç";
            openFileDialog1.InitialDirectory = @"";
            openFileDialog1.Filter = "Jpeg dosyaları (*.jpg)|*.jpg|BitMap Resimler(*.bmp)|*.bmp";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Mesaj = textBox2.Text;
           
        }
    }
}
