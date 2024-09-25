using System;

namespace KapsüllemeÖdev;

public class Personel
{
    private string tckNo;

    public string TCKNO
    {
        get
        {
            return tckNo.Substring(0,5) +"******"; // Substring kacıncı indexten baslıyım ve uzunluğu kaça kadar olsun
        }
        set
        {
            bool kontrol = false;
            if(value.Length == 11)
            {
               
                for(int i = 0; i < value.Length; i++)
                {
                    bool a =char.IsNumber(value[i]);
                     if(a)
                    {
                        
                    }
                    else
                    {
  
                        kontrol = true;
                        break;
                    }

                   
                }
                if(kontrol)
                {
                    Console.WriteLine("Lütfen TCKNO içinde Sayı Harici Bir Şey Girmeyiniz");
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
