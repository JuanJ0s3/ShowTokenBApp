using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using ShowTokenBApp.Services.Interfaces;
using ShowTokenBApp.Services;
//using Microsoft.Extensions.DependencyInjection;


namespace ShowTokenBApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

            object value = builder.Services.AddHttpClient();
            //builder.Services.AddSingleton<ILoadingService, LoadingService>();
            //builder.Services.AddSingleton<IPersonService, PersonService>();
            builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            var app = builder.Build();
            Startup.ServicesProvider = app.Services;
            return app;
        }
    }
}