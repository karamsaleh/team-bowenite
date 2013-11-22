using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Test
{
    /// <summary>
    /// Interaction logic for Buy.xaml
    /// </summary>
    public partial class Buy : UserControl
    {
        public Buy()
        {
            InitializeComponent();
            this.DateTextBox.Text = DateTime.Now.ToShortDateString();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.Width = double.NaN; ;
                this.Height = double.NaN; ;
            }
        }

        private void OnChooseSellerButtonClick(object sender, RoutedEventArgs e)
        {
            Window sellerWindow = new SellerChoice();
            sellerWindow.Show();
        }

        private void ShowPurchases(object sender, RoutedEventArgs e)
        {
            Window showSells = new ShowSells();
            showSells.Show();
        }

        private void ShowCalendar(object sender, MouseButtonEventArgs e)
        {
            this.ChooseDateCalendar.Visibility = Visibility.Visible;
        }

        private void OnClickExitButton(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to exit?", "Exit Confirmation", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Environment.Exit(1);
            }
        }

        private void OnArticleButtonClick(object sender, RoutedEventArgs e)
        {
            Window window = new ArticleChoice();
            window.Show();
        }

        private void ChooseDate(object sender, MouseButtonEventArgs e)
        {
            this.ChooseDateCalendar.Visibility = Visibility.Collapsed;
            var date = sender;
            this.DateTextBox.Text = date.ToString().Remove(9, 9);
        }
    }
}
