namespace TekMıÇitMıMeTOT
{
    class Program
    {
        static void Main(string[]args)
        {
            // kullanıcıdan alınan sayı tek mı cıft mı metotu yazalım 
            Console.WriteLine("Bir Sayı Giriniz");
            int sayı = int.Parse(Console.ReadLine());
           int deneme =  TekCıft(sayı);
           Console.WriteLine(deneme);
              Console.WriteLine("Bir Sayı Giriniz");
            int sayı2 = int.Parse(Console.ReadLine());
            TekCuft(sayı2);
            Console.WriteLine(sayı2);
           
        }
        static int TekCıft(int a)
        {
            if(a % 2 == 0)
            {
                Console.WriteLine("Sayı Çifftir");
                return a;
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
                return a;
            }
        }  
        static void TekCuft(int a)
        {
            if(a % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }
        } 
        
    }
}