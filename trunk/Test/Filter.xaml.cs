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
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaction logic for Filter.xaml
    /// </summary>
    public partial class Filter : UserControl
    {
        public Filter()
        {
            InitializeComponent();
            this.setDefaultDatePickerDates();
        }

        private void setDefaultDatePickerDates()
        {
            DateTime beforeSevenDays = new DateTime();
            beforeSevenDays = DateTime.Today.AddDays(-7);
            this.startDate.Text = beforeSevenDays.ToShortDateString();
            this.endDate.Text = DateTime.Now.ToShortDateString();
        }

        private void OnListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OnCalendarClosed(object sender, RoutedEventArgs e)
        {
            DateTime startDate = DateTime.Parse(this.startDate.Text);
            DateTime endDate = DateTime.Parse(this.endDate.Text);
            if ((endDate - startDate).TotalDays < 0)
            {
                MessageBox.Show("The Start Date can not be after the End Date");
                this.setDefaultDatePickerDates();
            }
        }

        private void OnCheckBoxChecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
