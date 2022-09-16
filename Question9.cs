using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question9
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, sum, i;

            Console.WriteLine(a + "  " + b + " ");
            for (i = 2; i < 40; ++i)
            {
                sum = a + b;
                Console.WriteLine(sum + " ");
                a = b;
                b = sum;
            }
        }
    }
}
