using BerlinClock.Api;
using BerlinClock.Api.Rows;
using BerlinClock.Model;
using System.Windows;

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
            Application.Current.MainWindow.Closing += MainWindow_Closing;
            _berlinClockApi = new BerlinClockApi(
                                new Row5Hours(), new Row1Hour(),
                                new Row5Minutes(), new Row1Minute());
            _berlinClockApi.OnRow5HoursChanged += Row5HoursChanged;
            _berlinClockApi.OnRow1HourChanged += Row1HourChanged;
            _berlinClockApi.OnRow5MinutesChanged += Row5MinutesChanged;
            _berlinClockApi.OnRow1MinuteChanged += Row1MinuteChanged;
        }

        private readonly IBerlinClockApi _berlinClockApi;

        private void Row5HoursChanged(Row4LightsModel obj)
        {
            this.Set4Lights(this.R5h1, this.R5h2, this.R5h3, this.R5h4, obj);            
        }

        private void Row1HourChanged(Row4LightsModel obj)
        {
            this.Set4Lights(this.R1h1, this.R1h2, this.R1h3, this.R1h4, obj);
        }

        private void Row5MinutesChanged(Row11LightsModel obj)
        {
            this.Set11Lights(this.R5m1, this.R5m2, this.R5m3, this.R5m4, this.R5m5, this.R5m6,
                            this.R5m7, this.R5m8, this.R5m9, this.R5m10, this.R5m11, obj);
        }

        private void Row1MinuteChanged(Row4LightsModel obj)
        {
            this.Set4Lights(this.R1m1, this.R1m2, this.R1m3, this.R1m4, obj);
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _berlinClockApi.Dispose();
        }

        private void Set4Lights(UIElement r1, UIElement r2, UIElement r3, UIElement r4, Row4LightsModel values)
        {
            r1.SetShapeOpacity(values.Light1);
            r2.SetShapeOpacity(values.Light2);
            r3.SetShapeOpacity(values.Light3);
            r4.SetShapeOpacity(values.Light4);
        }

        private void Set11Lights(UIElement r1, UIElement r2, UIElement r3, UIElement r4, UIElement r5, UIElement r6, UIElement r7,
                                UIElement r8, UIElement r9, UIElement r10, UIElement r11, Row11LightsModel values)
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
        }
    }
}