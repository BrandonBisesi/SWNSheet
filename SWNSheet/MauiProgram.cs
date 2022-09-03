using SWNSheet.ViewModels;
using SWNSheet.Views;
using SWNSheet.Views.ItemsViews;

namespace SWNSheet;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<MainView>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<AllItemsView>();
        builder.Services.AddSingleton<AllItemsView>();
        builder.Services.AddSingleton<MoreItemsView>();
        builder.Services.AddSingleton<MoreItemsView>();
        builder.Services.AddSingleton<WeaponsView>();
        builder.Services.AddSingleton<WeaponsView>();
        builder.Services.AddSingleton<ArmourView>();
        builder.Services.AddSingleton<ArmourView>();

        return builder.Build();
    }
}
