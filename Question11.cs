using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {

                Console.WriteLine(n + " * " + i + " = " + n * i);
            }

        }
    }
}
