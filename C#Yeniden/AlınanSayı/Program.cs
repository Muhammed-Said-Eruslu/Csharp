// kullanıcıdan bir sayı alacağız 0 dan başlayıp aldıgımız sayıya kadar toplıcaz
// ve girdiği sayıyı boleceğiz eğer ortlaması 50 den buyukse 50 den buyuktur değilse kücüktür

Console.WriteLine("Bir Sayı Giriniz"); // output olarak bır sayı ıstedım
int sayı = int.Parse(Console.ReadLine()); // ınput olarak yakalıdım readlıne da gırılen deger string oldugu ıcın ıslem yapmak icin int e cevirdim
int toplam = 0;

for(int i = 0; i <= sayı; i++) // 0 dan baslayıp kullanıcının girdiği sayıya kadar toplıyorum
{
    toplam += i; // döngünün her seferinde i yi toplama atıyorum

}
double ortlama = toplam/sayı; // toplamı sayıya boluyroum boylelıkle ortalamasını buluyorum
if(ortlama > 50) // ortalama 50 den buyukse
{
    Console.WriteLine("Bölümünden Kalan 50 den Büyükütür");
}
else 
{
    Console.WriteLine("Bölümünden Kalan 50 den Küçükütür");
}