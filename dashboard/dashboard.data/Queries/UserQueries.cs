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
    public class UserQueries : IUserQueries
    {
        private readonly DashboardContext _context;
        private readonly IDbConnection _connection;

        public UserQueries(DashboardContext context)
        {
            _context = context;
            _connection = _context.Database.GetDbConnection();
        }
        public List<User> FetchUsers()
        {
            var qry = "SELECT [Id], [Email], [Role], [Dashboard], [Timestamp] FROM [Users]";
            return _connection.Query<User>(qry).ToList();
        }

        public User FetchUser(string email)
        {
            var param = new { Email = email };
            var qry = "SELECT [Id], [Email], [Role], [Dashboard], [Timestamp] FROM [Users] WHERE [Email] = @Email";
            return _connection.QueryFirstOrDefault<User>(qry, param);
        }

        public User FetchUser(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
