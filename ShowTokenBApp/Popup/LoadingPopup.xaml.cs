using Mopups.Pages;
namespace ShowTokenBApp.Popup;

public partial class LoadingPopup : PopupPage
{
	public LoadingPopup(string message)
	{
        InitializeComponent();
        lblLoading.Text = message;
    }
}