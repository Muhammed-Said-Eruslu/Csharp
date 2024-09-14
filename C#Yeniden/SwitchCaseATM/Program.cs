// 1 Bakiye goruntuleme
// 2 Para cek
// 3 para yatır
// q cıkıs

using System.Drawing;
using System.Globalization;

string doğruKullanıcıAdı = "Said";
string doğruSifre = "1234";

Console.WriteLine("Kullanıcı Adınızı Giriniz");
string kullanıcıAdı = Console.ReadLine();

Console.WriteLine("Şifrenizi Giriniz");
string sifre = Console.ReadLine();

bool girişBaşarılı = false;  // Giriş durumunu kontrol etmek için

while (!girişBaşarılı)
{
    // Şifre ve kullanıcı adı doğrulama
    if (kullanıcıAdı == doğruKullanıcıAdı && sifre == doğruSifre)
    {
        girişBaşarılı = true;  // Giriş başarılıysa true yapıyoruz
        int bakiye = 1000;

        while (true)  // Kullanıcı çıkana kadar işlemler yapılacak
        {
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz (1: Bakiye Görüntüle, 2: Para Çek, 3: Para Yatır, 4: Bilgileri Gör, q: Çıkış)");
            string secim = Console.ReadLine();

            try
            {
                switch (secim)
                {
                    case "1":
                        Console.WriteLine($"Şuanki Bakiyeniz: {bakiye}");
                        break;

                    case "2":
                        Console.WriteLine("Çekmek istediğiniz Tutarı Giriniz");
                        int cekilecekTutar = int.Parse(Console.ReadLine());

                        if (cekilecekTutar > bakiye)
                        {
                            Console.WriteLine("Mevcut Bakiyenizden Fazla Para Çekemezsiniz");
                        }
                        else
                        {
                            bakiye -= cekilecekTutar;
                            Console.WriteLine($"Yeni Bakiyeniz: {bakiye}");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                        int yatirilacakTutar = int.Parse(Console.ReadLine());
                        bakiye += yatirilacakTutar;  // Yatırma işlemiyle bakiye artar
                        Console.WriteLine($"Yeni Bakiyeniz: {bakiye}");
                        break;

                    case "4":
                        Console.WriteLine("Kullanıcı Adınız: Muhammed Said Eruslu");
                        Console.WriteLine("Şifreniz: 1234");
                        break;

                    case "q":
                        Console.WriteLine("ATM'den Çıkış Yapılıyor...");
                        return;  // Çıkış yapmak için

                    default:
                        Console.WriteLine("Lütfen geçerli bir işlem giriniz.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Bir hata oluştu. Lütfen tekrar deneyin.");
            }
        }
    }
    else
    {
        // Hatalı giriş durumu
        Console.WriteLine("Şifreniz veya kullanıcı adınız yanlış.");
        Console.WriteLine("Tekrar denemek ister misiniz? (Y/N)");
        string tekrar1 = Console.ReadLine().ToLower();

        if (tekrar1 == "y")
        {
            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            kullanıcıAdı = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz:");
            sifre = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("ATM'den Çıkış Yapılıyor...");
            return;  // Kullanıcı tekrar denemek istemezse programdan çıkış yap
        }
    }
}
