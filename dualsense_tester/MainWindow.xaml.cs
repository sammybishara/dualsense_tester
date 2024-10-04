using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HidLibrary;
using HidSharp;

namespace dualsense_tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            startListening();
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

        public void UpdateWindow(DrawingImage img)
        {
            dualsense_img.Source = img;
        }
    }
}
