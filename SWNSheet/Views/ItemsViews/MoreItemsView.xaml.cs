using SWNSheet.ViewModels.ItemsViewModels;

namespace SWNSheet.Views.ItemsViews;

public partial class MoreItemsView : ContentPage
{
	public MoreItemsView(MoreItemsViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}