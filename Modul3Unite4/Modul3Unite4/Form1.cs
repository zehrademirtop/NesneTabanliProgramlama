using System;
using System.Windows.Forms;

namespace Modul3Unite4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void buttonHesapla_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Boş giriş kontrolü
                if (string.IsNullOrWhiteSpace(textBoxSayi.Text))
                    throw new ArgumentNullException("Sayı alanı boş bırakılamaz!");

                // Sayı tipinde mi kontrolü
                int sayi = int.Parse(textBoxSayi.Text);

                // Negatif sayı kontrolü
                if (sayi < 0)
                    throw new Exception("Pozitif bir tam sayı giriniz!");

                // Faktöriyel hesaplama (taşmaları kontrol eder)
                long faktoriyel = 1;
                checked
                {
                    for (int i = 1; i <= sayi; i++)
                    {
                        faktoriyel *= i;
                    }
                }

                labelSonuc.Text = "Sonuç: " + faktoriyel.ToString();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sadece rakam giriniz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Sayı çok büyük! İşlem taşmaya neden oldu.", "Taşma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Textbox temizlenir ve imleç oraya odaklanır
                textBoxSayi.Clear();
                textBoxSayi.Focus();
            }
        }
    }
}
