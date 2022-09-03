using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SWNSheet.Views.ItemsViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWNSheet.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        async Task AllItems()
        {
            await Shell.Current.GoToAsync(nameof(AllItemsView));
        }

        [RelayCommand]
        async Task Character()
        {
            //await Shell.Current.GoToAsync(nameof(View));
        }

        [RelayCommand]
        async Task Ships()
        {
            //await Shell.Current.GoToAsync(nameof(View));
        }

    }
}
