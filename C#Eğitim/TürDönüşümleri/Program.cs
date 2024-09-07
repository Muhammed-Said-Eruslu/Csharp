using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TürDönüşümleri
{
    class Program
    {
        static void Main(string[] args)

        {
            // int a = 500;
            //long b = (long)a;
            //  Console.WriteLine(b.GetType());
            // Console.WriteLine(b); 

            /*int sayı1 = 5;
            int sayı2 = 10;

            string a = sayı1.ToString();
            string b = sayı2.ToString();
            Console.WriteLine(a + b);*/


            // Double veri tipinden int veri tipine nasıl donusturulur
            // int b = int.Parse(sayı);

            /* double sayı = 5.22;
             int a = Convert.ToInt32(sayı);*/


            // Console.WriteLine(a);
            // Console.WriteLine(sayı.GetType());

            // kullanıcıdan alınan değerler string veri tipinde olur
            /*Console.WriteLine("lütfen yasınızı gırınız");

            string kullanici_yas = Console.ReadLine();

            int kullanici_yasInt = int.Parse(kullanici_yas);
            int kullanıcı_yasInt2 = Convert.ToInt32(kullanici_yas);

            

            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanıcı_yasInt2);*/

            // kullanıcıdan iki tane sayı alan ve ikisinin toplamını ekrana yazdıran programı yaz
            Console.WriteLine("birinci sayıyı giriniz");
            string sayı1 = Console.ReadLine();

            Console.WriteLine("ikinci sayıyı giriniz");
            string sayı2 = Console.ReadLine();
            







            int sayı1Int = int.Parse(sayı1);
            int sayı2Int = int.Parse(sayı2);
            Console.WriteLine("iki sayının toplamı" + (sayı1Int+sayı2Int));





















        }
    }
}
