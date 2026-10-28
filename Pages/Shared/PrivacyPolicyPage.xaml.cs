
namespace LocalVibe.Pages.Shared;

public partial class PrivacyPolicyPage : ContentPage
{
    public PrivacyPolicyPage()
    {
        InitializeComponent();
    }

    private async Task ScrollToSectionAsync(VisualElement section)
    {
        //do rozbudowy
    }

    private async void OnGeneralClicked(object sender, EventArgs e)
    {
        //do rozbudowy
    }

    private async void OnDataClicked(object sender, EventArgs e)
    {
        //do rozbudowy
    }

    private async void OnUsageClicked(object sender, EventArgs e)
    {
        //do rozbudowy
    }

    private async void OnSecurityClicked(object sender, EventArgs e)
    {
    }

    private async void OnRightsClicked(object sender, EventArgs e)
    {
        //do rozbudowy
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page =
            new MainPage();
    }
}
