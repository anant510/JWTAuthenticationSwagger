using firstJWT.Models;
using firstJWT.Request_Models;

namespace firstJWT.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginRequest);
    }
}
