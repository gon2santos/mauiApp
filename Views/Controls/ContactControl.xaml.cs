namespace MauiApp1.Views.Controls;

public partial class ContactControl : ContentView
{
    public event EventHandler<string> onError;
    public event EventHandler<EventArgs> onCancel;
    public event EventHandler<EventArgs> onSave;

    public ContactControl()
    {
        InitializeComponent();
    }

    public string Name
    {
        get { return nameEntry.Text; }
        set { nameEntry.Text = value; }
    }

    public string Email
    {
        get { return emailEntry.Text; }
        set { emailEntry.Text = value; }
    }

    public string Address
    {
        get { return addressEntry.Text; }
        set { addressEntry.Text = value; }
    }

    public string Number
    {
        get { return numberEntry.Text; }
        set { numberEntry.Text = value; }
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        if (nameValidator.IsNotValid)
        {
            //DisplayAlert("Error", "Name is required!", "fine...");
            onError?.Invoke(sender, "Name is required!");
            return;
        }

        if (emailValidator.IsNotValid)
        {
            string err = "";
            foreach (var error in emailValidator.Errors)
            {
                err += error + "\n";
            }
            onError?.Invoke(sender, err);
            //DisplayAlert("Error", err, "OK");
            return;
        }
        onSave?.Invoke(sender, e);
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        onCancel?.Invoke(sender, e);
    }
}