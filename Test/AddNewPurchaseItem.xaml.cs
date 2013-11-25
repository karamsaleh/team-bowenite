namespace Test
{
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

    /// <summary>
    /// Interaction logic for AddNewPurchaseItem.xaml
    /// </summary>
    public partial class AddNewPurchaseItem : Window
    {
        public AddNewPurchaseItem()
        {
            InitializeComponent();
        }

        private void OnStockRadioButton(object sender, RoutedEventArgs e)
        {
            this.HiddenMeasurementBox.Visibility = Visibility.Collapsed;
            this.MeasurementCB.Visibility = Visibility.Visible;
        }

        private void OnServiceRadioButton(object sender, RoutedEventArgs e)
        {
            this.MeasurementCB.Visibility = Visibility.Collapsed;
            this.HiddenMeasurementBox.Visibility = Visibility.Visible;
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
