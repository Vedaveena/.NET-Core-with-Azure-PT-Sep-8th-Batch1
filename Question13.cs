using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any 3 Number:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());



            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1);
            }

            else if (n2 > n3)
            {
                Console.WriteLine(n2);
            }

            else
            {
                Console.WriteLine(n3);
            }



        } 
    }
}
