namespace LocalVibe.Pages.Shared;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        //dodac validacje i logike rejestracji
    }

    private async void OnLoginClicked(object sender, TappedEventArgs e)
    {
        Application.Current!.Windows[0].Page = new Shared.LoginPage();
    }

    private async void OnPrivacyPolicyClicked(object sender, TappedEventArgs e)
    {
        Application.Current!.Windows[0].Page = new Shared.PrivacyPolicyPage();
    }
}