using Xuong_C_.Models;

namespace Xuong_C_.Service
{
    public interface IUserService
    {
        User Register(User user);
        User Login(string username, string password);
    }
}
