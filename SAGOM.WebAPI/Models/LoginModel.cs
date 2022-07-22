// MACORATTI, JOSÉ CARLOS. Curso Clean Architecture Essencial. Disponível em: https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/. Acesso em: 20 jul. 2022.

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace SAGOM.WebAPI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid format email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max " +
            "{1} characters long.", MinimumLength = 10)]
        public string Password { get; set; }
    }
}


