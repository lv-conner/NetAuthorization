using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetAuthorization.Services
{
    public class AuthenticationServices : IAuthenticationServices
    {
        public AuthenticationServices()
        {
            _roles = new List<string>()
            {
                "admin",
                "user",
                "VIP"
            };
        }
        private List<string> _roles;

        public List<string> GetRoles(string user)
        {
            return _roles;
        }
    }
}