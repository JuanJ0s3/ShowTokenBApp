using CommunityToolkit.Maui.Core;
using Mopups.Interfaces;
using Mopups.Services;
using ShowTokenBApp.Popup;
using ShowTokenBApp.Services.Interfaces;

namespace ShowTokenBApp.Services
{
    public class LoadingService : ILoadingService
    {

        private readonly IPopupNavigation _popupNavigation;


        public LoadingService()
        {
            _popupNavigation = MopupService.Instance;

        }
        public async Task Hide()
        {
            await _popupNavigation.PopAsync(true);

        }

        public async Task Show(string message = "Loading...")
        {
            try
            {
                await _popupNavigation.PushAsync(new LoadingPopup(message), true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
