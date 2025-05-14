using System;
using System.Windows;

namespace ToplamaIslemi
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void islem(object sender, RoutedEventArgs e)
        {

            int sayi1, sayi2, sonuc;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);  

            sonuc = sayi1 + sayi2;
            
            textBox3.Text = sonuc.ToString();
        }
    }
}
