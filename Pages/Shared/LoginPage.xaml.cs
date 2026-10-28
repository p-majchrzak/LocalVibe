namespace LocalVibe.Pages.Shared;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
         Application.Current!.Windows[0].Page = new ErrorPage();
    }

    private void OnRegisterTapped(object sender, TappedEventArgs e)
    {
        Application.Current!.Windows[0].Page = new RegisterPage();
    }

    private async void OnForgotPasswordTapped(object sender,TappedEventArgs e)
    {
         Application.Current!.Windows[0].Page = new ErrorPage();
    }
    private void OnBackToHomeClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page = new MainPage();
    }
}