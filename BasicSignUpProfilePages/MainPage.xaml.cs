namespace BasicSignUpProfilePages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSignUp_Clicked(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtUsername.Text) 
                || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtPassword.Text)
                || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                lblErrorMessage.Text = "All fields must be filled.";
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblErrorMessage.Text = "Passwords must match.";
            }

            await Shell.Current.GoToAsync(nameof(ProfilePage));
        }
    }
}
