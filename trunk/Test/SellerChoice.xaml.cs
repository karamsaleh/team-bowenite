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
    /// Interaction logic for SellerChoice.xaml
    /// </summary>
    public partial class SellerChoice : Window
    {
        public SellerChoice()
        {
            InitializeComponent();
        }

        private void OnCloseClickButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.ArticleDetails.Visibility = Visibility.Collapsed;
        }

        private void OnAddNewButtonClick(object sender, RoutedEventArgs e)
        {
            Window addNewClientWindow = new AddNewClient();
            addNewClientWindow.Show();
            this.Close();
        }
    }
}
