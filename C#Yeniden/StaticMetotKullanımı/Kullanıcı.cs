using System;

namespace StaticMetotKullanımı;

public class Kullanıcı
{
    private int kullanıcıID { get; set; }

    private string İsmi { get; set; }

    private string  SoyIsımı { get; set; }

    private static int Maas {get; set;}

    static Kullanıcı()
    {
        Maas = 2500;
    }

    
    public Kullanıcı( int _kullanıcıID,string _İsmi,string _SoyIsımı,int _Maas) // ctor tab tab
    {
        _kullanıcıID = kullanıcıID;
        _İsmi = İsmi;
        _SoyIsımı = SoyIsımı;
        _Maas = Maas;
    }
    public void BilgileriGoster()
    {
        Console.WriteLine($"Kullanıcı ID: {kullanıcıID}\nKullanıcı İsmi:{İsmi}\nKullanıcı Soyismi:{SoyIsımı}\nKullanıcı Maaşı{Maas}");
    }
}
