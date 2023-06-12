namespace MauiApp1.Views;

using MauiApp1.Models;

public partial class Contacts : ContentPage
{
	public Contacts()
	{
		InitializeComponent();

		List<Contact> contactNames = ContactRepository.GetAllContacts();

		listContacts.ItemsSource = contactNames;
	}

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if (listContacts.SelectedItem != null) {
			//logic
			await DisplayAlert("test", "test", "Oki!");
			await Shell.Current.GoToAsync(nameof(EditContact));
		}
		
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }
}