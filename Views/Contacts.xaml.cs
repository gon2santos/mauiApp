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

    private void RefreshContactList()
    {
        var contactNames = new ObservableCollection<Contact>(ContactRepository.GetAllContacts());

        listContacts.ItemsSource = contactNames;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        searchBar.Text = string.Empty;

        RefreshContactList();
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
        Shell.Current.GoToAsync(nameof(AddContact));
    }

    private void MenuItemDelete_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var contact = menuItem.CommandParameter as Contact;
        ContactRepository.DeleteContact(contact);
        RefreshContactList();
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        var contactNames = new ObservableCollection<Contact>(ContactRepository.SearchContacts(((SearchBar)sender).Text));
        listContacts.ItemsSource = contactNames;
    }
}