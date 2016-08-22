using Altkom.RentBike.ViewModels;
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
using System.Windows.Shapes;

namespace Altkom.RentBike.WPFClient.Views
{
    /// <summary>
    /// Interaction logic for StationsView.xaml
    /// </summary>
    public partial class StationsView : Window
    {
        public StationsView()
        {
            InitializeComponent();


            // this.DataContext = new ViewModels.StationsViewModel();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var vm = this.DataContext as StationsViewModel;

        //    vm.SelectedStation.Number = "ST999";
        //    vm.SelectedStation.Name = "Stacja 999";
        //}
    }
}
