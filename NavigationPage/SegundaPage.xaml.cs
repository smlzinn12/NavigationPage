namespace NavigationPage;

public partial class SegundaPage : ContentPage
{
	public SegundaPage()
	{
		InitializeComponent();
	}

    private async void OnClicked(object sender, EventArgs e)
    {
        //Push: navegar para a proxima pagina 
        await Navigation.PushAsync(new TerceiraPage());
    }
}