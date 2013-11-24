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
    /// Interaction logic for AddNewItem.xaml
    /// </summary>
    public partial class AddNewItem : Window
    {
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void OnStockRadioButton(object sender, RoutedEventArgs e)
        {
            this.HiddenMeasurementBox.Visibility = Visibility.Collapsed;
            this.cbMeasurement.Visibility = Visibility.Visible;
        }

        private void OnServiceRadioButton(object sender, RoutedEventArgs e)
        {
            this.cbMeasurement.Visibility = Visibility.Collapsed;
            this.HiddenMeasurementBox.Visibility = Visibility.Visible;
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            if (rbStock.IsChecked.GetValueOrDefault())
            {
                ComboBoxItem cbItem = (ComboBoxItem)cbMeasurement.SelectedItem;

                Goods item = new Goods(int.Parse(tbID.Text), string.Empty, tbSellPrice.Text, 
                    decimal.Parse(tbSellPrice.Text), decimal.Parse(tbDiscount.Text),decimal.Parse(tbValue.Text),
                    cbItem.Content.ToString(), 0);

                List<Goods> goods = DataHandler.Instance.LoadGoods();
                goods.Add(item);
                DataHandler.Instance.SaveGoods(goods);
                Window artChoice = new ArticleChoice();
                artChoice.Show();
                this.Close();

            }
        }
    }
}
