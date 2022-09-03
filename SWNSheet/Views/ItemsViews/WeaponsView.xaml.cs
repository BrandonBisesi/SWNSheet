using SWNSheet.ViewModels.ItemsViewModels;

namespace SWNSheet.Views.ItemsViews;

public partial class WeaponsView : ContentPage
{
	public WeaponsView(WeaponsViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}