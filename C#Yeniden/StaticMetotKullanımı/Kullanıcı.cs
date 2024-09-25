using System;

namespace StaticMetotKullanımı;

public class Kullanıcı
{
    private int kullanıcıID { get; set; }

    private string İsmi { get; set; }

    private string  SoyIsımı { get; set; }

    private static int Maas {get; set;} // bunu statıc yapıyorum cunku statıc yapıcı metotda ulaşa bilmek için
    // program calıstıgında ılk yapıcı metot çalısır ama ıkı tane yapıcı metot varsa static olarak işaretlenmiş çalısır
    // static yapıcı  metot  erişim belirleyici (access modifiers) kulanamaz
    // static yapıcı metot parametre almazlar
    // Static yapıcı metot kaç nesne orneği oluşturulsa oluşturulsun bir kere çalışır

    static Kullanıcı()
    {
        Maas = 2500;
    }

    
    public Kullanıcı( int _kullanıcıID,string _İsmi,string _SoyIsımı) // ctor tab tab
    {
        _kullanıcıID = kullanıcıID;
        _İsmi = İsmi;
        _SoyIsımı = SoyIsımı;
       
    }
    public void BilgileriGoster()
    {
        Console.WriteLine($"Kullanıcı ID: {kullanıcıID}\nKullanıcı İsmi:{İsmi}\nKullanıcı Soyismi:{SoyIsımı}\nKullanıcı Maaşı{Maas}");
    }
    public void zamYap(int zamMıktarı)
    {
        Console.WriteLine($"Yeni Maaşı {Maas+zamMıktarı}");
    }
}
