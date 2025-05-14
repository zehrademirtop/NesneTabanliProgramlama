using System;

namespace SinifOrnegi
{
    class Program
    {
        // Bisiklet sınıfı Program sınıfının içinde tanımlanıyor
        class Bisiklet
        {
            // Alanlar (özellikler)
            private int hiz;
            private int vites;
            private int vitesSayisi;

            // Varsayılan kurucu
            public Bisiklet()
            {
                hiz = 0;
                vites = 1;
                vitesSayisi = 18;
            }

            // Parametreli kurucu
            public Bisiklet(int vitesSayisi)
            {
                hiz = 0;
                vites = 1;
                this.vitesSayisi = vitesSayisi;
            }

            // Vites değiştir
            public void VitesDegistir(int yeniVites)
            {
                if (yeniVites > 0 && yeniVites <= vitesSayisi)
                {
                    vites = yeniVites;
                    Console.WriteLine($"Vites {yeniVites} olarak değiştirildi.");
                }
                else
                {
                    Console.WriteLine("Geçersiz vites!");
                }
            }

            // Hızlan
            public void Hizlan(int artis)
            {
                hiz += artis;
                Console.WriteLine($"Hız {artis} kadar artırıldı.");
            }

            // Fren yap
            public void FrenYap(int azalis)
            {
                hiz -= azalis;
                if (hiz < 0)
                    hiz = 0;

                Console.WriteLine($"Hız {azalis} kadar azaltıldı.");
            }

            // Bilgileri yaz
            public void BilgileriYaz()
            {
                Console.WriteLine($"Hız: {hiz}, Vites: {vites}, Vites Sayısı: {vitesSayisi}");
            }

            // Doğrudan alanlara erişim örneği (erişim belirleyici kontrolü)
            public void SetVites(int yeniVites)
            {
                vites = yeniVites;
            }

            public void SetHiz(int yeniHiz)
            {
                hiz = yeniHiz;
            }
        }

        static void Main(string[] args)
        {
            // İlk bisiklet nesnesi (varsayılan kurucu ile)
            Bisiklet bisiklet1 = new Bisiklet();
            bisiklet1.VitesDegistir(5);
            bisiklet1.Hizlan(20);
            bisiklet1.FrenYap(5);
            bisiklet1.BilgileriYaz();

            Console.WriteLine("----------------------");

            // İkinci bisiklet nesnesi (parametreli kurucu ile)
            Bisiklet bisiklet2 = new Bisiklet(21);
            bisiklet2.VitesDegistir(10);
            bisiklet2.Hizlan(30);
            bisiklet2.FrenYap(15);
            bisiklet2.BilgileriYaz();

            Console.WriteLine("----------------------");

            // Metot kullanmadan değişkenlere değer verme (public metot ile erişim)
            bisiklet1.SetVites(3);
            bisiklet1.SetHiz(50);
            bisiklet1.BilgileriYaz();

            Console.ReadLine(); // Konsol kapanmasın diye
        }
    }
}
