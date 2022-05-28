using System.Threading.Tasks;
using UserSignUp.Model;

namespace UserSignUp.DAL
{
    public interface IUserDal
    {
        public Task<SignUp>signUp(SignUp request);
        public Task<SignIn> signIn(SignIn request);
    }
}
