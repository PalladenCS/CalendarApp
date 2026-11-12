using System;

namespace CalendarApp
{
    internal class IO
    {
        public void Menu()
        {
            Console.WriteLine("1: New Event");
            Console.WriteLine("2: View Events");
            Console.WriteLine("3:");
            Console.WriteLine("0: Exit");
        }

        public String ReadInput()
        {
            Console.Write("Input: ");
            return Console.ReadLine() ?? "";
        }

        public Event NewEventInput()
        {
            Console.Write("Event title: ");
            string title = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            string description = Console.ReadLine() ?? "";

            Console.Write("Start (example: 2026-11-12 18:00): ");
            DateTime startTime = DateTime.Parse(Console.ReadLine() ?? "");

            Console.Write("End (example: 2026-11-12 19:00): ");
            DateTime endTime = DateTime.Parse(Console.ReadLine() ?? "");

            return new Event(title, description, startTime, endTime);
        }
    }
}
