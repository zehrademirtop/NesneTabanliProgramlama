﻿using System;

namespace DiziToplamUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int[] sayi = { 1, 2, 3, 4 };

            int toplam = 0;


            foreach (int i in sayi)
            {
                toplam = toplam + i;
            }

            Console.WriteLine("Dizi Elemanlarının Toplamı: " + toplam);

       
            Console.ReadLine();
        }
    }
}
