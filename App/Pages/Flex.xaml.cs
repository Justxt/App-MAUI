namespace App.Pages;

public partial class Flex : ContentPage
{
	public Flex()
	{
		InitializeComponent();
	}

    private async void OnClickImg(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.Absolute());
    }
}