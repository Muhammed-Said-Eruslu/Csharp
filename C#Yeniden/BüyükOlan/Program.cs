namespace BüyükOlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan ıkı sayı alalım hangisi büyükse ekrana onu yazdıralım
            Büyük(40,30);
        }

        static void Büyük(int a , int b)
        {
            if(a > b)
            {
                Console.WriteLine($"Girilen İlk Sayı İkinci Sayıdan Büyüktür: {a}");
            }
            else if(a == b)
            {
                Console.WriteLine($"İki Sayı Bir birine Eşittir: {a} {b}");
            }
            else
            {
                Console.WriteLine($"Girilen İkinci Sayı Birinici Sayıdan Büyüktür: {b}");
            }
        }
    }
}