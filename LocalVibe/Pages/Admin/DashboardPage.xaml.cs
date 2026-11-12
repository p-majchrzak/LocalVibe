using LocalVibe;
namespace LocalVibe.Pages.Admin;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}
	private async void LogoutButton(object sender, EventArgs e)
    {
         Application.Current!.Windows[0].Page = new Shared.MainPage();
    }
}