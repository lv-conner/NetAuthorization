using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace NetAuthorization.Identity
{
    public class CustomerUser : IPrincipal
    {
        private IIdentity _identity;
        public IIdentity Identity => _identity;
        public List<string> roles;

        public bool IsInRole(string role)
        {
            return roles.Contains(role);
        }
    }

    public class CustomerIdentity : IIdentity
    {
        public CustomerIdentity(string name,string authenticationType)
        {
            _name = name;
            _authenticationType = authenticationType;
        }
        private string _name;
        public string Name => _name;
        private string _authenticationType;
        public string AuthenticationType => _authenticationType;

        public bool IsAuthenticated => !string.IsNullOrEmpty(_name);
    }
}