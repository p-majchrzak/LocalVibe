namespace LocalVibe.Pages.Shared;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await DisplayAlert(
            "LocalVibe",
            "Logowanie zostanie dodane na późniejszym etapie projektu.",
            "OK");
    }

    private async void OnForgotPasswordClicked(object sender, TappedEventArgs e)
    {
        await DisplayAlert(
            "Przypomnienie hasła",
            "Funkcja odzyskiwania hasła zostanie dodana później.",
            "OK");
    }

    private async void OnRegisterClicked(object sender, TappedEventArgs e)
    {
        Application.Current!.Windows[0].Page = new Shared.RegisterPage();
    }
}