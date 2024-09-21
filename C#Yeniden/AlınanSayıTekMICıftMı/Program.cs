namespace AlınanSayıTekMıCıftMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullınıdan alınan sayı tek mı cıkt mı metot
            TekCıft(6); // tek cıft metodu
        }

        static void TekCıft(int a) // parametre olarak bir int alır ve geriye değer dondurmez
        {
            if(a % 2 == 1) // girilen sayının ıkıye bolumunden kalan 1 se tektır
            {
                Console.WriteLine($"Girilen Sayı Tektir {a}");
                
            }
            else
            {
                Console.WriteLine($"Girilen Sayı Çifttir {a}");
                
            }
        }
    }
}