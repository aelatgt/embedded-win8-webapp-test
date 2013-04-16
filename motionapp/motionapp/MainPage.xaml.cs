using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Devices.Sensors;
using Microsoft.Xna.Framework;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Devices;
using System.Windows.Documents;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Xna.Framework.Graphics;
using Matrix = Microsoft.Xna.Framework.Matrix;
using System.Windows.Threading;


namespace motionapp
{
    public partial class MainPage : PhoneApplicationPage
    {
        PhotoCamera cam;
        // Url of Home page
        private string MainUri = "/Html/index.html";
        Motion motion;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            cam = new Microsoft.Devices.PhotoCamera();
            videoBrush.SetSource(cam);
        }

        private void Browser_Loaded(object sender, RoutedEventArgs e)
        {
            // Add your URL here
            Browser.Navigate(new Uri(MainUri, UriKind.Relative));
            Browser.IsScriptEnabled = true;

        }

        // Navigates back in the web browser's navigation stack, not the applications.
        private void BackApplicationBar_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        // Navigates forward in the web browser's navigation stack, not the applications.
        private void ForwardApplicationBar_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        // Navigates to the initial "home" page.
        private void HomeMenuItem_Click(object sender, EventArgs e)
        {
            Browser.Navigate(new Uri(MainUri, UriKind.Relative));
        }

        // Handle navigation failures.
        private void Browser_NavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            MessageBox.Show("Navigation to this page failed, check your internet connection");
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            // Check to see whether the Motion API is supported on the device.
            if (!Motion.IsSupported)
            {
                MessageBox.Show("the Motion API is not supported on this device.");
                return;
            }

            // If the Motion object is null, initialize it and add a CurrentValueChanged
            // event handler.
            if (motion == null)
            {
                motion = new Motion();
                motion.TimeBetweenUpdates = TimeSpan.FromMilliseconds(20);
                motion.CurrentValueChanged +=
                    new EventHandler<SensorReadingEventArgs<MotionReading>>(motion_CurrentValueChanged);
            }

            // Try to start the Motion API.
            try
            {
                motion.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("unable to start the Motion API.");
            }
        }

        void motion_CurrentValueChanged(object sender, SensorReadingEventArgs<MotionReading> e)
        {
            // This event arrives on a background thread. Use BeginInvoke to call
            // CurrentValueChanged on the UI thread.
            Dispatcher.BeginInvoke(() => CurrentValueChanged(e.SensorReading));
        }

        private void CurrentValueChanged(MotionReading e)
        {
            // Check to see if the Motion data is valid.
            if (motion.IsDataValid)
            {
                String q = e.Attitude.Quaternion.ToString();
      
                // Show the numeric values for attitude.
                qLBL.Text = q;

                Browser.InvokeScript("motionValues", e.Attitude.Quaternion.X.ToString(), e.Attitude.Quaternion.Y.ToString(), e.Attitude.Quaternion.Z.ToString(), e.Attitude.Quaternion.W.ToString());

                // Show the numeric values for acceleration.
                xLBL.Text = "X: " + e.DeviceAcceleration.X.ToString("0.00");
                yLBL.Text = "Y: " + e.DeviceAcceleration.Y.ToString("0.00");
                zLBL.Text = "Z: " + e.DeviceAcceleration.Z.ToString("0.00");
            }
        }

    }
}