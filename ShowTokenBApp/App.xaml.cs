using ShowTokenBApp.Pages;

namespace ShowTokenBApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new SelectionPage());
        }
    }
}