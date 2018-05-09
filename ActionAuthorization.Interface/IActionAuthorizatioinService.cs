using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAuthorization.Interface
{
    interface IActionAuthorizatioinService
    {
        bool HasPermission(string user, string role);
    }
}
