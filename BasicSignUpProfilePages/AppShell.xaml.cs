namespace BasicSignUpProfilePages
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("MainPage", typeof(MainPage));
            Routing.RegisterRoute("ProfilePage", typeof(ProfilePage));
        }
    }
}
