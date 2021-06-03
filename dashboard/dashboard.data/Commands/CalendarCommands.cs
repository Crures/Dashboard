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

        public void CreateEvent(CalendarEvent calEvent)
        {
            _context.Add(calEvent);
            _context.SaveChanges();
        }

        public void CreateUserCalendarevent(CalendarEvent calEvent)
        {

        }
    }
}
