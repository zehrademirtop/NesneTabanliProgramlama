using System;

namespace refOrnegi
{
    class Program
    {
        
        static void DegerArtir(ref int sayi)
        {
            sayi = sayi + 1;
        }

        static void Main(string[] args)
        {
           
            int sayim = 10;

            
            DegerArtir(ref sayim);

            
            Console.WriteLine("Sayı artırıldıktan sonra değeri: " + sayim);

            Console.ReadLine(); 
        }
    }
}
