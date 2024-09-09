// See https://aka.ms/new-console-template for more information
/*bool girisBasarılı = false; // daha giriş yapmadığı için false
string kullanıcıAdı; // tanımlama yaptık
string sifre; // aynen tanımlama

do
{
 Console.WriteLine("Lütfen Kullanıcı adınızı giriniz"); // kullanıcıdan kullancı adını istedik
 kullanıcıAdı = Console.ReadLine(); // inpt olarak aldık
 Console.WriteLine("Lütfen Şifrenizi Giriniz"); // sifre istedik output
 sifre = Console.ReadLine(); // input aldık sifre

 if(kullanıcıAdı == "Said" && sifre == "1234") // eğer gelen değer de kullanıcı adı Said'e eşitse ve sifre 1234 se blok çalısır
 {
    girisBasarılı = true; // döngüden çıkmak için true yapılır
    Console.WriteLine("Giriş Başarlı Hoşgeldiniz"); // şart sağlanırsa output mesajı
 }
 else // sağlanmazsa
 {
    Console.WriteLine("Giriş Yapılamadı"); // output mesajı
 }
}while(!girisBasarılı); // eğer sağlanmazsa başa döner cunku girisBasarılı değişkeni hiç bir zaman true olması true olana kadar devam eder */

// kullanıcıdan bir sayi alınız 
//girilen sayı tek ise tek cift ise cift yazsın
// girilen sayı değilse lütfen 
//sayı gırınız yazsın ve tekrar giriş istensin goto ile

/*basaDön: // basaDon dediğin zaman kod hata verdiği surece  bu lineden tekrar çalısır
try // try dene demek
{
    Console.Write("Lütfen bir sayı giriniz: "); // output olarak mesaj verdik
    int sayi = int.Parse(Console.ReadLine()); // neden inte çevirdik cunku ReadLine string değer tutar string değeri işlem yapmak için çevirdik

    if (sayi % 2 == 0) // eğer sayının 2 ye bölümünden kalan 0 sa
    {
        Console.WriteLine("Girilen Sayı Çifttir."); // burası çalısır
    }
    else // değilse
    {
        Console.WriteLine("Girilen Sayı Tektir."); // burası çalısır
    }
}
catch (FormatException) // else gibi Format hatası veriyoruz
{
    Console.WriteLine("Lütfen geçerli bir sayı giriniz."); // hatali girerse bu mesajı alır ve
    goto basaDön; // başa doner
}*/

// 1945 ile su ankı zamanı yazsın ama 1989 ve 1998 kırmızı yazsın

/*for(int yıl = 1945; yıl <= DateTime.Now.Year; yıl++) // yılı 1945 ten başlattık yıl şuan ki yıla eşit olana kadar devam edicek
{
 if(yıl == 1989 || yıl == 1998) // eğer yıl 1989 veya 1998 ise
 {
    Console.ForegroundColor = ConsoleColor.Red; // burası çalısır ve 1989 veya 1998 kırmızı olur
 }
 else // değilse
 {
    Console.ResetColor(); // basıc renge don
 }
 Console.WriteLine(yıl); // her seferinde yılı ekrana yazdır
}*/

// 1-100 arasında ki cift sayıların toplamı
// ıle tek sayıların toplamı farklarının karesi kaçtır

/*int fark = 0;
int tekToplam = 0;
int ciftToplam = 0;

for(int i = 0; i <= 100; i++) // i  100 olana kadar devam edıyor
{
    if(i % 2 == 0) // eğer i nin 2 ye bolumunden kalan 0 sa çifttir bu blok çalısır
    {
        ciftToplam += i; // çift toplamını bulmak ıcın yaparız i her arttiğında cifttoplama atar
    }
    else // değilse tek demek zaten
    {
        tekToplam += i; // aynı sekılde teker teker tektoplama atama yapar
    }
}
fark = ciftToplam-tekToplam; // sonra farkı bulmak için ciftten teki çıkartır
fark = fark * fark; // ve farkın karesini alır
Console.WriteLine(fark); // sonra farkı ekrana yazdırır*/


