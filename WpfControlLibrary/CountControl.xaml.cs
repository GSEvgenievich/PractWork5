using System.Windows;
using System.Windows.Controls;

namespace WpfControlLibrary
{
    /// <summary>
    /// Логика взаимодействия для CountControl.xaml
    /// </summary>
    public partial class CountControl : UserControl
    {
        public int MaxValue { get; set; }

        public int Value { get; set; }

        public CountControl()
        {
            InitializeComponent();
            minusButton.IsEnabled = false;
            Value = 0;
        }

        public event RoutedEventHandler ValueChanged;

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value < MaxValue)
            {
                Value++;
                minusButton.IsEnabled = true;
                countTextBox.Text = Value.ToString();
                ValueChanged?.Invoke(this, new RoutedEventArgs());
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value > 0)
            {
                Value--;
                if (Value == 0)
                    minusButton.IsEnabled = false;
                countTextBox.Text = Value.ToString();
                ValueChanged?.Invoke(this, new RoutedEventArgs());
            }
        }
    }
}
