string isim = "Muhammed Said Eruslu";
var result = isim.Length; // lenghti kadar yanı uzunlugu kadar 
var result2 = isim.Clone(); // string degerın bir refarnısını daha oluşturur // ismini değiştirsem bile ısım degıskenını yine muhammed said eruslu yazıcak
bool varMı = isim.EndsWith("u"); // cumle u ile bitiyor mu bıtıyosa true bıtmıyosa false
bool varmı2 = isim.StartsWith("M"); // cumle m ıle baslıyo mu // yada mu ile yada muhammed ile
var result3 = isim.IndexOf("Eruslu"); // Erusluyu arar
var result4 = isim.IndexOf(" "); // buldugu ilk boslugu sayar sonra aramaya devam etmez
var result5 = isim.LastIndexOf(" "); // aramaya sondan indexin sonundan başlar
var result6 = isim.Insert(0, "Merhaba "); // bir cumleye yada bir stringe başka bir metni yerleştirmek için kullanılır
var result7 = isim.Substring(4); //Metni parçalamak için kullanılır dortcü karakterden ıtıbaren al
var result8 = isim.Substring(4,3); // 4. Karakterden itibaren 3 tane al
var result9 = isim.ToLower(); // bütün karakterleri küçuk harfe ceviri
var result10 = isim.ToUpper(); // bütün karakterleri büyük harfe cevirir
var result11 = isim.Replace(" ", "-" ); // boslukları - ile değiştir
var result12 = isim.Remove(4); // belirli bir indexten sonrakıleri atmak için kullanılır
var result13 = isim.Remove(1,2); // 4 uncu indexten sonra kaç tanesini kaldırıyım // belirli karakterden sonra hangilerini kaldırmak istersen
var result14 = isim.
Console.WriteLine(result13);
