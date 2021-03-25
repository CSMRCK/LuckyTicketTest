using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LuckyTicket
{
    class Program
    {
        static public bool IsItLucky(int num)
        {
            int correctNum = num.ToString().Length;

            if (correctNum >= 4 && correctNum <= 8)
            {
                Console.WriteLine($"Current ticket is ok, ticket has {correctNum} numbers");

                if (correctNum % 2 == 0)
                {
                    Console.WriteLine("Ticket is even");
                    int[] arr = num.ToString().Select(o => int.Parse(o.ToString())).ToArray();
                    LinkedList<int> awesome = new LinkedList<int>(arr);
                    int half = awesome.Count / 2;
                    var laf = awesome.Take(half);

                    foreach (var item in laf)
                    {
                        Console.WriteLine("The first arr items : " + item);
                    }

                    var sec = awesome.Skip(half);

                    foreach (var item in sec)
                    {
                        Console.WriteLine("The second arr items : " + item);
                    }

                    int sumFisrt = laf.Sum();
                    Console.WriteLine("First half summ= " + sumFisrt);

                    int sumSecond = sec.Sum();
                    Console.WriteLine("Second half summ= " + sumSecond);


                    if (sumFisrt == sumSecond)
                    {
                        Console.WriteLine("The Ticket is lucky!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Ticket is not lucky!");
                        return false;
                    }

                    foreach (var item in awesome)
                    {
                        Console.WriteLine(item);
                    }



                }

                else if (correctNum % 2 == 1)
                {
                    Console.WriteLine("Ticket is odd");
                    int[] arr = num.ToString().Select(o => int.Parse(o.ToString())).ToArray();
                    LinkedList<int> awesome = new LinkedList<int>(arr);
                    awesome.AddFirst(0);

                    int half = awesome.Count / 2;
                    var laf = awesome.Take(half);

                    foreach (var item in laf)
                    {
                        Console.WriteLine("The first arr items : " + item);
                    }

                    var sec = awesome.Skip(half);

                    foreach (var item in sec)
                    {
                        Console.WriteLine("The second arr items : " + item);
                    }

                    int sumFisrt = laf.Sum();
                    Console.WriteLine("First half summ= " + sumFisrt);

                    int sumSecond = sec.Sum();
                    Console.WriteLine("Second half summ= " + sumSecond);


                    if (sumFisrt == sumSecond)
                    {
                        Console.WriteLine("The Ticket is lucky!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Ticket is not lucky!");
                        return false;
                    }

                    foreach (var item in awesome)
                    {
                        Console.WriteLine(item);
                    }



                }
                else
                {
                    return false;
                }


            }
            else
            {
                Console.WriteLine($"This ticket is fake! The ticket cannot have {correctNum} numbers!");
                return false;
            }

            Console.WriteLine('\n');
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your ticket number: ");

            do
            {
                int num = Convert.ToInt32(Console.ReadLine());
                IsItLucky(num);
                Console.WriteLine("Press the Escape (Esc) key to quit: \n", Console.BackgroundColor=ConsoleColor.Red);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Please enter your ticket number: ");
                

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


        }
    }
}
