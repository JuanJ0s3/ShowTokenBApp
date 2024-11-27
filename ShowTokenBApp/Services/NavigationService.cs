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
            else if (pageKey == "TheCocktailDBApiPage")
            {
                await Shell.Current.GoToAsync("//TheCocktailDBApiPage");
            }
            else if (pageKey == "TheMealDBApiPage")
            {
                await Shell.Current.GoToAsync("//TheMealDBApiPage");
            }
        }
    }
}
