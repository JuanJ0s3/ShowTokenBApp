using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowTokenBApp.Services.Interfaces;

namespace ShowTokenBApp.Services
{
    internal class NavigationService : INavigationService
    {
        public async Task NavigateToAsync(string pageKey)
        {
            if (pageKey == "IntroductionPage")
            {
                await Shell.Current.GoToAsync("//IntroductionPage");
            }
        }
    }
}
