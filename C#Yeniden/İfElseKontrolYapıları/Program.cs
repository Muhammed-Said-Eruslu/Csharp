// Öğrenicinin notu 50 den büyükse başarılı değilse başarısız

Console.WriteLine("Notunuzu Giriniz");
int not = int.Parse(Console.ReadLine());

if(not > 50)
{
    Console.WriteLine("Başarılı");
}
else
{
    Console.WriteLine("Başarısız");
}