using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16_9_22
{
    internal class Collections
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Question 1:");
            ArrayList l = new ArrayList() {27,37,2,30,48,100,81,91,67,56};
            Console.Write("\nBefore sorting: ");
            foreach (var n in l)
            {
                Console.Write(n+"\t");
            }
            l.Sort();
            Console.Write("\nAfter sorting: ");
            foreach (var n in l)
            {
                Console.Write(n+"\t");
            }


            Console.WriteLine("\n\nQuestion 2:");

            ArrayList name_list = new ArrayList() { "Renu", "Geetha", "Reka", "Swathi"};
            Console.Write("\nBefore sorting: ");
            foreach (var n in name_list)
            {
                Console.Write(n + "\t");
            }
            name_list.Sort();
            name_list.Reverse();
            Console.Write("\nAfter sorting in desending: ");
            foreach (var n in name_list)
            {
                Console.Write(n + "\t");
            }


            Console.WriteLine("\n\nQuestion 3:\n");

            SortedList data = new SortedList()
            {
                [255] = "Pradeep",
                [2066] = "Surya",
                [37] = "Roshini",
                [582] = "Lavanya"
            };
            
            foreach (var key in data.Keys)
            {
                Console.WriteLine("{0} {1}", key, data[key]);
            }


            Console.WriteLine("\n\nQuestion 4:");
            BookStore b = new BookStore();
            b.Show();

            Console.WriteLine("\n\nQuestion 5:");
            StudentName sn = new StudentName();
            sn.Show();
        }
    }

    public class BookStore
    {
        Hashtable BookList = new Hashtable()
        {
            [101] = "Time to Kill by John Grisham",
            [12] = "A Scanner Darkly by Philip K. ",
            [348] = "The Sun Also Rises by Ernest Hemingway. "
        };

        public void Show()
        {
            foreach (var k in BookList.Keys)
            {
                Console.WriteLine("Key:{0} \t\tValue:{1}", k, BookList[k]);
            }
            
        }
    }

    public class StudentName
    {
        ArrayList name_list = new ArrayList() { "Nenu", "Geetha", "Reka","Kaviya", "Swathi", "Gayatri", "Alanaa" };

        public void Show()
        {
            Console.Write("Names: \t");
            foreach (var n in name_list)
            {
                Console.Write(n + "\t");
            }

        }
        
            
    
    }
}
