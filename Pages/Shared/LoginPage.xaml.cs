namespace LocalVibe.Pages.Shared;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, TappedEventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new LocalVibe.Pages.Shared.MainPage();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new LocalVibe.Pages.Shared.LoginPage();
    }

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new LocalVibe.Pages.Shared.RegisterPage();
    }

    private async void OnForgotPasswordClicked(object sender,TappedEventArgs e)
    {
        //rozbudowac
    }
}