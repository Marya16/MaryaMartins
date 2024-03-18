using Microsoft.Maui.Controls;

namespace MariMarya;

public partial class MariMaryaPage : ContentPage
{
	public MariMaryaPage()
	{
		InitializeComponent();
	}


	void ButtonVoltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	} 
	
    void ButtonContinue(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MariMarya2Page();
	}
}