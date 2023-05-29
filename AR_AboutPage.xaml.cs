namespace AR_Apuntes;

public partial class AR_AboutPage : ContentPage
{
	public AR_AboutPage()
	{
		InitializeComponent();
	}

    private async void AR_LearnMore_Clicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}

