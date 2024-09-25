using System;

namespace PropertyKullanımı;

public class Müşteri
{

    public int kılo { get; set; } // property

    public int kılo2;
     //private int kılo; // buna erişemıyorum

    //public int MyProperty { get; set; } // propertyi boyle kullanırsak değişkenler hiçbir farkı olmaz 
/*
// get ve set blokları acılırsa kapuslleme yapılır
    public int KILO 
    {
        get
        {
            return kılo; // yakalığım değeri get icinde return  e
        }
        
        set
        {
            kılo = value;    // kullanıcının girmiş olduğu değeri value ıle yakalarım
        }
        
  }*/

  
}
