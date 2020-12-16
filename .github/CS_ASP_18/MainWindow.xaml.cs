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

namespace BlackOut1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (calendar1.SelectedDate.HasValue && calendar2.SelectedDate.HasValue)
            {
                DateTime x = calendar1.SelectedDate.Value;
                DateTime y = calendar2.SelectedDate.Value;
                label.Content = (y - x).Days;
                calendar3.BlackoutDates.Clear();
                calendar3.BlackoutDates.Add(new CalendarDateRange(x, y));
            }
        }
        private void calendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            l1.Content = calendar1.SelectedDate.Value;
        }
        private void calendar2_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            l2.Content = calendar2.SelectedDate.Value;
        }
    }
}