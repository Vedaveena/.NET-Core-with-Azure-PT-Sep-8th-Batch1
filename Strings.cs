namespace Assignment_14_9_22
{
    internal class Strings
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine("Select any one option from a to q \na)\tPrint the character at the 12th index.\nb)\tCheck whether the String contains the word “is”.\nc)\tAdd the string “and killed it” to the existing string.\nd)\tCheck whether the String ends with the word “dogs”.\ne)\tCheck whether the String is equal to “The quick brown Fox jumps over the lazy Dog”.\r\nf)\tCheck whether the String is equal to “THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG”.\ng)\tFind the length of the String.\nh)\tCheck whether the String matches to “The quick brown Fox jumps over the lazy Dog”.\r\ni)\tReplace the word “The” with the word “A”.\r\nj)\tSplit the above string into two such that two animal names do not come together.\r\nk)\tPrint the animal names alone separately from the above string.\r\nl)\tPrint the above string in completely lower case.\r\nm)\tPrint the above string in completely upper case.\r\nn)\tFind the index position of the character “a”.\r\no)\tFind the last index position of the character “e”.\r\np)\tPrompt the user to enter the home directory of Tomcat server. To the path that user enters, add another path to  WebApps/MyApps/Images  directory and display it in the console. Use verbatim string literals. \nq)\tPoem");

            char op = char.Parse(Console.ReadLine());

            switch(op)
            {
                case 'a':
                    {
                        char[] chars = str.ToCharArray();
                        Console.WriteLine("the character at the 12th index is : {0}",chars[12]);
                        break;
                    }

                    case 'b':
                    {
                        if(str.Contains("is"))
                        {
                            Console.WriteLine(str+" contains 'is'");
                        }
                        else
                        {
                                Console.WriteLine(str + " does not contain 'is'");
                        }
                        break;
                    }

                    case'c':
                    {
                        Console.WriteLine(str + " and killed it."); 
                        //string temp = String.Concat(str, " " + "and killed it.");
                        //Console.WriteLine(temp);
                        break;
                    }

                case 'd':
                    {
                        if (str.EndsWith("dogs"))
                            Console.WriteLine("True");
                        else
                            Console.WriteLine("False");

                        break;
                    }

                case 'e':
                    {
                        string s = "The quick brown Fox jumps over the lazy Dog";

                        if(str.Equals(s)) //str == s1 , if(str.CompareTo(s1)==0) 
                        {
                            Console.WriteLine("Equal\n");
                        }
                        else
                        {
                            Console.WriteLine("Not Equal\n");
                        }

                        break;
                    }

                    case 'f':
                    {
                        string s = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

                        if (str.Equals(s, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Equal");
                        }
                        else
                        {
                            Console.WriteLine("Not Equal");
                        }

                        break;
                    }

                case 'g':
                    {
                        Console.WriteLine("Length of the String: "+str.Length);
                        break;
                    }

                case 'h':
                    {
                        string s = "The quick brown Fox jumps over the lazy Dog";

                        if (String.Compare(str, s, true) == 0) //str == s1 , if(str.CompareTo(s1)==0) 
                        {
                            Console.WriteLine("Equal\n");
                        }
                        else
                        {
                            Console.WriteLine("Not Equal\n");
                        }

                        break;
                    }

                case 'i':
                    {
                        str = str.Replace("the", "a");
                        Console.WriteLine(str);
                        break;
                    }

                case 'j':
                    {
                        string s1 = str.Substring(0, 20);
                        string s2 = str.Substring(20);
                        Console.WriteLine(s2);
                        Console.WriteLine(s1);
                        break;
                    }

                case 'k':
                    {
                        Console.WriteLine("Name of animals: ");
                        string[] word_in_string = str.Split(" ");  //Question 11
                        foreach (string animal in word_in_string)
                        {
                            if (animal == "fox" || animal == "dog")
                            {
                                Console.WriteLine(animal);
                            }
                        }

                        break;
                    }

                case 'l':
                    {
                        Console.WriteLine(str.ToLower());
                        break;
                    }

                case 'm':
                    {
                        Console.WriteLine(str.ToUpper());
                        break;
                    }

                case 'n':
                    {
                        Console.WriteLine(str.IndexOf('a'));
                        break;
                    }

                case 'o':
                    {
                        Console.WriteLine(str.LastIndexOf('e'));
                        break;
                    }

                case 'p':
                    {
                        Console.WriteLine("Enter the home directory of Tomcat server");
                        string path1 = Console.ReadLine();
                        string path2 = @"/WebApps/MyApps/Images  directory ";
                        Console.WriteLine(path1+path2);
                        break ; 
                    }

                case 'q':
                    {
                        Console.Write("I WANDER'D lonely as a cloud "+ (char)10 + "That floats on high o'er vales and hills, " + (char)10 + "When all at once I saw a crowd, " + (char)10 + "A host, of golden daffodils;Beside the lake, beneath the trees, " + (char)10 + "Fluttering and dancing in the breeze."+ (char)10);
                       
                        break;
                    }
            }

            
        }
    }
}