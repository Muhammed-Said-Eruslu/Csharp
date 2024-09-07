using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniatm
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            // kullanıcıya soracağız nasıl bir işlem yapmak istediğini 
            // 1 para çekme
            // 2 para yatırma
            // 3 bakiye goruntuleme
            // q ya basarsa çıkıs yaptırcağız
            Console.WriteLine("ATM ye hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            string secim = Console.ReadLine();

            if (secim=="1")
            {
                Console.WriteLine("Şuanki bakiyeniz"+ bakiye);
                Console.ReadLine();

            }
            else if (secim== "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecek_tutar<=bakiye)
                {

                    Console.WriteLine("Kalan tutar :" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("bakiyenizden fazla para cekemezsiniz");
                    Console.ReadLine();
                }
                



            }
            else if(secim=="3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriinz");
                int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni tutar :" + (bakiye +yatırılacak_tutar));
                Console.ReadLine();
            } 
            else if(secim=="q")
            {
                Console.WriteLine("ATM den çıkış yapılıyor");
                Console.WriteLine("Çıkıs yapıldı iyi günler dileriz");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                Console.ReadLine();
            }


            

        }
    }
}
