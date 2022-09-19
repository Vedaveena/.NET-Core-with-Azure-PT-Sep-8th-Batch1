using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_19_9_22
{
    internal class BinarySerialization
    {
        public static void Serialization()
        {
            try
            {
                Movies movies = new Movies() { movieid = 192, moviename = "The Curse of the Black Pearl", year = 2003, actor = "Johnny Depp", director = "Gore Verbinski" };
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("C:\\Users\\dell\\Desktop\\Capgemini Training\\C#\\demo1.bat", FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, movies);
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
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("C:\\Users\\dell\\Desktop\\Capgemini Training\\C#\\demo1.bat", FileMode.Open, FileAccess.Read))
                {
                    Movies movies = formatter.Deserialize(stream) as Movies;
                    return movies;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
       public  static void Main(string[] args)
        {
            // Serialization();
            Movies movies = Deserialize();
            Console.WriteLine($"{movies.movieid} {movies.moviename} {movies.year} {movies.lang} {movies.actor} {movies.director}");
            Console.ReadKey();
        }

    }
}
