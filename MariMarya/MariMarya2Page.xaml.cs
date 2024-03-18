using Microsoft.Maui.Controls;

namespace MariMarya;

public partial class MariMarya2Page : ContentPage
{
	public MariMarya2Page()
	{
		InitializeComponent();
	}

	void VoltarButton(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MariMaryaPage();
	} 

	void MARIAZINHA(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	} 
}