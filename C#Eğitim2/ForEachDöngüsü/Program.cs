// See https://aka.ms/new-console-template for more information
// Dizi temelli dataların dolaşılması yani itareta edilmesi için kullanılır

string[] students = new string[3] {"Muhammed","Said","Eruslu"};

foreach(var student in students) // students için bir döngü kuruyoruz
{
    Console.WriteLine(student);
}
// foreach daha çok orneğin veri tabanından tabloyu çektiğimizde datayı çekmek için kullanır
// üzerinde arry türünde dolaşıalbilir nesnelere karşılık gelir