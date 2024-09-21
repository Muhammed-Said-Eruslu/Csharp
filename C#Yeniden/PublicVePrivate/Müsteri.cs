using System;

namespace PublicVePrivate;

public class Müsteri
{
    public string isim;
    public string soyisim;

    public int maasDegeri;

    public string cinsiyet;
    private int yas; // private oldugu ıcın sadece bu class ıcınden ulasabılırım
    // private bulunmus oldugu sınıf ıcersinden ulasılabılır ancak dıs dunyaya kapalıdır

    public Müsteri()
    {
        Console.WriteLine("Müşteri Sınıfının Yapıcı Metodu Çalıştı");
    }

     public void MusteriBilgileriniGoster()
     {
        Console.WriteLine($" isminiz: {isim}\nSoyisminiz: {soyisim}\nMaasınız: {maasDegeri}\nCinsiyetiniz: {cinsiyet}\nYaşınız: {yas}");
     }

     private void IsımSoyIsımYazdır(string musterıIsım, string musterıSoyIsım) // private metot oldugu ıcın sadece bu class ıcınden ulasabılırım
     {
        Console.WriteLine($"İsminiz: {musterıIsım}  Soyısmınız: {musterıSoyIsım} ");
     }
}
