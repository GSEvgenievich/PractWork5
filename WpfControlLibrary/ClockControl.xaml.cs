using System.Windows.Controls;
using System.Windows.Threading;

namespace WpfControlLibrary
{
    /// <summary>
    /// Логика взаимодействия для ClockControl.xaml
    /// </summary>
    public partial class ClockControl : UserControl
    {
        private DispatcherTimer timer;
        public ClockControl()
        {
            InitializeComponent();
            StartTimer();
        }
        private void StartTimer()
        {
            timer = new DispatcherTimer(DispatcherPriority.Render)
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
