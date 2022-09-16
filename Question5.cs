using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question5
    {
        public static void Main(string[] args)
        {
            int[] n = new int[5];
            Console.WriteLine("Enter 5  Numbers: ");

            for (int i = 0; i < 5; i++)
            {
                n[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)
            {
                if (n[i] % 2 == 0)
                {
                    Console.WriteLine(n[i] + " is a Even Number");
                }

                else
                {
                    Console.WriteLine(n[i] + " is an Odd Number");
                }
            }


        }
    }
}
