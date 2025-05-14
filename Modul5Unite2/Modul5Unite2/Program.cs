using System;

namespace StaticOrnegi
{
    class Program
    {
        
        class Nokta
        {
            private int x, y;
            private static int noktaSayisi = 0;

           
            public Nokta()
            {
                this.x = 0;
                this.y = 0;
                noktaSayisi++;
            }

           
            public Nokta(int x, int y)
            {
                this.x = x;
                this.y = y;
                noktaSayisi++;
            }

            public static int NoktaSayisi()
            {
                return noktaSayisi;
            }

            public void Yazdir()
            {
                Console.WriteLine($"Nokta: ({x}, {y})");
            }
        }

        static void Main(string[] args)
        {
           
            Nokta n1 = new Nokta();         
            Nokta n2 = new Nokta(5, 10);   
            Nokta n3 = new Nokta(3, 7);     

           
            n1.Yazdir();
            n2.Yazdir();
            n3.Yazdir();

           
            Console.WriteLine("Toplam Nokta Sayısı: " + Nokta.NoktaSayisi());

            Console.ReadLine(); 
        }
    }
}
