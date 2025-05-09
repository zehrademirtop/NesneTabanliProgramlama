using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modul1Unite2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


      

       

        private void ButtonTopla_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(TextBox1.Text);
            int b = Int16.Parse(TextBox2.Text);
            TextBox3.Text = (a + b).ToString();

        }

        private void ButtonCikar_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(TextBox1.Text);
            int b = Int16.Parse(TextBox2.Text);
            TextBox3.Text = (a - b).ToString();
        }

            private void ButtonCarp_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(TextBox1.Text);
            int b = Int16.Parse(TextBox2.Text);
            TextBox3.Text = (a * b).ToString();
        }

        private void ButtonBol_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(TextBox1.Text);
            int b = Int16.Parse(TextBox2.Text);

            if (b != 0)
            {
                TextBox3.Text = (a / b).ToString();
            }
            else
            {
                TextBox3.Text = "Tanımsız"; // 0'a bölünme hatası
            }
        }
        }
    }

    

