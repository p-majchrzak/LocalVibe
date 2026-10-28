namespace LocalVibe.Pages.Shared;

public partial class ErrorPage : ContentPage
{
    private readonly Action? _retryAction;

    public ErrorPage()
    {
        InitializeComponent();
    }

    public ErrorPage(string errorMessage, Action? retryAction = null)
    {
        InitializeComponent();

        ErrorMessageLabel.Text = string.IsNullOrWhiteSpace(errorMessage)
            ? "Wystąpił nieoczekiwany błąd. Spróbuj ponownie za chwilę."
            : errorMessage;

        _retryAction = retryAction;
    }

    private void OnRetryClicked(object sender, EventArgs e)
    {
        if (_retryAction is not null)
        {
            _retryAction.Invoke();
        }
        else
        {
            Application.Current!.Windows[0].Page = new MainPage();
        }
    }

    private void OnHomeClicked(object sender, EventArgs e)
    {
        Application.Current!.Windows[0].Page = new MainPage();
    }
}