using System;
using System.Windows.Forms;

namespace Modul3Unite2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Kullanıcıdan kat numarasını al
            Console.WriteLine("Lütfen kat numarasını giriniz (0-3 arasında): ");
            int katNumarasi;

            // Kat numarasını al
            bool validKatNumarasi = int.TryParse(Console.ReadLine(), out katNumarasi);

            // Girilen kat numarasının geçerli olup olmadığını kontrol et
            if (!validKatNumarasi || katNumarasi < 0 || katNumarasi > 3)
            {
                Console.WriteLine("Lütfen 0-3 arasında bir kat numarası giriniz...");
            }
            else
            {
                // Geçerli kat numarasına göre işlemler
                if (katNumarasi == 0)
                {
                    Console.WriteLine("Zemin Kat: Öğrenci kantini, oyun alanı ve yönetim odası bulunur.");
                }
                else if (katNumarasi == 1)
                {
                    Console.WriteLine("1. Kat: Sınıflar ve laboratuvarlar bulunur.");
                }
                else if (katNumarasi == 2)
                {
                    Console.WriteLine("2. Kat: Öğretmenler odası, idari ofisler bulunur.");
                }
                else if (katNumarasi == 3)
                {
                    Console.WriteLine("3. Kat: Konferans salonu ve misafir odası bulunur.");
                }
            }

            // Form1'in çalışmasını başlat
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
