using LocalVibe;
namespace LocalVibe.Pages.User;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}
	private async void LogoutButton(object sender, EventArgs e)
    {
         Application.Current!.Windows[0].Page = new Shared.MainPage();
    }

}