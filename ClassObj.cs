using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_14_9_22
{
     public class ClassObj
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select any one Question from 1 to 7 :\n1)\n2)\n3) Calculate Students Results\n4) Book Store\n5) Shape\n6) Bank\n7) Find the Marks and Percentage\n\n");
            int z = int.Parse(Console.ReadLine());

            switch(z)
            {
                case 1:
                    {
                        break;
                    }

                case 2:
                    {
                        break;
                    }

                case 3:
                    {
                        int[] m1 = { 59, 81, 91, 100, 42 };
                        int[] m2 = { 20, 59, 35, 84, 49 };
                        
                   // Student s1 = new Student(101, "Ram", 'A', 2, "CSE", m1);
                      //  Student s2 = new Student(103, "Priya", 'D', 7, "ECE", m2);
                      //  s1.DisplayDetails();
                        
                        break;
                    }

                    case 4:
                    {
                        Console.WriteLine("Enter ISBN : ");
                        int n = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the Book Name : ");
                        string book_name = Console.ReadLine();

                        Console.WriteLine("Enter the Title : ");
                        string book_title = Console.ReadLine();

                        Console.WriteLine("Enter the Author Name : ");
                        string book_author = Console.ReadLine();

                        Console.WriteLine("Enter Quantity of Book : ");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the Price of one Book : ");
                        double price = double.Parse(Console.ReadLine());

                        BookStore book = new BookStore();
                        book.ISBN = n;
                        book.BOOKNAME = book_name;
                        book.BOOKTITLE = book_title;
                        book.BOOKAUTHOR = book_author;
                        book.QUANTITYOFBOOKS = quantity;
                        book.BOOKPRICE = price;

                        Console.WriteLine("\n\nBill Amount = " + book.QUANTITYOFBOOKS * book.BOOKPRICE + " Rs");
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("Find the area of : \nSquare\nRectangle\nTriangle\nCircle");
                        string shape = Console.ReadLine();
                        Shape s = new Shape();

                        switch(shape)
                        {
                            case "Square":
                                {
                                    Console.Write("Enter the Int value : ");
                                    int x = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Area = "+s.AreaOfShape(x));
                                    break;
                                }

                            case "Rectangle":
                                {
                                    Console.Write("Enter the two values in int : ");
                                    int x = int.Parse(Console.ReadLine());
                                    int y = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Area = "+s.AreaOfShape(x,y));
                                    break;
                                }

                            case "Triangle":
                                {
                                    Console.Write("Enter the two values in double : ");
                                    double x = double.Parse(Console.ReadLine());
                                    double y = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Area = " + s.AreaOfShape(x, y));
                                    break;
                                }

                            case "Circle":
                                {
                                    Console.Write("Enter the Radius values in double : ");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Area = " + s.AreaOfShape(x));
                                    break;
                                }
                        }
                        break;
                    }

                case 6:
                    {
                        Console.WriteLine("Enter Your Name");
                        string Name = Console.ReadLine();
                        Bank cust = new Bank(Name);

                        Console.WriteLine("Withdraw / Deposit");
                        string ans = Console.ReadLine();

                        switch(ans)
                        {
                            case "Withdraw":
                                {
                                    cust.DisplayDetails();
                                    Console.WriteLine("Enter the Amount..");
                                    double amt = double.Parse(Console.ReadLine());
                                    cust.Withdraw(amt);
                                    break;
                                }

                            case "Deposit":
                                {
                                    Console.WriteLine("Enter the Amount..");
                                    double amt = double.Parse(Console.ReadLine());
                                    cust.Deposit(amt);
                                    break;
                                }
                        }
                        


                        break;
                    }

                case 7:
                    {
                        Student_marks s1 = new Student_marks(91,"vedha",98,76,89);
                        s1.ShowDetails();

                        Student_marks s2 = new Student_marks(65, "Veena", 81, 56, 48);
                        s2.ShowDetails();

                        break;
                    }
            }
        }
    }

    public class Student
    {
        public int RollNo;
        public string Name;
        public char Class;
        public int Sem;
        public string Branch;
        public int[] Marks = new int[5] ;

        Student() { }

        Student(int rollno, string name, char clas, int sem, string branch, int [] marks) 
        { 
            this.RollNo = rollno;
            this.Name = name;
            this.Class = clas;
            this.Sem = sem;
            this.Branch = branch;
            this.Marks = marks;
        }

        string DisplayResult()
        {
            string result = "Pass";
            return result;
        }

        void DisplayDetails()
        {
            Console.WriteLine(DisplayResult());
        }

    }

    public class Student_marks
    {
        public int RollNo;
        public string StudName;
        public int MarksInEng;
        public int MarksInMaths;
        public int MarksInScience;

        public Student_marks() { }

        public Student_marks(int rollNo, string studName, int marksInEng, int marksInMaths, int marksInScience)
        {
            this.RollNo = rollNo;
            this.StudName = studName;
            this.MarksInEng = marksInEng;
            this.MarksInMaths = marksInMaths;
            this.MarksInScience = marksInScience;
        }

        public int TotalMarks()
        {
            int marks = MarksInEng + MarksInMaths + MarksInScience;
            return marks;
            
        }

        public double AvgMarks()
        {
            double per = TotalMarks() / 3;
            return per;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Roll No: " + RollNo);
            Console.WriteLine("Student Name: " + StudName);
            Console.WriteLine("Total Marks: "+TotalMarks());
            Console.WriteLine("Percentage: " + AvgMarks() + "%");
        }
    }

    public class Bank
    {
        public string Name;
        public int AccNo;
        public string AccType;
        public double Balance;

        public Bank(string name)
        {
            this.Name = name;
            initialVal();
        }

        public void initialVal()
        {
            Balance = 1000.00;
            
        }

        public void Deposit(double amt)
        {
            Balance += amt;
            Console.WriteLine("Process Completed ..." + "\nBalance Amount = "+Balance);


        }

        public void Withdraw(double amt)
        {
            
            Balance -= amt;
            Console.WriteLine("Process Completed ..." + "\nBalance Amount =  " + Balance);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nName of the Depositor: "+ Name);
            Console.WriteLine("Balance amount in the account = " + Balance + "\n");
        }


    }

    public class Shape
    {
        public int AreaOfShape(int x)
        {
            return x*x;
        }
        public int AreaOfShape(int x, int y)
        {
            return x*y;
        }

        public double AreaOfShape(double x)
        {
            return 3.14 * x*x;
        }

        public double AreaOfShape(double x, double y)
        {
            return (x*y)/2;
        }

    }

    public class BookStore
    {
        private int isbn;
        private string bookName;
        private string bookTitle;
        private string bookAuthor;
        private int quantityOfBooks;
        private double bookPrice;

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string BOOKNAME
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public string BOOKTITLE
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }

        public string BOOKAUTHOR
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        public int QUANTITYOFBOOKS
        {
            get { return quantityOfBooks; }
            set { quantityOfBooks = value; }
        }

        public double BOOKPRICE
        {
            get { return bookPrice; }
            set { bookPrice = value; }
        }
    }
}
