using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14_9_22
{
    internal class ExtraQuestion
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("1) Swap two numbers.\n2) Find no. of eggs.\n3) Find leap year.\n 4) \n5) ");

            Console.WriteLine("Select any one from 1 to 5");
            int n = int.Parse(Console.ReadLine());
            
            switch(n)
            {
                case 1:
                    {
                        Console.WriteLine("Enter 1st numbers:");
                        int a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter 2nd numbers:");
                        int b = int.Parse(Console.ReadLine());

                        Console.WriteLine("Before Swap: a = " + a + " , b = " + b);

                        a = a * b;
                        b = a / b;
                        a = a / b;

                        Console.WriteLine("After Swap: a = " + a + " , b = " + b);
                        break;

                    }

                    case 2:
                    {
                        Console.WriteLine("Enter the total number of Eggs:");
                        int x = int.Parse(Console.ReadLine());

                        int temp=0,g=0,d=0;

                        while(x>0)
                        {
                            if (x >= 144)
                            {
                                g = x / 144;
                                x = x % 144;

                            }
                            else if(x >= 12)
                            {
                                d = x / 12;
                                x = x % 12;
                            }
                            else { temp = x; break; }
                        }

                        //Console.WriteLine("Your number of eggs is {0} gross, {1} dozen, and {3} ", g,d,temp);
                        Console.WriteLine("Your number of eggs is "+g+" gross, "+d+" dozen, and "+temp);
                        break;

                    }

                case 3:
                    {
                        Console.WriteLine("Enter the Year :");
                        int year = int.Parse(Console.ReadLine());

                        if((year%4 == 0 && year % 100 != 0) || year % 400 ==0)
                        {
                            Console.WriteLine(year+" is a Leap Year");
                        }
                        else
                        {
                            Console.WriteLine(year + " is not a Leap Year");
                        }

                        break;
                    }
            }
        }
    }
}
