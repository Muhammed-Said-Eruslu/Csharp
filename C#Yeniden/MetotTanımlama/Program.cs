// parametresiz geriye değer dondurmeyen metot tanımlama

namespace MetotTanımlama
{
  class Program
  {
    static void Main (string[] args)
    {
        SelamVer(); // derleyiciye selam ver metodunun içine git dıyor
        AdınıYaz("Muhhamed Said",19); // parametreli
        AdınıYaz();
        SelamVer();
    }

    static void SelamVer()
    {
        Console.WriteLine("Selamlar");
    }
    static void AdınıYaz(string ad,int yas)
    {
        System.Console.WriteLine(ad);
        System.Console.WriteLine(yas);
    }
    static void AdınıYaz() // overload oldu
    {
        System.Console.WriteLine("Muhammed Said 19");
    }

  }
}
