using System;

namespace TemsilciOrnegi
{

    public delegate void DiziIsle(ref string[] dizi);

    class Program
    {
      
        public static void DiziYazdir(ref string[] dizi)
        {
            Console.WriteLine("Dizinin Elemanları:");
            foreach (string s in dizi)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------");
        }

        public static void SiralaAZ(ref string[] dizi)
        {
            Array.Sort(dizi);
            Console.WriteLine("A-Z'ye göre sıralandı.");
        }


        public static void SiralaZA(ref string[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
            Console.WriteLine("Z-A'ya göre sıralandı.");
        }

        static void Main(string[] args)
        {
          
            string[] kelimeler = { "Portakal", "Elma", "Muz", "Karpuz", "Çilek" };

            DiziIsle temsilci;

            temsilci = DiziYazdir;
            Console.WriteLine("İlk Hali:");
            temsilci(ref kelimeler);

         
            temsilci = SiralaAZ;
            temsilci(ref kelimeler);

            temsilci = DiziYazdir;
            temsilci(ref kelimeler);

       
            temsilci = SiralaZA;
            temsilci += DiziYazdir;

            temsilci(ref kelimeler);

            Console.WriteLine("İşlem tamamlandı.");
            Console.ReadKey();
        }
    }
}
