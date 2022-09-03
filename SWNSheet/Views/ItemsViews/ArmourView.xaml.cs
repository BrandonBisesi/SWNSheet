using SWNSheet.ViewModels.ItemsViewModels;

namespace SWNSheet.Views.ItemsViews;

public partial class ArmourView : ContentPage
{
	public ArmourView(ArmourViewModel vm)
	{
		InitializeComponent();

        BindingContext = vm;
    }
}