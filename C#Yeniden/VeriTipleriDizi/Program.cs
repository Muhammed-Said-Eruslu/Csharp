// string
// double
// char

/*string[] isimler = new string[4]; // burda denilen string veri tipinde bir dizi tanımlıyorum 4 eleman tutabilen bir dizidir 
// daha sonradan değer atıcam

// AMA DİREKT DEĞER ATAMAK İSTERSEM 
string[] isimler2 ={"Said","Abo","Zeynep"};

Console.WriteLine(isimler2[0]); // mesala ben 0 ıncı indexi ekrana yazdırmak ıstıyorum ondan 0 ıncı dedım

for(int i = 0; i <= isimler2.Length; i++) // ben bütün hepsini yazdırmak istersem boyle kullanırım // i 0 oldugu ıcın ındex 0 da said var onu yazdurcak
// sonra ısımlerın uzunluguna eşit oldugu sürece donceği için index 2 ye kadar yazıcak dongu her arttıgında o ankı elemanı yazdırıp 
// dongu devam edene kadar yazdırmaya devam edicek
{
    Console.WriteLine(isimler2[i]);
}*/

using System.Diagnostics;

/*double[] ondalıklı = {1.31,31.31,32,4.32432,4.423};

for(int i = 0; i <= ondalıklı.Length; i++)
{
    Console.WriteLine(ondalıklı[i]);
}
*/
char[] karakterler = {'S','A','İ','D'};

for(int i = 0; i <= karakterler.Length; i++)
{
    Console.WriteLine(karakterler[i]);
}