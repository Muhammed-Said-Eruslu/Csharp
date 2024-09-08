// See https://aka.ms/new-console-template for more information

private static bool ISPrimeNumber(int number)
{
    // bir sayı gönderilecek asal olup olmadıgını bulmaya calıscaz
    // asal tam boleni olmayan sayı

    bool result = true;

    for(int i= 2; i < number; i++) // 2 den başlatıyoz 1 asal oldugu ıcın
    {
        if(number % i == 0) // sayının i ye bolumunden kalan 0 sa
        {
            result = false;
            i = number; // diyelim 6 6 asal olur ve şarta bidajha girmez
            
        }
        return result; 
    }
}
if(ISPrimeNumber(6))
{
    Console.WriteLine("Asal Syıdır");
}
else
{
    Console.WriteLine("Asal Sayıdır");
}