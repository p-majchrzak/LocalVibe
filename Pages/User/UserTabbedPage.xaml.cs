namespace LocalVibe.Pages.User;

public partial class UserTabbedPage : TabbedPage
{
	public UserTabbedPage()
	{
		InitializeComponent();
		foreach (var page in Children)
		{
			page.Title = string.Empty;
		}
	}
}