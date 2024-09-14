
int[] sayılar = new int[4]; // sayılar adında bir dizi olusturuyorum ve bu dizi 4 elemanlı

sayılar[0] = 10; // sayılar dizimin 0 ıncı ındexi artık 10 // index 0 ı çağırdığımda 10 değeri gelicek
sayılar[1] = 20;
sayılar[2] = 30;
sayılar[3] = 40;

for(int i = 0; i <=sayılar.Length; i++) // sayılar dizimin lenghti kadar donucek uzunluğu 4 ort oldugu ıcın 4 e kadar donucek
{
 Console.WriteLine(sayılar[i]); // Her dondugunde sayılar dızısının i ninci elemanını yazdır
}
