using System.Threading.Tasks;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg.Data
{
    public class AuthRepository:IAuthRepository
    {
        public Task<ServiceResponse<int>> Register(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}