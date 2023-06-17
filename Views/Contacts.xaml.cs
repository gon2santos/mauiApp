namespace MauiApp1.Views;

using Contact = MauiApp1.Models.Contact;
using ContactRepository = MauiApp1.Models.ContactRepository;
using System.Collections.ObjectModel;

public partial class Contacts : ContentPage
{
    public Contacts()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var contactNames = new ObservableCollection<Contact>(ContactRepository.GetAllContacts());

        listContacts.ItemsSource = contactNames;
    }

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listContacts.SelectedItem != null)
        {
            //logic
            await Shell.Current.GoToAsync($"{nameof(EditContact)}?Id={((Contact)listContacts.SelectedItem).ContactId}");
        }

    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }

    private void addBtn_Clicked(object sender, EventArgs e)
    {

    }
}