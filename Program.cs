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
            //preserves console color
            ConsoleColor oldColor = Console.ForegroundColor;
            tellNameOfProgram();

            //create a randomizer object
            Random randomObject = new Random();

            //loops forever
            while (true)
            {
                //asks question and input
                string questionString = AskQuestion();

                //why is typed
                if(questionString.ToLower() == "why")
                {
                    Console.WriteLine("Because I said so");
                    continue;
                }

                //see if quit was typed
                if(questionString.ToLower() == "quit")
                {
                    break;
                }

                //no question given
                if(questionString.Length == 0)
                {
                    Console.WriteLine("You need to write a question");
                    continue;
                }

                //response to reply
                if(questionString.ToLower() == "this is dumb")
                {
                    Console.WriteLine("You're dumb! BYE!");
                    break;
                }

                //thinking about the answer
                int sectosleep = randomObject.Next(5) + 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Thinking. Hold on...");
                Thread.Sleep(sectosleep * 1000);

                //Get Random Number
                int randomNum = randomObject.Next(4);

                //Use rand num to determine response
                switch(randomNum)
                {
                    case 0:
                        {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n yes");
                            break;
                        }
                    case 1:
                        {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n no");
                            break;
                        }
                    case 2:
                        {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n Hell NO!");
                            break;
                        }
                    case 3:
                        {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n OMG YES!");
                            break;
                        }
                }
                //time to ask again
                Thread.Sleep(2000);
            }

            //restores all console color
            Console.ForegroundColor = oldColor;
        }

        //This will tell people name of program
        static void tellNameOfProgram()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Magic 8 Ball by Nick");
        }

        //asks question
        static string AskQuestion()
        {
            //asks question and input
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nAsk a question: ");
            Console.ForegroundColor = ConsoleColor.White;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}
