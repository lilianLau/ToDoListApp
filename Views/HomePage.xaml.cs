namespace ToDoListApp.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void GoToEditPage_Tapped(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new EditPage());
    }
}