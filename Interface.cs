using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment_16_9_22
{
    internal class Interface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Company Name(TCS / Accenture): ");
            string comp = Console.ReadLine();
            Console.WriteLine("Enter the Employee Id: ");
            int empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Department: ");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter Your Designation: ");
            string desg = Console.ReadLine();
            Console.WriteLine("Enter your Basic Salary: ");
            double bsal = double.Parse(Console.ReadLine());

            if(comp == "TCS")
            {
                Console.WriteLine("Enter the How many Yrs you have completed: ");
                float n = float.Parse(Console.ReadLine());
                TCS e1 = new TCS(empid, name, dept, desg, bsal,n);
                e1.Display();
               
            }
            else if(comp == "Accenture")
            {
                Accenture e2 = new Accenture(empid, name, dept, desg, bsal);
                e2.Display();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
            
        }
    }

    interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaVeDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);

    }

    public class TCS : GovtRules
    {
        private int Empid;
        private string Name;
        private string Dept;
        private string Desg;
        private double BasicSalary;
        public float N;


            public int EMPID
        {
            get { return Empid; }
            set { Empid = value; }
        }

        public string NAME
        {
            get { return Name; }
            set { Name = value; }
        }

        public string DEPT
        {
            get { return Dept; }
            set { Dept = value; }
        }

        public string DESG
        {
            get { return Desg; }
            set { Desg = value; }
        }

        public double BASICSALARY
        {
            get { return BASICSALARY; }
            set { BASICSALARY = value; }
        }

        public TCS(int empid, string name, string dept, string desg, double bsal, float n)
        {
            Empid = empid;
            Name = name;
            Dept = dept;
            Desg = desg;
            BasicSalary = bsal;
            N = n;
          
        }

        public double EmployeePF(double BasicSalary)
        {
            double pf1 = BasicSalary - (0.12 * BasicSalary);
            double pf2 = BasicSalary - (0.0833 * BasicSalary);
            double pf3 = BasicSalary - (0.0367 * BasicSalary);
            return pf1 + pf2 + pf3;
            }
        public string LeaVeDetails()
        {
            return "1 day of Casual Leave per month\r\n12 days of Sick Leave per year\r\n10 days of Previlage Leave per year\r\n";
        }
        public double gratuityAmount(float serviceCompleted, double BasicSalary)
        {
            double gratutity = 0.0;

            if (serviceCompleted > 5 && serviceCompleted <= 10)
            {
                gratutity = BasicSalary;
            }
            else if (serviceCompleted > 10 && serviceCompleted <= 20)
            {
                gratutity = 2 * BasicSalary;
            }
            else if (serviceCompleted > 20)
            {
                gratutity = 3 * BasicSalary;
            }
            else if (serviceCompleted < 5)
            {
                gratutity = 0.0;
            }

            return gratutity;
        }

        public void Display()
        {
            Console.Write("Employee Id: " + Empid + "\t\t\t\t\t");
            Console.WriteLine("Employee Name: " + Name);
            Console.Write("Department Name: " + Dept + "\t\t\t");
            Console.WriteLine("Designation of the employee: " + Desg);
            Console.WriteLine("\nBasic Salary Of the Employee: " + BasicSalary);
            Console.WriteLine("Total PF:" + EmployeePF(BasicSalary));
            Console.WriteLine("Gratuity Amount: " + gratuityAmount(N,BasicSalary));
            Console.WriteLine("\nLeave Details: \n" + LeaVeDetails());
        }
    }

    public class Accenture : GovtRules
    {
        private int Empid;
        private string Name;
        private string Dept;
        private string Desg;
        private double BasicSalary;

            public int EMPID
        {
            get { return Empid; }
            set { Empid = value; }
        }

        public string NAME
        {
            get { return Name; }
            set { Name = value; }
        }

        public string DEPT
        {
            get { return Dept; }
            set { Dept = value; }
        }

        public string DESG
        {
            get { return Desg; }
            set { Desg = value; }
        }

        public double BASICSALARY
        {
            get { return BASICSALARY; }
            set { BASICSALARY = value; }
        }

        public Accenture(int empid, string name, string dept, string desg, double bsal)
        {
            Empid = empid;
            Name = name;
            Dept = dept;
            Desg = desg;
            BasicSalary = bsal;
        }

        public double EmployeePF(double BasicSalary)
        {
            double pf1 = BasicSalary - (0.12 * BasicSalary);
            double pf2 = BasicSalary - (0.12 * BasicSalary);
            return pf1 + pf2;
        }
        public string LeaVeDetails()
        {
            return "2 day of Casual Leave per month\r\n5 days of Sick Leave per year\r\n5 days of Previlage Leave per year\r\n";
        }
        public double gratuityAmount( float serviceCompleted, double BasicSalary)
        {

            return 0.0;
        }

        public void Display()
        {
            Console.Write("Employee Id: " + Empid + "\t\t\t\t\t");
            Console.WriteLine("Employee Name: " +Name);
            Console.Write("Department Name: " + Dept + "\t\t\t\t");
            Console.WriteLine("Designation of the employee: "+Desg);
            Console.WriteLine("\nBasic Salary Of the Employee: " + BasicSalary);
            Console.WriteLine("Total PF:"+EmployeePF(BasicSalary));
            Console.WriteLine("Gratuity Amount: "+gratuityAmount(0, BasicSalary));
            Console.WriteLine("\nLeave Details:\n " + LeaVeDetails());
        }
    }
}

    