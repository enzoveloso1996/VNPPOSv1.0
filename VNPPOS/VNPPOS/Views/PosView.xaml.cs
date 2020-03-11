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

namespace VNPPOS.Views
{
    /// <summary>
    /// Interaction logic for PosView.xaml
    /// </summary>
    public partial class PosView : Window
    {
        public PosView()
        {
            InitializeComponent();
        }

        private void shirtTab(object sender, RoutedEventArgs e)
        {
            shirts.Visibility = Visibility.Visible;
            jackets.Visibility = Visibility.Collapsed;
            pants.Visibility = Visibility.Collapsed;
            shorts.Visibility = Visibility.Collapsed;
            bags.Visibility = Visibility.Collapsed;
            caps.Visibility = Visibility.Collapsed;
            polo.Visibility = Visibility.Collapsed;
        }

        private void jacketTab(object sender, RoutedEventArgs e)
        {
            shirts.Visibility = Visibility.Collapsed;
            jackets.Visibility = Visibility.Visible;
            pants.Visibility = Visibility.Collapsed;
            shorts.Visibility = Visibility.Collapsed;
            bags.Visibility = Visibility.Collapsed;
            caps.Visibility = Visibility.Collapsed;
            polo.Visibility = Visibility.Collapsed;
        }

        private void poloTab(object sender, RoutedEventArgs e)
        {
            shirts.Visibility = Visibility.Collapsed;
            jackets.Visibility = Visibility.Collapsed;
            pants.Visibility = Visibility.Collapsed;
            shorts.Visibility = Visibility.Collapsed;
            bags.Visibility = Visibility.Collapsed;
            caps.Visibility = Visibility.Collapsed;
            polo.Visibility = Visibility.Visible;
        }

        private void pantsTab(object sender, RoutedEventArgs e)
        {
            shirts.Visibility = Visibility.Collapsed;
            jackets.Visibility = Visibility.Collapsed;
            pants.Visibility = Visibility.Visible;
            shorts.Visibility = Visibility.Collapsed;
            bags.Visibility = Visibility.Collapsed;
            caps.Visibility = Visibility.Collapsed;
            polo.Visibility = Visibility.Collapsed;
        }

        private void shortTab(object sender, RoutedEventArgs e)
        {
            shirts.Visibility = Visibility.Collapsed;
            jackets.Visibility = Visibility.Collapsed;
            pants.Visibility = Visibility.Collapsed;
            shorts.Visibility = Visibility.Visible;
            bags.Visibility = Visibility.Collapsed;
            caps.Visibility = Visibility.Collapsed;
            polo.Visibility = Visibility.Collapsed;
        }

        private void bagTab(object sender, RoutedEventArgs e)
        {
            shirts.Visibility = Visibility.Collapsed;
            jackets.Visibility = Visibility.Collapsed;
            pants.Visibility = Visibility.Collapsed;
            shorts.Visibility = Visibility.Collapsed;
            bags.Visibility = Visibility.Visible;
            caps.Visibility = Visibility.Collapsed;
            polo.Visibility = Visibility.Collapsed;
        }

        private void capsTab(object sender, RoutedEventArgs e)
        {
            shirts.Visibility = Visibility.Collapsed;
            jackets.Visibility = Visibility.Collapsed;
            pants.Visibility = Visibility.Collapsed;
            shorts.Visibility = Visibility.Collapsed;
            bags.Visibility = Visibility.Collapsed;
            caps.Visibility = Visibility.Visible;
            polo.Visibility = Visibility.Collapsed;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dateTime.Text = DateTime.Now.ToString();
        }
    }
}
