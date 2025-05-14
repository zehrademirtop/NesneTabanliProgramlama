using System;

namespace BasvuruTuruKopyalama
{
    class Program
    {
        // Sınıf tanımı Program sınıfının üst kısmında yer almalı
        class Bisiklet
        {
            int hiz = 0;
            int vites = 0;

            public Bisiklet()
            {
                vites = 18;
            }

            public void Hizlan(int artis)
            {
                hiz = hiz + artis;
            }

            public void BilgileriYaz()
            {
                Console.Write("Vites: {0} ", vites);
                Console.WriteLine("Hız: {0}", hiz);
            }
        }

        static void Main(string[] args)
        {
            // Birinci nesne: new ile oluşturuluyor
            Bisiklet bisiklet1 = new Bisiklet();

            // İkinci nesne: birinciden kopyalanıyor (referans kopyası)
            Bisiklet bisiklet2 = bisiklet1;

            // bisiklet1 hızlanıyor
            bisiklet1.Hizlan(10);

            // Bilgileri yazdır
            Console.WriteLine("Bisiklet 1 Bilgileri:");
            bisiklet1.BilgileriYaz();

            Console.WriteLine("Bisiklet 2 Bilgileri:");
            bisiklet2.BilgileriYaz();

            Console.ReadLine(); // Konsolun hemen kapanmaması için
        }
    }
}
