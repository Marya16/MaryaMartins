namespace MariMarya;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void Button_Clicked(object sender,EventArgs args)
	{ 
      Application.Current.MainPage = new MariMaryaPage();
	}
	void Button_Clicked_1(object sender,EventArgs args)
	{
      sobre.IsVisible=true;
    }

}