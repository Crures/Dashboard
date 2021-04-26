using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dashboard.context.Model;

namespace dashboard.context.IServices
{
    public interface IUserService
    {
        public void CreateUser(User user);
        public List<User> FetchUsers();
        public User FetchUser(int id);
    }
}
