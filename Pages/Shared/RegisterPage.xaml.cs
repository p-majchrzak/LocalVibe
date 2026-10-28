namespace LocalVibe.Pages.Shared;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, TappedEventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new LocalVibe.Pages.Shared.MainPage();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new LocalVibe.Pages.Shared.LoginPage();
    }

    private void OnPrivacyPolicyClicked(object sender, TappedEventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new LocalVibe.Pages.Shared.PrivacyPolicyPage();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        //dodac validacje i rejestracje
    }
}