using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question8
    {
        public static void Main(string[] args)
        {
            int i, fact = 1, n;
            Console.Write("Enter any Number: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + n + " is: " + fact);
        }
    }
}
