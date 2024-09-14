// kullanıcıdan bir sayı alacağız 0 dan başlayıp aldıgımız sayıya kadar toplıcaz
// ve girdiği sayıyı boleceğiz eğer ortlaması 50 den buyukse 50 den buyuktur değilse kücüktür

Console.WriteLine("Bir Sayı Giriniz");
int sayı = int.Parse(Console.ReadLine());
int toplam = 0;

for(int i = 1; i <= sayı; i++)
{
    toplam += i;

}
double ortlama = toplam/sayı;
if(ortlama > 50)
{
    Console.WriteLine("Bölümünden Kalan 50 den Büyükütür");
}
else 
{
    Console.WriteLine("Bölümünden Kalan 50 den Küçükütür");
}