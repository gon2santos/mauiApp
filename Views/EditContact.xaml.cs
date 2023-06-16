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

    private void CancelBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

	public string ContactId 
	{
		set 
		{
			contact = ContactRepository.GetContactById(int.Parse(value));
			name.Text = contact.Name;
			number.Text = contact.number;
			email.Text = contact.Email;
			address.Text = contact.address;
		}
	}

    private void UpdateButton_Clicked(object sender, EventArgs e)
    {
		contact.number = number.Text;
		contact.Name = name.Text;
		contact.Email = email.Text;
		contact.address = address.Text;
		ContactRepository.UpdateContact(contact.ContactId, contact);
		Shell.Current.GoToAsync("..");
    }
}