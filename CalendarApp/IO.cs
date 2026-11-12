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

            Console.Write("Start (MM/DD/YYY HH:MM): ");
            DateTime startTime = DateTime.Parse(Console.ReadLine() ?? "");

            Console.Write("End (MM/DD/YYY HH:MM): ");
            DateTime endTime = DateTime.Parse(Console.ReadLine() ?? "");

            return new Event(title, description, startTime, endTime);
        }

        public void ViewEvents(Schedule schedule)
        {
            foreach (Event calendarEvent in schedule.GetEvents())
            {
                Console.WriteLine($"Title: {calendarEvent.Title}");
                Console.WriteLine($"Description: {calendarEvent.Description}");
                Console.WriteLine($"Start: {calendarEvent.StartTime}");
                Console.WriteLine($"End: {calendarEvent.EndTime}");
                Console.WriteLine();
            }
        }
    }
}
