namespace NavigationPage
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
           
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            //Push: navegar para a proxima pagina 
            await Navigation.PushAsync(new SegundaPage());
        }
    }
}
