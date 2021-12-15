using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace app_progetto
{
    public class AuthenticatedUser : IIdentity
    {
        public AuthenticatedUser(string autenticationType, bool isAuthenticated, string name)
        {
            AuthenticationType = autenticationType;
            IsAuthenticated = isAuthenticated;
            Name = name;
        }

        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public string Name { get; set; }
    }
}
