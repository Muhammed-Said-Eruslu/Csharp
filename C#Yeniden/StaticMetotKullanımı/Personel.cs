using System;

namespace StaticMetotKullanımı;

public class Personel
{
    public static int a;
    public static void IsımSoyIısmYazdır()
    {
        Console.WriteLine("Said Eruslu");
    }

    public static void IkıSayınınToplamı(int a,int b)
    {
        int toplam = a+b;
        Console.WriteLine($"İki Sayının Toplamı : {toplam}");
    }
}
