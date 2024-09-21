namespace OgrencıUygulaması
{
    class Program
    {
       public static void Main(string[] args)
        {
            Ogrencı ogrencı = new Ogrencı(368,"Muhammed Said","Eruslu", 90,90,85,"İTU");
            Console.WriteLine("Uygulamamıza Hoş Geldiniz Yapmak İstediğiniz İşlemi Seçiniz");
            Islemler();
            string ıslem = Console.ReadLine();

            switch(ıslem)
            {
                case "1":
                ogrencı.OgrencıBılgılerınıGoster();
                break;
                case "2":
                ogrencı.OgrencıOrtalamaBul();
                break;
                case "3":
                ogrencı.OkulGetir();
                break;
                case "4":
                Console.WriteLine("Çıkış Yapılıyor");
                break;

                default:
                Console.WriteLine("Lüten Geçerli Bir İşlem Giriniz");
                break;
            }

            
        }


        static void Islemler()
        {
            Console.WriteLine("1- Öğrenci Biligilerini Göster 2- Öğrencinin Ortalamasını Göster 3- Öğrenicini Okulunu Göster 4- Çıkıs Yap");
        }

       
        
    }
}
