namespace BasicSignUpProfilePages
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ProfilePage", typeof(ProfilePage));
        }
    }
}
