/*
 * FirstProgram.cs
 * A simple program to demonstrate some basic concepts including:
 *   - header comments
 *   - in line comments
 *   - proper indenting
 *   - grouping of common code blocks
 *   - sequencing/order of code execution
 *   
 * Revision History
 *   - Tony Theodoropoulos, 2023.01.12: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FIrstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.WriteLine("Springfield Nuclear Power Plant");
            Console.WriteLine("Press Enter to Activate");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.WriteLine("Meltdown Happening!!!!!!");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("Meltdown Happening!!!!!!");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.WriteLine("Meltdown Happening!!!!!!");
            Thread.Sleep(1000);

            Console.ReadKey();
        }
    }
}
