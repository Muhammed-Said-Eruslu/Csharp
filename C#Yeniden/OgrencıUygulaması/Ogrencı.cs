using System;

namespace OgrencıUygulaması;

public class Ogrencı
{
    private int ogrencıNo; // private olarak tanımladığım ıcın bu sınıfın dısında kullanılamaz üretilemez

    private string ısım;

    private string soyIsım;

    private double vize1;

    private double vıze2;

    private double fınal;

    private string okulIsım;

    public Ogrencı(int _ogrencıNo, string _Isım, string _soyIsım, double _Vize1, double _Vıze2, double _Fınal, string _OkulIsım) // kullanıcadan aldığım parametreleri
    {
        ogrencıNo = _ogrencıNo; // parametre larak gelen değerler yukarda tanımladıgım değerlere eşit oldu
        ısım = _Isım; // private olarak tanımladıgım değişkene atarım bu classta oldugu ıcın ben kullana bılırım
        soyIsım = _soyIsım;
        vize1 = _Vize1;
        vıze2 = _Vıze2;
        fınal = _Fınal;
        okulIsım = _OkulIsım;
    }

    public void OgrencıBılgılerınıGoster()
    {
        Console.WriteLine($"Öğrenci Numarası : {ogrencıNo}");
        Console.WriteLine($"Öğrenci İsmi : {ısım}");
        Console.WriteLine($"Öğrenci Soy İsmi : {soyIsım}");
        Console.WriteLine($"Öğrenci Vize 1 : {vize1}");
        Console.WriteLine($"Öğrenci Vize 2 : {vıze2}");
        Console.WriteLine($"Öğrenci Final : {fınal}");
        Console.WriteLine($"Öğrenci Okul İsmi : {okulIsım}");
    }

    public double OgrencıOrtalamaBul()
    {

     double toplamOrtlama = vize1 * 0.2 + vıze2 * 0.2 + fınal * 0.6; // ortlamasını bulurum
     Console.WriteLine($"Vize 1 Vize 2 Ve Finalin Ortlaması {toplamOrtlama}"); // ortlamayı yazdırıp
     return toplamOrtlama; // toplam ortlamayı dondururum 
    }
    public void OkulGetir()
    {
        Console.WriteLine($"Öğrencinin Okulu: {okulIsım}");
    }

}
