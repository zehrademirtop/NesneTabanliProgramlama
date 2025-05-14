using System;

namespace kutulamaOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int sayi = 42;

            object kutuluDeger = sayi;

            Console.WriteLine("Kutulanan değer (object): " + kutuluDeger);

          
            int cozulmusDeger = (int)kutuluDeger;

            Console.WriteLine("Kutudan çıkarılan değer (int): " + cozulmusDeger);

           
            if (kutuluDeger is int)
            {
                Console.WriteLine("kutuluDeger bir int türündedir.");
            }

            if (kutuluDeger is string)
            {
                Console.WriteLine("Bu yazı görünmez, çünkü object string değil.");
            }

           
            object metin = "Merhaba";
            string strDeger = metin as string;

            if (strDeger != null)
            {
                Console.WriteLine("as işleciyle dönüştürülen metin: " + strDeger);
            }

            object sayisalMetin = 100;
            string sayiStr = sayisalMetin as string; 

            if (sayiStr == null)
            {
                Console.WriteLine("sayisalMetin değişkeni string'e dönüştürülemedi (as işleci başarısız).");
            }

            Console.ReadLine(); 
        }
    }
}
