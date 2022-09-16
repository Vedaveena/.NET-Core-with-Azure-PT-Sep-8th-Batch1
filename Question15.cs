using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13_9_22
{
    internal class Question15
    {
        public static void Main(string[] args)
        {
            int[] n = new int[10];
            Console.WriteLine("Enter 10 sub marks: ");

            for (int i = 0; i < 10; i++)
            {
                n[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Select any one from this : 1. Total 2. Average 3. Minimum marks 4. Maximum marks 5. Display marks in ascending order 6. Display marks in descending order ");

            int x = int.Parse(Console.ReadLine());
            int total = 0;
            int temp = 0;

            for (int i = 0; i < 10; i++)
            {
                total += n[i];
            }

            switch (x)
            {
                case 1:
                    Console.WriteLine(total);
                    break;
                case 2:
                    Console.WriteLine(total / 10);
                    break;
                case 3:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = i + 1; j < 5; j++)
                            {
                                if (n[i] < n[j])
                                {
                                    temp = n[i];
                                }
                                else
                                {
                                    temp = n[j];
                                }
                            }
                        }

                        Console.WriteLine(temp);

                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = i + 1; j < 5; j++)
                            {
                                if (n[i] > n[j])
                                {
                                    temp = n[i];
                                }
                                else
                                {
                                    temp = n[j];
                                }
                            }
                        }

                        Console.WriteLine(temp);

                        break;
                    }
                case 5:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = i + 1; j < 5; j++)
                            {
                                if (n[i] > n[j])
                                {
                                    temp = n[i];
                                    n[i] = n[j];
                                    n[j] = temp;
                                }

                            }
                        }

                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(n[i] + " ");
                        }

                        break;
                    }
                case 6:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = i + 1; j < 5; j++)
                            {
                                if (n[i] > n[j])
                                {
                                    temp = n[i];
                                    n[i] = n[j];
                                    n[j] = temp;
                                }

                            }
                        }

                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(n[i] + " ");
                        }

                        break;
                    }
            }


        }

    }
}
