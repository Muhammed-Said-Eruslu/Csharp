using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichCaseYapısı
{
    class Program
    {
        static void Main(string[] args)

        {
            // swich case yapısı ile mini atm uygulaması
            // 1 bakiye goruntuleme
            // 2 para çek 
            // 3 para yatır 
            // 4 çıkış yap 
            // 1 2 3 4 dışında bir değer girilmişse hata versin 
            Console.WriteLine("Lütfen bir işlem seçiniz");
            Console.WriteLine("1 bakiye görüntüleme");
            Console.WriteLine("2 para çekme");
            Console.WriteLine("3 para yatırma");
            Console.WriteLine("4 çıkış yapma");
            string secim = Console.ReadLine();
            int bakiye = 700;

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz:" + bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz:" + (bakiye - cekilecek_tutar));
                        Console.ReadLine(); 
                    }
                    break;
                case "3":
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                    int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yeni Bakiyenizz :" + (bakiye + yatırılacak_tutar));
                    Console.ReadLine(); 
                    break;

                case "4":
                    Console.WriteLine("Hesabınızdan çıkış yapılıyor iyi günler");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Lütfen Geçerli bir işlem giriniz");
                    Console.ReadLine();
                    break;






            }

        }
    }
}
