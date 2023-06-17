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
            contactCtrl.Name = contact.Name;
            contactCtrl.Number = contact.number;
            contactCtrl.Email = contact.Email;
            contactCtrl.Address = contact.address;
        }
    }

    private void UpdateButton_Clicked(object sender, EventArgs e)
    {
        contact.number = contactCtrl.Number;
        contact.Name = contactCtrl.Name;
        contact.Email = contactCtrl.Email;
        contact.address = contactCtrl.Address;
        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_onError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}