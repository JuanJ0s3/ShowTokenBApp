using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShowTokenBApp.Services.Interfaces;

namespace ShowTokenBApp.ViewModels
{
    public partial class IntroductionViewModel : ObservableObject
    {
        private readonly INavigationService _navigationService;
        private ILoadingService _loadingService;

        public IntroductionViewModel()
        { 
            _loadingService = Startup.GetService<ILoadingService>();
            _navigationService = Startup.GetService<INavigationService>();
        }

        [RelayCommand]
        public async Task NavigateIntroduction()
        {
            await _loadingService.Show();
            await _navigationService.NavigateToAsync("SelectionPage");
            await _loadingService.Hide();
        }
    }
}
