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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.bkgImg.Visibility = Visibility.Visible;
        }

        private void OnSellClick(object sender, RoutedEventArgs e)
        {
            this.Sell.Visibility = Visibility.Visible;
            this.Buy.Visibility = Visibility.Collapsed;
            this.bkgImg.Visibility = Visibility.Collapsed;
            //Sell sell = new Sell();
            //MessageBoxResult result = MessageBox.Show("If you continue, all unsaved information will be lost!", "Continue confirmation", MessageBoxButton.OKCancel);
            //if (result == MessageBoxResult.OK)
            //{
            //    int count = this.WorkStack.Children.Count;
            //    this.WorkStack.Children.RemoveRange(0, count);
            //    this.WorkStack.Children.Add(sell);
            //}
        }

        private void OnBuyClick(object sender, RoutedEventArgs e)
        {
            this.Buy.Visibility = Visibility.Visible;
            this.Sell.Visibility = Visibility.Collapsed;
            this.bkgImg.Visibility = Visibility.Collapsed;
            //Buy buy = new Buy();
            //MessageBoxResult result = MessageBox.Show("If you continue, all unsaved information will be lost!", "Continue confirmation", MessageBoxButton.OKCancel);
            //if (result == MessageBoxResult.OK)
            //{
            //    int count = this.WorkStack.Children.Count;
            //    this.WorkStack.Children.RemoveRange(0, count);
            //    this.WorkStack.Children.Add(buy);
            //}
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to exit?", "Exit Confirmation", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Environment.Exit(1);
            }
            
        }
    }
}
