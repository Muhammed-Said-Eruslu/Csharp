namespace OgrencıUygulaması
{
    class Program
    {
       public static void Main(string[] args)
        {
            Ogrencı ogrencı = new Ogrencı(368,"Muhammed Said","Eruslu", 90,90,85,"İTU"); // toplamda 7 paramete alır
            Console.WriteLine("Uygulamamıza Hoş Geldiniz Yapmak İstediğiniz İşlemi Seçiniz");
            Islemler(); // islemler diyerek derleyiciyi islemler metoduna gotururum
            string ıslem = Console.ReadLine();

            switch(ıslem)
            {
                case "1": // 1 e eşitse
                ogrencı.OgrencıBılgılerınıGoster();  // ogrenci classımın bir objecını üretirim ve metotu tanımlar derleyici ordakı metoda gider ve bilgileri buraya aktarır
                break;
                case "2": // 2 ye eşitse
                ogrencı.OgrencıOrtalamaBul(); // derleyici ogrencı classıma gıder ve OgrencıOrtalamaBul metdounu cagırır yanı objesını uretir
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


        static void Islemler() // islemler metodunun icine girer
        {
            Console.WriteLine("1- Öğrenci Biligilerini Göster 2- Öğrencinin Ortalamasını Göster 3- Öğrenicini Okulunu Göster 4- Çıkıs Yap"); // ve bunları ekrana yazdırır
        }

       
        
    }
}
