using System;
using System.Security.Permissions;

namespace CalendarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IO io = new IO();
            string input = "";

            Console.WriteLine("Hello, welcome to your calendar!");
            while(input != "0")
            {
                Console.WriteLine("1: New Event");
                Console.WriteLine("2: View Events");
                Console.WriteLine("3:");
                Console.WriteLine("0: Exit");
                Console.Write("Input: ");
                input = io.ReadInput();
            }
        }
    }
}
