using System;

namespace CalendarApp
{
    internal class IO
    {
        public String ReadInput()
        {
            String input = Console.ReadLine() ?? "";
            if(input == "1")
            {
                //add event
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
            return input;
        }

        public void WriteOutput(string title)
        {
            Console.WriteLine($"You entered: {title}");
        }

        //Console.Write("Event title: ");
        //return Console.ReadLine() ?? "";
    }
}
