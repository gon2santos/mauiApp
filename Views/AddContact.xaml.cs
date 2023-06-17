using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class AddContact : ContentPage
{
    public AddContact()
    {
        InitializeComponent();
    }

    private void contactCtrl_onSave(object sender, EventArgs e)
    {
        ContactRepository.AddContact(new Models.Contact
        (
            contactCtrl.Name,
            contactCtrl.Email,
            0,
            contactCtrl.Number,
            contactCtrl.Address
        ));

        Shell.Current.GoToAsync($"//{nameof(Contacts)}");
    }

    private void contactCtrl_onCancel(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(Contacts)}");
    }

    private void contactCtrl_onError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}