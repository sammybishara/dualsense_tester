using System.Windows;
using System.Windows.Media;
using HidSharp;
using System.Windows.Threading;

namespace dualsense_tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DrawingImage img;
        private DispatcherTimer _frameTimer;
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
                    DualSenseTester ds_tester = new DualSenseTester(this);
                }
            }
        }

        public void UpdateImage(DrawingImage newImg)
        {
            img = newImg;
        }

        public void RenderFrame()
        {
            dualsense_img.Source = img;
        }

        public void StartRendering(int targetFPS) {
            // Calculate interval based on target FPS
            TimeSpan interval = TimeSpan.FromMilliseconds(1000 / targetFPS);

            // Set up the timer
            _frameTimer = new DispatcherTimer
            {
                Interval = interval
            };

            _frameTimer.Tick += (s, e) =>
            {
                RenderFrame(); // Call the rendering method
            };

            _frameTimer.Start();
        }

    }
}
