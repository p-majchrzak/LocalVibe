namespace LocalVibe.Pages.Shared;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        //dodac walidacje i rejestracje
        Application.Current!.Windows[0].Page = new ErrorPage();
    }

    private void OnLoginTapped(object sender, TappedEventArgs e)
    {
        Application.Current!.Windows[0].Page = new LoginPage();
    }

    private void OnBackToHomeClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page = new MainPage();
    }
    private void OnPrivacyPolicyTapped(object sender, TappedEventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new PrivacyPolicyPage();
    }
}