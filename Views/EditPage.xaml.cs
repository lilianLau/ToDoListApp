namespace ToDoListApp.Views;

public partial class EditPage : ContentPage
{
	public EditPage()
	{
		InitializeComponent();
	}

    private async void GoBack_Tapped(object sender, TappedEventArgs e)
    {
		await Navigation.PopAsync();
    }
}