using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirişUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı giriş sayfası uygulaması
            // kullanıcı adını doğru bir şekilde girerse tebrikler başarılı bir şekilde giriş yaptınız
            // yanlış girerse hata versin ve 3 hakkı olsun yanlış bilgi girdiği sürece döngü devam etsin
            int hak_sayısı = 3;
            while (true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz");
                string kullanıcıAdı = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz");
                string sifre = Console.ReadLine();




                if (kullanıcıAdı=="Muhammed Said Eruslu"&& sifre=="2KcmgFYpI")
                {
                    Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız");
                    break;  

                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış !");
                    if (hak_sayısı>0)
                    {
                        hak_sayısı -= 1;


                    }
                    if (hak_sayısı==0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur bidaha giriş yapamazsınız !");
                        break;
                    }
                }
            }
            Console.ReadLine();



        }
    }
}
