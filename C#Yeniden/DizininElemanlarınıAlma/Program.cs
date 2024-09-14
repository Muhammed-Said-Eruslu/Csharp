// Dizinin elamanlarını kullanıcıdan alma ve ekrana yazdırma

int[] sayılar = new int[4];

for(int i = 0; i < sayılar.Length; i++)
{
    Console.WriteLine($"Sayılar Dizisinin "+(i+1)+". ındex giriniz");
    sayılar[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i < sayılar.Length; i++)
{
    Console.WriteLine(sayılar[i]);
}
