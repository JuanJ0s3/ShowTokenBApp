using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShowTokenBApp.Services.Interfaces;

namespace ShowTokenBApp.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly INavigationService _navigationService;
        private ILoadingService _loadingService;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        public LoginViewModel()
        {
            _authenticationService = Startup.GetService<IAuthenticationService>();
            _navigationService = Startup.GetService<INavigationService>();
            _loadingService = Startup.GetService<ILoadingService>();
        }

        [RelayCommand]
        private async Task LoginAsync(string message = "")
        {
            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {
                await _loadingService.Show();
                if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
                {
                    await Toast.Make("Por favor ingrese las credenciales", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();

                    return;
                }
                try
                {
                    var isAuthenticated = await _authenticationService.AuthenticateAsync(Username, Password);
                    if (isAuthenticated)
                    {
                        await _navigationService.NavigateToAsync("PersonPage");
                    }
                    else
                    {
                        await Toast.Make("Credenciales incorrectas", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
                    }
                }
                catch (Exception ex)
                {
                    await Toast.Make("Error en el servidor: " + ex.Message, CommunityToolkit.Maui.Core.ToastDuration.Long).Show();
                }
                finally
                {
                    await _loadingService.Hide();
                }
            }
        }
    }
}
