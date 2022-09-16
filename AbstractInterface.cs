using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16_9_22
{
    internal class AbstractInterface
    {
        public static void Main(string[] args)
        {
            Salary s = new Salary();
            Console.WriteLine("Daily Salary : \t\t\t" +s.Sal(400.00));
            Console.WriteLine("Month Salary : \t\t\t" + s.MonthSal(400.00));
            Console.WriteLine("Yearl Salary : \t\t\t" + s.yearSal(400.00));

        }
    }

    interface Sal_year
    {
        public double yearSal(double dsal);
    }

    public abstract class Sal_Month
    {
        public abstract double MonthSal(double dsal);

        public double Sal(double dsal)
        {
            return dsal;
        }

    }

    public class Salary : Sal_Month,Sal_year
    {
        public double yearSal(double dsal)
        {
            return 360 * dsal;
        }

        public override double MonthSal(double dsal)
        {
            return 30 * dsal;
        }
    }
}
