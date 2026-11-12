using System;
using System.Security.Permissions;

namespace CalendarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IO io = new IO();
            Schedule schedule = new Schedule();
            string input = "";

            Console.WriteLine("Hello, welcome to your calendar!");
            while(input != "0")
            {
                io.Menu();
                input = io.ReadInput();
                if(input == "1")
                {
                    Event newEvent = io.NewEventInput();
                    schedule.AddEvent(newEvent);
                } 
                else if (input == "2")
                {
                    //view events
                } 
                else if (input == "0")
                {
                    Console.WriteLine("Code 0, exiting...");
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                }
            }
        }
    }
}
