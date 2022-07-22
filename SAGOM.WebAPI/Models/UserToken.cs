// MACORATTI, JOSÉ CARLOS. Curso Clean Architecture Essencial. Disponível em: https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/. Acesso em: 20 jul. 2022.

using System;

namespace SAGOM.WebAPI.Models
{
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
