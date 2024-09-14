// 1 den 10 a kadar olan sayıları ekrana yazdırın do while ile
// 1 den 100 e kadar olan sayıların toplamını ekrana yazdırın do while ile

/*int i = 1;

do
{
Console.WriteLine(i); // 1 yazdırır
i++; // sorna i 10 dan kucuk mu evet true olana kadar dongu devam eder

}while(i <= 10);
*/

int i = 0;
int toplam = 0;

do
{
    
toplam +=i;
i++;
    
}while(i <= 100);
Console.WriteLine(toplam);

