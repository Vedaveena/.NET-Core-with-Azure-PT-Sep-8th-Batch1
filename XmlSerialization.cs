using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment_19_9_22
{
    internal class XmlSerialization
    {
        public static void Serialization()
        {
            try
            {
                Movies movies = new Movies() { movieid = 192, moviename = "The Curse of the Black Pearl", year = 2003, actor = "Johnny Depp", director = "Gore Verbinski" };
                XmlSerializer serializer = new XmlSerializer(typeof(Movies));
                using (FileStream stream = new FileStream("C:\\Users\\dell\\Desktop\\Capgemini Training\\C#\\demo.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, movies);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Movies Deserialize()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Movies));
                using (FileStream stream = new FileStream("C:\\Users\\dell\\Desktop\\Capgemini Training\\C#\\demo.xml", FileMode.Open, FileAccess.Read))
                {
                    Movies employee = serializer.Deserialize(stream) as Movies;
                    return employee;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public static void Serialization1() //serialize list of employees
        {
            try
            {
                Movies movies1 = new Movies() { movieid = 58, moviename = "Avengers", year = 2020, actor = "John", director = "Joe Russo" };
                //Movies e = new Movies() { Eid = 2, Ename = "Ram", Salary = 32000 };
                //Movies employee2 = new Movies() { Eid = 3, Ename = "Raghu", Salary = 32000 };
                List<Movies> employees = new List<Movies>() { movies1 };
                XmlSerializer serializer = new XmlSerializer(typeof(List<Movies>));
                using (FileStream stream = new FileStream("C:\\Users\\dell\\Desktop\\Capgemini Training\\C#\\demo.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, movies1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<Movies> Deserialize1()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Movies>));
                using (FileStream stream = new FileStream("C:\\Users\\dell\\Desktop\\Capgemini Training\\C#\\demo.xml", FileMode.Open, FileAccess.Read))
                {
                    List<Movies> movies = serializer.Deserialize(stream) as List<Movies>;
                    return movies;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        static void Main()
        {
            //// Serialization();
            // Employee e = Deserialize();
            // Console.WriteLine(e.Ename);
            Serialization1();
            //List<Employee> employees = Deserialize1();
            //foreach(Employee employee in employees)
            //Console.WriteLine($"{employee.Eid} {employee.Ename} {employee.Salary}");
            Console.ReadKey();
        }
    }
}
