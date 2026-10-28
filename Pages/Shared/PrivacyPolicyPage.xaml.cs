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

    private async void ScrollToSection(VisualElement section)
    {
        await PolicyScrollView.ScrollToAsync(
            section,
            ScrollToPosition.Start,
            true);
    }

    private void OnGeneralClicked(object sender, EventArgs e)
    {
        ScrollToSection(GeneralSection);
    }

    private void OnDataClicked(object sender, EventArgs e)
    {
        ScrollToSection(DataSection);
    }

    private void OnUsageClicked(object sender, EventArgs e)
    {
        ScrollToSection(UsageSection);
    }

    private void OnSecurityClicked(object sender, EventArgs e)
    {
        ScrollToSection(SecuritySection);
    }

    private void OnRightsClicked(object sender, EventArgs e)
    {
        ScrollToSection(RightsSection);
    }

    private void OnContactClicked(object sender, EventArgs e)
    {
        
    }
}