namespace App.Pages;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}

    private void GoToFlex(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pages.Flex());
    }
}