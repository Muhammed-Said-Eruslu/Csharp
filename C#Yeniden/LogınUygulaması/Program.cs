// Kullanıcı Giriş Sayfası Uygulaması Yapacağız
// kullanıcı adı ve sifresini dogru girerse tebrikler başarılı bir gırıs yaptınız
// yanlış girerse hata verelim ve 3 hak tanımlıyalım kullanıcı yanlış giridiği sürece dongu devam etsin

using System.Drawing;

int kalanhak = 3; // kalan hakkımızı tanımladık

while(true) // true olmasının sebebi sifreyi ve kullanıcı adını yanlış girerse tekrar alabilmek için
{
    Console.WriteLine("Kullanıcı Adınızı Giriniz");
    string kullanıcıAdı = Console.ReadLine();

    Console.WriteLine("Şifrenizi Giriniz");
    string sifre = Console.ReadLine();

    if(kullanıcıAdı == "Said" && sifre == "123") // eşite bunlara
    {
        Console.WriteLine("Tebrikler Başarılı Bir Şekilde Giriş yaptınız");
        break; // donguyu kır cunku zaten giriş yaptı
    }
    else // değilse
    {
        if(kalanhak > 0) // kalan hak 0 dan buyuk oldugu surece  donguye gir
        {
            kalanhak--; // ve bir azalt
            Console.WriteLine($"Kalan Hakkınız: {kalanhak}");
        }
        if(kalanhak == 0) // 0 a eşitse hakkı bitmiştir
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Hakkınız Kalmadı: {kalanhak}");
            Console.ForegroundColor = ConsoleColor.White;
            break; // ve donguden cık
        }
    }
}

