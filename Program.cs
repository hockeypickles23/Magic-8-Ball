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


            
        }

        static void tellNameOfProgram()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Magic 8 Ball by Nick Dill");
        }
    }
}
