using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            int ans = (5 * 5 * 5) + (n * n * n);
            Console.WriteLine(ans);

        }
    }
}
