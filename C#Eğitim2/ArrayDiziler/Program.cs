// See https://aka.ms/new-console-template for more information
// Neden Arrayler kullanılır 
// Örnek : Bir Öğretmen var ve 10 tane öğrencisi var tek tek girmek yerine
// Öğretmen öğrencileri bir listede görmek istiyorsa 
// Arraylerle aynı tıpdekı değerleri değişkenleri tek bır noktada yonetıp tek bir değişkenle yonetme seklınde
// ve ona hızlıca ulaşsma onu bır donguyle gezme

string [] students = new string[3]{"Said","Zeynep","Abdullah"}; // 3 elemanlı
//students[0] ="Said"; // yani students arrayının 0 ıncı elemanı Said'e eşittir
// [] bu tek boyutlu dızı demek
string [] students2 = {"Said","Zeynep","Abdullah"} ; 

foreach(var student in students2) // foreach arryı gezmek ıcın kullanılır
// gezerken her bir elemana takma ısım veriyoruz
{
    Console.WriteLine(student);
}
string[,] regions = new string[7,3] // 7 bolge var ve her bolge ıcın 3 sehir
{
    {"İstanbul","İzmit","Kocaeli"}, // her satır ıcın 1 // sütünlar ıcınde 3 veri olması lazım
    {"Ankara","Konya","Kırıkkale"},
    {"Antalya","Adana","Mersin"},
    {"Rize","Trabzon","Samsun"},
    {"İzmir","Muğla","Denizli"},
    {"Diyarbakır","Antep","Urfa"},
    {"Erzurum","Van","Malatya"},
};

for(int i = 0; i <= regions.GetUpperBound(0); i++) // satırlar 0 ıcı daımasıon sütünlar 1 // bu satır icin
// 2 tane yazmasının sebebi getupperbound 0 // 7 nın alabıleceği 7 satır ama 0 dan basladıgı ıcın 6 aldı
{
for(int j = 0; j <= regions.GetUpperBound(1); j++) // bu sutun ıcın
{
    Console.WriteLine(regions[i,j]); // i nin j nıncı değeri
}
Console.WriteLine("***********");
}
//regions[0,0] = "İstanbul"; // 0 ıncı bolgenın o ıncı sehri
// 7 satır 3 kolon

// Türkiyenin bolgeleri ve bu bolgelerde ki en buyuk sehırler

