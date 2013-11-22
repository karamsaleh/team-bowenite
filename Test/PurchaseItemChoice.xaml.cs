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

namespace Test
{
    /// <summary>
    /// Interaction logic for PurchaseItemChoice.xaml
    /// </summary>
    public partial class PurchaseItemChoice : Window
    {
        public PurchaseItemChoice()
        {
            InitializeComponent();
        }

        private void OnLostWindowFocus(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnChoiceButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            this.ArticleDetails.Visibility = Visibility.Visible;
        }

        private void OnCloseClickButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnAddNewButtonClick(object sender, RoutedEventArgs e)
        {
            Window addNewPurchaseItemWindow = new AddNewPurchaseItem();
            addNewPurchaseItemWindow.Show();
            this.Close();
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.ArticleDetails.Visibility = Visibility.Collapsed;
        }
    }
}
