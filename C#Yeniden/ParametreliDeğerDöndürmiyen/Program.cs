using System.Globalization;

namespace ParametreliDeğerDöndüriyen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parametre Alan Değer Döndürmeyen Metotlar
            //Toplama(12,3);
           // Carpım(3,3,3);
           IsımSoyısım("Muhammed Said","Eruslu");
        
        }
        static void Toplama(int toplam1,int toplam2)
        {
            Console.WriteLine($"İki Sayının Toplamı {toplam1+toplam2}");
        }

        static void Carpım(int carp1,int carp2,int carp3)
        {
            int carpım = carp1 * carp2 * carp3;
            Console.WriteLine($"Üç Sayının Çarpımı {carpım}");
        }
        
        static void IsımSoyısım(string isim,string soyısım)
        {
            Console.WriteLine($"İsminiz: {isim}");
            Console.WriteLine($"Soy İsminiz {soyısım}");
        }
    }
}
