using CommunityToolkit.Maui.Core;
using ShowTokenBApp.Services.Interfaces;

namespace ShowTokenBApp.Services
{
    public class LoadingService : ILoadingService
    {
      
        public Task<bool> Hide()
        {
            throw new NotImplementedException();
        }

        public Task Show(string message = "Loading...")
        {
            throw new NotImplementedException();
        }
    }
}
