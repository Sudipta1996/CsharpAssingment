using pharmacyManagementWebApiservice.Models;
using System.Collections.Generic;

namespace pharmacyManagementWebApiservice.Repository
{
    public interface IUserRepository
    {
        UserDetail Create(UserDetail user);
        IEnumerable<UserDetail> GetAll();
        UserDetail GetByEmail(string email);
        UserDetail GetById(int id);
    }
}
