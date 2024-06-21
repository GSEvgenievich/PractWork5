using System.Windows;
using System.Windows.Controls;

namespace Task3
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

        private void CountControl_ValueChanged(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(costTextBox.Text, out int cost))
                sumLabel.Content = countControl.Value * cost;
        }

        private void costTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            sumLabel.Content = countControl.Value * Convert.ToInt32(costTextBox.Text);
        }
    }
}