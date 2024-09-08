// See https://aka.ms/new-console-template for more information
// metodlar neden yazılır 
// mesala veri tabanına kullaıcının bilgilerini kaydetme işlemi var
// kaydetme metodunu ayrı ayrı yazarsan onlarca yeri değiştirmek gerekir


//static void Add() // farklı yerlerde kullanım amacı ıcın yapılır kendı fonkısoyumuz gibi bişey
// metodlar publıc private protected gibi erişim belirleyiciler ile tanımlanabilirler.

//var result = Add2(20); // Add2 de iki parametre var ve ikisini de girmek zorunlu
 // aslında elımde kı resultun bu metodun calısması sonucunda ortya cıkan int diyoruz derleyeyiciye
 //Console.WriteLine(result);

/*int number1; // ilk basta değer 20 di ama ref kullandıgımız ıcın methodun ıcınde kı 30 ile değişti
int number2 = 100;
var result2 = Add3(out number1,number2); // number1 gitmıyor 20 gidiyor yada 100
Console.WriteLine(result2); // 130
Console.WriteLine(number1); // 20*/


Console.WriteLine(Çarpma(2,4));
Console.WriteLine(Carpma(2,4,5));
Console.WriteLine(Add4(10,20,30,30,340,3));

{
    Console.WriteLine("Added");
}
// Statik Metodlar: Genellikle sınıfa özgü olan ve nesne oluşturulmadan kullanılabilen işlevler için uygundur. Örneğin, matematiksel işlemler, 
//yardımcı işlevler ve veri paylaşımı gibi işlevler için kullanılır. Sınıfın genel işlevlerini temsil eder.
// Dinamik Metodlar: Nesneye özgü olan ve sınıfın belirli bir örneği ile ilişkili işlevler için uygundur. Örneğin, 
//nesnenin durumunu değiştiren veya nesneye özgü verilerle çalışan işlevler için kullanılır.
// dinamık classın ıcınde olması lazım ama statık classın ıcınde olmasa da olur
// kendini tekrarlama metodunu kullanmak ıcın yaparz

static int Add2(int number1, int number2=30) // add2 yi kullanan kısının number1 ve number2 iki tane değişken gondermesi lazım
// voıd git sunuu yap demek bi işlem yap  // ne tipte veri dondurmek ıstıyorsak veri tipini ona gore değiştiriyoruz
// sonuc tipimin yine int olması lazım
// sonradan number2 = 30 yaptım neden
// eğer number2 ye değer verilmese default olarak 30 u kullan ama verilirse o kullanılır 30 kullanılmaz
// ve onceden Add2() metoduna iki parametre gırmek zorunluydu ben number2 = 30 dediğim için artık 1 parametre alsa bile yeter
// default değerlerim her zaman metodun en sonunda olması lazım ama ikisinede sayı verirsen sıkıntı olmaz

{
    var result = number1 + number2;
    return result;
}

static int Add3(out int  number1 ,int number2)
{
    number1 = 30;
    return number1 + number2;
}

// ref: bellkete iki number1 gonderdiğimizde aslında bellekte ıkı tane değişken kullanıyor
// onun yerine number1 refini kullan methoddakı 
// refin alternatifi out mantık olarak aynı
// farkı refde number 1 mutlaka değeri olması lazım ama outta boyle bir şeye gerek yok


static int Çarpma(int number1 ,int number2) // int Çarpma(int number1 ,int number2) burası metodun imzası
// aynı sekılde olamaz ama 3 parametre alırsa olur
{
    return number1 * number2;
}

static int Carpma(int number1 ,int number2,int number3) // methodoverload aşırı yuklenme
{
    return number1 * number2 * number3;
}

static int Add4(params int[] numbers) // params formatında birden fazla sayı alabılırım
{
    return numbers.Sum(); // çsum dızıde kı butun sayıları topla sonucu return et
}
// params ile metodumuza ayni tipte istediğimiz kadar parametre gondere biliriz
// params parametrelerin son metodu olmak zorunda

Console.ReadLine();