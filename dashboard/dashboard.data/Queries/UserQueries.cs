using System.Collections.Generic;
using System.Linq;
using dashboard.context.IQueries;
using dashboard.context.Model;

namespace dashboard.data.Queries
{
    public class UserQueries : IUserQueries
    {
        private readonly DashboardContext _context;

        public UserQueries(DashboardContext context)
        {
            _context = context;
        }
        public List<User> FetchUsers()
        {
            return _context.Users.ToList();
        }

        public User FetchUser(int id)
        {
            var query = _context.Users.FirstOrDefault(u => u.Id == id);
            return query;
        }
    }
}
