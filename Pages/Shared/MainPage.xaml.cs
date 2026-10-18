using LocalVibe;
namespace LocalVibe.Pages.Shared;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	
	private async void OnZalogujClicked(object sender, EventArgs e)
	{
		Application.Current!.Windows[0].Page = new User.UserTabbedPage();
	}
	private async void OnZalogujAdminClicked(object sender, EventArgs e)
	{
		Application.Current!.Windows[0].Page = new Admin.AdminTabbedPage();
	}
}