using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Authenticate
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string? RoleName { get; private set; }

        public Authenticate(string email, string password, string? roleName)
        {
            Email = email;
            Password = password;
            RoleName = roleName;
        }
    }
}
