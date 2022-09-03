using SWNSheet.ViewModels.ItemsViewModels;

namespace SWNSheet.Views.ItemsViews;

public partial class AllItemsView : ContentPage
{
	public AllItemsView(AllItemsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}