using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    public class AuthenticateDTO
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string? RoleName { get; private set; }

        public AuthenticateDTO(string email, string password, string? roleName = null)
        {
            Email = email;
            Password = password;
            RoleName = roleName;
        }
    }
}
