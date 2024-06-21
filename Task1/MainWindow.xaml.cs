using System.Windows;
using System.Windows.Controls;

namespace Task1
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
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                this.Title = radioButton.Content.ToString();
            }
            if (radioButton1.IsChecked == true)
                radioButton5.IsEnabled = false;
            else radioButton5.IsEnabled = true;
            if (radioButton2.IsChecked == true)
                radioButton4.IsEnabled = false;
            else radioButton4.IsEnabled = true;
            if (radioButton3.IsChecked == true)
                radioButton1.IsEnabled = false;
            else radioButton1.IsEnabled = true;
            if (radioButton4.IsChecked == true)
                radioButton3.IsEnabled = false;
            else radioButton3.IsEnabled = true;
            if (radioButton5.IsChecked == true)
                radioButton2.IsEnabled = false;
            else radioButton2.IsEnabled = true;
        }
    }
}