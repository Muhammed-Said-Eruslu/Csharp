using System;

namespace KapsüllemeÖdev;

public class Personel
{
    private string tckNo;

    public string TCKNO
    {
        get
        {
            return tckNo.Substring(1,5);
        }
        set
        {
            bool kontrol = false;
            if(value.Length == 11)
            {
                for(int i = 0; i < value.Length; i++)
                {
                   bool sayıMı = char.IsNumber(value[i]);

                   if(sayıMı)
                   {

                   }
                   else
                   {
                     kontrol = true;
                   }
                }
                if(kontrol)
                {
                    System.Console.WriteLine("Lütfen TCKNO İçinde Sayı Kullanınız");
                }
                else
                {
                    tckNo = value;
                }
               
            }
            else
            {
                System.Console.WriteLine("Girdiğiniz TCKNO 11 Değildir");
            }
        }
    }
}
