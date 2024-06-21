using System.Windows;

namespace Task5
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
            MessageBox.Show("Значение изменено");
        }
    }
}