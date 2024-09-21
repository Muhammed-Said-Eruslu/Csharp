using System;

namespace ClassOluşturma;

public class Araba
{
    public int  kapıSaysı;
    public string arabaModeli;
    public string arabaRengi;

    public Araba(int _kapıSaysı, string _arabaModeli, string _arabaRengi) // yapıcı metot bu şekilde tanımlanır kısaltılmıs halı ctor  // parametre alabilir
    {
        kapıSaysı = _kapıSaysı; // gelen degerler publıcc olarak kapısaysına esit araba.kapısayısı denilidiği zaman ıcınde kı değeri bize gostericek
        arabaModeli = _arabaModeli; // aynı sekılde .arabamdelı dediğim zaman ıcınde hangı değer varsa bana onu verir
        arabaRengi = _arabaRengi;
    }
  /*  public Araba(Parameters) ctor ile ctor yazıp tab tab  constructurın kısaltılmıs halı
    {
        
    }*/

    public void motorCalıstır()
    {
        Console.WriteLine("Motor Calısıyor");
    }
    public void kapıKılıtlte()
    {
        Console.WriteLine("Kapılar Kilitlenioyr");
    }

}
