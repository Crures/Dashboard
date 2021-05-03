using System.Linq;
using dashboard.context.ICommands;
using dashboard.context.Model;
// ReSharper disable AssignNullToNotNullAttribute

namespace dashboard.data.Commands
{
    public class UserCommands : IUserCommands
    {
        private readonly DashboardContext _context;

        public UserCommands(DashboardContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            var entity = _context.Users.FirstOrDefault(g => g.Email == user.Email);
            if (entity == null)
            {
                _context.Add(user);
            }

            _context.Entry(entity).CurrentValues.SetValues(user);
            _context.SaveChanges();

        }
    }
}
