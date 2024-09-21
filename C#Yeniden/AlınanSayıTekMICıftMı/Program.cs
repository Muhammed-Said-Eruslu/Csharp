namespace AlınanSayıTekMıCıftMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullınıdan alınan sayı tek mı cıkt mı metot
            TekCıft(6);
        }

        static void TekCıft(int a)
        {
            if(a % 2 == 1)
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