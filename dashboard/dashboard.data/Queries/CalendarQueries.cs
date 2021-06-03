using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using dashboard.context.IQueries;
using dashboard.context.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace dashboard.data.Queries
{
    public class CalendarQueries : ICalendarQueries
    {
        private readonly DashboardContext _context;
        private readonly IDbConnection _connection;

        public CalendarQueries(DashboardContext context)
        {
            _context = context;
            _connection = _context.Database.GetDbConnection();
        }

        public List<CalendarEvent> FetchCalendarEventsForUser(int id)
        {
            var param = new { id };
            var qry = "SELECT * FROM CalendarEvent WHERE Id IN (SELECT CalendarEvent FROM [UserCalendarEvent] WHERE [User] = @Id) AND [start] >= GETDATE() and [start] < GETDATE()+1";
            return  _connection.Query<CalendarEvent>(qry, param).ToList();
        }

        public CalendarEvent FetchEvent(int id)
        {
            var param = new { id };
            var qry = "SELECT [Id], [Start], [End], [Title], [Couleur], [Createur],[Description] FROM [CalendarEvent] WHERE [Id] = @Id";
            return _connection.QueryFirstOrDefault<CalendarEvent>(qry, param);
        }
    }
}
