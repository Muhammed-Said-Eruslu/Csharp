// ArrayList bir classtır
/*
using System.Collections;

ArrayList koleksiyın = new ArrayList {};

koleksiyın.Add("said"); // kolekysıyona sonradan değer atama ıcın kullanılır object veri tipinde veri alır 
koleksiyın.Add("Muhammed");
koleksiyın.Add("SADAD");
koleksiyın.Remove("SADAD"); // bu değeri kaldırır
int diziCount = koleksiyın.Count; // dizinin countunu alır ve int olarak değer dondurur eleman sayısını bulur
// koleksiyın.Clear(); dizinin içindeki herseyi siler
bool varMI = koleksiyın.Contains("said"); // Contains Türkçede içermek anlamına gelir
int ındex  = koleksiyın.IndexOf("said"); // bir değer alır ve aldıgı değerin index numarasını verir
koleksiyın.Insert(2,"BOSLUK"); // bitane index numarası veririz ve verdiğimiz index numarasına o değeri yerleştirir
koleksiyın.Reverse(); // ters çevirmek anlamına gelir

ArrayList rakamlar = new ArrayList {};
rakamlar.Add(3); // sort metodu diziyi büyükten kucuge sıralar
rakamlar.Add(543);
rakamlar.Add(665433);
rakamlar.Add(0);
rakamlar.Add(-1232131);

int a2 = 10;
string b = a2.ToString(); // stringe cevirir


foreach(var a in koleksiyın)
{
    Console.WriteLine(a);
}
Console.WriteLine($"Dizinin eleman sayısı {diziCount}");
Console.WriteLine($"Dizide Said Var MI? {varMI}");
Console.WriteLine($"Saidin Bulunduğu ındex Numarası {ındex}");

foreach(var i in rakamlar)
{
    Console.WriteLine($"Dizinin Büyükten Küçüğe Sıralanmış Halı {i}");
}
Console.WriteLine(a2);
*/

List<int> sayılar = new List<int>();
sayılar.Add(3);

//Faydalı List<T> Metotları:
//Add(item): Listeye eleman ekler.
//Remove(item): Listedeki bir elemanı siler.
//Contains(item): Liste bir elemanı içeriyor mu kontrol eder.
//Count: Listedeki eleman sayısını döner.
//IndexOf(item): Belirli bir elemanın indeksini döner.
