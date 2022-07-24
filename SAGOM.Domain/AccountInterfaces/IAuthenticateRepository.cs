using SAGOM.Domain.Entities;
using System.Threading.Tasks;

namespace SAGOM.Domain.AccountInterfaces
{
    public interface IAuthenticateRepository
    {
        Task<bool> Authenticate(Authenticate authenticate);
        Task<bool> RegisterUser(Costumer costumer, Authenticate authenticate);
        Task<bool> RegisterUser(Employee employee, Authenticate authenticate);
        Task<bool> RegisterRole(string name);
        Task Logout();

    }
}