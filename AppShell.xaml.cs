using MauiApp1.Views;

namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MauiApp1.Views.Contacts), typeof(MauiApp1.Views.Contacts));
		Routing.RegisterRoute(nameof(AddContact), typeof(AddContact));
		Routing.RegisterRoute(nameof(EditContact), typeof(EditContact));
	}
}
