using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoCanvasProgramming
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DrawHouse();
        }
        private void DrawHouse()
        {
            // wall
            Rectangle wall = new Rectangle();
            wall.Fill = new SolidColorBrush(Windows.UI.Colors.Tomato);
            wall.Width = 400;
            wall.Height = 200;
            wall.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            wall.StrokeThickness = 3;

            canvas.Children.Add(wall);
            Canvas.SetLeft(wall, 100);
            Canvas.SetTop(wall, 300);

            // roof
            Polygon roof = new Polygon();
            roof.Points.Add(new Point(80, 300));
            roof.Points.Add(new Point(520, 300));
            roof.Points.Add(new Point(300, 200));
            roof.StrokeThickness = 2;
            roof.Fill = new SolidColorBrush(Windows.UI.Colors.Black);

            canvas.Children.Add(roof);
            

            // sun
            Ellipse sun = new Ellipse();
            sun.Width = 100;
            sun.Height = 100;
            sun.Fill = new SolidColorBrush(Windows.UI.Colors.Yellow);

            canvas.Children.Add(sun);
            Canvas.SetLeft(sun, 500);
            Canvas.SetTop(sun, 100);

        }
    }

    
}
