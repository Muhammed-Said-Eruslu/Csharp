using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOŞULYAPISINOTORENEĞİ
{
    class Program
    {
        static void Main(string[] args)

        {
            // kullanıcıdan 3 tane not alan ve bu notların ortalamsını bulan ve ortalaması 
            // eğer 80 - 100 arasındaysa A+
            // eğer 60 - 80 arasındaysa A
            // eğer 40 - 60 arasındaysa B+
            // eğer  40 dan kucukse f yazdıran kod
            Console.WriteLine("Lütfen 1. notunuzu giriniz");
            int birinci_not = Convert.ToInt32(Console.ReadLine());
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            int üçüncü_not = Convert.ToInt32(Console.ReadLine());


            int sonuc = (birinci_not + ikinci_not + üçüncü_not) / 3;

            if (sonuc > 80 && sonuc < 100)
            {
                Console.WriteLine("Not Değeriniz A+");

            }
            else if (sonuc > 60 && sonuc < 80)
            {
                Console.WriteLine("Not Değeriniz A");
            }
            else if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("Not Değeriniz B+");
            }
            else
            {
                Console.WriteLine("Not Değeriniz F dir");
            }
        }
    }
}
