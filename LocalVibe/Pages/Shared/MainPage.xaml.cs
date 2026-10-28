
namespace LocalVibe.Pages.Shared;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new RegisterPage();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new LoginPage();
    }
}