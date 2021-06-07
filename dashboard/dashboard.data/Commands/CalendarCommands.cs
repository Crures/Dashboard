using dashboard.context.ICommands;
using dashboard.context.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.data.Commands
{
    public class CalendarCommands : ICalendarCommands
    {
        private readonly DashboardContext _context;

        public CalendarCommands(DashboardContext context)
        {
            _context = context;
        }

        public CalendarEvent CreateEvent(CalendarEvent calEvent)
        {
            var entity = _context.CalendarEvents.FirstOrDefault(g => g.Start == calEvent.Start
            && g.End == calEvent.End && g.Title == calEvent.Title);
            if (entity == null)
            {
                _context.Add(calEvent);
            }

            _context.SaveChanges();
            return calEvent;
        }

        public void CreateUserCalendarevent(int calId, int userId)
        {
            var b = new UserCalendarEvent();
            b.User = userId;
            b.CalendarEvent = calId;
            _context.Add(b);
            _context.SaveChanges();
        }
    }
}
