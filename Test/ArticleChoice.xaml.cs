using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ArticleChoice.xaml
    /// </summary>
    public partial class ArticleChoice : Window
    {
        public ArticleChoice()
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

            Goods selectedGoods = this.dgArticles.SelectedItem as Goods;
            this.tbArticleName.Text = selectedGoods.Name;
            this.tbSellPrice.Text = selectedGoods.SalesPrice.ToString();
            this.tbDiscount.Text = selectedGoods.Discount.ToString();
        }

        private void OnCloseClickButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnAddNewButtonClick(object sender, RoutedEventArgs e)
        {
            Window addNewArticleWindow = new AddNewItem();
            addNewArticleWindow.Show();
            this.Close();
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.ArticleDetails.Visibility = Visibility.Collapsed;
        }

        private void ArticlesGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<Goods> items = DataHandler.Instance.LoadGoods();
            dgArticles.ItemsSource = items;
        }
    }
}
