using ClassOluşturma;

namespace ClassOlusturma
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Araba araba = new Araba(); // araba sınıfından yeni bir obje olusturuyorum // class kullanımı adında bir tane namespacem var namespacin icinde tanımlanmıs araba adında bir class var
            araba.arabaModeli = "Dodge"; // araba classının ıcınde bir string deger alırım
            araba.arabaRengi = "Siyah"; // araba classının ıcınde bir string değer alırm
            araba.kapıSaysı = 2; // araba classının ıcınde int bir değer alırım
            araba.motorCalıstır(); // araba sınıfı ıcersinde bir metodum parametre almam geriye değer dondurmem
            araba.kapıKılıtlte(); // araba sınıfının içinde bir metodum parametre almam geriye değer dondurmem

            Console.WriteLine($"Araba Modeli {araba.arabaModeli}");
            Console.WriteLine($"Araba Rengi {araba.arabaRengi}");
            Console.WriteLine($"Araba Kapı Sayısı {araba.kapıSaysı}");
            

        }
    }
}
