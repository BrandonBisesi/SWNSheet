using SWNSheet.Views;
using SWNSheet.Views.ItemsViews;

namespace SWNSheet;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(AllItemsView), typeof(AllItemsView));
        Routing.RegisterRoute(nameof(MoreItemsView), typeof(MoreItemsView));
        Routing.RegisterRoute(nameof(WeaponsView), typeof(WeaponsView));
        Routing.RegisterRoute(nameof(ArmourView), typeof(ArmourView));
    }
}