// for ile tek sayıların toplamı 
/*int toplam = 0;
for(int i = 1; i <= 100; i = i+2)
{
    toplam += i;
} 

Console.WriteLine(toplam);*/

/*int toplam = 0;

for(int i = 0; i <=100; i = i+2)
{
    toplam += i;
}
Console.WriteLine(toplam);*/

// kullanıcıdan alınan 10 adet sayının toplamını ekrana yazdıran program
/*Console.WriteLine("10 adet sayı giriniz");
int toplam = 0;

for(int i = 0; i < 10; i++)
{
    int sayı = int.Parse(Console.ReadLine());
    toplam += sayı;
    
}
Console.WriteLine(toplam);*/

/*int toplam = 0;
int adet = 5;

//Kullanıcıdan 5 adet pozitif
// tam sayı alıp, bu sayıların ortalamasını ekrana yazdıran bir program yazın.
for(int i = 1; i <= adet; i++)
{
    Console.Write("Lütfen pozitif bir tam sayı girin: ");
    int sayı = int.Parse(Console.ReadLine());
    if(sayı > 0)
    {
        toplam += sayı;
    }
    else
    {
        Console.WriteLine("Lütfen Pozitif Giriniz");
        i--;
    }
    double ortlama = (double)toplam/adet;
    Console.WriteLine(ortlama);
}*/

// Kullanıcıdan 10 adet tam sayı alın. Bu sayıların kaç tanesinin
// pozitif, kaç tanesinin negatif 
//ve kaç tanesinin sıfır olduğunu ekrana yazdıran bir program yazın.

/*for(int i = 0; i < 10; i++)
{
    int sayı = int.Parse(Console.ReadLine());
    Console.WriteLine($"10 Adet Sayı Giriniz: Sayınız = {sayı} ");
    if(sayı > 0)
    {
        Console.WriteLine("Sayınız Pozitif");
    }
    else if(sayı < 0)
    {
        Console.WriteLine("Sayınız negatif");
    }
    else if(sayı == 0)
    {
        Console.WriteLine("Sayınız 0");
    }
    
}*/

/*int negatifSayılar = 0;
int pozitifSayılar = 0;
int sıfırSayısı = 0;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Lütfen Bir Sayı Giriniz");
    int sayı = int.Parse(Console.ReadLine());

    if(sayı > 0)
    {
        Console.WriteLine("Sayınız Pozitif");
        pozitifSayılar++;
    }
    else if(sayı < 0)
    {
        Console.WriteLine("Sayınız Negatif");
        negatifSayılar++;
    }
    else if(sayı == 0)
    {
        Console.WriteLine("sayınız Sıfır");
        sıfırSayısı++;
    }
    Console.WriteLine($"Toplam Pozitif Sayılar{pozitifSayılar}");
    Console.WriteLine($"Toplam Negatif Sayılar{negatifSayılar}");
    Console.WriteLine($"Toplam Sıfır Sayılar{sıfırSayısı}");
}*/

// Kullanıcıdan 10 adet sayı alıp bu sayıların en büyüğünü 
// ve en küçüğünü ekrana yazdıran bir program yazın.

/*int enBuyk, enKucuk;
Console.WriteLine("Lütfen Bir Sayı Giriniz");
int sayı = int.Parse(Console.ReadLine());

enBuyk = sayı;
enKucuk = sayı;

for(int i = 1; i < 10; i++)
{
    Console.WriteLine("Lütfen Bir Sayı Giriniz");
    sayı = int.Parse(Console.ReadLine());

    if(sayı > enBuyk)
    {
        enBuyk = sayı;
    }
    else if(sayı < enKucuk)
    {
        enKucuk = sayı;
    }
    Console.WriteLine($"En Büyük Sayı {enBuyk}");
    Console.WriteLine($"En Küçük Sayı {enKucuk}");
}*/