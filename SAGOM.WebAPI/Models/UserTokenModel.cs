using System;

namespace SAGOM.WebAPI.Models
{
    public class UserTokenModel
    {
        public string Token { get; private set; }
        public DateTime Expiration { get; private set; }

        public UserTokenModel(string token, DateTime expiration)
        {
            Token = token;
            Expiration = expiration;
        }
    }
}
