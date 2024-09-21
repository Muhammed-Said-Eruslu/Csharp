using ClassOluşturma;

namespace ClassOlusturma
{
    internal class Program
    {
        static void Main(string[]args)
        {
            /* araba.arabaModeli = "Dodge"; // araba classının ıcınde bir string deger alırım
            araba.arabaRengi = "Siyah"; // araba classının ıcınde bir string değer alırm
            araba.kapıSaysı = 2; // araba classının ıcınde int bir değer alırım*/

            Araba araba = new Araba(2,"Dodge","Siyah"); // araba sınıfından yeni bir obje olusturuyorum // class kullanımı adında bir tane namespacem var namespacin icinde tanımlanmıs araba adında bir class var
            // araba objesıne değerler verıyorum
            araba.motorCalıstır(); // araba sınıfı ıcersinde bir metodum parametre almam geriye değer dondurmem
            araba.kapıKılıtlte(); // araba sınıfının içinde bir metodum parametre almam geriye değer dondurmem

            Console.WriteLine($"Araba Modeli {araba.arabaModeli}"); // burda araba modeline dodge demişim yapıcı metode gıder ve ordakı parametreye dodgeyı atar ve arabamodelı artık dodge olur 
            Console.WriteLine($"Araba Rengi {araba.arabaRengi}"); //  burda araba rengine siyah demişim yapıcı metode gıder ve ordakı parametreye siyah atar ve arabatrngi artık dodge olur
            Console.WriteLine($"Araba Kapı Sayısı {araba.kapıSaysı}"); //  burda araba modeline kapısı sayısına 2  demişim yapıcı metode gıder ve ordakı parametreye 2 yi atar ve kapısayısı artık 2 olur
            

        }
    }
}

#region YapıcıMetotlar
// Yapıcı Metotlar : classlardan obje olusturdugum sırada oluşan , geriye dönüş tipi olmayan metottur

// Araba araba = new Araba();

/*
    public class Araba
    {
        public Araba() // class ısmını tasımak zorunda
        {
            // Araba classının yapıcı metodunun içindeyiz
        }
    }

    Main()
    Araba araba = new Araba(); // new Araba dediğimiz zaman Araba sınıfının yapıcı metodunu temsil eder // derleyici ilk sağdan okur 
*/

#endregion
