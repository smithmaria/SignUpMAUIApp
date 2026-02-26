namespace BasicSignUpProfilePages;

[QueryProperty(nameof(Username), "username")]
[QueryProperty(nameof(Email), "email")]
public partial class ProfilePage : ContentPage
{
	private string username;
	public string Username
	{
		get => username;
		set
		{
			username = value;
			lblUsername.Text = $"Username: {username}";
		}
	}

	private string email;
	public string Email
	{
		get => email;
		set
		{
			email = value;
			lblEmail.Text = $"Email: {email}";
		}
	}

	public ProfilePage()
	{
		InitializeComponent();
	}

    private async void btnSignOut_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(MainPage));
    }
}