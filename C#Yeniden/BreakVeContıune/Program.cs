// Break Anahtar Kelimesi
// Contiune Anahtar Kelimesi

for(int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);

    if(i == 7) // i 7 ye eşitse 
    {
        break; // donguyu kır
    }
}

for(int i = 0; i <= 10; i++)
{
    

    if(i == 7) // i 7 ye eşitse 
    {
        continue; // donguyu sadece bir kereye mahsus kırar
    }
    Console.WriteLine(i);
}
