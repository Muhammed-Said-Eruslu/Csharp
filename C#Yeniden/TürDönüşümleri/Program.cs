                                            // STRİNG VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞÜM
/*int a = 5;

byte b = (byte)a; // değiştirmek içinde iki tarafında aynı veri tipinde olması lazım
Console.WriteLine(b.GetType());
Console.WriteLine(b);*/

/*string sayı1 = "1";
string sayı2 = "2";*/

/*int a = int.Parse(sayı1); // Parse donüştür demek
int b = int.Parse(sayı2); // sayı2 yı int e ceviriyoruz hangi türde cevirmek istediğimizi giriyoruz hangi türde olcaksa eşitliğin iki tarafı da o türde olmalı
Console.WriteLine(a+b);

int a = Convert.ToInt32(sayı1);
int b = Convert.ToInt32(sayı2);
Console.WriteLine(a+b);*/
                                            // İNT VERİ TİPİNDEN STRİNG VERİ TİPİNE DONUSUM

/*int sayı1 = 5;
int sayı2 = 10;

string a = sayı1.ToString(); // Elimizde ki değerleri string veri tipine değiştiren metot
string b = sayı2.ToString(); // string değerler toplanamaz yan yana yazdırılır*/

// Double veri tipinden int veri tipine nasıl donusturulur
/*double sayı = 5.22;

int a = Convert.ToInt32(sayı); // 5.22 oldugu ıcın ınt tam sayı tutar ondan dolayı noktadan sonrasını atar
Console.WriteLine(a);
Console.WriteLine(a.GetType());*/
                                            // Not: Kullanıcıdan alınan değerler STRİNG VERİ TİPİNDE OLUR

Console.WriteLine("Lütfen Yaşınızı Giriniz");
string kullanıcı_Yas = Console.ReadLine(); // ReadLine fonksıyonundan string deger doner 

int kullanıcı_YasInt = int.Parse(kullanıcı_Yas);
int kullanıcı_YasInt2 = int.Parse(kullanıcı_Yas);
Console.WriteLine(kullanıcı_YasInt);
Console.WriteLine(kullanıcı_YasInt2);     

