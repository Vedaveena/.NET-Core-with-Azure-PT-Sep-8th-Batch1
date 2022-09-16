using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question19
    {
        public static void Main(string[] args)
        {
            String w = Console.ReadLine();
            int n = w.Length;
            int flag = 1;
            for (int i = 0; i < n / 2; i++)
            {
                if (w[i] != w[n - 1 - i])
                    flag = -1;
            }
            if (flag == 1)
                Console.WriteLine("Pallindrome");
            else
            {
                Console.WriteLine("not Pallindrome");
            }



        }
    }
}
