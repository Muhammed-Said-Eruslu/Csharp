using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ve_operatörü
{
    class Program
    {
        static void Main(string[] args)
        {
            // && shift+6
            int sayı = 5;
            int sayı1 = 5;
            int sayı2 = 10;
            bool Kontrolet = sayı == sayı1 && sayı < sayı2;
            Console.WriteLine(Kontrolet);
            Console.ReadLine();

        }
    }
}
