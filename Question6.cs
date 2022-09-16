using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question6
    {
        public static void Main(string[] args)
        {
            double F = double.Parse(Console.ReadLine());
            double C = (F - 32) * 5 / 9;
            Console.WriteLine("Temperature in celsius is:" + C);
            Console.ReadLine();
        }
    }
}
