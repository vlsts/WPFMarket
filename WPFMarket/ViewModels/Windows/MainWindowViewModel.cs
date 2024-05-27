using System.Collections.ObjectModel;
using Wpf.Ui.Controls;

namespace WPFMarket.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _applicationTitle = "WPFMarket";

        [ObservableProperty]
        private ObservableCollection<NavigationViewItem> _menuItems = new()
        {
            new()
            {
                Content = "Admin",
                Icon = new SymbolIcon { Symbol = SymbolRegular.HomePerson24 },
                TargetPageType = typeof(Views.Pages.Admin.AdminPage),
                MenuItemsSource = new ObservableCollection<NavigationViewItem>{
                    //new()
                    //{
                    //    Content = "Data",
                    //    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    //    TargetPageType = typeof(Views.Pages.DataPage)
                    //}
                }

            },
            new()
            {
                Content = "Cashier",
                Icon = new SymbolIcon { Symbol = SymbolRegular.PeopleMoney24 },
                TargetPageType = typeof(Views.Pages.Cashier.CashierPage),
                MenuItemsSource = new ObservableCollection<NavigationViewItem>{
                }

            },
        };

        [ObservableProperty]
        private ObservableCollection<NavigationViewItem> _footerMenuItems = new()
        {
            new()
            {
                Content = "Operator",
                Icon = new SymbolIcon { Symbol = SymbolRegular.DatabasePerson24 },
                TargetPageType = typeof(Views.Pages.Operator.OperatorPage)
            },
            new()
            {
                Content = "Settings",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(Views.Pages.SettingsPage)
            }
        };

        [ObservableProperty]
        private ObservableCollection<MenuItem> _trayMenuItems = new()
        {
            new MenuItem { Header = "Home", Tag = "tray_home" }
        };
    }
}
