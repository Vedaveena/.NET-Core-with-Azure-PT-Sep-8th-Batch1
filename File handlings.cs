using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_19_9_22
{
    internal class File_handlings
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Path");
            string path = Console.ReadLine();
            // ReadWrite.Read(path);
            //ReadWrite.Write(path);
            //ReadWrite.WriteObject(path);
            ReadWrite.WriteList(path);

        }
    }

    class Movies
    {
        public int movieid { get; set; }
        public string moviename { get; set; }
        public int year { get; set; }
        public string lang { get; set; }
        public string actor { get; set; }
        public string director { get; set; }
        public override string ToString()
        {
            return String.Format($"ID: {movieid} Name:{moviename} Year:{year} Language:{lang} Actor:{actor} Director:{director}");
        }
    }
    public class ReadWrite
    {
        public static void WriteObject(string path) //add model data to the file
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                Movies movies = new Movies() { movieid = 192, moviename = "The Curse of the Black Pearl", year = 2003, actor = "Johnny Depp", director = "Gore Verbinski" };
                sw.WriteLine(movies); //to write text to the given file

            }
        }
        public static void WriteList(string path) //add list of model to the file
        {
            List<Movies> list = new List<Movies>()
            {
                new Movies(){movieid=58,moviename="Avengers",year= 2020,  actor = "John", director = "Joe Russo" },
                 new Movies(){movieid=2487,moviename="3",year= 2009,  actor = "Dhanush", director = "Aishwarys" },
                  new Movies(){movieid=100,moviename="Don",year= 2022,  actor = "Sivakarthikayen", director = "Nalson" },
            };
            foreach (Movies item in list)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {

                    sw.WriteLine(item);

                }
            }
        }
    }
}
