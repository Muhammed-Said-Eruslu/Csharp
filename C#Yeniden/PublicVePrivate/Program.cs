namespace PublicVePrivate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Public Private  erişim belirleyiciler

            Müsteri müsteri1 = new Müsteri();

            müsteri1.cinsiyet = "Erkek";
            müsteri1.isim = "Said";
            müsteri1.soyisim = "Eruslu";
            müsteri1.maasDegeri = 1500000;

            // müsteri1.yas = 19; yas değerine ulasamıyorum private oldugu ıcın

        }
    }
}
