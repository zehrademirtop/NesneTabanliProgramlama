using System;
using System.Windows.Forms;

namespace Modul2Unite2
{
    public partial class Form1 : Form
    {
        struct Tarih
        {
            public int gun;
            public int ay;
            public int yil;

            public Tarih(int g, int a, int y)
            {
                gun = g;
                ay = a;
                yil = y;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tarih t = new Tarih(9, 5, 2025);
            MessageBox.Show("Tarih: " + t.gun + "/" + t.ay + "/" + t.yil);
        }
    }
}
