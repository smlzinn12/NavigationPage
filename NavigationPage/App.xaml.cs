namespace NavigationPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Microsoft.Maui.Controls.NavigationPage(new MainPage()));

        }
    }
}