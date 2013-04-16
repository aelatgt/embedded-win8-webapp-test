using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

using Microsoft.Devices.Sensors;
using Microsoft.Devices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Matrix = Microsoft.Xna.Framework.Matrix;
using System.Windows.Threading;

namespace SpaceLabeler
{
    public partial class MyCustomePage : PhoneApplicationPage
    {
    }
}

namespace SpaceLabeler
{
    public partial class MainPage : MyCustomePage
    {
        PhotoCamera cam;

        Motion motion;
        List<TextBlock> textBlocks;
        List<Vector3> points;
        System.Windows.Point pointOnScreen;
        Viewport viewport;
        Matrix projection;
        Matrix view;
        Matrix attitude;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Initialize the list of TextBlock and Vector3 objects.
            textBlocks = new List<TextBlock>();
            points = new List<Vector3>();
            //gobutton.SetValue(Canvas.ZIndexProperty, 2);
            //searchbar.SetValue(Canvas.ZIndexProperty, 2);
            cam = new Microsoft.Devices.PhotoCamera();
            videoBrush.SetSource(cam);
        }

    
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {

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
                motion.CurrentValueChanged += new EventHandler<SensorReadingEventArgs<MotionReading>>(motion_CurrentValueChanged);
            }

            motion.Start();

            // Hook up the event handler for when the user taps the screen.
            //this.MouseLeftButtonUp += new MouseButtonEventHandler(MainPage_MouseLeftButtonUp);

            //base.OnNavigatedTo(e);
        }

        void MainPage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // If the Canvas containing the TextBox is visible, ignore
            // this event.
            /*
            if (TextBoxCanvas.Visibility == Visibility.Visible)
            {
                return;
            }

            // Save the location where the user touched the screen.
            pointOnScreen = e.GetPosition(LayoutRoot);

            // Save the device attitude when the user touched the screen.
            attitude = motion.CurrentValue.Attitude.RotationMatrix;

            // Make the Canvas containing the TextBox visible and
            // give the TextBox focus.
            TextBoxCanvas.Visibility = Visibility.Visible;
            txtName.Focus();
             */

        }

        void motion_CurrentValueChanged(object sender, SensorReadingEventArgs<MotionReading> e)
        {
            // This event arrives on a background thread. Use BeginInvoke to call a method on the UI thread.
            Dispatcher.BeginInvoke(() => CurrentValueChanged(e.SensorReading));
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {   /*
            // If the key is not the Enter key, don't do anything.
            if (e.Key != Key.Enter)
            {
                return;
            }

            // When the TextBox loses focus. Hide the Canvas containing it.
            TextBoxCanvas.Visibility = Visibility.Collapsed;

            // If any of the objects we need are not present, exit the event handler.
            if (txtName.Text == "" || pointOnScreen == null || motion == null)
            {
                return;
            }

            // Translate the point before projecting it.
            System.Windows.Point p = pointOnScreen;
            p.X = LayoutRoot.RenderSize.Width - p.X;
            p.Y = LayoutRoot.RenderSize.Height - p.Y;
            p.X *= .5;
            p.Y *= .5;

            // Use the attitude Matrix saved in the OnMouseLeftButtonUp handler.
            // Rotate it 90 degrees around the X axis to put it in xna coordinate system.
            attitude = Matrix.CreateRotationX(MathHelper.PiOver2) * attitude;


            // Use Viewport.Unproject to translate the point on the screen to 3D space.
            Vector3 unprojected = viewport.Unproject(new Vector3((float)p.X, (float)p.Y, -.9f), projection, view, attitude);
            unprojected.Normalize();
            unprojected *= -10;

            // Call the helper method to add this point
            AddPoint(unprojected, txtName.Text);

            // Clear the TextBox
            txtName.Text = "";
             */
        }

        private void CurrentValueChanged(MotionReading reading)
        {/*
            // If the viewport width is 0, it needs to be initialized.
            if (viewport.Width == 0)
            {
                InitializeViewport();
            }

            // Get the RotationMatrix from the MotionReading.
            // Rotate it 90 degrees around the X axis to put it in xna coordinate system.
            Matrix attitude = Matrix.CreateRotationX(MathHelper.PiOver2) * reading.Attitude.RotationMatrix;

            // Loop through the points in the list
            for (int i = 0; i < points.Count; i++)
            {
                // Create a World matrix for the point.
                Matrix world = Matrix.CreateWorld(points[i], new Vector3(0, 0, 1), new Vector3(0, 1, 0));

                // Use Viewport.Project to project the point from 3D space into screen coordinates.
                Vector3 projected = viewport.Project(Vector3.Zero, projection, view, world * attitude);

                if (projected.Z > 1 || projected.Z < 0)
                {
                    // If the point is outside of this range, it is behind the camera.
                    // So hide the TextBlock for this point.
                    textBlocks[i].Visibility = Visibility.Collapsed;
                }
                else
                {
                    // Otherwise, show the TextBlock
                    textBlocks[i].Visibility = Visibility.Visible;

                    // Create a TranslateTransform to position the TextBlock.
                    // Offset by half of the TextBlock's RenderSize to center it on the point.
                    TranslateTransform tt = new TranslateTransform();
                    tt.X = projected.X - (textBlocks[i].RenderSize.Width / 2);
                    tt.Y = projected.Y - (textBlocks[i].RenderSize.Height / 2);
                    textBlocks[i].RenderTransform = tt;
                }
            }
            */
        }

        private void AddPoint(Vector3 point, string name)
        {   /*
            // Create a new TextBlock. Set the Canvas.ZIndexProperty to make sure
            // it appears above the camera rectangle.
            TextBlock textblock = new TextBlock();
            textblock.Text = name;
            textblock.FontSize = 76;
            textblock.SetValue(Canvas.ZIndexProperty, 2);
            textblock.Visibility = Visibility.Collapsed;

            // Add the TextBlock to the LayoutRoot container.
            LayoutRoot.Children.Add(textblock);

            // Add the TextBlock and the point to the List collections.
            textBlocks.Add(textblock);
            points.Add(point);
             */
        }

        public void InitializeViewport()
        {
            // Initialize the viewport and matrixes for 3d projection.
            viewport = new Viewport(0, 0, (int)this.ActualWidth, (int)this.ActualHeight);
            float aspect = viewport.AspectRatio;
            projection = Matrix.CreatePerspectiveFieldOfView(1, aspect, 1, 12);
            view = Matrix.CreateLookAt(new Vector3(0, 0, 1), Vector3.Zero, Vector3.Up);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string site;
            site = searchbar.Text;
            webBrowser1.Navigate(new Uri(site, UriKind.Absolute));
            //webBrowser1.SetValue(Canvas.ZIndexProperty, 2);

        }
    }
}