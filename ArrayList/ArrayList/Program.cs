/*int[] sayılar = { 5, 3, 9, 1, 7 };

// Diziyi sıralama
Array.Sort(sayılar);

// Diziyi tersine çevirme
Array.Reverse(sayılar);

// Dizide bir elemanı arama
int index = Array.IndexOf(sayılar, 9);

// Diziyi yazdırma
foreach (int sayı in sayılar)
{
    Console.WriteLine(sayı);
}*/

/*
Array Sınıfının Metotları
Sort(Array array): Diziyi sıralar.
Reverse(Array array): Diziyi tersine çevirir.
IndexOf(Array array, object value): Verilen değerin dizideki indeksini döner.
Clear(Array array, int index, int length): Dizideki belirli bir aralıktaki elemanları temizler (0'a veya null'a sıfırlar).
Length: Dizinin boyutunu döner.
*/

// Array sınıfı diziler veya collectıons içersinde kullanabileceğimiz 
// bir çok ozellik (property) ve metot (methods) barındırır

#region Lenght
/*
int[] number = {1,3,4,534,6,63,435,3,345,34,5,345,3,4535};
Console.WriteLine(number.Length);
*/
#endregion

#region Copy
/*
int[] kaynak = {21,231,65,45,33,734,4,6};
int[] hedef  = {1,4,5,6};
Array.Copy(kaynak,hedef,3); // kaynak parametresi alır ve hedef parametresi alır ilk 3 elemanı yazdır sonra hedef olarak ücüncü sayıyı ata

foreach (int i in hedef)
{
    Console.WriteLine(i);
}
Console.WriteLine(new string('-',30));

foreach (var i in kaynak)
{
    Console.WriteLine(i);
}

*/
#endregion

#region Sort
// Sıralama yapmak ıcın kullanılır 
using System.Data;
/*
int[] sayılar = {-32,0,-534534,3424,32,1,63432};
Array.Sort(sayılar);

foreach(var i in sayılar)
{
    Console.WriteLine(i);
}*/
#endregion

#region IndexOf
/*int[] numbers = {756,75,576,85,5678,85};
int result = Array.IndexOf(numbers,85,2); // 2 aramaya başlanacak değer
Console.WriteLine(result);

int[] numbers2 = {756,75,576,85,5678,85};
int result2 = Array.IndexOf(numbers2,85); // burda nerden arıyacağını bız gırmyoz
Console.WriteLine(result2);*/
#endregion

#region LastIndexOf
/*
int[] numbers = {56,64,744,35347,34373,323432,-1,423};
int result2 = Array.LastIndexOf(numbers,-1,7);
Console.WriteLine(result2);

int[] numbers2 = {324,42342,623,42,632,4,235,234,252};
int result3 = Array.LastIndexOf(numbers,45);
Console.WriteLine(result3);*/
#endregion

#region Reverse
/*int[] numbers = {32,4326,436,35,2,-23235,234234234,0,3242,39999};
Array.Sort(numbers);
Array.Reverse(numbers);

foreach(var i in numbers)
{
    System.Console.WriteLine(i);
}
*/
#endregion

#region Clear
/*
int[] numbers = {321,423532,4,325,32,4,52,4};
Array.Clear(numbers,0,4); // nerden başlıyım nereye kadar siliyim

foreach(var i in numbers)
{
    System.Console.WriteLine(i);
}
*/
#endregion

#region Resize
// İlkel dizinin eleman sayısını arttırmak veya azaltmak ıcın kullanılır
string[] sehirler = {"Afyon","İstanbul","Ankara"};
Array.Resize(ref sehirler,sehirler.Length+1); // mevcut dizinin uzunluğuna +1 eklenir
sehirler[3] = "Van";

foreach(var i in sehirler)
{
    Console.WriteLine(i);
}

#endregion
