namespace LocalVibe.Pages.Admin;

public partial class AdminTabbedPage : TabbedPage
{
	public AdminTabbedPage() 
	{
		InitializeComponent();
		foreach (var page in Children)
		{
			page.Title = string.Empty;
		}
	}
}