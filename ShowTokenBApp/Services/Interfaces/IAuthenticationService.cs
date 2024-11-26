using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTokenBApp.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(string username, string password);
    }
}
