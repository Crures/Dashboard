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

        public User FetchUser(int id)
        {
            var param = new { id };
            var qry = "SELECT [Id], [Email], [Role], [Dashboard], [Timestamp] FROM [Users] WHERE [Id] = @Id";
            return _connection.QueryFirstOrDefault<User>(qry, param);
        }

        public User Authenticate(User user)
        {
            var param = new { user.Email, user.Password };
            var qry = "SELECT [Id], [Email], [Role], [Dashboard], [Timestamp] FROM [Users] WHERE [Email] = @email AND [Password] = @password";
            return _connection.QueryFirstOrDefault<User>(qry, param);
        }
    }
}
