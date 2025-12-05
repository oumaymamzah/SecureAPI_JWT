using SecureAPI_JWT.Models;

namespace SecureAPI_JWT.Services
{
    public interface IAuthService
    {
        public Task<AuthModel> RegisterAsync(RegisterModel model);
        public Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        public Task<string> AddRoleAsync(AddRoleModel model);
        public Task<string> CreateRoleAsync(CreateRoleModel model);
    }
}