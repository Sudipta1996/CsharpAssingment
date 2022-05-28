using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using UserSignUp.Model;

namespace UserSignUp.DAL
{
    public class UserDl : IUserDal
    {
        private UserDbContext _dbContext;
        private DbSet<SignUp> signupentity;
        public UserDl(UserDbContext context)
        {
            _dbContext = context;
            signupentity = context.Set<SignUp>();
        }

        public Task<SignIn> signIn(SignIn request)
        {
            throw new System.NotImplementedException();
        }

        public Task<SignUp> signUp(SignUp request)
        {
            throw new System.NotImplementedException();
        }
    }
}
