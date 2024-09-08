// See https://aka.ms/new-console-template for more information
                                    //Refactorıng işlemleri yapılabılır hem coda da hemde stduıo da 
                                    // studıo da yapmak ıcın kod yazaken sağ clık refactorung seceneğine tıklarız extrac var ordan yaparız
// 1 den 100 kadar kı sayıları ekrana yazdır

for(int i = 1; i <= 100; i++ ) // i 100 den küçük veya eşit oldugu sürece döngü devam eder (Loop)
// burda ki int i sadece bu blokta kullanıla bilir for 3 bloktan olusur int i = 1 sayac baslangıc değeri
// ikinci kısım şart yuzden kücük oldugu surece 
// her dönus bittiğinde i yi bir arrtık
// yani koşul true olduğu sürece döngü devam eder false oldugu zaman cıkar
{
    Console.WriteLine(i);
}
Console.WriteLine("Döngü Bitti");

for(int t = 1; t <= 100; t+=2) // tek sayıları yazdrımak için // j = j+2 => aynı sey j+=2

{
    Console.WriteLine(t);
}

for(int c = 0; c <= 100; c+=2) // çift sayıları yazdırmak için

{
    Console.WriteLine(c);
}

for(int b = 100; b >= 0; b--) // 100 den geri gider aynı sekılde tek cıft yapmal ıcın yukarısyla aynı

{
    Console.WriteLine(b);
}

Console.ReadKey();