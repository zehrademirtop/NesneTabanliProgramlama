using System;
using System.Windows.Forms;

namespace Modul3Unite1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int a = 16;
            int b = 12;
            int c = 10;

            int islem = a + c / (b - c) * 10;         // işlemli
            int islem2 = a + c / b - c * 10;          // parantezsiz
            int islem3 = a + (c * 10) / (b - c);      // çarpma önce

            bool pozitifMi = islem > 0;
            bool negatifMi = islem2 < 0;

            label1.Text = "İşlem Sonucu: " + islem;
            label2.Text = "Parantezsiz Sonuç: " + islem2;
            label3.Text = "Yer değiştirme Sonucu: " + islem3;
            label4.Text = "Pozitif mi? " + pozitifMi;
            label5.Text = "Negatif mi? " + negatifMi;
        }
    }
}
