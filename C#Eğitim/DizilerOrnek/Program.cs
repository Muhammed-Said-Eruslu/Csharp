using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcını girdiği sayı dizinin içinde var mı kontrol eden varsa kaç tane olduğun soyleyen yoksa yoktur diye uyarı veren program
            int[] sayılar = { 10, 10, 20, 30, 20, 40, 30, 50, 80, 90, 70, 40, 50, 60, 5, 15, 25, 35, 31, 79, 91, 120, 9 };
            int adet = 0;
            int sayı;
            Console.WriteLine("Lütfen bir sayı giriniz :");
            sayı = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i<sayılar.Length; i++)
            {
                if (sayı == sayılar[i])
                    adet++;
            }
            if (adet==0)
            {
                Console.WriteLine("Girdiğiniz Değer Dizide Bulunamadı11");
            }

            else
            {
                Console.WriteLine("Girdiğiniz Değer Dizide Bulundu");
                Console.WriteLine("Adet"+adet);
            }
            Console.ReadLine();
        }
    }
}
