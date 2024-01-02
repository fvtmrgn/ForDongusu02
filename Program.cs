using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tek sayıları toplamak için 'tek', çift sayıları toplamak için 'çift' yazın: ");
            string secim = Console.ReadLine().ToLower();

            int toplam = 0;

            for (int i = 1; i <= sayi; i++)
            {
                if ((secim == "tek" && i % 2 == 1) || (secim == "çift" && i % 2 == 0))
                {
                    toplam += i;
                }
            }

              Console.WriteLine("1 ile " + sayi +" arasındaki " + $"{(secim == "tek" ? "Tek" : "çift")} sayıların toplamı: {toplam}");
     


        }
    }
}
