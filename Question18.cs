using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st word");

            string s1 = Console.ReadLine();

            Console.WriteLine("Enter 2nd word");

            string s2 = Console.ReadLine();

            if (s1 == s2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            //Console.WriteLine("Length : " + w.Length);

        }
    }
}
