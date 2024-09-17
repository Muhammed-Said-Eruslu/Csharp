namespace  İkiSayıAlma
{
    class Program
    {
        static void Main(string[]args)
        {
            // Kullanıcıdan İkİ sayı alalım hangisi büyükse ekrana onu yazdıralım
            Console.WriteLine("iki sayı Giriniz");
            int sayı1 = int.Parse(Console.ReadLine());
             int sayı2 = int.Parse(Console.ReadLine());
             BüyükKüçük(sayı1,sayı2);
        }
        static void BüyükKüçük(int a,int b)
        {
            if(a > b)
            {
                Console.WriteLine("Birinci Sayı İkinci Sayıdan büyüktür");
            }
            else if( a < b)
            {
                Console.WriteLine("ikinci Sayı Birinci Sayıdan Büyüktür");
            }
            else if(a == b)
            {
                Console.WriteLine("İki Sayı Bir birine eşittir");
            }
        }
    }
}
