using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShowTokenBApp.Services.Interfaces;

namespace ShowTokenBApp.ViewModels
{
    public partial class SelectionViewModel : ObservableObject
    {
        private readonly INavigationService _navigationService;
        private ILoadingService _loadingService;




        public SelectionViewModel()
        {
            _navigationService = Startup.GetService<INavigationService>();
            _loadingService = Startup.GetService<ILoadingService>();
        }

        [RelayCommand]
        public async Task NavigateCoctail()
        {
            await _loadingService.Show();
            await _navigationService.NavigateToAsync("TheCocktailDBApiPage");
            await _loadingService.Hide();
        }

        [RelayCommand]
        public async Task NavigateMeal()
        {
            await _loadingService.Show();
            await _navigationService.NavigateToAsync("TheMealDBApiPage");
            await _loadingService.Hide();
        }
    }
}
