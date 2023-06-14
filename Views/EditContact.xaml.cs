namespace MauiApp1.Views;
using MauiApp1.Models;

[QueryProperty(nameof(ContactId), "Id")]

public partial class EditContact : ContentPage
{
	private Contact contact;
	public EditContact()
	{
		InitializeComponent();
	}

    private void cancelBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

	public string ContactId 
	{
		set 
		{
			contact = ContactRepository.GetContact(int.Parse(value));
			lblName.Text = contact.Name;
		}
	}
}