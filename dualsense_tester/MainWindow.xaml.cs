using System.Windows;
using System.Windows.Media;
using HidSharp;
using System.Windows.Threading;
using System.Diagnostics;
using System.Threading;

namespace dualsense_tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer frameTimer;
        private DualSenseTester DualSenseTester;
        private CancellationTokenSource _cancellationTokenSource;
        public MainWindow()
        {
            InitializeComponent();
            startListening();
            // Target fps is currently set to 120
            StartRendering(120);
        }

        private void startListening()
        {
            var deviceList = DeviceList.Local;
            var devices = deviceList.GetAllDevices();
            foreach (var device in devices)
            {
                if (device.GetFriendlyName() == "DualSense Wireless Controller")
                {
                    DualSenseTester = new DualSenseTester(this);
                }
            }
        }

        public void RenderFrame()
        {
            Dispatcher.Invoke(() =>
            {
                dualsense_img.Source = DualSenseTester.dualsenseImg;
            });
        }

        public void StartRendering(int targetFPS) {
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            Task.Run(async () =>
            {
                int frameInterval = 1000 / targetFPS; // milliseconds per frame
                Stopwatch stopwatch = new Stopwatch();

                while (!token.IsCancellationRequested)
                {
                    stopwatch.Restart();
                    RenderFrame(); // Perform rendering

                    // Wait for the next frame
                    int elapsed = (int)stopwatch.ElapsedMilliseconds;
                    int delay = frameInterval - elapsed;

                    if (delay > 0)
                    {
                        await Task.Delay(delay, token);
                    }
                }
            }, token);
        }

        protected override void OnClosed(EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource?.Dispose();
            base.OnClosed(e);
        }
    }
}
