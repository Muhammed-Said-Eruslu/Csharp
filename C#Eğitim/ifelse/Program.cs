using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            //öğrencinin notu 50 den yüksekse başarlı değilse başarısız yazdıran program
            int not = 31;
            if(not>50) 
            {
                Console.WriteLine("öğrenci bu dersten başarılı bir şekilde geçmiştir");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("dersten başarısız oldunuz");
                Console.ReadLine();
            }
        }
    }
}
