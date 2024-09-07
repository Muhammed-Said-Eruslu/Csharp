using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedenkitleendeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beden kitle indeksi = kilo / boy*boy
            // beden kitle indeksi 18 e eşit veya dusukse zayıf 
            // 18 25 arasındaysa normal 
            // 25 den buyukse obez
            Console.WriteLine("Kilonuuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());
            double bke = kilo / (boy * boy);
            if(bke<18)
            {
                Console.WriteLine("Zayıfsınız");
                Console.ReadLine();

            }
            else if (bke>18 && bke <25)
            {
                Console.WriteLine("Normalsiniz");
                Console.ReadLine();
            }
            else if (bke>25)
            {
                Console.WriteLine("Obezsiniz");
                Console.ReadLine();

            }



        }
    }
}
