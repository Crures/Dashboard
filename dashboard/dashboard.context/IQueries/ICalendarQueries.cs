using dashboard.context.Model;
using System.Collections.Generic;

namespace dashboard.context.IQueries
{
    public interface ICalendarQueries
    {
        public List<CalendarEvent> FetchCalendarEventsForUser(int id);
        public CalendarEvent FetchEvent(int id);
    }
}
