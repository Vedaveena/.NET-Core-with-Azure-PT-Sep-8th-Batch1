using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question17
    {
        public static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine(" Enter a word");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }

            Console.WriteLine(revs);


        }
    }
}
