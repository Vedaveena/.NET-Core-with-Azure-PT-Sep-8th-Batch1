using System.Collections;
using System.Collections.Generic;

namespace Assignment_19_9_22
{
    internal class GenericCollection
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Question 1:");
            List<int> l = new List<int>() { 27, 37, 2, 30, 48, 100, 81, 91, 67, 56 };
            Console.Write("\nBefore sorting: ");
            foreach (var n in l)
            {
                Console.Write(n + "\t");
            }
            l.Sort();
            Console.Write("\nAfter sorting: ");
            foreach (var n in l)
            {
                Console.Write(n + "\t");
            }


            Console.WriteLine("\n\nQuestion 2:");

            List<string> name_list = new List<string>() { "Renu", "Geetha", "Reka", "Swathi" };
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

            Dictionary<int,string> data = new Dictionary<int, string>()
            {
                [255] = "Pradeep",
                [2066] = "Surya",
                [37] = "Roshini",
                [582] = "Lavanya"
            };

            var sortedDict = from entry in data orderby entry.Value ascending select entry;

            foreach (KeyValuePair<int, string> item in sortedDict)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
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
        
        Dictionary<int, string> BookList = new Dictionary<int, string>()
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
        List<string> name_list = new List<string>() { "Nenu", "Geetha", "Reka", "Kaviya", "Swathi", "Gayatri", "Alanaa" };

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