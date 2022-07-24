using System;

namespace SAGOM.WebAPI.Models
{
    public class UserToken
    {
        public string Token { get; private set; }
        public DateTime Expiration { get; private set; }

        public UserToken(string token, DateTime expiration)
        {
            Token = token;
            Expiration = expiration;
        }
    }
}
