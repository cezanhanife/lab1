using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, toplam;
            Console.Write("sayı gırınız:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("sayı gırınız:");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("{0} ve {1}sayılarının toplamı:{2}", a,b,(a + b));
            Console.ReadKey();


        }
    }
}
