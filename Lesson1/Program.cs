using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = Console.ReadLine();
            int a = int.Parse(strA);

            string strB = Console.ReadLine();
            int b = int.Parse(strB);

            int sum = a + b;
            int raz = a - b;
            int pro = a * b;
            int chast = a / b;
            Console.WriteLine("{1} + {0} = {2}", a, b, sum);
            Console.WriteLine("{1} - {0} = {2}", a, b, raz);
            Console.WriteLine("{1} * {0} = {2}", a, b, pro);
            Console.WriteLine("{1} / {0} = {2}", a, b, chast);
            
            Console.ReadKey();
    
        }
    }
}
