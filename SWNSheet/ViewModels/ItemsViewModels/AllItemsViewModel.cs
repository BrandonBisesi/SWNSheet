using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SWNSheet.Views.ItemsViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWNSheet.ViewModels.ItemsViewModels
{
    public partial class AllItemsViewModel : ObservableObject
    {
        [RelayCommand]
        async Task Weapons()
        {
            await Shell.Current.GoToAsync(nameof(WeaponsView));
        }
        [RelayCommand]
        async Task Armour()
        {
            await Shell.Current.GoToAsync(nameof(ArmourView));
        }
        [RelayCommand]
        async Task MoreItems()
        {
            await Shell.Current.GoToAsync(nameof(MoreItemsView));
        }
    }
}
