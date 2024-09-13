// kullanıcıdan nasıl bir işlem yapmak istediğini soracağız
// 1- bakiye görüntüleme
// 2 para çekme
// 3 para yatırma
// q ya basarsa cıksın
int bakiye = 1000;
int cekılecekTutar = 0;

Console.WriteLine("Nasıl Bir İşlem yapmak istersin");
string secım = Console.ReadLine();

if(secım == "1")
{
    Console.WriteLine($"Şuan ki bakiyeniz {bakiye}");
}
else if(secım == "3")
{
    Console.WriteLine("Ne kadar yatırmak istersiniz");
    int yatıralacakTutar = int.Parse(Console.ReadLine());
    Console.WriteLine($"Yeni Bakiyeniz {bakiye+yatıralacakTutar}");
}
else if(secım == "2")
{
    Console.WriteLine("Ne kadar çekmek  istersiniz");
    cekılecekTutar = int.Parse(Console.ReadLine());
    
    
    if(cekılecekTutar > bakiye)
    {
        Console.WriteLine("BAKİYENİZDEN FAZLA PARA ÇEKEMEZSİNİZ");
    }
    else if(cekılecekTutar <= bakiye)
    {
        Console.WriteLine($"Yeni Bakiyeniz {bakiye-cekılecekTutar}");
    }
}
else if(secım == "q")
{
    Console.WriteLine("ATM'den çıkıs yapılıyor");
}