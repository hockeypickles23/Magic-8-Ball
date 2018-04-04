using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    /// <summary>
    /// Entry point for 8 Ball Program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            tellNameOfProgram();
            Random randomObject = new Random();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ask a question?: ");
                string questionString = Console.ReadLine();

                if (questionString.ToLower() == "quit")
                {
                    break;
                }

                if (questionString.ToLower() == "exit")
                {
                    break;
                }

                if (questionString.Length == 0)
                {
                    Console.WriteLine("\nASK A QUESTION NOW!\n");
                    continue;
                }

                if (questionString.ToLower() == "this sucks")
                {
                    Console.WriteLine("YOU SUCK!");
                    break;
                }

                if (questionString.ToLower() == "")
                {
                    break;
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                int randomNumber = randomObject.Next(5);
                switch(randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("\nYES!\n");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("\nNO!\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nMaybe?\n");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nOMG YES!\n");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nGOD NO!\n");
                            break;
                        }
                }
            }

            Console.ForegroundColor = oldColor;
            return;
        }

        static void tellNameOfProgram()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Magic 8 Ball by Nick Dill");
        }
    }
}