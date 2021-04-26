using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dashboard.context.IServices;
using dashboard.context.Model;

namespace dashboard.data.Services
{
    public class UserService : IUserService
    {
        private readonly DashboardContext _context;

        public UserService(DashboardContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            var entity = _context.Users.FirstOrDefault(g => g.Email == user.Email);
            if (entity == null)
            {
                _context.Add(user);
                _context.SaveChanges();
            }

            _context.Entry(entity).CurrentValues.SetValues(user);
            _context.SaveChanges();
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
