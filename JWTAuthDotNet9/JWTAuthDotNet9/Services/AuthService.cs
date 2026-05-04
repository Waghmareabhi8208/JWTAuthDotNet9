using JWTAuthDotNet9.Entities;
using JWTAuthDotNet9.Models;

namespace JWTAuthDotNet9.Services
{
    public class AuthService : IAuthService
    {
        public Task<string?> LoginAsync(UserDto request)
        {
            throw new NotImplementedException();
        }

        public Task<User?> RegisterAsync(UserDto request)
        {
            throw new NotImplementedException();
        }
    }
}
