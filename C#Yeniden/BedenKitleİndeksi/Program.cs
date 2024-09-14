// Beden kitle indeksi = kılo / boy*boy
// Beden kitle indeksi 18 e eşitse veya dusukse zayıf
// 18 25 normal
// 25 ten buyuk obez

using System.Collections.Concurrent;

Console.WriteLine("Kilonuzu Giriniz");
int kılo = int.Parse(Console.ReadLine());

Console.WriteLine("Boyunuzu Girinizi");
double boy = double.Parse(Console.ReadLine());



double bki = kılo / (boy*boy);

if(bki < 18)
{
    Console.WriteLine("Zayif");
}
else if(bki > 18 && bki < 25)
{
     Console.WriteLine("Normal");
}
else if(bki > 25)
{
    Console.WriteLine("Obez");
}