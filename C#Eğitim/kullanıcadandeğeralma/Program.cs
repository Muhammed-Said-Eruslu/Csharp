using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcadandeğeralma
{
    class Program
    {
        static void Main(string[] args)
        
        
       {
            //readline
            Console.WriteLine("lütfen adınızı giriniz");

            string isim = Console.ReadLine();

            Console.WriteLine("lütfen soyisminizi giriniz");

            

            
            string soyisim = Console.ReadLine();
            Console.WriteLine("kullanıcının ismi" + isim);

            Console.WriteLine("kullanıcının soyismi" + soyisim);

            Console.ReadLine();
        }
    }
}
