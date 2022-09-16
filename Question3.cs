using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
