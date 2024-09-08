// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.ReadLine();
// Value Types = değer tipleri
var number7 = 10; // değer tipine gore değişir int girersen int char girersen char olur char girsen bile bundan sonra  hersey int olarak kabul edilir
var number8 = "Said";
string days = "Pazar";
decimal number6 = 10.999991M; // sonuna m koyarız 28 karakter tutar vırgulden sonra
double number5 = 10.90; // ondalıklı sayı 
char character = 'S';
bool cındition  = true; // mantıksal veri tipi true false 1 ve 0
byte number4 = 0; // 0 ile 255 arasında değer tutar
short number3 = 3101; // min -32768 max 32767 16 byte yer kaplar
long number2 = 21474836765; // min -9223372036854775808 max 9223372036854775807 // 64 bitlik yer kaplar
int number1 = 10; // min 2147483648 max 2147483647 // 32 bitlik yer kaplar
Console.WriteLine("Number1 ıs {0}",number1); // 0 virgülden sonra kı ilk deger 1 ikinci değer index olarak başlar
Console.WriteLine("Number2 ıs {0}",number2);
Console.WriteLine("Number3 ıs {0}",number3);
Console.WriteLine("Number4 ıs {0}",number4);
Console.WriteLine("Character ıs {0}",(int)character);
Console.WriteLine("Number4 ıs {0}",number5);
Console.WriteLine(myDays.Cuma);
Console.ReadKey();

enum myDays // magic string
{
    Pazar =10,Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi // sirayla gider 10 11
    // ama farklı değerler de verebiliriz ama farktan sonra yine sıralı gider
}

/*if(myDays.Pazar)
{

}
else if(myDays.Pazartesi)
{

}*/