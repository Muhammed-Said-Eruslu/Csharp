// kullanıcını girdiği sayı dizide var mı varsa kac tane oldugunu yoksa uyarı versin

System.Console.WriteLine("Bir Sayı Giriniz");
int gir = int.Parse(Console.ReadLine());
int[] sayılar = {1,234,63,53,67,3,6,25,78,3,4,7,37,534,233,1};
int kaçTanevar = 0;
foreach(var i in sayılar)
{
  if(gir == i)
  {
   kaçTanevar++;
  }  

}
if(kaçTanevar== 0)
{
    System.Console.WriteLine("Girdiğiniz Sayı Dizide Yoktur");
}
else if( kaçTanevar != 0)
{
    System.Console.WriteLine($"Şu kadar sayıda dızıde vardır {kaçTanevar}");
}