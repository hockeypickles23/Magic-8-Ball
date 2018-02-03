using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                //Get Random Number
                int randomNum = randomObject.Next(4);

                //Use rand num to determine response
                switch(randomNum)
                {
                    case 0:
                        {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("yes");
                            break;
                        }
                    case 1:
                        {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("no");
                            break;
                        }
                    case 2:
                        {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Hell NO!");
                            break;
                        }
                    case 3:
                        {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("OMG YES!");
                            break;
                        }
                }
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
            Console.Write("Ask a question: ");
            Console.ForegroundColor = ConsoleColor.White;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}
