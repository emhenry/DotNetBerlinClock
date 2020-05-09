using BerlinClock.Api;
using BerlinClock.Api.Rows;
using BerlinClock.Model;
using System.Windows;
using System.Windows.Threading;

namespace BerlinClock.App
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _dispatcher = Dispatcher.CurrentDispatcher;
            Application.Current.MainWindow.Closing += MainWindow_Closing;
            _berlinClockApi = new BerlinClockApi(new Row5Hours(), new Row1Hour(),
                                new Row5Minutes(), new Row1Minute(), new SystemTimeApi());

            _berlinClockApi.OnShortTimeUpdated += ShortTimeUpdate;
            _berlinClockApi.OnOrangeLightVisible += OrangeLightVisible;
            _berlinClockApi.OnRow5HoursChanged += Row5HoursChange;
            _berlinClockApi.OnRow1HourChanged += Row1HourChange;
            _berlinClockApi.OnRow5MinutesChanged += Row5MinutesChange;
            _berlinClockApi.OnRow1MinuteChanged += Row1MinuteChange;
        }

        private readonly Dispatcher _dispatcher;
        private readonly IBerlinClockApi _berlinClockApi;

        private void OrangeLightVisible(bool isVisible)
            => _dispatcher.Invoke(() => this.Lamp.SetShapeOpacity(isVisible));

        private void ShortTimeUpdate(string time)
            => _dispatcher.Invoke(() => this.LblTime.Content = time);

        private void Row5HoursChange(Row4LightsModel row5h)
            => this.Set4Lights(this.R5h1, this.R5h2, this.R5h3, this.R5h4, row5h);

        private void Row1HourChange(Row4LightsModel row1h)
            => this.Set4Lights(this.R1h1, this.R1h2, this.R1h3, this.R1h4, row1h);

        private void Row5MinutesChange(Row11LightsModel row5m)
            => this.Set11Lights(this.R5m1, this.R5m2, this.R5m3, this.R5m4, this.R5m5, this.R5m6,
                            this.R5m7, this.R5m8, this.R5m9, this.R5m10, this.R5m11, row5m);

        private void Row1MinuteChange(Row4LightsModel row1m)
            => this.Set4Lights(this.R1m1, this.R1m2, this.R1m3, this.R1m4, row1m);

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
            => _berlinClockApi.Dispose();

        private void Set4Lights(UIElement r1, UIElement r2, UIElement r3, UIElement r4, Row4LightsModel values)
            => _dispatcher.Invoke(() =>
            {
                r1.SetShapeOpacity(values.Light1);
                r2.SetShapeOpacity(values.Light2);
                r3.SetShapeOpacity(values.Light3);
                r4.SetShapeOpacity(values.Light4);
            });

        private void Set11Lights(UIElement r1, UIElement r2, UIElement r3, UIElement r4, UIElement r5, UIElement r6, UIElement r7,
                                UIElement r8, UIElement r9, UIElement r10, UIElement r11, Row11LightsModel values)
            => _dispatcher.Invoke(() =>
            {
                r1.SetShapeOpacity(values.Light1);
                r2.SetShapeOpacity(values.Light2);
                r3.SetShapeOpacity(values.Light3);
                r4.SetShapeOpacity(values.Light4);
                r5.SetShapeOpacity(values.Light5);
                r6.SetShapeOpacity(values.Light6);
                r7.SetShapeOpacity(values.Light7);
                r8.SetShapeOpacity(values.Light8);
                r9.SetShapeOpacity(values.Light9);
                r10.SetShapeOpacity(values.Light10);
                r11.SetShapeOpacity(values.Light11);
            });

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            _dispatcher.Invoke(() =>
            {
                this.BtnStart.Visibility = Visibility.Hidden;
                this.BtnStop.Visibility = Visibility.Visible;
                this.LblHour.Visibility = Visibility.Hidden;
                this.LblMinute.Visibility = Visibility.Hidden;
                this.CbHour.Visibility = Visibility.Hidden;
                this.CbMinute.Visibility = Visibility.Hidden;
            });

            int hour = this.CbHour.SelectedIndex;
            int minute = this.CbMinute.SelectedIndex;

            _berlinClockApi.Start(hour, minute);
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            _dispatcher.Invoke(() =>
            {
                this.BtnStop.Visibility = Visibility.Hidden;
                this.BtnStart.Visibility = Visibility.Visible;
                this.LblHour.Visibility = Visibility.Visible;
                this.LblMinute.Visibility = Visibility.Visible;
                this.CbHour.Visibility = Visibility.Visible;
                this.CbMinute.Visibility = Visibility.Visible;
            });

            _berlinClockApi.Stop();
        }
    }
}