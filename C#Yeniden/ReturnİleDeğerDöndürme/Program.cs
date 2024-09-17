using System.Data;

namespace ReturnİleDeğerDöndürme // Baş isim
{
    class Program // sınıfı ve ismi
    {
        static void Main(string[] args) // Metot
        {
            // Parametre alan -Geriye Değer Döndüren Metot Tanımlama
            // return anahtar kelımesi
            // metot sonu
           Console.WriteLine( YapToplama(10,2)); // metoda götür // artık burası 12 değerine sahip
           int donenDeger = YapToplama(12,3);
           Console.WriteLine(donenDeger);
            string ısım = IsımSoyIsımDondur("Muhammed Said", "Eruslu");
            Console.WriteLine(ısım);
            
        }
        static int  YapToplama(int sayı1,int sayı2)
        {
            int sonuc = sayı1+sayı2;
        
            return sonuc; // burda kı sonucu al
            
        }

        static string IsımSoyIsımDondur(string isim, string soyisim)
        {
            // Return Anahtar kelimesinin iki işlevi vardır
            // 1- Değerleri Döndürmesi
            // 2- Return Anahtar Kelimesi Metodu Bitiren Anahtar Kelimedir
            return isim + " " + soyisim; // return anahtar kelimesi bir metodun bitişidir
            System.Console.WriteLine("sdasdad"); // return metodu bitiriği için her şey soluk 
        }
    }
}