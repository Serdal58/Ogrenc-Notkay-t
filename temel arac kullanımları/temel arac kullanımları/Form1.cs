using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temel_arac_kullanımları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tıkla_Click(object sender, EventArgs e)
        {
            
            sehiri.Text = comboBox1.Text;
            textBox1.Text = "c#";
            label8.Text = textBox1.Text;
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ar");
            listBox1.Items.Add("matlab");
            comboBox1.Items.Add("iskandinav");
            listBox1.Items.Add(textBox1.Text);


        }
    }
}
