namespace MauiApp1.Views;

public partial class EditContact : ContentPage
{
	public EditContact()
	{
		InitializeComponent();
	}

    private void cancelBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}