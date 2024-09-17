namespace KaresiniAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan aldıgımız sayının karesini alalım eğer sayı 25 den buyukse 25 den buyuk yazsın değilse ..

            Console.WriteLine("Bir Sayı Giriniz");
            int bırSayı = int.Parse(Console.ReadLine());
           int bakalım =  KaresinAl(bırSayı);
           
           if(bakalım >= 25)
           {
            Console.WriteLine("Sayının Karesi 25 den Büyük Veya Eşit");
           }
           else
           {
            Console.WriteLine("Sayının Karesi 25 den Küçük");
           }
        }
        static int KaresinAl(int a)
        {
            return a*a;
        }
   }
 }  
