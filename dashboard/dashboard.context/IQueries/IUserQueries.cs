using System.Collections.Generic;
using dashboard.context.Model;

namespace dashboard.context.IQueries
{
    public interface IUserQueries
    {
        public List<User> FetchUsers();
        public User FetchUser(int id);
    }
}