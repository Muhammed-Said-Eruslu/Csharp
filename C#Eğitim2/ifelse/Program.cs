﻿// See https://aka.ms/new-console-template for more information
var number2 = 11;
//var number = 10;
/*if(number == 10) // sayı 10 oldugu süre if calısır
{
 Console.WriteLine("Number is 10");
}

else if(number == 20)
{
    Console.WriteLine("Number ıs 20");
}

else // if in değili else if ise ayrı bir tane daha kosul alır
{
    Console.WriteLine("Number is not 10");
}*/

/*Console.WriteLine(number2 == 10 ? "Number is 10" : "Numner is not 10"); // sayı onsa number is 10 değilse number is not 10
// single line if */

/*if(number2 >= 0 && number2 <= 100)
{
    Console.WriteLine("Sayı 0 ile 100 arasında");
}
else if(number2 > 100 && number2 <= 200) // ikisinide true oldugu durumda blok calısır
{
    Console.WriteLine("Sayı 101 ile 200 arasında");
}
else if(number2 > 200 || number2 < 0) // ikisinden birinin true oldugu durumda blok calısır
{
    Console.WriteLine("Sayı 0 dan kucuk veya 200 yuzden buyuk");
}*/
if(number2 < 100) // sayı 100 den kucukse blok calısır
{
    if(number2 >= 90 && number2 < 195) // sayı 90 ile 95 arasında mı
    {
        Console.WriteLine("Sayı 90 ile 95 arasında");
    }
    else
    {
        Console.WriteLine("Sayı 90 ve 95 arasında değil");
    }
}
else
{
    Console.WriteLine("Sayı 100 den kucuk değil");
}