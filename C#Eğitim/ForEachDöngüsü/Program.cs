using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Muhammed", "Said", "Eruslu", "Abo" };
            foreach (string a in isimler)
            {
                Console.WriteLine(a);
            }
            double[] os = { 1.2, 1.4, 1.6, 1.8, 2.2 };
            foreach (double f in os)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
            

        }
        
    }
}
