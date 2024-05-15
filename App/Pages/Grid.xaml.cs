namespace App.Pages;

public partial class Grid : ContentPage
{
	public Grid()
	{
		InitializeComponent();
	}

	private void GoToStack(object sender, EventArgs e)
	{
        Navigation.PushAsync(new Stack());
    }
}