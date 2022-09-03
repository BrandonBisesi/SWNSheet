using SWNSheet.ViewModels;
namespace SWNSheet.Views;

public partial class MainView : ContentPage
{

	public MainView(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

