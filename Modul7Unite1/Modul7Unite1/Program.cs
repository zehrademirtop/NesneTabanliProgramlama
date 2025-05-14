using System;

namespace Modul7Unite1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci örneği
            Ogrenci birOgrenci = new Ogrenci("Ali UZUN");
            Console.WriteLine("Adı: {0}", birOgrenci.Ad);
            Console.WriteLine("Boyu: {0}", birOgrenci.Boy);
            Console.WriteLine("Kilosu: {0}", birOgrenci.Kilo);

            // Daire örneği
            Daire daire = new Daire(3.0);
            Console.WriteLine("Dairenin Alanı: {0}", daire.Alan());

            Console.ReadLine();
        }
    }
}
