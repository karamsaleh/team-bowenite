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
    /// Interaction logic for Sell.xaml
    /// </summary>
    public partial class Sell : UserControl
    {
        public Sell()
        {
            InitializeComponent();
            this.DateTextBox.Text = DateTime.Now.ToShortDateString();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.Width = double.NaN; ;
                this.Height = double.NaN; ;
            }
        }

        private void ChooseDate(object sender, MouseButtonEventArgs e)
        {
            this.ChooseDateCalendar.Visibility = Visibility.Collapsed;
            var date = sender;
            this.DateTextBox.Text = date.ToString().Remove(9, 9);
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

        private void ShowCalendar(object sender, MouseButtonEventArgs e)
        {
            this.ChooseDateCalendar.Visibility = Visibility.Visible;
        }

        private void OnChooseClientButtonClick(object sender, RoutedEventArgs e)
        {
            Window clientWindow = new ClientChoice();
            clientWindow.Show();
        }

        private void OnCompanyRBChecked(object sender, RoutedEventArgs e)
        {
            this.IndividualSellField.Visibility = Visibility.Collapsed;
            this.IndividualSellNo.Visibility = Visibility.Collapsed;
            this.CompanySellField.Visibility = Visibility.Visible;
            this.CompanySellNo.Visibility = Visibility.Visible;
        }

        private void OnIndividualRBChecked(object sender, RoutedEventArgs e)
        {
            this.IndividualSellField.Visibility = Visibility.Visible;
            this.IndividualSellNo.Visibility = Visibility.Visible;
            this.CompanySellField.Visibility = Visibility.Collapsed;
            this.CompanySellNo.Visibility = Visibility.Collapsed;
        }

        private void ShowInvoices(object sender, RoutedEventArgs e)
        {
            Window showInvoices = new ShowInvoices();
            showInvoices.Show();
        }


    }
}
