using ShowTokenBApp.Services.Interfaces;

namespace ShowTokenBApp.Services
{
    internal class NavigationService : INavigationService
    {
        public async Task NavigateToAsync(string pageKey)
        {
            if (pageKey == "LoginPage")
            {
                await Shell.Current.GoToAsync("//LoginPage");
            }

            else if (pageKey == "IntroductionPage")
            {
                await Shell.Current.GoToAsync("//IntroductionPage");
            }

            else if (pageKey == "SelectionPage")
            {
                await Shell.Current.GoToAsync("//SelectionPage");
            }
        }
    }
}
