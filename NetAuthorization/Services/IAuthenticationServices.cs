using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAuthorization.Services
{
    public interface IAuthenticationServices
    {
        List<string> GetRoles(string user);
    }
}
