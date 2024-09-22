namespace GetterVeSetterMetotları
{
    class Program
    {
        static void Main(string[]args)
        {
            // getter ve setter metotları // set Turkcede atamak gondermek demektir // get metodu da degeri almak ıcın kullanılır
            // property ile

            Ogerncı ogerncı = new Ogerncı();

            ogerncı.SetIsım("Said");
            string gelenIsım = ogerncı.GetIsım();

            if(gelenIsım == "Said")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
            }
        }
    }
}
