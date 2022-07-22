// MACORATTI, JOSÉ CARLOS. Curso Clean Architecture Essencial. Disponível em: https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/. Acesso em: 20 jul. 2022.

using System.Threading.Tasks;

namespace SAGOM.Domain.Account
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate(string email, string password);

        Task<bool> RegisterUser(string email, string password);

        Task Logout();

    }
}