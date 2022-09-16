using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question14
    {
        public static void Main(string[] args)
        {
            int[] n = new int[5];
            Console.WriteLine("Enter 5  Numbers: ");

            for (int i = 0; i < 5; i++)
            {
                n[i] = int.Parse(Console.ReadLine());

            }
            int temp = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (n[i] < n[j])
                    {
                        temp = n[i];
                    }
                    else
                    {
                        temp = n[j];
                    }
                }
            }

            Console.WriteLine(temp);


        }
    }
}
