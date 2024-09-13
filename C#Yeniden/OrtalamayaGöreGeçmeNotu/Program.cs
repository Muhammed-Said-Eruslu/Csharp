// Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan program 
// Eğer  80 100 arasındaysa A+
// 60 80 arasındaysa A
// 40 60 arasındaysa B+
// 40 dan kücükse F yazdıran

Console.WriteLine("3 Tane Not Giriniz");
int not1 = int.Parse(Console.ReadLine());
int not2 = int.Parse(Console.ReadLine());
int not3 = int.Parse(Console.ReadLine());

double notOrtalama = (not1+not2+not3) / 3;

if(notOrtalama >= 80 && notOrtalama <= 100)
{
    Console.WriteLine("Not Ortalaması A+");
}
else if(notOrtalama >= 60 && notOrtalama < 80)
{
    Console.WriteLine("Not Ortlaması A");
}
else if(notOrtalama >= 40 && notOrtalama <  60)
{
    Console.WriteLine("Not Ortlaması B+");
}
else
{
    Console.WriteLine("Not Ortlaması F");
}