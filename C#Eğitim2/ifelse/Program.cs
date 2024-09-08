﻿// See https://aka.ms/new-console-template for more information
var number2 = 11;
var number = 10;
if(number == 10) // sayı 10 oldugu süre if calısır
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
}
Console.ReadLine();

Console.WriteLine(number2 == 10 ? "Number is 10" : "Numner is not 10"); // sayı onsa number is 10 değilse number is not 10
// single line if 