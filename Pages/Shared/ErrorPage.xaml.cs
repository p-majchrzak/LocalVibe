using LocalVibe;

namespace LocalVibe.Pages.Shared;

public partial class ErrorPage : ContentPage
{
    public ErrorPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        try
        {
            if (Shell.Current is not null)
            {
                if (Shell.Current.Navigation.NavigationStack.Count > 1)
                {
                    await Shell.Current.Navigation.PopAsync();
                    return;
                }

                if (Shell.Current.Navigation.ModalStack.Count > 0)
                {
                    await Shell.Current.Navigation.PopModalAsync();
                    return;
                }

                await GoHomeAsync();
                return;
            }

            if (Navigation.NavigationStack.Count > 1)
            {
                await Navigation.PopAsync();
            }
            else if (Navigation.ModalStack.Count > 0)
            {
                await Navigation.PopModalAsync();
            }
            else
            {
                await GoHomeAsync();
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(
                $"Błąd powrotu: {ex.Message}");
        }
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await GoHomeAsync();
    }

    private async Task GoHomeAsync()
    {
        try
        {
            if (Shell.Current is not null)
            {
                await Shell.Current.GoToAsync("//HomePage");
                return;
            }

            if (Application.Current?.Windows.FirstOrDefault()
                is Window window)
            {
                window.Page = new AppShell();
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(
                $"Błąd nawigacji do strony głównej: {ex.Message}");
        }
    }
}
