using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTokenBApp.Services.Interfaces
{
    public interface ILoadingService
    {
        Task Show(string message = "Loading...");
        Task<bool> Hide();
    }
}
