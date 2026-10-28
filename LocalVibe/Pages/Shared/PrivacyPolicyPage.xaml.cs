namespace LocalVibe.Pages.Shared;

public partial class PrivacyPolicyPage : ContentPage
{
    public PrivacyPolicyPage()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new RegisterPage();
    }
}