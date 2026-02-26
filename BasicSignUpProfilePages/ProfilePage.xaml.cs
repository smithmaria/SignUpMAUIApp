namespace BasicSignUpProfilePages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private async void btnSignOut_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(MainPage));
    }
}