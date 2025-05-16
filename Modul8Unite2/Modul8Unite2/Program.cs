using System;
using System.Collections.Generic;

namespace SepetUygulamasi
{
    // Ürün sınıfı
    public class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public Urun(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
    }

    // Sepet sınıfı
    public class Sepet
    {
        // Olay tanımı
        public event EventHandler<Urun> UrunEklendi;

        private List<Urun> urunler = new List<Urun>();

        public void UrunEkle(Urun urun)
        {
            urunler.Add(urun);
            // Olay tetikleniyor
            UrunEklendi?.Invoke(this, urun);
        }

        public List<Urun> Getir()
        {
            return urunler;
        }
    }

    class Program
    {
        static decimal toplamTutar = 0;

        static void Main(string[] args)
        {
            Sepet sepet = new Sepet();

            // Olay dinleniyor
            sepet.UrunEklendi += Sepet_UrunEklendi;

            while (true)
            {
                Console.Write("Ürün adı (çıkmak için 'q'): ");
                string ad = Console.ReadLine();
                if (ad.ToLower() == "q") break;

                Console.Write("Fiyat: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal fiyat))
                {
                    Urun yeniUrun = new Urun(ad, fiyat);
                    sepet.UrunEkle(yeniUrun);
                }
                else
                {
                    Console.WriteLine("Geçerli bir fiyat giriniz.");
                }
            }

            Console.WriteLine($"Sepetinizde {sepet.Getir().Count} ürün var. Toplam Tutar: {toplamTutar} TL");
        }

        // Olay gerçekleşince çalışacak metot
        private static void Sepet_UrunEklendi(object sender, Urun urun)
        {
            toplamTutar += urun.Fiyat;
            Console.WriteLine($"'{urun.Ad}' ürünü sepete eklendi. Güncel toplam: {toplamTutar} TL\n");
        }
    }
}
