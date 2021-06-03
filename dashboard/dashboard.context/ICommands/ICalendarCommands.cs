using dashboard.context.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.context.ICommands
{
    public interface ICalendarCommands
    {
        public void CreateEvent(CalendarEvent calEvent);
        public void CreateUserCalendarevent(CalendarEvent calEvent);
    }
}
