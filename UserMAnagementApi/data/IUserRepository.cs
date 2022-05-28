using System.Collections.Generic;
using UserMAnagementApi.Model;

namespace UserMAnagementApi.data
{
    public interface IUserRepository
    {
        User Create(User user);
        IEnumerable<User> GetAll();
        User GetByEmail(string email);
        User GetById(int id);


    }
}
