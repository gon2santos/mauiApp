namespace MauiApp1.Views;

public partial class AddContact : ContentPage
{
	public AddContact()
	{
		InitializeComponent();
	}

    private void cancelBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}