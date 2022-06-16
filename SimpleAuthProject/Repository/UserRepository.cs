using pharmacyManagementWebApiservice.Models;
using System.Collections.Generic;
using System.Linq;

namespace pharmacyManagementWebApiservice.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PharmacyManagementContext _context;

        public UserRepository(PharmacyManagementContext context)//constructor dependency injection//
        {
            _context = context;
        }
        #region CreateUser
        public UserDetail Create(UserDetail user)
        {
            _context.UserDetails.Add(user);
            _context.SaveChanges();

            return user;
        }
        #endregion
        #region Getall
        public IEnumerable<UserDetail> GetAll()
        {
            return _context.UserDetails;
        }
        #endregion
        public UserDetail GetByEmail(string email)//get email by id//
        {
            return _context.UserDetails.FirstOrDefault(x => x.Email == email);
        }

        public UserDetail GetById(int id)//get by id//
        {
            return _context.UserDetails.FirstOrDefault(u => u.UserId == id);
        }
    }
}
