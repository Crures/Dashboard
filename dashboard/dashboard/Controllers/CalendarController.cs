using dashboard.context.ICommands;
using dashboard.context.IQueries;
using dashboard.context.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace dashboard.Controllers
{
    [Route("api/Calendar")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarQueries _calendarQueries;
        private readonly ICalendarCommands _calendarCommands;

        public CalendarController(ICalendarQueries calendarQueries, ICalendarCommands calendarCommands)
        {
            _calendarQueries = calendarQueries;
            _calendarCommands = calendarCommands;
        }


         //GET: api/<ValuesController>
        [HttpGet("GetUserEvents/{id}")]
        public List<CalendarEvent> Get(int id)
        {
            var qry = _calendarQueries.FetchCalendarEventsForUser(id);
            return qry;
        }
        
        [HttpGet("{id}")]
        public CalendarEvent GetEvent(int id)
        {
            var qry = _calendarQueries.FetchEvent(id) ;
            return qry;
        }
    }
}
