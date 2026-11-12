using System;

namespace CalendarApp
{
    internal class Schedule
    {
        private List<Event> events = new List<Event>();

        public void AddEvent(Event newEvent)
        {
            events.Add(newEvent);
        }
    }
}
