namespace App.Pages;

public partial class Absolute : ContentPage
{
	public Absolute()
	{
		InitializeComponent();
	}

	private async void OnClick(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MainPage());
    }
}