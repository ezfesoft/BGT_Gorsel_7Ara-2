using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_Gorsel_7Ara_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double not1;
            double not2;
            double sonuc;

            not1 = Convert.ToDouble(textBox1.Text);
            not2 = Convert.ToDouble(textBox2.Text);

            sonuc = (not1 * 0.4) + (not2 * 0.6);

            label4.Text = sonuc.ToString();

            if (sonuc>=50)
            {
                label6.Text = "BAŞARILI";
            }
            if (sonuc < 50)
            {
                label6.Text = "BAŞARISIZ";
            }
        }
    }
}
