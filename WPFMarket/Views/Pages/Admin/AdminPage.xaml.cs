using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui.Controls;
using WPFMarket.ViewModels.Pages;

namespace WPFMarket.Views.Pages.Admin
{
    public partial class AdminPage : INavigableView<AdminViewModel>
    {
        public AdminViewModel ViewModel { get; }

        public AdminPage(AdminViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
