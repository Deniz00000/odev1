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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double toplam = 0;
            if (radioButton1.Checked == true)
            {
                toplam = sayi1 + sayi2;
            }
            else if (radioButton2.Checked == true)
            {
                toplam = sayi1 - sayi2;
            }
            else if (radioButton3.Checked == true)
            {
                toplam = sayi1 / sayi2;
            }
            else if (radioButton4.Checked == true)
            {
                toplam = sayi1 * sayi2;
            }
            label3.Text = toplam.ToString();
        }
    }
}
