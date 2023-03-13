using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static int Factorial(int n)
        {
            int rezult;
            if (n == 0 || n == 1)
            {
                rezult = 1;
                return rezult;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            int factorial = Factorial(n);
            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
