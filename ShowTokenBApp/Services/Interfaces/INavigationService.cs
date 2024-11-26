using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTokenBApp.Services.Interfaces
{
    public interface INavigationService
    {
        Task NavigateToAsync(string pageKey);
    }
}
