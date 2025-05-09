using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mdul3Unite3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam = 0;

            int i = Math.Min(sayi1, sayi2);
            do
            {
                toplam += i;
                i++;
            } while (i <= Math.Max(sayi1, sayi2));

            labelSonuc.Text = "Toplam: " + toplam.ToString();
        }
    }
}
